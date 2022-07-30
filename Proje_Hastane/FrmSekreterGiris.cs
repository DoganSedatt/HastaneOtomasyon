using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void sekreterGirisPBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.TCnumara = MskTC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
            bgl.baglanti().Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmGirisler frGiris = new FrmGirisler();
            frGiris.Show();
            this.Hide();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Orange;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }

        private void sekreterCikis_Click(object sender, EventArgs e)
        {
            DialogResult secenek;
            secenek = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes) { Application.Exit(); }
            else { }
        }

        private void sekreterCikis_MouseHover(object sender, EventArgs e)
        {
            sekreterCikis.BackColor = Color.Orange;
        }

        private void sekreterCikis_MouseLeave(object sender, EventArgs e)
        {
            sekreterCikis.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }

        private void sekreterEnglish_Click(object sender, EventArgs e)
        {
            lblSifre.Text = "Password:";
            lblSifre.Location = new Point(20, 143);
            sekreterGirisPBtn.ButtonText = "Login";
            lblSekreterGirisPaneli.Text = "Secretary Login";
        }

        private void sekreterTurkce_Click(object sender, EventArgs e)
        {
            lblSifre.Text = "Şifre:";
            lblSifre.Location = new Point(60, 143);
            sekreterGirisPBtn.ButtonText = "Giriş Yap";
            lblSekreterGirisPaneli.Text = "Sekreter Giriş";

        }
        int tik=0;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tik++;
            if (tik%2==1) { TxtSifre.UseSystemPasswordChar = false;}
            else { TxtSifre.UseSystemPasswordChar = true; }
        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
