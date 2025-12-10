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
    public partial class FrmRandevuListele : Form
    {
        int _userID;
        public FrmRandevuListele(int userID)
        {
            InitializeComponent();
            _userID = userID;

        }

        private void FrmRandevuListele_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = Db.GetConnection())
            {
                string sql = @"
            SELECT 
                RandevuID,
                Tarih,
                Saat,
                GelinAdSoyad,
                DamatAdSoyad,
                Durum
            FROM Randevular
            WHERE UserID = @UserID
            ORDER BY Tarih, Saat";

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@UserID", _userID);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRandevular.DataSource = dt;
            }

            dgvRandevular.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {

            if (dgvRandevular.CurrentRow == null)
            {
                MessageBox.Show("Lütfen iptal etmek istediğiniz randevuyu seçin.");
                return;
            }


            int randevuID = Convert.ToInt32(dgvRandevular.CurrentRow.Cells["RandevuID"].Value);
            DateTime tarih = Convert.ToDateTime(dgvRandevular.CurrentRow.Cells["Tarih"].Value);


            double kalanGun = (tarih - DateTime.Now.Date).TotalDays;

            if (kalanGun < 10)
            {
                MessageBox.Show("Randevu tarihine 10 günden az kaldığı için iptal edemezsiniz.");
                return;
            }


            var sonuc = MessageBox.Show("Bu randevuyu iptal etmek istediğinize emin misiniz?",
                                        "Onay",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

            if (sonuc != DialogResult.Yes)
                return;


            using (SqlConnection conn = Db.GetConnection())
            {
                string sql = "UPDATE Randevular SET Durum = 'İptal' WHERE RandevuID = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", randevuID);

                conn.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Randevu iptal edildi.");


            FrmRandevuListele_Load(null, null);
        }

        private void buttonGeriDon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
