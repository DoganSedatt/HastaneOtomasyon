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
    public partial class FrmDoktorGiriss : Form
    {
        public FrmDoktorGiriss()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        
        private void doktorGeri_Click(object sender, EventArgs e)
        {
            FrmGirisler frGiris = new FrmGirisler();
            frGiris.Show();
            this.Hide();
        }

        private void doktorCikis_Click(object sender, EventArgs e)
        {
            DialogResult secenek;
            secenek = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes) { Application.Exit(); }
            else { }
        }

        private void doktorTurkce_Click(object sender, EventArgs e)
        {
            lblSifre.Text = "Şifre:";
            lblSifre.Location = new Point(50, 150);
            doktorGirisPBtn.ButtonText = "Giriş Yap";
            lblDoktorGirisPaneli.Text = "Doktor Giriş";
        }

        private void doktorEnglish_Click(object sender, EventArgs e)
        {
            lblSifre.Text = "Password:";
            lblSifre.Location = new Point(15, 150);
            doktorGirisPBtn.ButtonText = "Login";
            lblDoktorGirisPaneli.Text = "Patient Login";
        }

        private void doktorGirisPBtn_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTc=@p1 and DoktorSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.TC = MskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc veya Şifre");
            }
            bgl.baglanti().Close();
        }

        private void doktorGeri_MouseHover(object sender, EventArgs e)
        {
            doktorGeri.BackColor = Color.Orange;
        }

        private void doktorGeri_MouseLeave(object sender, EventArgs e)
        {
            doktorGeri.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
        }

        private void doktorCikis_MouseHover(object sender, EventArgs e)
        {
            doktorCikis.BackColor = Color.Orange;
        }

        private void doktorCikis_MouseLeave(object sender, EventArgs e)
        {
            doktorCikis.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }
        int tik = 0;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tik++;
            if (tik%2==1) { TxtSifre.UseSystemPasswordChar = false; }
            else { TxtSifre.UseSystemPasswordChar = true; }
        }
    }
}
