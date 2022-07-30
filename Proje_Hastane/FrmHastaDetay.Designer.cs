namespace Proje_Hastane
{
    partial class FrmHastaDetay
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.grpKisiBilgi = new System.Windows.Forms.GroupBox();
            this.LblAdSoy = new System.Windows.Forms.Label();
            this.LblKimlik = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.grpRandevuAl = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.rtxtSikayet = new System.Windows.Forms.RichTextBox();
            this.cmbxDoktor = new System.Windows.Forms.ComboBox();
            this.cmbxBrans = new System.Windows.Forms.ComboBox();
            this.lblSikayet = new System.Windows.Forms.Label();
            this.lblDoktor = new System.Windows.Forms.Label();
            this.lblBrans = new System.Windows.Forms.Label();
            this.grpGecmisRandevular = new System.Windows.Forms.GroupBox();
            this.dtGecmisRandevular = new System.Windows.Forms.DataGridView();
            this.grpAktifRandevular = new System.Windows.Forms.GroupBox();
            this.dtAktifRandevular = new System.Windows.Forms.DataGridView();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.bnfbtnRandevuAl = new Bunifu.Framework.UI.BunifuThinButton2();
            this.randevuAl = new System.Windows.Forms.CheckBox();
            this.bnfbtnGuncelle = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSekreterDetay = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.grpKisiBilgi.SuspendLayout();
            this.grpRandevuAl.SuspendLayout();
            this.grpGecmisRandevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGecmisRandevular)).BeginInit();
            this.grpAktifRandevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtAktifRandevular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // grpKisiBilgi
            // 
            this.grpKisiBilgi.Controls.Add(this.LblAdSoy);
            this.grpKisiBilgi.Controls.Add(this.LblKimlik);
            this.grpKisiBilgi.Controls.Add(this.lblAdSoyad);
            this.grpKisiBilgi.Controls.Add(this.lblTC);
            this.grpKisiBilgi.ForeColor = System.Drawing.Color.White;
            this.grpKisiBilgi.Location = new System.Drawing.Point(23, 89);
            this.grpKisiBilgi.Name = "grpKisiBilgi";
            this.grpKisiBilgi.Size = new System.Drawing.Size(308, 167);
            this.grpKisiBilgi.TabIndex = 0;
            this.grpKisiBilgi.TabStop = false;
            this.grpKisiBilgi.Text = "Kişi Bilgi";
            // 
            // LblAdSoy
            // 
            this.LblAdSoy.AutoSize = true;
            this.LblAdSoy.Location = new System.Drawing.Point(162, 98);
            this.LblAdSoy.Name = "LblAdSoy";
            this.LblAdSoy.Size = new System.Drawing.Size(100, 29);
            this.LblAdSoy.TabIndex = 2;
            this.LblAdSoy.Text = "Null Null";
            // 
            // LblKimlik
            // 
            this.LblKimlik.AutoSize = true;
            this.LblKimlik.Location = new System.Drawing.Point(162, 46);
            this.LblKimlik.Name = "LblKimlik";
            this.LblKimlik.Size = new System.Drawing.Size(100, 29);
            this.LblKimlik.TabIndex = 1;
            this.LblKimlik.Text = "Null Null";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.ForeColor = System.Drawing.Color.White;
            this.lblAdSoyad.Location = new System.Drawing.Point(42, 98);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(114, 29);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.ForeColor = System.Drawing.Color.White;
            this.lblTC.Location = new System.Drawing.Point(6, 46);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(150, 29);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "TC Kimlik No:";
            // 
            // grpRandevuAl
            // 
            this.grpRandevuAl.Controls.Add(this.bnfbtnGuncelle);
            this.grpRandevuAl.Controls.Add(this.lblSaat);
            this.grpRandevuAl.Controls.Add(this.bnfbtnRandevuAl);
            this.grpRandevuAl.Controls.Add(this.lblTarih);
            this.grpRandevuAl.Controls.Add(this.mskSaat);
            this.grpRandevuAl.Controls.Add(this.mskTarih);
            this.grpRandevuAl.Controls.Add(this.txtId);
            this.grpRandevuAl.Controls.Add(this.lblId);
            this.grpRandevuAl.Controls.Add(this.rtxtSikayet);
            this.grpRandevuAl.Controls.Add(this.cmbxDoktor);
            this.grpRandevuAl.Controls.Add(this.cmbxBrans);
            this.grpRandevuAl.Controls.Add(this.lblSikayet);
            this.grpRandevuAl.Controls.Add(this.lblDoktor);
            this.grpRandevuAl.Controls.Add(this.lblBrans);
            this.grpRandevuAl.ForeColor = System.Drawing.Color.White;
            this.grpRandevuAl.Location = new System.Drawing.Point(23, 284);
            this.grpRandevuAl.Name = "grpRandevuAl";
            this.grpRandevuAl.Size = new System.Drawing.Size(308, 440);
            this.grpRandevuAl.TabIndex = 1;
            this.grpRandevuAl.TabStop = false;
            this.grpRandevuAl.Text = "Randevu Al";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(126, 26);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(162, 36);
            this.txtId.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(89, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(38, 29);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "İd:";
            // 
            // rtxtSikayet
            // 
            this.rtxtSikayet.Location = new System.Drawing.Point(126, 234);
            this.rtxtSikayet.Name = "rtxtSikayet";
            this.rtxtSikayet.Size = new System.Drawing.Size(162, 112);
            this.rtxtSikayet.TabIndex = 6;
            this.rtxtSikayet.Text = "";
            // 
            // cmbxDoktor
            // 
            this.cmbxDoktor.FormattingEnabled = true;
            this.cmbxDoktor.Location = new System.Drawing.Point(126, 191);
            this.cmbxDoktor.Name = "cmbxDoktor";
            this.cmbxDoktor.Size = new System.Drawing.Size(162, 36);
            this.cmbxDoktor.TabIndex = 5;
            this.cmbxDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbxDoktor_SelectedIndexChanged);
            // 
            // cmbxBrans
            // 
            this.cmbxBrans.FormattingEnabled = true;
            this.cmbxBrans.Location = new System.Drawing.Point(126, 150);
            this.cmbxBrans.Name = "cmbxBrans";
            this.cmbxBrans.Size = new System.Drawing.Size(162, 36);
            this.cmbxBrans.TabIndex = 4;
            this.cmbxBrans.SelectedIndexChanged += new System.EventHandler(this.cmbxBrans_SelectedIndexChanged);
            // 
            // lblSikayet
            // 
            this.lblSikayet.AutoSize = true;
            this.lblSikayet.ForeColor = System.Drawing.Color.White;
            this.lblSikayet.Location = new System.Drawing.Point(33, 236);
            this.lblSikayet.Name = "lblSikayet";
            this.lblSikayet.Size = new System.Drawing.Size(94, 29);
            this.lblSikayet.TabIndex = 3;
            this.lblSikayet.Text = "Şikayet:";
            // 
            // lblDoktor
            // 
            this.lblDoktor.AutoSize = true;
            this.lblDoktor.ForeColor = System.Drawing.Color.White;
            this.lblDoktor.Location = new System.Drawing.Point(38, 195);
            this.lblDoktor.Name = "lblDoktor";
            this.lblDoktor.Size = new System.Drawing.Size(89, 29);
            this.lblDoktor.TabIndex = 3;
            this.lblDoktor.Text = "Doktor:";
            // 
            // lblBrans
            // 
            this.lblBrans.AutoSize = true;
            this.lblBrans.ForeColor = System.Drawing.Color.White;
            this.lblBrans.Location = new System.Drawing.Point(51, 154);
            this.lblBrans.Name = "lblBrans";
            this.lblBrans.Size = new System.Drawing.Size(76, 29);
            this.lblBrans.TabIndex = 3;
            this.lblBrans.Text = "Branş:";
            // 
            // grpGecmisRandevular
            // 
            this.grpGecmisRandevular.Controls.Add(this.dtGecmisRandevular);
            this.grpGecmisRandevular.ForeColor = System.Drawing.Color.White;
            this.grpGecmisRandevular.Location = new System.Drawing.Point(398, 92);
            this.grpGecmisRandevular.Name = "grpGecmisRandevular";
            this.grpGecmisRandevular.Size = new System.Drawing.Size(973, 271);
            this.grpGecmisRandevular.TabIndex = 2;
            this.grpGecmisRandevular.TabStop = false;
            this.grpGecmisRandevular.Text = "Geçmiş Randevular";
            // 
            // dtGecmisRandevular
            // 
            this.dtGecmisRandevular.BackgroundColor = System.Drawing.Color.White;
            this.dtGecmisRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtGecmisRandevular.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtGecmisRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtGecmisRandevular.Location = new System.Drawing.Point(3, 32);
            this.dtGecmisRandevular.Name = "dtGecmisRandevular";
            this.dtGecmisRandevular.RowHeadersWidth = 51;
            this.dtGecmisRandevular.RowTemplate.Height = 24;
            this.dtGecmisRandevular.Size = new System.Drawing.Size(967, 236);
            this.dtGecmisRandevular.TabIndex = 0;
            // 
            // grpAktifRandevular
            // 
            this.grpAktifRandevular.Controls.Add(this.dtAktifRandevular);
            this.grpAktifRandevular.ForeColor = System.Drawing.Color.White;
            this.grpAktifRandevular.Location = new System.Drawing.Point(398, 418);
            this.grpAktifRandevular.Name = "grpAktifRandevular";
            this.grpAktifRandevular.Size = new System.Drawing.Size(970, 306);
            this.grpAktifRandevular.TabIndex = 3;
            this.grpAktifRandevular.TabStop = false;
            this.grpAktifRandevular.Text = "Aktif Randevular";
            
            // dtAktifRandevular
            // 
            this.dtAktifRandevular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtAktifRandevular.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtAktifRandevular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtAktifRandevular.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtAktifRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtAktifRandevular.Location = new System.Drawing.Point(3, 32);
            this.dtAktifRandevular.Name = "dtAktifRandevular";
            this.dtAktifRandevular.RowHeadersWidth = 51;
            this.dtAktifRandevular.RowTemplate.Height = 24;
            this.dtAktifRandevular.Size = new System.Drawing.Size(964, 271);
            this.dtAktifRandevular.TabIndex = 49;
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(126, 109);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(162, 36);
            this.mskSaat.TabIndex = 10;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(126, 68);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(162, 36);
            this.mskTarih.TabIndex = 9;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.Location = new System.Drawing.Point(63, 115);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(64, 25);
            this.lblSaat.TabIndex = 11;
            this.lblSaat.Text = "Saat:";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.White;
            this.lblTarih.Location = new System.Drawing.Point(58, 76);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(69, 25);
            this.lblTarih.TabIndex = 12;
            this.lblTarih.Text = "Tarih:";
            // 
            // bnfbtnRandevuAl
            // 
            this.bnfbtnRandevuAl.ActiveBorderThickness = 1;
            this.bnfbtnRandevuAl.ActiveCornerRadius = 20;
            this.bnfbtnRandevuAl.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnRandevuAl.ActiveForecolor = System.Drawing.Color.White;
            this.bnfbtnRandevuAl.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnRandevuAl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.bnfbtnRandevuAl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfbtnRandevuAl.BackgroundImage")));
            this.bnfbtnRandevuAl.ButtonText = "Randevu Al";
            this.bnfbtnRandevuAl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfbtnRandevuAl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfbtnRandevuAl.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnRandevuAl.IdleBorderThickness = 1;
            this.bnfbtnRandevuAl.IdleCornerRadius = 20;
            this.bnfbtnRandevuAl.IdleFillColor = System.Drawing.Color.White;
            this.bnfbtnRandevuAl.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnfbtnRandevuAl.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnRandevuAl.Location = new System.Drawing.Point(126, 351);
            this.bnfbtnRandevuAl.Margin = new System.Windows.Forms.Padding(5);
            this.bnfbtnRandevuAl.Name = "bnfbtnRandevuAl";
            this.bnfbtnRandevuAl.Size = new System.Drawing.Size(162, 41);
            this.bnfbtnRandevuAl.TabIndex = 13;
            this.bnfbtnRandevuAl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfbtnRandevuAl.Click += new System.EventHandler(this.bnfbtnRandevuAl_Click);
            // 
            // randevuAl
            // 
            this.randevuAl.AutoSize = true;
            this.randevuAl.Checked = true;
            this.randevuAl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randevuAl.Location = new System.Drawing.Point(164, 724);
            this.randevuAl.Name = "randevuAl";
            this.randevuAl.Size = new System.Drawing.Size(147, 33);
            this.randevuAl.TabIndex = 15;
            this.randevuAl.Text = "Randevu Al";
            this.randevuAl.UseVisualStyleBackColor = true;
            this.randevuAl.Visible = false;
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
            this.bnfbtnGuncelle.ButtonText = "Bigi Güncelle";
            this.bnfbtnGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnfbtnGuncelle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnfbtnGuncelle.ForeColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnGuncelle.IdleBorderThickness = 1;
            this.bnfbtnGuncelle.IdleCornerRadius = 20;
            this.bnfbtnGuncelle.IdleFillColor = System.Drawing.Color.White;
            this.bnfbtnGuncelle.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bnfbtnGuncelle.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bnfbtnGuncelle.Location = new System.Drawing.Point(126, 391);
            this.bnfbtnGuncelle.Margin = new System.Windows.Forms.Padding(5);
            this.bnfbtnGuncelle.Name = "bnfbtnGuncelle";
            this.bnfbtnGuncelle.Size = new System.Drawing.Size(161, 41);
            this.bnfbtnGuncelle.TabIndex = 16;
            this.bnfbtnGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bnfbtnGuncelle.Click += new System.EventHandler(this.bnfbtnGuncelle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1336, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // lblSekreterDetay
            // 
            this.lblSekreterDetay.AllowDrop = true;
            this.lblSekreterDetay.AutoEllipsis = true;
            this.lblSekreterDetay.AutoSize = true;
            this.lblSekreterDetay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSekreterDetay.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSekreterDetay.ForeColor = System.Drawing.Color.White;
            this.lblSekreterDetay.Location = new System.Drawing.Point(616, 12);
            this.lblSekreterDetay.Name = "lblSekreterDetay";
            this.lblSekreterDetay.Size = new System.Drawing.Size(204, 26);
            this.lblSekreterDetay.TabIndex = 17;
            this.lblSekreterDetay.Text = "HASTA DETAY FORMU";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1383, 734);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSekreterDetay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.randevuAl);
            this.Controls.Add(this.grpAktifRandevular);
            this.Controls.Add(this.grpGecmisRandevular);
            this.Controls.Add(this.grpRandevuAl);
            this.Controls.Add(this.grpKisiBilgi);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Detay";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.grpKisiBilgi.ResumeLayout(false);
            this.grpKisiBilgi.PerformLayout();
            this.grpRandevuAl.ResumeLayout(false);
            this.grpRandevuAl.PerformLayout();
            this.grpGecmisRandevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGecmisRandevular)).EndInit();
            this.grpAktifRandevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtAktifRandevular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpKisiBilgi;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.GroupBox grpRandevuAl;
        private System.Windows.Forms.RichTextBox rtxtSikayet;
        private System.Windows.Forms.ComboBox cmbxDoktor;
        private System.Windows.Forms.ComboBox cmbxBrans;
        private System.Windows.Forms.Label lblSikayet;
        private System.Windows.Forms.Label lblDoktor;
        private System.Windows.Forms.Label lblBrans;
        private System.Windows.Forms.GroupBox grpGecmisRandevular;
        private System.Windows.Forms.DataGridView dtGecmisRandevular;
        private System.Windows.Forms.GroupBox grpAktifRandevular;
        private System.Windows.Forms.Label LblAdSoy;
        private System.Windows.Forms.Label LblKimlik;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dtAktifRandevular;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblTarih;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfbtnRandevuAl;
        private System.Windows.Forms.CheckBox randevuAl;
        private Bunifu.Framework.UI.BunifuThinButton2 bnfbtnGuncelle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSekreterDetay;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}