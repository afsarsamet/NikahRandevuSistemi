using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;    
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nikah_Randevu_Sistemi_Login
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void FrmGiris_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTC.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen T.C. Kimlik No ve Şifre alanlarını doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(DbConfig.ConnectionString))
            {
                conn.Open();
                string sql = "SELECT UserID, Ad, Soyad FROM Users WHERE TC = @TC AND Sifre = @Sifre";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@TC", txtTC.Text.Trim());
                    cmd.Parameters.AddWithValue("@Sifre", txtSifre.Text.Trim());

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            // 🔴 GİRİŞ BAŞARILI — BURADA USERID'Yİ ALIYORUZ
                            Session.UserID = Convert.ToInt32(dr["UserID"]);
                            Session.AdSoyad = dr["Ad"] + " " + dr["Soyad"];

                            MessageBox.Show("Giriş Başarılı!");

                            // Randevu formunu aç
                            FrmRandevuOlustur frm = new FrmRandevuOlustur();
                            frm.Show();
                            this.Hide(); // Login ekranını gizle
                        }
                        else
                        {
                            MessageBox.Show("TC veya Şifre hatalı.");
                        }
                    }
                }


            }

        }

        private void bntKayitOl_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmKayit frm = new FrmKayit();
            frm.ShowDialog();
            this.Show();
        }
    }
}
