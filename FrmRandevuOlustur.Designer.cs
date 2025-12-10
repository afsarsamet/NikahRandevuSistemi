namespace NikahRandevu0
{
    partial class FrmRandevuOlustur
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDamatTC = new System.Windows.Forms.TextBox();
            this.txtDamatAdSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGelinAdSoyad = new System.Windows.Forms.TextBox();
            this.txtGelinTC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtGelinDogum = new System.Windows.Forms.DateTimePicker();
            this.dtDamatDogum = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSahit1AdSoyad = new System.Windows.Forms.TextBox();
            this.txtSahit1TC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSahit2AdSoyad = new System.Windows.Forms.TextBox();
            this.txtSahit2TC = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.dtRandevuTarih = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnRandevuOlustur = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCikis = new System.Windows.Forms.Button();
            this.btnRandevularim = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(302, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "DAMAT BİLGİLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C. Kimlik No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ad Soyad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi";
            // 
            // txtDamatTC
            // 
            this.txtDamatTC.Location = new System.Drawing.Point(400, 64);
            this.txtDamatTC.MaxLength = 11;
            this.txtDamatTC.Name = "txtDamatTC";
            this.txtDamatTC.Size = new System.Drawing.Size(146, 22);
            this.txtDamatTC.TabIndex = 4;
            this.txtDamatTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDamatTC_KeyPress);
            // 
            // txtDamatAdSoyad
            // 
            this.txtDamatAdSoyad.Location = new System.Drawing.Point(400, 101);
            this.txtDamatAdSoyad.Name = "txtDamatAdSoyad";
            this.txtDamatAdSoyad.Size = new System.Drawing.Size(146, 22);
            this.txtDamatAdSoyad.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(708, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "GELİN BİLGİLERİ";
            // 
            // txtGelinAdSoyad
            // 
            this.txtGelinAdSoyad.Location = new System.Drawing.Point(804, 104);
            this.txtGelinAdSoyad.Name = "txtGelinAdSoyad";
            this.txtGelinAdSoyad.Size = new System.Drawing.Size(146, 22);
            this.txtGelinAdSoyad.TabIndex = 13;
            // 
            // txtGelinTC
            // 
            this.txtGelinTC.Location = new System.Drawing.Point(804, 67);
            this.txtGelinTC.MaxLength = 11;
            this.txtGelinTC.Name = "txtGelinTC";
            this.txtGelinTC.Size = new System.Drawing.Size(146, 22);
            this.txtGelinTC.TabIndex = 12;
            this.txtGelinTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGelinTC_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(710, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Doğum Tarihi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(710, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ad Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(708, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "T.C. Kimlik No";
            // 
            // dtGelinDogum
            // 
            this.dtGelinDogum.Location = new System.Drawing.Point(804, 148);
            this.dtGelinDogum.Name = "dtGelinDogum";
            this.dtGelinDogum.Size = new System.Drawing.Size(200, 22);
            this.dtGelinDogum.TabIndex = 14;
            // 
            // dtDamatDogum
            // 
            this.dtDamatDogum.Location = new System.Drawing.Point(400, 147);
            this.dtDamatDogum.Name = "dtDamatDogum";
            this.dtDamatDogum.Size = new System.Drawing.Size(200, 22);
            this.dtDamatDogum.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(303, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "ŞAHİT BİLGİLERİ";
            // 
            // txtSahit1AdSoyad
            // 
            this.txtSahit1AdSoyad.Location = new System.Drawing.Point(402, 345);
            this.txtSahit1AdSoyad.Name = "txtSahit1AdSoyad";
            this.txtSahit1AdSoyad.Size = new System.Drawing.Size(146, 22);
            this.txtSahit1AdSoyad.TabIndex = 20;
            // 
            // txtSahit1TC
            // 
            this.txtSahit1TC.Location = new System.Drawing.Point(402, 308);
            this.txtSahit1TC.MaxLength = 11;
            this.txtSahit1TC.Name = "txtSahit1TC";
            this.txtSahit1TC.Size = new System.Drawing.Size(146, 22);
            this.txtSahit1TC.TabIndex = 19;
            this.txtSahit1TC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSahit1TC_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ad Soyad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(304, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 17;
            this.label11.Text = "T.C. Kimlik No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(303, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "1. Şahit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(703, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "2. Şahit";
            // 
            // txtSahit2AdSoyad
            // 
            this.txtSahit2AdSoyad.Location = new System.Drawing.Point(804, 342);
            this.txtSahit2AdSoyad.Name = "txtSahit2AdSoyad";
            this.txtSahit2AdSoyad.Size = new System.Drawing.Size(146, 22);
            this.txtSahit2AdSoyad.TabIndex = 26;
            // 
            // txtSahit2TC
            // 
            this.txtSahit2TC.Location = new System.Drawing.Point(804, 305);
            this.txtSahit2TC.MaxLength = 11;
            this.txtSahit2TC.Name = "txtSahit2TC";
            this.txtSahit2TC.Size = new System.Drawing.Size(146, 22);
            this.txtSahit2TC.TabIndex = 25;
            this.txtSahit2TC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSahit2TC_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(703, 351);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Ad Soyad";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(704, 311);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "T.C. Kimlik No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(305, 416);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(216, 24);
            this.label16.TabIndex = 27;
            this.label16.Text = "RANDEVU BİLGİLERİ";
            // 
            // cmbSaat
            // 
            this.cmbSaat.FormattingEnabled = true;
            this.cmbSaat.Location = new System.Drawing.Point(400, 518);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(121, 24);
            this.cmbSaat.TabIndex = 28;
            // 
            // dtRandevuTarih
            // 
            this.dtRandevuTarih.Location = new System.Drawing.Point(400, 471);
            this.dtRandevuTarih.Name = "dtRandevuTarih";
            this.dtRandevuTarih.Size = new System.Drawing.Size(200, 22);
            this.dtRandevuTarih.TabIndex = 29;
            this.dtRandevuTarih.ValueChanged += new System.EventHandler(this.dtRandevuTarih_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(306, 476);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Tarih";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(309, 526);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 16);
            this.label18.TabIndex = 31;
            this.label18.Text = "Saat";
            // 
            // btnRandevuOlustur
            // 
            this.btnRandevuOlustur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRandevuOlustur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRandevuOlustur.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevuOlustur.Location = new System.Drawing.Point(794, 455);
            this.btnRandevuOlustur.Name = "btnRandevuOlustur";
            this.btnRandevuOlustur.Size = new System.Drawing.Size(229, 87);
            this.btnRandevuOlustur.TabIndex = 32;
            this.btnRandevuOlustur.Text = "RANDEVUYU ONAYLA";
            this.btnRandevuOlustur.UseVisualStyleBackColor = false;
            this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCikis);
            this.panel1.Controls.Add(this.btnRandevularim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 610);
            this.panel1.TabIndex = 33;
            // 
            // buttonCikis
            // 
            this.buttonCikis.Location = new System.Drawing.Point(0, 533);
            this.buttonCikis.Name = "buttonCikis";
            this.buttonCikis.Size = new System.Drawing.Size(230, 77);
            this.buttonCikis.TabIndex = 1;
            this.buttonCikis.Text = "ÇIKIŞ";
            this.buttonCikis.UseVisualStyleBackColor = true;
            this.buttonCikis.Click += new System.EventHandler(this.buttonCikis_Click);
            // 
            // btnRandevularim
            // 
            this.btnRandevularim.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevularim.Location = new System.Drawing.Point(0, 0);
            this.btnRandevularim.Name = "btnRandevularim";
            this.btnRandevularim.Size = new System.Drawing.Size(230, 77);
            this.btnRandevularim.TabIndex = 0;
            this.btnRandevularim.Text = "RANDEVULARIM";
            this.btnRandevularim.UseVisualStyleBackColor = true;
            this.btnRandevularim.Click += new System.EventHandler(this.btnRandevularim_Click);
            // 
            // FrmRandevuOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1133, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRandevuOlustur);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dtRandevuTarih);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtSahit2AdSoyad);
            this.Controls.Add(this.txtSahit2TC);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSahit1AdSoyad);
            this.Controls.Add(this.txtSahit1TC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtDamatDogum);
            this.Controls.Add(this.dtGelinDogum);
            this.Controls.Add(this.txtGelinAdSoyad);
            this.Controls.Add(this.txtGelinTC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDamatAdSoyad);
            this.Controls.Add(this.txtDamatTC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmRandevuOlustur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRandevuOlustur";
            this.Load += new System.EventHandler(this.FrmRandevuOlustur_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDamatTC;
        private System.Windows.Forms.TextBox txtDamatAdSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGelinAdSoyad;
        private System.Windows.Forms.TextBox txtGelinTC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtGelinDogum;
        private System.Windows.Forms.DateTimePicker dtDamatDogum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSahit1AdSoyad;
        private System.Windows.Forms.TextBox txtSahit1TC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSahit2AdSoyad;
        private System.Windows.Forms.TextBox txtSahit2TC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.DateTimePicker dtRandevuTarih;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnRandevuOlustur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRandevularim;
        private System.Windows.Forms.Button buttonCikis;
    }
}
