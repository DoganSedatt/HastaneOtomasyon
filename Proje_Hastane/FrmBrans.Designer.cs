namespace Proje_Hastane
{
    partial class FrmBrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrans));
            this.dtBrans = new System.Windows.Forms.DataGridView();
            this.txtBransAd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBransid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnnBtnEkle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfbtnsil = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfbtnGuncelle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblBrans = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bransCikis = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtBrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bransCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // dtBrans
            // 
            this.dtBrans.BackgroundColor = System.Drawing.Color.White;
            this.dtBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtBrans.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtBrans.Location = new System.Drawing.Point(315, 135);
            this.dtBrans.Name = "dtBrans";
            this.dtBrans.RowHeadersWidth = 51;
            this.dtBrans.RowTemplate.Height = 24;
            this.dtBrans.Size = new System.Drawing.Size(478, 229);
            this.dtBrans.TabIndex = 62;
            this.dtBrans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtBrans_CellClick);
            // 
            // txtBransAd
            // 
            this.txtBransAd.Location = new System.Drawing.Point(146, 182);
            this.txtBransAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBransAd.Name = "txtBransAd";
            this.txtBransAd.Size = new System.Drawing.Size(151, 22);
            this.txtBransAd.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(36, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "Branş Ad:";
            // 
            // txtBransid
            // 
            this.txtBransid.Enabled = false;
            this.txtBransid.Location = new System.Drawing.Point(146, 135);
            this.txtBransid.Margin = new System.Windows.Forms.Padding(4);
            this.txtBransid.Name = "txtBransid";
            this.txtBransid.Size = new System.Drawing.Size(151, 22);
            this.txtBransid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(37, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Branş İd:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bnnBtnEkle
            // 
            this.bnnBtnEkle.ActiveBorderThickness = 1;
            this.bnnBtnEkle.ActiveCornerRadius = 20;
            this.bnnBtnEkle.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bnnBtnEkle.ActiveForecolor = System.Drawing.Color.White;
            this.bnnBtnEkle.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bnnBtnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bnnBtnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnnBtnEkle.BackgroundImage")));
            this.bnnBtnEkle.ButtonText = "Ekle";
            this.bnnBtnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnnBtnEkle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnnBtnEkle.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnnBtnEkle.IdleBorderThickness = 1;
            this.bnnBtnEkle.IdleCornerRadius = 20;
            this.bnnBtnEkle.IdleFillColor = System.Drawing.Color.White;
            this.bnnBtnEkle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnnBtnEkle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnnBtnEkle.Location = new System.Drawing.Point(146, 213);
            this.bnnBtnEkle.Margin = new System.Windows.Forms.Padding(5);
            this.bnnBtnEkle.Name = "bnnBtnEkle";
            this.bnnBtnEkle.Size = new System.Drawing.Size(151, 50);
            this.bnnBtnEkle.TabIndex = 63;
            this.bnnBtnEkle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnnBtnEkle.Click += new System.EventHandler(this.bnnBtnEkle_Click);
            // 
            // bnfbtnsil
            // 
            this.bnfbtnsil.ActiveBorderThickness = 1;
            this.bnfbtnsil.ActiveCornerRadius = 20;
            this.bnfbtnsil.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnsil.ActiveForecolor = System.Drawing.Color.White;
            this.bnfbtnsil.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnsil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bnfbtnsil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfbtnsil.BackgroundImage")));
            this.bnfbtnsil.ButtonText = "Sil";
            this.bnfbtnsil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfbtnsil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfbtnsil.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnsil.IdleBorderThickness = 1;
            this.bnfbtnsil.IdleCornerRadius = 20;
            this.bnfbtnsil.IdleFillColor = System.Drawing.Color.White;
            this.bnfbtnsil.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnfbtnsil.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnsil.Location = new System.Drawing.Point(146, 263);
            this.bnfbtnsil.Margin = new System.Windows.Forms.Padding(5);
            this.bnfbtnsil.Name = "bnfbtnsil";
            this.bnfbtnsil.Size = new System.Drawing.Size(151, 50);
            this.bnfbtnsil.TabIndex = 63;
            this.bnfbtnsil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfbtnsil.Click += new System.EventHandler(this.bnfbtnsil_Click);
            // 
            // bnfbtnGuncelle
            // 
            this.bnfbtnGuncelle.ActiveBorderThickness = 1;
            this.bnfbtnGuncelle.ActiveCornerRadius = 20;
            this.bnfbtnGuncelle.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnGuncelle.ActiveForecolor = System.Drawing.Color.White;
            this.bnfbtnGuncelle.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bnfbtnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfbtnGuncelle.BackgroundImage")));
            this.bnfbtnGuncelle.ButtonText = "Güncelle";
            this.bnfbtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfbtnGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfbtnGuncelle.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnGuncelle.IdleBorderThickness = 1;
            this.bnfbtnGuncelle.IdleCornerRadius = 20;
            this.bnfbtnGuncelle.IdleFillColor = System.Drawing.Color.White;
            this.bnfbtnGuncelle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnfbtnGuncelle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnGuncelle.Location = new System.Drawing.Point(146, 314);
            this.bnfbtnGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.bnfbtnGuncelle.Name = "bnfbtnGuncelle";
            this.bnfbtnGuncelle.Size = new System.Drawing.Size(151, 50);
            this.bnfbtnGuncelle.TabIndex = 63;
            this.bnfbtnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfbtnGuncelle.Click += new System.EventHandler(this.bnfbtnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(114, 225);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(114, 271);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(114, 323);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 64;
            this.pictureBox3.TabStop = false;
            // 
            // lblBrans
            // 
            this.lblBrans.AllowDrop = true;
            this.lblBrans.AutoEllipsis = true;
            this.lblBrans.AutoSize = true;
            this.lblBrans.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBrans.ForeColor = System.Drawing.Color.White;
            this.lblBrans.Location = new System.Drawing.Point(343, 9);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(159, 27);
            this.lblBrans.TabIndex = 65;
            this.lblBrans.Text = "BRANŞ FORMU";
            // 
            // bransCikis
            // 
            this.bransCikis.Image = ((System.Drawing.Image)(resources.GetObject("bransCikis.Image")));
            this.bransCikis.Location = new System.Drawing.Point(792, 12);
            this.bransCikis.Name = "bransCikis";
            this.bransCikis.Size = new System.Drawing.Size(35, 35);
            this.bransCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bransCikis.TabIndex = 67;
            this.bransCikis.TabStop = false;
            this.bransCikis.Click += new System.EventHandler(this.bransCikis_Click);
            this.bransCikis.MouseLeave += new System.EventHandler(this.bransCikis_MouseLeave);
            this.bransCikis.MouseHover += new System.EventHandler(this.bransCikis_MouseHover);
            // 
            // FrmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(839, 425);
            this.Controls.Add(this.bransCikis);
            this.Controls.Add(this.lblBrans);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bnfbtnGuncelle);
            this.Controls.Add(this.bnfbtnsil);
            this.Controls.Add(this.bnnBtnEkle);
            this.Controls.Add(this.dtBrans);
            this.Controls.Add(this.txtBransAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBransid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBrans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branşlar";
            this.Load += new System.EventHandler(this.FrmBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtBrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bransCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtBrans;
        private System.Windows.Forms.TextBox txtBransAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBransid;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 bnnBtnEkle;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfbtnsil;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfbtnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBrans;
        private System.Windows.Forms.PictureBox bransCikis;
    }
}