namespace Proje_Hastane
{
    partial class FrmHastaGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaGiris));
            this.lblHastaGirisPaneli = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.lnkHastaKayit = new System.Windows.Forms.LinkLabel();
            this.hastaGirisPBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hastaCikis = new System.Windows.Forms.PictureBox();
            this.hastaEnglish = new System.Windows.Forms.PictureBox();
            this.hastaTurkce = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaTurkce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHastaGirisPaneli
            // 
            this.lblHastaGirisPaneli.AutoSize = true;
            this.lblHastaGirisPaneli.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaGirisPaneli.ForeColor = System.Drawing.SystemColors.Window;
            this.lblHastaGirisPaneli.Location = new System.Drawing.Point(102, 67);
            this.lblHastaGirisPaneli.Name = "lblHastaGirisPaneli";
            this.lblHastaGirisPaneli.Size = new System.Drawing.Size(197, 46);
            this.lblHastaGirisPaneli.TabIndex = 0;
            this.lblHastaGirisPaneli.Text = "Hasta Giriş";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.Color.White;
            this.lblTC.Location = new System.Drawing.Point(49, 144);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(82, 25);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "TC No:";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.White;
            this.lblSifre.Location = new System.Drawing.Point(67, 184);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(64, 25);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "Şifre:";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(137, 147);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(135, 22);
            this.MskTC.TabIndex = 1;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // lnkHastaKayit
            // 
            this.lnkHastaKayit.AutoSize = true;
            this.lnkHastaKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkHastaKayit.LinkColor = System.Drawing.Color.Snow;
            this.lnkHastaKayit.Location = new System.Drawing.Point(179, 282);
            this.lnkHastaKayit.Name = "lnkHastaKayit";
            this.lnkHastaKayit.Size = new System.Drawing.Size(51, 20);
            this.lnkHastaKayit.TabIndex = 4;
            this.lnkHastaKayit.TabStop = true;
            this.lnkHastaKayit.Text = "Kayıt";
            this.lnkHastaKayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHastaKayit_LinkClicked);
            // 
            // hastaGirisPBtn
            // 
            this.hastaGirisPBtn.ActiveBorderThickness = 1;
            this.hastaGirisPBtn.ActiveCornerRadius = 20;
            this.hastaGirisPBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.hastaGirisPBtn.ActiveForecolor = System.Drawing.Color.White;
            this.hastaGirisPBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.hastaGirisPBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.hastaGirisPBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hastaGirisPBtn.BackgroundImage")));
            this.hastaGirisPBtn.ButtonText = "Giriş Yap";
            this.hastaGirisPBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hastaGirisPBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastaGirisPBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.hastaGirisPBtn.IdleBorderThickness = 1;
            this.hastaGirisPBtn.IdleCornerRadius = 20;
            this.hastaGirisPBtn.IdleFillColor = System.Drawing.Color.White;
            this.hastaGirisPBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.hastaGirisPBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.hastaGirisPBtn.Location = new System.Drawing.Point(137, 227);
            this.hastaGirisPBtn.Margin = new System.Windows.Forms.Padding(5);
            this.hastaGirisPBtn.Name = "hastaGirisPBtn";
            this.hastaGirisPBtn.Size = new System.Drawing.Size(135, 50);
            this.hastaGirisPBtn.TabIndex = 5;
            this.hastaGirisPBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hastaGirisPBtn.Click += new System.EventHandler(this.hastaGirisPBtn_Click);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(137, 186);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(135, 22);
            this.TxtSifre.TabIndex = 8;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // hastaCikis
            // 
            this.hastaCikis.Image = ((System.Drawing.Image)(resources.GetObject("hastaCikis.Image")));
            this.hastaCikis.Location = new System.Drawing.Point(353, 12);
            this.hastaCikis.Name = "hastaCikis";
            this.hastaCikis.Size = new System.Drawing.Size(35, 35);
            this.hastaCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hastaCikis.TabIndex = 10;
            this.hastaCikis.TabStop = false;
            this.hastaCikis.Click += new System.EventHandler(this.hastaCikis_Click);
            this.hastaCikis.MouseLeave += new System.EventHandler(this.hastaCikis_MouseLeave);
            this.hastaCikis.MouseHover += new System.EventHandler(this.hastaCikis_MouseHover);
            // 
            // hastaEnglish
            // 
            this.hastaEnglish.Image = ((System.Drawing.Image)(resources.GetObject("hastaEnglish.Image")));
            this.hastaEnglish.Location = new System.Drawing.Point(353, 353);
            this.hastaEnglish.Name = "hastaEnglish";
            this.hastaEnglish.Size = new System.Drawing.Size(35, 35);
            this.hastaEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hastaEnglish.TabIndex = 11;
            this.hastaEnglish.TabStop = false;
            this.hastaEnglish.Click += new System.EventHandler(this.hastaEnglish_Click);
            // 
            // hastaTurkce
            // 
            this.hastaTurkce.Image = ((System.Drawing.Image)(resources.GetObject("hastaTurkce.Image")));
            this.hastaTurkce.Location = new System.Drawing.Point(12, 353);
            this.hastaTurkce.Name = "hastaTurkce";
            this.hastaTurkce.Size = new System.Drawing.Size(35, 35);
            this.hastaTurkce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hastaTurkce.TabIndex = 12;
            this.hastaTurkce.TabStop = false;
            this.hastaTurkce.Click += new System.EventHandler(this.hastaTurkce_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(278, 186);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // FrmHastaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.hastaTurkce);
            this.Controls.Add(this.hastaEnglish);
            this.Controls.Add(this.hastaCikis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.hastaGirisPBtn);
            this.Controls.Add(this.lnkHastaKayit);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblHastaGirisPaneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHastaGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Giriş";
            this.Load += new System.EventHandler(this.FrmHastaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaTurkce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHastaGirisPaneli;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.LinkLabel lnkHastaKayit;
        private Bunifu.Framework.UI.BunifuThinButton2 hastaGirisPBtn;
        private System.Windows.Forms.TextBox TxtSifre;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox hastaCikis;
        private System.Windows.Forms.PictureBox hastaTurkce;
        private System.Windows.Forms.PictureBox hastaEnglish;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}