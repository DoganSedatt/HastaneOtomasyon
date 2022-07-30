namespace Proje_Hastane
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.lblGiris = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.hastaGirisBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.doktorGirisBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.sekreterGirisBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.girisEnglish = new System.Windows.Forms.PictureBox();
            this.girisTurkce = new System.Windows.Forms.PictureBox();
            this.girisTemaAydinlik = new System.Windows.Forms.PictureBox();
            this.girisTemaKaranlik = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bnfGorsel = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisTurkce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisTemaAydinlik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisTemaKaranlik)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.Font = new System.Drawing.Font("Candara", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.Color.White;
            this.lblGiris.Location = new System.Drawing.Point(271, 81);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(577, 40);
            this.lblGiris.TabIndex = 7;
            this.lblGiris.Text = "Necmettin Erbakan Üniversite Hastanesi";
            this.lblGiris.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(400, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // hastaGirisBtn
            // 
            this.hastaGirisBtn.ActiveBorderThickness = 1;
            this.hastaGirisBtn.ActiveCornerRadius = 20;
            this.hastaGirisBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.hastaGirisBtn.ActiveForecolor = System.Drawing.Color.White;
            this.hastaGirisBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.hastaGirisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.hastaGirisBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hastaGirisBtn.BackgroundImage")));
            this.hastaGirisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hastaGirisBtn.ButtonText = "Hasta Giriş";
            this.hastaGirisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hastaGirisBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hastaGirisBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.hastaGirisBtn.IdleBorderThickness = 2;
            this.hastaGirisBtn.IdleCornerRadius = 20;
            this.hastaGirisBtn.IdleFillColor = System.Drawing.Color.White;
            this.hastaGirisBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.hastaGirisBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.hastaGirisBtn.Location = new System.Drawing.Point(400, 357);
            this.hastaGirisBtn.Margin = new System.Windows.Forms.Padding(5);
            this.hastaGirisBtn.Name = "hastaGirisBtn";
            this.hastaGirisBtn.Size = new System.Drawing.Size(225, 56);
            this.hastaGirisBtn.TabIndex = 14;
            this.hastaGirisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.hastaGirisBtn.Click += new System.EventHandler(this.hastaGirisBtn_Click_1);
            // 
            // doktorGirisBtn
            // 
            this.doktorGirisBtn.ActiveBorderThickness = 1;
            this.doktorGirisBtn.ActiveCornerRadius = 20;
            this.doktorGirisBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.doktorGirisBtn.ActiveForecolor = System.Drawing.Color.White;
            this.doktorGirisBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.doktorGirisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.doktorGirisBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doktorGirisBtn.BackgroundImage")));
            this.doktorGirisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.doktorGirisBtn.ButtonText = "Doktor Giriş";
            this.doktorGirisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doktorGirisBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doktorGirisBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.doktorGirisBtn.IdleBorderThickness = 2;
            this.doktorGirisBtn.IdleCornerRadius = 20;
            this.doktorGirisBtn.IdleFillColor = System.Drawing.Color.White;
            this.doktorGirisBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.doktorGirisBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.doktorGirisBtn.Location = new System.Drawing.Point(400, 413);
            this.doktorGirisBtn.Margin = new System.Windows.Forms.Padding(5);
            this.doktorGirisBtn.Name = "doktorGirisBtn";
            this.doktorGirisBtn.Size = new System.Drawing.Size(225, 56);
            this.doktorGirisBtn.TabIndex = 14;
            this.doktorGirisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.doktorGirisBtn.Click += new System.EventHandler(this.doktorGirisBtn_Click);
            // 
            // sekreterGirisBtn
            // 
            this.sekreterGirisBtn.ActiveBorderThickness = 1;
            this.sekreterGirisBtn.ActiveCornerRadius = 20;
            this.sekreterGirisBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.sekreterGirisBtn.ActiveForecolor = System.Drawing.Color.White;
            this.sekreterGirisBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.sekreterGirisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.sekreterGirisBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sekreterGirisBtn.BackgroundImage")));
            this.sekreterGirisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sekreterGirisBtn.ButtonText = "Sekreter Giriş";
            this.sekreterGirisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sekreterGirisBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekreterGirisBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.sekreterGirisBtn.IdleBorderThickness = 2;
            this.sekreterGirisBtn.IdleCornerRadius = 20;
            this.sekreterGirisBtn.IdleFillColor = System.Drawing.Color.White;
            this.sekreterGirisBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.sekreterGirisBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.sekreterGirisBtn.Location = new System.Drawing.Point(400, 469);
            this.sekreterGirisBtn.Margin = new System.Windows.Forms.Padding(5);
            this.sekreterGirisBtn.Name = "sekreterGirisBtn";
            this.sekreterGirisBtn.Size = new System.Drawing.Size(225, 56);
            this.sekreterGirisBtn.TabIndex = 14;
            this.sekreterGirisBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sekreterGirisBtn.Click += new System.EventHandler(this.sekreterGirisBtn_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1005, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // girisEnglish
            // 
            this.girisEnglish.Image = ((System.Drawing.Image)(resources.GetObject("girisEnglish.Image")));
            this.girisEnglish.Location = new System.Drawing.Point(997, 535);
            this.girisEnglish.Name = "girisEnglish";
            this.girisEnglish.Size = new System.Drawing.Size(48, 48);
            this.girisEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.girisEnglish.TabIndex = 16;
            this.girisEnglish.TabStop = false;
            this.girisEnglish.Click += new System.EventHandler(this.girisEnglish_Click);
            // 
            // girisTurkce
            // 
            this.girisTurkce.Image = ((System.Drawing.Image)(resources.GetObject("girisTurkce.Image")));
            this.girisTurkce.Location = new System.Drawing.Point(943, 535);
            this.girisTurkce.Name = "girisTurkce";
            this.girisTurkce.Size = new System.Drawing.Size(48, 48);
            this.girisTurkce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.girisTurkce.TabIndex = 17;
            this.girisTurkce.TabStop = false;
            this.girisTurkce.Click += new System.EventHandler(this.girisTurkce_Click);
            // 
            // girisTemaAydinlik
            // 
            this.girisTemaAydinlik.Image = ((System.Drawing.Image)(resources.GetObject("girisTemaAydinlik.Image")));
            this.girisTemaAydinlik.Location = new System.Drawing.Point(12, 543);
            this.girisTemaAydinlik.Name = "girisTemaAydinlik";
            this.girisTemaAydinlik.Size = new System.Drawing.Size(40, 40);
            this.girisTemaAydinlik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.girisTemaAydinlik.TabIndex = 18;
            this.girisTemaAydinlik.TabStop = false;
            this.girisTemaAydinlik.Click += new System.EventHandler(this.girisTemaAydinlik_Click);
            // 
            // girisTemaKaranlik
            // 
            this.girisTemaKaranlik.Image = ((System.Drawing.Image)(resources.GetObject("girisTemaKaranlik.Image")));
            this.girisTemaKaranlik.Location = new System.Drawing.Point(58, 543);
            this.girisTemaKaranlik.Name = "girisTemaKaranlik";
            this.girisTemaKaranlik.Size = new System.Drawing.Size(40, 40);
            this.girisTemaKaranlik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.girisTemaKaranlik.TabIndex = 19;
            this.girisTemaKaranlik.TabStop = false;
            this.girisTemaKaranlik.Click += new System.EventHandler(this.girisTemaKaranlik_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(0, 24);
            this.bunifuCustomLabel1.TabIndex = 20;
            this.bunifuCustomLabel1.Visible = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(12, 52);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(0, 24);
            this.bunifuCustomLabel2.TabIndex = 21;
            this.bunifuCustomLabel2.Visible = false;
            // 
            // bnfGorsel
            // 
            this.bnfGorsel.ActiveBorderThickness = 1;
            this.bnfGorsel.ActiveCornerRadius = 20;
            this.bnfGorsel.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bnfGorsel.ActiveForecolor = System.Drawing.Color.White;
            this.bnfGorsel.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bnfGorsel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bnfGorsel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfGorsel.BackgroundImage")));
            this.bnfGorsel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bnfGorsel.ButtonText = "Görseller";
            this.bnfGorsel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfGorsel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfGorsel.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfGorsel.IdleBorderThickness = 2;
            this.bnfGorsel.IdleCornerRadius = 20;
            this.bnfGorsel.IdleFillColor = System.Drawing.Color.White;
            this.bnfGorsel.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnfGorsel.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnfGorsel.Location = new System.Drawing.Point(400, 525);
            this.bnfGorsel.Margin = new System.Windows.Forms.Padding(5);
            this.bnfGorsel.Name = "bnfGorsel";
            this.bnfGorsel.Size = new System.Drawing.Size(225, 56);
            this.bnfGorsel.TabIndex = 22;
            this.bnfGorsel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfGorsel.Click += new System.EventHandler(this.bnfGorsel_Click);
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1057, 595);
            this.Controls.Add(this.bnfGorsel);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.girisTemaKaranlik);
            this.Controls.Add(this.girisTemaAydinlik);
            this.Controls.Add(this.girisTurkce);
            this.Controls.Add(this.girisEnglish);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.sekreterGirisBtn);
            this.Controls.Add(this.doktorGirisBtn);
            this.Controls.Add(this.hastaGirisBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGiris);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hastane Sistem Giriş";
            this.Load += new System.EventHandler(this.FrmGirisler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisTurkce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisTemaAydinlik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.girisTemaKaranlik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 sekreterGirisBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 doktorGirisBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 hastaGirisBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox girisTurkce;
        private System.Windows.Forms.PictureBox girisEnglish;
        private System.Windows.Forms.PictureBox girisTemaAydinlik;
        private System.Windows.Forms.PictureBox girisTemaKaranlik;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfGorsel;
    }
}

