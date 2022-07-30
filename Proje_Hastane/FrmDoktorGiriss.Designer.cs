namespace Proje_Hastane
{
    partial class FrmDoktorGiriss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiriss));
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.doktorGirisPBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.lblDoktorGirisPaneli = new System.Windows.Forms.Label();
            this.doktorGeri = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.doktorCikis = new System.Windows.Forms.PictureBox();
            this.doktorTurkce = new System.Windows.Forms.PictureBox();
            this.doktorEnglish = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.doktorGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorTurkce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(137, 186);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(135, 22);
            this.TxtSifre.TabIndex = 15;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // doktorGirisPBtn
            // 
            this.doktorGirisPBtn.ActiveBorderThickness = 1;
            this.doktorGirisPBtn.ActiveCornerRadius = 20;
            this.doktorGirisPBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.doktorGirisPBtn.ActiveForecolor = System.Drawing.Color.White;
            this.doktorGirisPBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.doktorGirisPBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.doktorGirisPBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("doktorGirisPBtn.BackgroundImage")));
            this.doktorGirisPBtn.ButtonText = "Giriş Yap";
            this.doktorGirisPBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doktorGirisPBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doktorGirisPBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.doktorGirisPBtn.IdleBorderThickness = 1;
            this.doktorGirisPBtn.IdleCornerRadius = 20;
            this.doktorGirisPBtn.IdleFillColor = System.Drawing.Color.White;
            this.doktorGirisPBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.doktorGirisPBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.doktorGirisPBtn.Location = new System.Drawing.Point(137, 227);
            this.doktorGirisPBtn.Margin = new System.Windows.Forms.Padding(5);
            this.doktorGirisPBtn.Name = "doktorGirisPBtn";
            this.doktorGirisPBtn.Size = new System.Drawing.Size(135, 50);
            this.doktorGirisPBtn.TabIndex = 14;
            this.doktorGirisPBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.doktorGirisPBtn.Click += new System.EventHandler(this.doktorGirisPBtn_Click);
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(137, 147);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(135, 22);
            this.MskTC.TabIndex = 12;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.White;
            this.lblSifre.Location = new System.Drawing.Point(67, 184);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(64, 25);
            this.lblSifre.TabIndex = 9;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.Color.White;
            this.lblTC.Location = new System.Drawing.Point(49, 144);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(82, 25);
            this.lblTC.TabIndex = 10;
            this.lblTC.Text = "TC No:";
            // 
            // lblDoktorGirisPaneli
            // 
            this.lblDoktorGirisPaneli.AutoSize = true;
            this.lblDoktorGirisPaneli.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorGirisPaneli.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDoktorGirisPaneli.Location = new System.Drawing.Point(102, 67);
            this.lblDoktorGirisPaneli.Name = "lblDoktorGirisPaneli";
            this.lblDoktorGirisPaneli.Size = new System.Drawing.Size(215, 46);
            this.lblDoktorGirisPaneli.TabIndex = 11;
            this.lblDoktorGirisPaneli.Text = "Doktor Giriş";
            // 
            // doktorGeri
            // 
            this.doktorGeri.Image = ((System.Drawing.Image)(resources.GetObject("doktorGeri.Image")));
            this.doktorGeri.Location = new System.Drawing.Point(12, 12);
            this.doktorGeri.Name = "doktorGeri";
            this.doktorGeri.Size = new System.Drawing.Size(35, 35);
            this.doktorGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doktorGeri.TabIndex = 16;
            this.doktorGeri.TabStop = false;
            this.doktorGeri.Click += new System.EventHandler(this.doktorGeri_Click);
            this.doktorGeri.MouseLeave += new System.EventHandler(this.doktorGeri_MouseLeave);
            this.doktorGeri.MouseHover += new System.EventHandler(this.doktorGeri_MouseHover);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // doktorCikis
            // 
            this.doktorCikis.Image = ((System.Drawing.Image)(resources.GetObject("doktorCikis.Image")));
            this.doktorCikis.Location = new System.Drawing.Point(353, 12);
            this.doktorCikis.Name = "doktorCikis";
            this.doktorCikis.Size = new System.Drawing.Size(35, 35);
            this.doktorCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doktorCikis.TabIndex = 17;
            this.doktorCikis.TabStop = false;
            this.doktorCikis.Click += new System.EventHandler(this.doktorCikis_Click);
            this.doktorCikis.MouseLeave += new System.EventHandler(this.doktorCikis_MouseLeave);
            this.doktorCikis.MouseHover += new System.EventHandler(this.doktorCikis_MouseHover);
            // 
            // doktorTurkce
            // 
            this.doktorTurkce.Image = ((System.Drawing.Image)(resources.GetObject("doktorTurkce.Image")));
            this.doktorTurkce.Location = new System.Drawing.Point(12, 353);
            this.doktorTurkce.Name = "doktorTurkce";
            this.doktorTurkce.Size = new System.Drawing.Size(35, 35);
            this.doktorTurkce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doktorTurkce.TabIndex = 18;
            this.doktorTurkce.TabStop = false;
            this.doktorTurkce.Click += new System.EventHandler(this.doktorTurkce_Click);
            // 
            // doktorEnglish
            // 
            this.doktorEnglish.Image = ((System.Drawing.Image)(resources.GetObject("doktorEnglish.Image")));
            this.doktorEnglish.Location = new System.Drawing.Point(353, 353);
            this.doktorEnglish.Name = "doktorEnglish";
            this.doktorEnglish.Size = new System.Drawing.Size(35, 35);
            this.doktorEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.doktorEnglish.TabIndex = 19;
            this.doktorEnglish.TabStop = false;
            this.doktorEnglish.Click += new System.EventHandler(this.doktorEnglish_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(278, 187);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // FrmDoktorGiriss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.doktorEnglish);
            this.Controls.Add(this.doktorTurkce);
            this.Controls.Add(this.doktorCikis);
            this.Controls.Add(this.doktorGeri);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.doktorGirisPBtn);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.lblDoktorGirisPaneli);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoktorGiriss";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDoktorGiriss";
            ((System.ComponentModel.ISupportInitialize)(this.doktorGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorTurkce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doktorEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSifre;
        private Bunifu.Framework.UI.BunifuThinButton2 doktorGirisPBtn;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblDoktorGirisPaneli;
        private System.Windows.Forms.PictureBox doktorGeri;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox doktorCikis;
        private System.Windows.Forms.PictureBox doktorTurkce;
        private System.Windows.Forms.PictureBox doktorEnglish;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}