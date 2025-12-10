namespace NikahRandevu0
{
    partial class FrmRandevuListele
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
            this.dgvRandevular = new System.Windows.Forms.DataGridView();
            this.btnIptalEt = new System.Windows.Forms.Button();
            this.buttonGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRandevular
            // 
            this.dgvRandevular.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvRandevular.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRandevular.Location = new System.Drawing.Point(12, 12);
            this.dgvRandevular.MultiSelect = false;
            this.dgvRandevular.Name = "dgvRandevular";
            this.dgvRandevular.RowHeadersWidth = 51;
            this.dgvRandevular.RowTemplate.Height = 24;
            this.dgvRandevular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRandevular.Size = new System.Drawing.Size(983, 343);
            this.dgvRandevular.TabIndex = 0;
            // 
            // btnIptalEt
            // 
            this.btnIptalEt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptalEt.Location = new System.Drawing.Point(279, 375);
            this.btnIptalEt.Name = "btnIptalEt";
            this.btnIptalEt.Size = new System.Drawing.Size(437, 123);
            this.btnIptalEt.TabIndex = 1;
            this.btnIptalEt.Text = "RANDEVUYU İPTAL ET";
            this.btnIptalEt.UseVisualStyleBackColor = true;
            this.btnIptalEt.Click += new System.EventHandler(this.btnIptalEt_Click);
            // 
            // buttonGeriDon
            // 
            this.buttonGeriDon.Location = new System.Drawing.Point(12, 551);
            this.buttonGeriDon.Name = "buttonGeriDon";
            this.buttonGeriDon.Size = new System.Drawing.Size(213, 56);
            this.buttonGeriDon.TabIndex = 2;
            this.buttonGeriDon.Text = "Geri Dön";
            this.buttonGeriDon.UseVisualStyleBackColor = true;
            this.buttonGeriDon.Click += new System.EventHandler(this.buttonGeriDon_Click);
            // 
            // FrmRandevuListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 619);
            this.Controls.Add(this.buttonGeriDon);
            this.Controls.Add(this.btnIptalEt);
            this.Controls.Add(this.dgvRandevular);
            this.MaximizeBox = false;
            this.Name = "FrmRandevuListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRandevuListele";
            this.Load += new System.EventHandler(this.FrmRandevuListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRandevular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRandevular;
        private System.Windows.Forms.Button btnIptalEt;
        private System.Windows.Forms.Button buttonGeriDon;
    }
}
