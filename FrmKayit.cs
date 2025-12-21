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
using RandevuEkranı;

namespace NikahRandevu0
{
    public partial class FrmKayit : Form
    {
        public FrmKayit()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Araclar.TCKontrol(txtTC.Text) == false)
            {
                MessageBox.Show("Hatalı TC girdiniz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTC.Text) ||
                string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTel.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtSifre2.Text) ||
                cmbCinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                return; 
            }

            
            if (txtTC.Text.Length != 11)
            {
                MessageBox.Show("T.C. Kimlik Numarası 11 haneli olmalıdır.");
                return;
            }
              if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Geçersiz e-posta adresi.");
                 return;
            }

            
            if (txtSifre.Text != txtSifre2.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor.");
                return;
            }

            using(SqlConnection conn = Db.GetConnection())
            {
                conn.Open();

               
                string checkSql = "SELECT COUNT(*) FROM users WHERE TC = @TC";
                using (SqlCommand checkcmd = new SqlCommand(checkSql, conn))
                {
                    checkcmd.Parameters.AddWithValue("@TC", txtTC.Text.Trim());

                    object result = checkcmd.ExecuteScalar();
                    int count = 0;
                    if (result != null && result != DBNull.Value)
                        count = Convert.ToInt32(result);

                    if (count > 0)
                    {
                        MessageBox.Show("Bu T.C. Kimlik Numarası zaten kayıtlı.");
                        return;
                    }
                }

            
                string insertSql = @"INSERT INTO users (TC,Ad,Soyad,Email,Telefon,Cinsiyet,Sifre)
                             VALUES (@TC,@Ad,@Soyad,@Email,@Telefon,@Cinsiyet,@Sifre)";
                using (SqlCommand cmd = new SqlCommand(insertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@TC", txtTC.Text.Trim());
                    cmd.Parameters.AddWithValue("@Ad", txtAd.Text.Trim());
                    cmd.Parameters.AddWithValue("@Soyad", txtSoyad.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@Telefon", txtTel.Text.Trim()); ;  

                    string cinsiyetKodu = cmbCinsiyet.SelectedItem.ToString() == "Erkek" ? "E" : "K";
                    cmd.Parameters.AddWithValue("@Cinsiyet", cinsiyetKodu);

                    string sifreHash=SifreHashleme.HashSifre(txtSifre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Sifre", sifreHash);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Kayıt başarılı! Giriş ekranına dönebilirsiniz.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt başarısız. Lütfen tekrar deneyiniz.");
                    }
                }
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKayit_Load(object sender, EventArgs e)
        {

        }

        private void FrmKayit_Load_1(object sender, EventArgs e)
        {

        }

        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }




}

