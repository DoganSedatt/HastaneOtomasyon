using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void FrmGirisler_Load(object sender, EventArgs e)
        {
            timer1.Start();
            bunifuCustomLabel1.Visible = true;
            bunifuCustomLabel2.Visible = true;
            
            
        }
   
        private void hastaGirisBtn_Click_1(object sender, EventArgs e)
        {
            FrmHastaGiris frHastaGris = new FrmHastaGiris();
            frHastaGris.Show();
            this.Hide();
        }

     

        private void sekreterGirisBtn_Click_1(object sender, EventArgs e)
        {
            FrmSekreterGiris frSekreterGiris = new FrmSekreterGiris();
            frSekreterGiris.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult secenek;
            secenek = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes) { Application.Exit(); }
            else { }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Orange;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.meramtip.com.tr/");
        }

        
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip lnk = new ToolTip();
            lnk.SetToolTip(pictureBox1, "http://www.meramtip.com.tr/");
            lnk.ToolTipTitle = "Adrese Git";
        }

        private void girisEnglish_Click(object sender, EventArgs e)
        {
            hastaGirisBtn.ButtonText = "Patient Login";
            doktorGirisBtn.ButtonText = "Doctor Login";
            sekreterGirisBtn.ButtonText = "Secretary Login";
            bnfGorsel.ButtonText = "Images";
            lblGiris.Text = "Necmettin Erbakan University Hospital";
        }

        private void girisTurkce_Click(object sender, EventArgs e)
        {
            hastaGirisBtn.ButtonText = "Hasta Giriş";
            doktorGirisBtn.ButtonText = "Doktor Giriş";
            sekreterGirisBtn.ButtonText = "Sekreter Giriş";
            bnfGorsel.ButtonText = "Görseller";
            lblGiris.Text = "Necmettin Erbakan Üniversite Hastanesi";
            
        }

        private void girisTemaAydinlik_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(204,204,204);
            hastaGirisBtn.ActiveFillColor = System.Drawing.Color.FromArgb(204, 204, 204);
            doktorGirisBtn.ActiveFillColor = System.Drawing.Color.FromArgb(204,204,204);
            sekreterGirisBtn.ActiveFillColor = System.Drawing.Color.FromArgb(204,204,204);
            bnfGorsel.ActiveFillColor = System.Drawing.Color.FromArgb(204,204,204);
            lblGiris.ForeColor = Color.Black;
            hastaGirisBtn.IdleLineColor = System.Drawing.Color.FromArgb(51, 51, 51);
            doktorGirisBtn.IdleLineColor = System.Drawing.Color.FromArgb(51, 51, 51);
            sekreterGirisBtn.IdleLineColor = System.Drawing.Color.FromArgb(51, 51, 51);
            bnfGorsel.IdleLineColor = System.Drawing.Color.FromArgb(51,51,51);
            bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(34,36,49);
            bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(34,36,49);
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(204,204,204);
           
            
        }

        private void girisTemaKaranlik_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.FromArgb(34,36,49);
            hastaGirisBtn.ActiveFillColor = System.Drawing.Color.FromArgb(34,36,49);
            doktorGirisBtn.ActiveFillColor = System.Drawing.Color.FromArgb(34,36,49);
            sekreterGirisBtn.ActiveFillColor = System.Drawing.Color.FromArgb(34, 36, 49);
            bnfGorsel.ActiveFillColor = System.Drawing.Color.FromArgb(34,36,49);
            lblGiris.ForeColor = Color.White;
            hastaGirisBtn.IdleLineColor = Color.SeaGreen;
            doktorGirisBtn.IdleLineColor = Color.SeaGreen;
            sekreterGirisBtn.IdleLineColor = Color.SeaGreen;
            bnfGorsel.IdleLineColor = Color.SeaGreen;
            bunifuCustomLabel1.ForeColor = Color.White;
            bunifuCustomLabel2.ForeColor = Color.White;
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }

        private void doktorGirisBtn_Click(object sender, EventArgs e)
        {
            FrmDoktorGiriss fr = new FrmDoktorGiriss();
            fr.Show();
            this.Hide();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = "Tarih:"+DateTime.Now.ToLongDateString();
            bunifuCustomLabel2.Text = "Saat:"+DateTime.Now.ToLongTimeString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmGirisss fr = new FrmGirisss();
            fr.Show();
        }

        private void bnfGorsel_Click(object sender, EventArgs e)
        {
            FrmGorseller fr = new FrmGorseller();
            fr.Show();
            this.Hide();
        }
    }
}
