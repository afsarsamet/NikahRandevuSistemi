using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NikahRandevu0
{
    public partial class FrmAdminPanel : Form
    {
        public FrmAdminPanel()
        {
            InitializeComponent();

        }

        private void FrmAdminPanel_Load(object sender, EventArgs e)
        {
            RandevulariYukle();
        }
        private void RandevulariYukle()
        {
            
        
            try
            {
                using (SqlConnection conn = Db.GetConnection())
                {
                    string sql = @"
                SELECT 
                    RandevuID,
                    userID,
                    GelinTC,
                    GelinAdSoyad,
                    DamatTC,
                    DamatAdSoyad,
                    Sahit1TC,
                    Sahit1AdSoyad,
                    Sahit2TC,
                    Sahit2AdSoyad,
                    Tarih,
                    Saat,
                    Durum          -- 🔴 BUNU EKLEDİK
                FROM randevular
                ORDER BY Tarih, Saat";

                    using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        dgvRandevular.DataSource = dt;
                    }
                }

                dgvRandevular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevular yüklenirken hata: " + ex.Message);
            }
        }

        
        private int? SeciliRandevuIdGetir()
        {
            if (dgvRandevular.CurrentRow == null)
                return null;

            object val = dgvRandevular.CurrentRow.Cells["RandevuID"].Value;
            return Convert.ToInt32(val);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            int? id = SeciliRandevuIdGetir();
            if (id == null)
            {
                MessageBox.Show("Lütfen bir randevu seçin.");
                return;
            }

            var sonuc = MessageBox.Show(
                "Bu randevuyu silmeyi onaylıyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (sonuc != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn =Db.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM randevular WHERE RandevuID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id.Value);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Randevu silindi");
                RandevulariYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silinme sırasında hata: " + ex.Message);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvRandevular.CurrentRow == null || dgvRandevular.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Lütfen listede kayıtlı bir randevu satırı seçin.");
                return;
            }

            DataGridViewRow row = dgvRandevular.CurrentRow;

            // Önce RandevuID'yi güvenli şekilde al
            object idVal = row.Cells["RandevuID"].Value;

            if (idVal == null || idVal == DBNull.Value || string.IsNullOrWhiteSpace(idVal.ToString()))
            {
                MessageBox.Show("Bu satırın RandevuID değeri yok. Lütfen veritabanında kayıtlı bir randevu seçin.");
                return;
            }

            int randevuId = Convert.ToInt32(idVal);

            // Diğer alanlar
            string gelinTC = row.Cells["GelinTC"].Value?.ToString();
            string gelinAd = row.Cells["GelinAdSoyad"].Value?.ToString();
            string damatTC = row.Cells["DamatTC"].Value?.ToString();
            string damatAd = row.Cells["DamatAdSoyad"].Value?.ToString();
            string sahit1TC = row.Cells["Sahit1TC"].Value?.ToString();
            string sahit1Ad = row.Cells["Sahit1AdSoyad"].Value?.ToString();
            string sahit2TC = row.Cells["Sahit2TC"].Value?.ToString();
            string sahit2Ad = row.Cells["Sahit2AdSoyad"].Value?.ToString();

            // Tarih
            DateTime tarih;
            if (!DateTime.TryParse(row.Cells["Tarih"].Value?.ToString(), out tarih))
            {
                MessageBox.Show("Tarih alanı hatalı.");
                return;
            }

            // Saat (string)
            string saat = row.Cells["Saat"].Value?.ToString();

            try
            {
                using (SqlConnection conn = Db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                UPDATE randevular SET
                    GelinTC = @GelinTC,
                    GelinAdSoyad = @GelinAdSoyad,
                    DamatTC = @DamatTC,
                    DamatAdSoyad = @DamatAdSoyad,
                    Sahit1TC = @Sahit1TC,
                    Sahit1AdSoyad = @Sahit1AdSoyad,
                    Sahit2TC = @Sahit2TC,
                    Sahit2AdSoyad = @Sahit2AdSoyad,
                    Tarih = @Tarih,
                    Saat = @Saat
                WHERE RandevuID = @id";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@GelinTC", gelinTC);
                        cmd.Parameters.AddWithValue("@GelinAdSoyad", gelinAd);
                        cmd.Parameters.AddWithValue("@DamatTC", damatTC);
                        cmd.Parameters.AddWithValue("@DamatAdSoyad", damatAd);
                        cmd.Parameters.AddWithValue("@Sahit1TC", sahit1TC);
                        cmd.Parameters.AddWithValue("@Sahit1AdSoyad", sahit1Ad);
                        cmd.Parameters.AddWithValue("@Sahit2TC", sahit2TC);
                        cmd.Parameters.AddWithValue("@Sahit2AdSoyad", sahit2Ad);
                        cmd.Parameters.AddWithValue("@Tarih", tarih);
                        cmd.Parameters.AddWithValue("@Saat", saat);
                        cmd.Parameters.AddWithValue("@id", randevuId);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Randevu güncellendi.");
                RandevulariYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata: " + ex.Message);
            }
        }

        private void btnDurumuPasifYap_Click(object sender, EventArgs e)
        {
            
        
            int? id = SeciliRandevuIdGetir();
            if (id == null)
            {
                MessageBox.Show("Lütfen bir randevu seçin.");
                return;
            }

            var sonuc = MessageBox.Show(
                "Bu randevunun durumunu PASİF yapmak istiyor musunuz?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (sonuc != DialogResult.Yes)
                return;

            try
            {
                using (SqlConnection conn = Db.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE randevular SET Durum = 'Pasif' WHERE RandevuID = @id", conn);
                    cmd.Parameters.AddWithValue("@id", id.Value);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Randevu durumu PASİF yapıldı.");
                RandevulariYukle();   // grid’i yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Durum güncellenirken hata: " + ex.Message);
            }
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {

        }
    }
}

