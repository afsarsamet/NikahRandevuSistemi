using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;


namespace NikahRandevu0
{
    public partial class FrmRandevuOlustur : MaterialForm
    {
        private int YasHesapla(DateTime dogumTarihi)
        {
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumTarihi.Year;

            if (dogumTarihi.Date > bugun.AddYears(-yas))
                yas--;

            return yas;
        }
        public FrmRandevuOlustur()
        {
            InitializeComponent();
        }

        private void FrmRandevuOlustur_Load(object sender, EventArgs e)
        {

            dtRandevuTarih_ValueChanged(null, null);
        }

        private void dtRandevuTarih_ValueChanged(object sender, EventArgs e)
        {
            cmbSaat.Items.Clear();

            DateTime secilenTarih = dtRandevuTarih.Value.Date;

            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();


                List<string> doluSaatler = new List<string>();

                string sqlDolu = @"
                    SELECT Saat 
                    FROM Randevular
                    WHERE Tarih = @Tarih AND Durum = 'Aktif'";

                using (SqlCommand cmdDolu = new SqlCommand(sqlDolu, conn))
                {
                    cmdDolu.Parameters.AddWithValue("@Tarih", secilenTarih);

                    using (SqlDataReader dr = cmdDolu.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            string saat = dr["Saat"].ToString().Substring(0, 5);
                            doluSaatler.Add(saat);
                        }
                    }
                }


                string sqlSlot = "SELECT Saat FROM SaatSlotlari ORDER BY Saat";

