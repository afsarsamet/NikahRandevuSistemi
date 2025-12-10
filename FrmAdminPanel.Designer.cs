namespace NikahRandevu0
{
    partial class FrmAdminPanel
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
            System.Windows.Forms.Button btnDuzenle;
            this.dgvRandevular = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.btnDurumuPasifYap = new System.Windows.Forms.Button();
            btnDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDuzenle
            // 
            btnDuzenle.Location = new System.Drawing.Point(941, 451);
            btnDuzenle.Name = "btnDuzenle";
            btnDuzenle.Size = new System.Drawing.Size(211, 103);
            btnDuzenle.TabIndex = 3;
            btnDuzenle.Text = "Düzenle";
            btnDuzenle.UseVisualStyleBackColor = true;
            btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevular.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvRandevular.Location = new System.Drawing.Point(0, 0);
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.RowHeadersWidth = 51;
            this.dgvRandevular.RowTemplate.Height = 24;
            this.dgvRandevular.Size = new System.Drawing.Size(1181, 472);
            this.dgvRandevular.TabIndex = 0;
            this.dgvRandevular.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(12, 451);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(196, 103);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.Location = new System.Drawing.Point(304, 451);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(206, 103);
            this.btnIptalEt.TabIndex = 2;
            this.btnIptalEt.Text = "Randevu Sil";
            this.btnIptalEt.UseVisualStyleBackColor = true;
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // btnDurumuPasifYap
            // 
            this.btnDurumuPasifYap.Location = new System.Drawing.Point(634, 449);
            this.btnDurumuPasifYap.Name = "btnDurumuPasifYap";
            this.btnDurumuPasifYap.Size = new System.Drawing.Size(205, 105);
            this.btnDurumuPasifYap.TabIndex = 4;
            this.btnDurumuPasifYap.Text = "Randevu İptal";
            this.btnDurumuPasifYap.UseVisualStyleBackColor = true;
            this.btnDurumuPasifYap.Click += new System.EventHandler(this.btnDurumuPasifYap_Click);
            // 
            // FrmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 706);
            this.Controls.Add(this.btnDurumuPasifYap);
            this.Controls.Add(btnDuzenle);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dgvRandevular);
            this.MaximizeBox = false;
            this.Name = "FrmAdminPanel";
            this.Text = "Admin Paneli - Randevular";
            this.Load += new System.EventHandler(this.FrmAdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRandevular;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnIptalEt;
        private System.Windows.Forms.Button btnDurumuPasifYap;
    }
}
