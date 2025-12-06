using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NikahRandevu0
{
    public partial class FrmRandevuOlustur : Form
    {
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

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
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
                }
            }

            MessageBox.Show("Randevunuz başarıyla oluşturuldu!");

            FrmRandevuListele frm = new FrmRandevuListele(Session.UserID); 
            frm.ShowDialog();
        }


    }
}