                using (SqlCommand cmdSlot = new SqlCommand(sqlSlot, conn))
                using (SqlDataReader dr2 = cmdSlot.ExecuteReader())
                {
                    while (dr2.Read())
                    {
                        string saat = dr2["Saat"].ToString().Substring(0, 5);

                        if (!doluSaatler.Contains(saat))
                            cmbSaat.Items.Add(saat);
                    }
                }
            }
        }

        private async void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            int gelinYas = YasHesapla(dtGelinDogum.Value.Date);
            int damatYas = YasHesapla(dtDamatDogum.Value.Date);

            
            if (gelinYas < 16 || damatYas < 16)
            {
                MessageBox.Show("Randevu alamazsınız.");
                return;
            }

            
            if ((gelinYas == 16 || gelinYas == 17) ||
                (damatYas == 16 || damatYas == 17))
            {
                MessageBox.Show(
                    "Lütfen Belediyeye müracaat ediniz.",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            if (gelinYas > 110 || damatYas > 110)
            {
                MessageBox.Show("Lütfen gerçek doğum tarihinizi giriniz.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGelinTC.Text) ||
    string.IsNullOrWhiteSpace(txtGelinAdSoyad.Text) ||
    string.IsNullOrWhiteSpace(txtDamatTC.Text) ||
    string.IsNullOrWhiteSpace(txtDamatAdSoyad.Text) ||
    string.IsNullOrWhiteSpace(txtSahit1TC.Text) ||
    string.IsNullOrWhiteSpace(txtSahit1AdSoyad.Text) ||
    string.IsNullOrWhiteSpace(txtSahit2TC.Text) ||
    string.IsNullOrWhiteSpace(txtSahit2AdSoyad.Text))
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            
            if (!Araclar.TCKontrol(txtDamatTC.Text) ||
    !Araclar.TCKontrol(txtGelinTC.Text) ||
    !Araclar.TCKontrol(txtSahit1TC.Text) ||
    !Araclar.TCKontrol(txtSahit2TC.Text))
            {
                MessageBox.Show("TC Kimlik numaralarından biri veya birkaçı hatalı!");
                return;
            }
            if (cmbSaat.SelectedItem == null)
            {
                MessageBox.Show("Lütfen saat seçiniz!");
                return;
            }

            DateTime tarih = dtRandevuTarih.Value.Date;
            string saat = cmbSaat.SelectedItem.ToString();
            int salonId = 5700;

            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();


                string kontrolSql = @"
            SELECT COUNT(*) 
            FROM Randevular
            WHERE Tarih = @Tarih
              AND Saat = @Saat
              AND SalonID = @SalonID
              AND Durum = 'Aktif'";

                using (SqlCommand kontrolCmd = new SqlCommand(kontrolSql, conn))
                {
                    kontrolCmd.Parameters.AddWithValue("@Tarih", tarih);
                    kontrolCmd.Parameters.AddWithValue("@Saat", saat);
                    kontrolCmd.Parameters.AddWithValue("@SalonID", salonId);

                    int sayi = (int)kontrolCmd.ExecuteScalar();

                    if (sayi > 0)
                    {
                        MessageBox.Show("Bu tarih ve saatte zaten aktif bir randevu var.");
                        return;
                    }
                }


                string sql = @"
    INSERT INTO Randevular
    (UserID, 
     GelinTC, GelinAdSoyad, GelinDogumTarihi,
     DamatTC, DamatAdSoyad, DamatDogumTarihi,
     Sahit1AdSoyad, Sahit1TC,
     Sahit2AdSoyad, Sahit2TC,
     Tarih, Saat, SalonID, OlusturmaTarihi, Durum)
    VALUES
    (@UserID,
     @GelinTC, @GelinAdSoyad, @GelinDogum,
     @DamatTC, @DamatAdSoyad, @DamatDogum,
     @S1AdSoyad, @S1TC,
     @S2AdSoyad, @S2TC,
     @Tarih, @Saat, @SalonID, GETDATE(), 'Aktif')";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {

                    cmd.Parameters.AddWithValue("@UserID", Session.UserID);


                    cmd.Parameters.AddWithValue("@GelinTC", txtGelinTC.Text);
                    cmd.Parameters.AddWithValue("@GelinAdSoyad", txtGelinAdSoyad.Text);
                    cmd.Parameters.AddWithValue("@GelinDogum", dtGelinDogum.Value.Date);


                    cmd.Parameters.AddWithValue("@DamatTC", txtDamatTC.Text);
                    cmd.Parameters.AddWithValue("@DamatAdSoyad", txtDamatAdSoyad.Text);
                    cmd.Parameters.AddWithValue("@DamatDogum", dtDamatDogum.Value.Date);


                    cmd.Parameters.AddWithValue("@S1AdSoyad", txtSahit1AdSoyad.Text);
                    cmd.Parameters.AddWithValue("@S1TC", txtSahit1TC.Text);
                    cmd.Parameters.AddWithValue("@S2AdSoyad", txtSahit2AdSoyad.Text);
                    cmd.Parameters.AddWithValue("@S2TC", txtSahit2TC.Text);


                    cmd.Parameters.AddWithValue("@Tarih", tarih);
                    cmd.Parameters.AddWithValue("@Saat", saat);
                    cmd.Parameters.AddWithValue("@SalonID", salonId);

                    cmd.ExecuteNonQuery();
                    await MailWebhookGonderAsync();
                }
            }

            MessageBox.Show("Randevunuz başarıyla oluşturuldu!");


        }

        private void btnRandevularim_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRandevuListele frm = new FrmRandevuListele(Session.UserID);
            frm.ShowDialog();   
            this.Show();

        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDamatTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtGelinTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtSahit1TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtSahit2TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
        private async Task MailWebhookGonderAsync()
        {
            string webhookUrl = "https://nikahrandevu.app.n8n.cloud/webhook/NikahRandevu"; 

            string email = Session.Email;                
            string gelinAd = txtGelinAdSoyad.Text;
            string damatAd = txtDamatAdSoyad.Text;
            string tarih = dtRandevuTarih.Value.ToString("yyyy-MM-dd");
            string saat = cmbSaat.SelectedItem.ToString();

            string json = $@"
{{
  ""email"": ""{email}"",
  ""gelinAdSoyad"": ""{gelinAd}"",
  ""damatAdSoyad"": ""{damatAd}"",
  ""tarih"": ""{tarih}"",
  ""saat"": ""{saat}""
}}";

            using (var client = new HttpClient())
            {
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(webhookUrl, content);
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Mail webhook gönderilirken hata: " + ex.Message);
                }
            }
        }

        private void dtGelinDogum_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
