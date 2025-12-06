namespace Nikah_Randevu_Sistemi_Login
{
    partial class FrmGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTC = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.bntKayitOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(390, 266);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(105, 20);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "T.C. Kimlik No";
            this.lblTC.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(425, 329);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(42, 20);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre";
            this.lblSifre.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(510, 266);
            this.txtTC.MaxLength = 11;
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(211, 26);
            this.txtTC.TabIndex = 2;
            this.txtTC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(510, 329);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(211, 26);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.UseSystemPasswordChar = true;
            this.txtSifre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(446, 395);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(111, 32);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // bntKayitOl
            // 
            this.bntKayitOl.Location = new System.Drawing.Point(604, 395);
            this.bntKayitOl.Name = "bntKayitOl";
            this.bntKayitOl.Size = new System.Drawing.Size(111, 32);
            this.bntKayitOl.TabIndex = 5;
            this.bntKayitOl.Text = "Kayıt Ol";
            this.bntKayitOl.UseVisualStyleBackColor = true;
            this.bntKayitOl.Click += new System.EventHandler(this.bntKayitOl_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 716);
            this.Controls.Add(this.bntKayitOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTC);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button bntKayitOl;
    }
}