namespace Proje_Hastane
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.randevuAl = new System.Windows.Forms.CheckBox();
            this.btnKaydetBnf = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtİd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rchDuyuru = new System.Windows.Forms.RichTextBox();
            this.btnOlusturBnf = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.DtBrans = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.DtDoktorlar = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDuyurularBnf = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRandevuListeBnf = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBransPaneliBnf = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDoktorPaneliBnf = new Bunifu.Framework.UI.BunifuThinButton2();
            this.sekreterDetayGeri = new System.Windows.Forms.PictureBox();
            this.sekreterCikis = new System.Windows.Forms.PictureBox();
            this.lblSekreterDetay = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtBrans)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtDoktorlar)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterDetayGeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(30, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(123, 103);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(83, 25);
            this.lblAdSoyad.TabIndex = 2;
            this.lblAdSoyad.Text = "Null Null";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(120, 55);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(133, 25);
            this.lblTC.TabIndex = 1;
            this.lblTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.randevuAl);
            this.groupBox2.Controls.Add(this.btnKaydetBnf);
            this.groupBox2.Controls.Add(this.cmbBrans);
            this.groupBox2.Controls.Add(this.cmbDoktor);
            this.groupBox2.Controls.Add(this.mskSaat);
            this.groupBox2.Controls.Add(this.mskTC);
            this.groupBox2.Controls.Add(this.mskTarih);
            this.groupBox2.Controls.Add(this.txtİd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(400, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 565);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Paneli";
            // 
            // randevuAl
            // 
            this.randevuAl.AutoSize = true;
            this.randevuAl.Checked = true;
            this.randevuAl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.randevuAl.Location = new System.Drawing.Point(129, 335);
            this.randevuAl.Name = "randevuAl";
            this.randevuAl.Size = new System.Drawing.Size(135, 29);
            this.randevuAl.TabIndex = 14;
            this.randevuAl.Text = "Randevu Al";
            this.randevuAl.UseVisualStyleBackColor = true;
            this.randevuAl.Visible = false;
            // 
            // btnKaydetBnf
            // 
            this.btnKaydetBnf.ActiveBorderThickness = 1;
            this.btnKaydetBnf.ActiveCornerRadius = 20;
            this.btnKaydetBnf.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnKaydetBnf.ActiveForecolor = System.Drawing.Color.White;
            this.btnKaydetBnf.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaydetBnf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnKaydetBnf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydetBnf.BackgroundImage")));
            this.btnKaydetBnf.ButtonText = "Randevu Al";
            this.btnKaydetBnf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydetBnf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydetBnf.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnKaydetBnf.IdleBorderThickness = 1;
            this.btnKaydetBnf.IdleCornerRadius = 20;
            this.btnKaydetBnf.IdleFillColor = System.Drawing.Color.White;
            this.btnKaydetBnf.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnKaydetBnf.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnKaydetBnf.Location = new System.Drawing.Point(117, 372);
            this.btnKaydetBnf.Margin = new System.Windows.Forms.Padding(5);
            this.btnKaydetBnf.Name = "btnKaydetBnf";
            this.btnKaydetBnf.Size = new System.Drawing.Size(147, 52);
            this.btnKaydetBnf.TabIndex = 13;
            this.btnKaydetBnf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKaydetBnf.Click += new System.EventHandler(this.btnKaydetBnf_Click);
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(117, 191);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(147, 33);
            this.cmbBrans.TabIndex = 8;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(117, 236);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(147, 33);
            this.cmbDoktor.TabIndex = 9;
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(117, 149);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(147, 30);
            this.mskSaat.TabIndex = 7;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(117, 281);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(147, 30);
            this.mskTC.TabIndex = 10;
            this.mskTC.ValidatingType = typeof(System.DateTime);
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(117, 107);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(147, 30);
            this.mskTarih.TabIndex = 6;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtİd
            // 
            this.txtİd.Enabled = false;
            this.txtİd.Location = new System.Drawing.Point(117, 65);
            this.txtİd.Name = "txtİd";
            this.txtİd.Size = new System.Drawing.Size(147, 30);
            this.txtİd.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(39, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Doktor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Hasta Tc:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(46, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Branş:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(57, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Saat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(52, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tarih:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(84, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "İd:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rchDuyuru);
            this.groupBox3.Controls.Add(this.btnOlusturBnf);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Location = new System.Drawing.Point(30, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 340);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duyuru Oluştur";
            // 
            // rchDuyuru
            // 
            this.rchDuyuru.Location = new System.Drawing.Point(23, 31);
            this.rchDuyuru.Name = "rchDuyuru";
            this.rchDuyuru.Size = new System.Drawing.Size(305, 237);
            this.rchDuyuru.TabIndex = 3;
            this.rchDuyuru.Text = "";
            // 
            // btnOlusturBnf
            // 
            this.btnOlusturBnf.ActiveBorderThickness = 1;
            this.btnOlusturBnf.ActiveCornerRadius = 20;
            this.btnOlusturBnf.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnOlusturBnf.ActiveForecolor = System.Drawing.Color.White;
            this.btnOlusturBnf.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnOlusturBnf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnOlusturBnf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOlusturBnf.BackgroundImage")));
            this.btnOlusturBnf.ButtonText = "Oluştur";
            this.btnOlusturBnf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOlusturBnf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOlusturBnf.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOlusturBnf.IdleBorderThickness = 1;
            this.btnOlusturBnf.IdleCornerRadius = 20;
            this.btnOlusturBnf.IdleFillColor = System.Drawing.Color.White;
            this.btnOlusturBnf.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnOlusturBnf.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnOlusturBnf.Location = new System.Drawing.Point(22, 276);
            this.btnOlusturBnf.Margin = new System.Windows.Forms.Padding(5);
            this.btnOlusturBnf.Name = "btnOlusturBnf";
            this.btnOlusturBnf.Size = new System.Drawing.Size(305, 50);
            this.btnOlusturBnf.TabIndex = 13;
            this.btnOlusturBnf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOlusturBnf.Click += new System.EventHandler(this.btnOlusturBnf_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.DtBrans);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Location = new System.Drawing.Point(732, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(408, 326);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branş";
            // 
            // DtBrans
            // 
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DtBrans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DtBrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtBrans.BackgroundColor = System.Drawing.Color.White;
            this.DtBrans.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtBrans.DefaultCellStyle = dataGridViewCellStyle5;
            this.DtBrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtBrans.GridColor = System.Drawing.SystemColors.ScrollBar;
            this.DtBrans.Location = new System.Drawing.Point(3, 26);
            this.DtBrans.Name = "DtBrans";
            this.DtBrans.RowHeadersWidth = 51;
            this.DtBrans.RowTemplate.Height = 24;
            this.DtBrans.Size = new System.Drawing.Size(402, 297);
            this.DtBrans.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.DtDoktorlar);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox5.Location = new System.Drawing.Point(729, 405);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(411, 343);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // DtDoktorlar
            // 
            this.DtDoktorlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DtDoktorlar.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DtDoktorlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtDoktorlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DtDoktorlar.DefaultCellStyle = dataGridViewCellStyle6;
            this.DtDoktorlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtDoktorlar.Location = new System.Drawing.Point(3, 26);
            this.DtDoktorlar.Name = "DtDoktorlar";
            this.DtDoktorlar.RowHeadersWidth = 51;
            this.DtDoktorlar.RowTemplate.Height = 24;
            this.DtDoktorlar.Size = new System.Drawing.Size(405, 314);
            this.DtDoktorlar.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDuyurularBnf);
            this.groupBox6.Controls.Add(this.btnRandevuListeBnf);
            this.groupBox6.Controls.Add(this.btnBransPaneliBnf);
            this.groupBox6.Controls.Add(this.btnDoktorPaneliBnf);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox6.Location = new System.Drawing.Point(30, 648);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(693, 100);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnDuyurularBnf
            // 
            this.btnDuyurularBnf.ActiveBorderThickness = 1;
            this.btnDuyurularBnf.ActiveCornerRadius = 20;
            this.btnDuyurularBnf.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDuyurularBnf.ActiveForecolor = System.Drawing.Color.White;
            this.btnDuyurularBnf.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDuyurularBnf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnDuyurularBnf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDuyurularBnf.BackgroundImage")));
            this.btnDuyurularBnf.ButtonText = "Duyurular";
            this.btnDuyurularBnf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuyurularBnf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyurularBnf.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDuyurularBnf.IdleBorderThickness = 1;
            this.btnDuyurularBnf.IdleCornerRadius = 20;
            this.btnDuyurularBnf.IdleFillColor = System.Drawing.Color.White;
            this.btnDuyurularBnf.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDuyurularBnf.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDuyurularBnf.Location = new System.Drawing.Point(517, 31);
            this.btnDuyurularBnf.Margin = new System.Windows.Forms.Padding(5);
            this.btnDuyurularBnf.Name = "btnDuyurularBnf";
            this.btnDuyurularBnf.Size = new System.Drawing.Size(150, 50);
            this.btnDuyurularBnf.TabIndex = 9;
            this.btnDuyurularBnf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDuyurularBnf.Click += new System.EventHandler(this.btnDuyurularBnf_Click);
            // 
            // btnRandevuListeBnf
            // 
            this.btnRandevuListeBnf.ActiveBorderThickness = 1;
            this.btnRandevuListeBnf.ActiveCornerRadius = 20;
            this.btnRandevuListeBnf.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRandevuListeBnf.ActiveForecolor = System.Drawing.Color.White;
            this.btnRandevuListeBnf.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRandevuListeBnf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnRandevuListeBnf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRandevuListeBnf.BackgroundImage")));
            this.btnRandevuListeBnf.ButtonText = "Randevu Liste";
            this.btnRandevuListeBnf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandevuListeBnf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandevuListeBnf.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRandevuListeBnf.IdleBorderThickness = 1;
            this.btnRandevuListeBnf.IdleCornerRadius = 20;
            this.btnRandevuListeBnf.IdleFillColor = System.Drawing.Color.White;
            this.btnRandevuListeBnf.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRandevuListeBnf.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRandevuListeBnf.Location = new System.Drawing.Point(352, 31);
            this.btnRandevuListeBnf.Margin = new System.Windows.Forms.Padding(5);
            this.btnRandevuListeBnf.Name = "btnRandevuListeBnf";
            this.btnRandevuListeBnf.Size = new System.Drawing.Size(150, 50);
            this.btnRandevuListeBnf.TabIndex = 8;
            this.btnRandevuListeBnf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRandevuListeBnf.Click += new System.EventHandler(this.btnRandevuListeBnf_Click);
            // 
            // btnBransPaneliBnf
            // 
            this.btnBransPaneliBnf.ActiveBorderThickness = 1;
            this.btnBransPaneliBnf.ActiveCornerRadius = 20;
            this.btnBransPaneliBnf.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnBransPaneliBnf.ActiveForecolor = System.Drawing.Color.White;
            this.btnBransPaneliBnf.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnBransPaneliBnf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBransPaneliBnf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBransPaneliBnf.BackgroundImage")));
            this.btnBransPaneliBnf.ButtonText = "Branş Paneli";
            this.btnBransPaneliBnf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBransPaneliBnf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBransPaneliBnf.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnBransPaneliBnf.IdleBorderThickness = 1;
            this.btnBransPaneliBnf.IdleCornerRadius = 20;
            this.btnBransPaneliBnf.IdleFillColor = System.Drawing.Color.White;
            this.btnBransPaneliBnf.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnBransPaneliBnf.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnBransPaneliBnf.Location = new System.Drawing.Point(186, 31);
            this.btnBransPaneliBnf.Margin = new System.Windows.Forms.Padding(5);
            this.btnBransPaneliBnf.Name = "btnBransPaneliBnf";
            this.btnBransPaneliBnf.Size = new System.Drawing.Size(150, 50);
            this.btnBransPaneliBnf.TabIndex = 7;
            this.btnBransPaneliBnf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBransPaneliBnf.Click += new System.EventHandler(this.btnBransPaneliBnf_Click);
            // 
            // btnDoktorPaneliBnf
            // 
            this.btnDoktorPaneliBnf.ActiveBorderThickness = 1;
            this.btnDoktorPaneliBnf.ActiveCornerRadius = 20;
            this.btnDoktorPaneliBnf.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnDoktorPaneliBnf.ActiveForecolor = System.Drawing.Color.White;
            this.btnDoktorPaneliBnf.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnDoktorPaneliBnf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnDoktorPaneliBnf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorPaneliBnf.BackgroundImage")));
            this.btnDoktorPaneliBnf.ButtonText = "Doktor Paneli";
            this.btnDoktorPaneliBnf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoktorPaneliBnf.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoktorPaneliBnf.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDoktorPaneliBnf.IdleBorderThickness = 1;
            this.btnDoktorPaneliBnf.IdleCornerRadius = 20;
            this.btnDoktorPaneliBnf.IdleFillColor = System.Drawing.Color.White;
            this.btnDoktorPaneliBnf.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDoktorPaneliBnf.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDoktorPaneliBnf.Location = new System.Drawing.Point(20, 31);
            this.btnDoktorPaneliBnf.Margin = new System.Windows.Forms.Padding(5);
            this.btnDoktorPaneliBnf.Name = "btnDoktorPaneliBnf";
            this.btnDoktorPaneliBnf.Size = new System.Drawing.Size(150, 50);
            this.btnDoktorPaneliBnf.TabIndex = 6;
            this.btnDoktorPaneliBnf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoktorPaneliBnf.Click += new System.EventHandler(this.btnDoktorPaneliBnf_Click);
            // 
            // sekreterDetayGeri
            // 
            this.sekreterDetayGeri.Image = ((System.Drawing.Image)(resources.GetObject("sekreterDetayGeri.Image")));
            this.sekreterDetayGeri.Location = new System.Drawing.Point(12, 8);
            this.sekreterDetayGeri.Name = "sekreterDetayGeri";
            this.sekreterDetayGeri.Size = new System.Drawing.Size(35, 35);
            this.sekreterDetayGeri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sekreterDetayGeri.TabIndex = 6;
            this.sekreterDetayGeri.TabStop = false;
            this.sekreterDetayGeri.Click += new System.EventHandler(this.sekreterDetayGeri_Click);
            this.sekreterDetayGeri.MouseLeave += new System.EventHandler(this.sekreterDetayGeri_MouseLeave);
            this.sekreterDetayGeri.MouseHover += new System.EventHandler(this.sekreterDetayGeri_MouseHover);
            // 
            // sekreterCikis
            // 
            this.sekreterCikis.Image = ((System.Drawing.Image)(resources.GetObject("sekreterCikis.Image")));
            this.sekreterCikis.Location = new System.Drawing.Point(1115, 8);
            this.sekreterCikis.Name = "sekreterCikis";
            this.sekreterCikis.Size = new System.Drawing.Size(35, 35);
            this.sekreterCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sekreterCikis.TabIndex = 7;
            this.sekreterCikis.TabStop = false;
            this.sekreterCikis.Click += new System.EventHandler(this.sekreterCikis_Click);
            this.sekreterCikis.MouseLeave += new System.EventHandler(this.sekreterCikis_MouseLeave);
            this.sekreterCikis.MouseHover += new System.EventHandler(this.sekreterCikis_MouseHover);
            // 
            // lblSekreterDetay
            // 
            this.lblSekreterDetay.AllowDrop = true;
            this.lblSekreterDetay.AutoEllipsis = true;
            this.lblSekreterDetay.AutoSize = true;
            this.lblSekreterDetay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSekreterDetay.ForeColor = System.Drawing.Color.White;
            this.lblSekreterDetay.Location = new System.Drawing.Point(462, 8);
            this.lblSekreterDetay.Name = "lblSekreterDetay";
            this.lblSekreterDetay.Size = new System.Drawing.Size(235, 26);
            this.lblSekreterDetay.TabIndex = 8;
            this.lblSekreterDetay.Text = "SEKRETER DETAY FORMU";
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1162, 757);
            this.Controls.Add(this.lblSekreterDetay);
            this.Controls.Add(this.sekreterCikis);
            this.Controls.Add(this.sekreterDetayGeri);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Detay";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtBrans)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtDoktorlar)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sekreterDetayGeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sekreterCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.TextBox txtİd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rchDuyuru;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DtBrans;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView DtDoktorlar;
        private System.Windows.Forms.GroupBox groupBox6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOlusturBnf;
        private Bunifu.Framework.UI.BunifuThinButton2 btnKaydetBnf;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDuyurularBnf;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRandevuListeBnf;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBransPaneliBnf;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDoktorPaneliBnf;
        private System.Windows.Forms.PictureBox sekreterDetayGeri;
        private System.Windows.Forms.PictureBox sekreterCikis;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSekreterDetay;
        private System.Windows.Forms.CheckBox randevuAl;
    }
}