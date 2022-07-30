namespace Proje_Hastane
{
    partial class FrmRandevuListesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRandevuListesi));
            this.dtRandevuListesi = new System.Windows.Forms.DataGridView();
            this.lblRandevuListe = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.randevuListeCikis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtRandevuListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuListeCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // dtRandevuListesi
            // 
            this.dtRandevuListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtRandevuListesi.BackgroundColor = System.Drawing.Color.White;
            this.dtRandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtRandevuListesi.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtRandevuListesi.Location = new System.Drawing.Point(22, 79);
            this.dtRandevuListesi.Name = "dtRandevuListesi";
            this.dtRandevuListesi.RowHeadersWidth = 51;
            this.dtRandevuListesi.RowTemplate.Height = 24;
            this.dtRandevuListesi.Size = new System.Drawing.Size(1102, 450);
            this.dtRandevuListesi.TabIndex = 0;
            // 
            // lblRandevuListe
            // 
            this.lblRandevuListe.AllowDrop = true;
            this.lblRandevuListe.AutoEllipsis = true;
            this.lblRandevuListe.AutoSize = true;
            this.lblRandevuListe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRandevuListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRandevuListe.ForeColor = System.Drawing.Color.White;
            this.lblRandevuListe.Location = new System.Drawing.Point(436, 20);
            this.lblRandevuListe.Name = "lblRandevuListe";
            this.lblRandevuListe.Size = new System.Drawing.Size(267, 27);
            this.lblRandevuListe.TabIndex = 9;
            this.lblRandevuListe.Text = "RANDEVU LİSTESİ FORMU";
            // 
            // randevuListeCikis
            // 
            this.randevuListeCikis.Image = ((System.Drawing.Image)(resources.GetObject("randevuListeCikis.Image")));
            this.randevuListeCikis.Location = new System.Drawing.Point(1104, 12);
            this.randevuListeCikis.Name = "randevuListeCikis";
            this.randevuListeCikis.Size = new System.Drawing.Size(35, 35);
            this.randevuListeCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.randevuListeCikis.TabIndex = 11;
            this.randevuListeCikis.TabStop = false;
            this.randevuListeCikis.Click += new System.EventHandler(this.randevuListeCikis_Click);
            this.randevuListeCikis.MouseLeave += new System.EventHandler(this.randevuListeCikis_MouseLeave);
            this.randevuListeCikis.MouseHover += new System.EventHandler(this.randevuListeCikis_MouseHover);
            // 
            // FrmRandevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1151, 541);
            this.Controls.Add(this.randevuListeCikis);
            this.Controls.Add(this.lblRandevuListe);
            this.Controls.Add(this.dtRandevuListesi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRandevuListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randevu Listesi";
            this.Load += new System.EventHandler(this.FrmRandevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtRandevuListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randevuListeCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtRandevuListesi;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRandevuListe;
        private System.Windows.Forms.PictureBox randevuListeCikis;
    }
}