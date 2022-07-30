namespace Proje_Hastane
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.lblSekreterGirisPaneli = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sekreterGirisPBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sekreterCikis = new System.Windows.Forms.PictureBox();
            this.sekreterTurkce = new System.Windows.Forms.PictureBox();
            this.sekreterEnglish = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterCikis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterTurkce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.White;
            this.lblSifre.Location = new System.Drawing.Point(80, 176);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(64, 25);
            this.lblSifre.TabIndex = 1;
            this.lblSifre.Text = "Şifre:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.ForeColor = System.Drawing.Color.White;
            this.lblTC.Location = new System.Drawing.Point(62, 136);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(82, 25);
            this.lblTC.TabIndex = 2;
            this.lblTC.Text = "TC No:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(150, 178);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(135, 22);
            this.TxtSifre.TabIndex = 10;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(150, 140);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(135, 22);
            this.MskTC.TabIndex = 9;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // lblSekreterGirisPaneli
            // 
            this.lblSekreterGirisPaneli.AutoSize = true;
            this.lblSekreterGirisPaneli.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSekreterGirisPaneli.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSekreterGirisPaneli.Location = new System.Drawing.Point(98, 58);
            this.lblSekreterGirisPaneli.Name = "lblSekreterGirisPaneli";
            this.lblSekreterGirisPaneli.Size = new System.Drawing.Size(239, 46);
            this.lblSekreterGirisPaneli.TabIndex = 11;
            this.lblSekreterGirisPaneli.Text = "Sekreter Giriş";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 40;
            this.bunifuElipse1.TargetControl = this;
            // 
            // sekreterGirisPBtn
            // 
            this.sekreterGirisPBtn.ActiveBorderThickness = 1;
            this.sekreterGirisPBtn.ActiveCornerRadius = 20;
            this.sekreterGirisPBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.sekreterGirisPBtn.ActiveForecolor = System.Drawing.Color.White;
            this.sekreterGirisPBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.sekreterGirisPBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.sekreterGirisPBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sekreterGirisPBtn.BackgroundImage")));
            this.sekreterGirisPBtn.ButtonText = "Giriş Yap";
            this.sekreterGirisPBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sekreterGirisPBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sekreterGirisPBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.sekreterGirisPBtn.IdleBorderThickness = 1;
            this.sekreterGirisPBtn.IdleCornerRadius = 20;
            this.sekreterGirisPBtn.IdleFillColor = System.Drawing.Color.White;
            this.sekreterGirisPBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.sekreterGirisPBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.sekreterGirisPBtn.Location = new System.Drawing.Point(150, 220);
            this.sekreterGirisPBtn.Margin = new System.Windows.Forms.Padding(5);
            this.sekreterGirisPBtn.Name = "sekreterGirisPBtn";
            this.sekreterGirisPBtn.Size = new System.Drawing.Size(135, 50);
            this.sekreterGirisPBtn.TabIndex = 12;
            this.sekreterGirisPBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sekreterGirisPBtn.Click += new System.EventHandler(this.sekreterGirisPBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // sekreterCikis
            // 
            this.sekreterCikis.Image = ((System.Drawing.Image)(resources.GetObject("sekreterCikis.Image")));
            this.sekreterCikis.Location = new System.Drawing.Point(353, 12);
            this.sekreterCikis.Name = "sekreterCikis";
            this.sekreterCikis.Size = new System.Drawing.Size(35, 35);
            this.sekreterCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sekreterCikis.TabIndex = 14;
            this.sekreterCikis.TabStop = false;
            this.sekreterCikis.Click += new System.EventHandler(this.sekreterCikis_Click);
            this.sekreterCikis.MouseLeave += new System.EventHandler(this.sekreterCikis_MouseLeave);
            this.sekreterCikis.MouseHover += new System.EventHandler(this.sekreterCikis_MouseHover);
            // 
            // sekreterTurkce
            // 
            this.sekreterTurkce.Image = ((System.Drawing.Image)(resources.GetObject("sekreterTurkce.Image")));
            this.sekreterTurkce.Location = new System.Drawing.Point(12, 353);
            this.sekreterTurkce.Name = "sekreterTurkce";
            this.sekreterTurkce.Size = new System.Drawing.Size(35, 35);
            this.sekreterTurkce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sekreterTurkce.TabIndex = 15;
            this.sekreterTurkce.TabStop = false;
            this.sekreterTurkce.Click += new System.EventHandler(this.sekreterTurkce_Click);
            // 
            // sekreterEnglish
            // 
            this.sekreterEnglish.Image = ((System.Drawing.Image)(resources.GetObject("sekreterEnglish.Image")));
            this.sekreterEnglish.Location = new System.Drawing.Point(353, 353);
            this.sekreterEnglish.Name = "sekreterEnglish";
            this.sekreterEnglish.Size = new System.Drawing.Size(35, 35);
            this.sekreterEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sekreterEnglish.TabIndex = 16;
            this.sekreterEnglish.TabStop = false;
            this.sekreterEnglish.Click += new System.EventHandler(this.sekreterEnglish_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(291, 179);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(22, 22);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // FrmSekreterGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.sekreterEnglish);
            this.Controls.Add(this.sekreterTurkce);
            this.Controls.Add(this.sekreterCikis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sekreterGirisPBtn);
            this.Controls.Add(this.lblSekreterGirisPaneli);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmSekreterGiris";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSekreterGiris";
            this.Load += new System.EventHandler(this.FrmSekreterGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterCikis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterTurkce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label lblSekreterGirisPaneli;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 sekreterGirisPBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox sekreterCikis;
        private System.Windows.Forms.PictureBox sekreterEnglish;
        private System.Windows.Forms.PictureBox sekreterTurkce;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}