namespace Proje_Hastane
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.AdSoyadlbl = new System.Windows.Forms.Label();
            this.lblTcno = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchRandevuDetay = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtRandevuListesi = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bnfDuyurularBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bnfBilgibtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.doktorDetayGeri = new System.Windows.Forms.PictureBox();
            this.doktorDetayCikis = new System.Windows.Forms.PictureBox();
            this.lblDoktorDetay = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtRandevuListesi)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doktorDetayGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorDetayCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.AdSoyadlbl);
            this.groupBox1.Controls.Add(this.lblTcno);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doktor Bilgi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdSoyad.Location = new System.Drawing.Point(12, 88);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(122, 29);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // AdSoyadlbl
            // 
            this.AdSoyadlbl.AutoSize = true;
            this.AdSoyadlbl.Location = new System.Drawing.Point(140, 88);
            this.AdSoyadlbl.Name = "AdSoyadlbl";
            this.AdSoyadlbl.Size = new System.Drawing.Size(105, 29);
            this.AdSoyadlbl.TabIndex = 2;
            this.AdSoyadlbl.Text = "Null Null";
            // 
            // lblTcno
            // 
            this.lblTcno.AutoSize = true;
            this.lblTcno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTcno.Location = new System.Drawing.Point(140, 41);
            this.lblTcno.Name = "lblTcno";
            this.lblTcno.Size = new System.Drawing.Size(156, 29);
            this.lblTcno.TabIndex = 1;
            this.lblTcno.Text = "00000000000";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTC.Location = new System.Drawing.Point(44, 41);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(90, 29);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchRandevuDetay);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(13, 305);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rchRandevuDetay
            // 
            this.rchRandevuDetay.Location = new System.Drawing.Point(6, 33);
            this.rchRandevuDetay.Name = "rchRandevuDetay";
            this.rchRandevuDetay.Size = new System.Drawing.Size(367, 236);
            this.rchRandevuDetay.TabIndex = 3;
            this.rchRandevuDetay.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtRandevuListesi);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox3.Location = new System.Drawing.Point(412, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(795, 687);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevularım";
            // 
            // dtRandevuListesi
            // 
            this.dtRandevuListesi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtRandevuListesi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtRandevuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtRandevuListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtRandevuListesi.Location = new System.Drawing.Point(3, 30);
            this.dtRandevuListesi.Name = "dtRandevuListesi";
            this.dtRandevuListesi.ReadOnly = true;
            this.dtRandevuListesi.RowHeadersWidth = 51;
            this.dtRandevuListesi.RowTemplate.Height = 24;
            this.dtRandevuListesi.Size = new System.Drawing.Size(789, 654);
            this.dtRandevuListesi.TabIndex = 0;
            this.dtRandevuListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtRandevuListesi_CellContentClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bnfDuyurularBtn);
            this.groupBox4.Controls.Add(this.bnfBilgibtn);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(12, 597);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(380, 189);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // bnfDuyurularBtn
            // 
            this.bnfDuyurularBtn.ActiveBorderThickness = 1;
            this.bnfDuyurularBtn.ActiveCornerRadius = 20;
            this.bnfDuyurularBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bnfDuyurularBtn.ActiveForecolor = System.Drawing.Color.White;
            this.bnfDuyurularBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bnfDuyurularBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bnfDuyurularBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfDuyurularBtn.BackgroundImage")));
            this.bnfDuyurularBtn.ButtonText = "Duyurular";
            this.bnfDuyurularBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfDuyurularBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfDuyurularBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfDuyurularBtn.IdleBorderThickness = 1;
            this.bnfDuyurularBtn.IdleCornerRadius = 20;
            this.bnfDuyurularBtn.IdleFillColor = System.Drawing.Color.White;
            this.bnfDuyurularBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnfDuyurularBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnfDuyurularBtn.Location = new System.Drawing.Point(66, 109);
            this.bnfDuyurularBtn.Margin = new System.Windows.Forms.Padding(5);
            this.bnfDuyurularBtn.Name = "bnfDuyurularBtn";
            this.bnfDuyurularBtn.Size = new System.Drawing.Size(255, 72);
            this.bnfDuyurularBtn.TabIndex = 10;
            this.bnfDuyurularBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfDuyurularBtn.Click += new System.EventHandler(this.bnfDuyurularBtn_Click);
            // 
            // bnfBilgibtn
            // 
            this.bnfBilgibtn.ActiveBorderThickness = 1;
            this.bnfBilgibtn.ActiveCornerRadius = 20;
            this.bnfBilgibtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bnfBilgibtn.ActiveForecolor = System.Drawing.Color.White;
            this.bnfBilgibtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bnfBilgibtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bnfBilgibtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfBilgibtn.BackgroundImage")));
            this.bnfBilgibtn.ButtonText = "Bilgi Düzenle";
            this.bnfBilgibtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfBilgibtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfBilgibtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfBilgibtn.IdleBorderThickness = 1;
            this.bnfBilgibtn.IdleCornerRadius = 20;
            this.bnfBilgibtn.IdleFillColor = System.Drawing.Color.White;
            this.bnfBilgibtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnfBilgibtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnfBilgibtn.Location = new System.Drawing.Point(66, 27);
            this.bnfBilgibtn.Margin = new System.Windows.Forms.Padding(5);
            this.bnfBilgibtn.Name = "bnfBilgibtn";
            this.bnfBilgibtn.Size = new System.Drawing.Size(255, 72);
            this.bnfBilgibtn.TabIndex = 10;
            this.bnfBilgibtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfBilgibtn.Click += new System.EventHandler(this.bnfBilgibtn_Click);
            // 
            // doktorDetayGeri
            // 
            this.doktorDetayGeri.Image = ((System.Drawing.Image)(resources.GetObject("doktorDetayGeri.Image")));
            this.doktorDetayGeri.Location = new System.Drawing.Point(12, 12);
            this.doktorDetayGeri.Name = "doktorDetayGeri";
            this.doktorDetayGeri.Size = new System.Drawing.Size(35, 35);
            this.doktorDetayGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doktorDetayGeri.TabIndex = 7;
            this.doktorDetayGeri.TabStop = false;
            this.doktorDetayGeri.Click += new System.EventHandler(this.doktorDetayGeri_Click_1);
            this.doktorDetayGeri.MouseLeave += new System.EventHandler(this.doktorDetayGeri_MouseLeave);
            this.doktorDetayGeri.MouseHover += new System.EventHandler(this.doktorDetayGeri_MouseHover_1);
            // 
            // doktorDetayCikis
            // 
            this.doktorDetayCikis.Image = ((System.Drawing.Image)(resources.GetObject("doktorDetayCikis.Image")));
            this.doktorDetayCikis.Location = new System.Drawing.Point(1172, 12);
            this.doktorDetayCikis.Name = "doktorDetayCikis";
            this.doktorDetayCikis.Size = new System.Drawing.Size(35, 35);
            this.doktorDetayCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doktorDetayCikis.TabIndex = 8;
            this.doktorDetayCikis.TabStop = false;
            this.doktorDetayCikis.Click += new System.EventHandler(this.doktorDetayCikis_Click);
            this.doktorDetayCikis.MouseLeave += new System.EventHandler(this.doktorDetayCikis_MouseLeave);
            this.doktorDetayCikis.MouseHover += new System.EventHandler(this.doktorDetayCikis_MouseHover);
            // 
            // lblDoktorDetay
            // 
            this.lblDoktorDetay.AllowDrop = true;
            this.lblDoktorDetay.AutoEllipsis = true;
            this.lblDoktorDetay.AutoSize = true;
            this.lblDoktorDetay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDoktorDetay.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorDetay.ForeColor = System.Drawing.Color.White;
            this.lblDoktorDetay.Location = new System.Drawing.Point(519, 21);
            this.lblDoktorDetay.Name = "lblDoktorDetay";
            this.lblDoktorDetay.Size = new System.Drawing.Size(222, 26);
            this.lblDoktorDetay.TabIndex = 9;
            this.lblDoktorDetay.Text = "DOKTOR DETAY FORMU";
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1219, 798);
            this.Controls.Add(this.lblDoktorDetay);
            this.Controls.Add(this.doktorDetayCikis);
            this.Controls.Add(this.doktorDetayGeri);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Detay";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtRandevuListesi)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doktorDetayGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorDetayCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label AdSoyadlbl;
        private System.Windows.Forms.Label lblTcno;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchRandevuDetay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtRandevuListesi;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox doktorDetayGeri;
        private System.Windows.Forms.PictureBox doktorDetayCikis;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDoktorDetay;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfBilgibtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfDuyurularBtn;
    }
}