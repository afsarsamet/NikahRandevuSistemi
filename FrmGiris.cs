using RandevuEkranı;
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

namespace NikahRandevu0
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
            string tc = txtTC.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (string.IsNullOrWhiteSpace(tc) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen T.C. ve Şifre girin.");
                return;
            }

            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

                string sqlPersonel = @"
            SELECT PrID, Ad, Soyad, Sifre
            FROM personel
            WHERE TC = @TC";

                using (SqlCommand cmdP = new SqlCommand(sqlPersonel, conn))
                {
                    cmdP.Parameters.AddWithValue("@TC", tc);

                    using (SqlDataReader drP = cmdP.ExecuteReader())
                    {
                        if (drP.Read())
                        {
                            string dbHashP = drP["Sifre"].ToString();

                            if (SifreHashleme.VerifyPassword(sifre, dbHashP))
                            {
                                Session.UserID = Convert.ToInt32(drP["PrID"]);
                                Session.AdSoyad = drP["Ad"] + " " + drP["Soyad"];
                                Session.IsAdmin = true;

                                MessageBox.Show("Görevli girişi başarılı!");
                                new FrmAdminPanel().Show();
                                this.Hide();
                                return;
                            }
                        }
                    }
                }

 
                string sqlUser = @"
            SELECT userID, Ad, Soyad, Email, Sifre
            FROM Users
            WHERE TC = @TC";

                using (SqlCommand cmdU = new SqlCommand(sqlUser, conn))
                {
                    cmdU.Parameters.AddWithValue("@TC", tc);

                    using (SqlDataReader drU = cmdU.ExecuteReader())
                    {
                        if (!drU.Read())
                        {
                            MessageBox.Show("TC veya Şifre hatalı.");
                            return;
                        }

                        string dbHashU = drU["Sifre"].ToString();

                        if (!SifreHashleme.VerifyPassword(sifre, dbHashU))
                        {
                            MessageBox.Show("TC veya Şifre hatalı.");
                            return;
                        }

                        Session.UserID = Convert.ToInt32(drU["userID"]);
                        Session.AdSoyad = drU["Ad"] + " " + drU["Soyad"];
                        Session.IsAdmin = false;
                        Session.Email = drU["Email"].ToString();

                        MessageBox.Show("Giriş başarılı!");
                        new FrmRandevuOlustur().Show(); // istersen userID yolla: new FrmRandevuOlustur(Session.UserID)
                        this.Hide();
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

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
