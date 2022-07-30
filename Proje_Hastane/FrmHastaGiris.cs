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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();

    
        
        
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
           
        }
        
        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {
         
           
        }
       
        private void lnkHastaKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }

        private void hastaGirisPBtn_Click(object sender, EventArgs e) 
        {
            try
            {
                SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTc=@p1 and HastaSifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", MskTC.Text);
                komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    FrmHastaDetay fr = new FrmHastaDetay();
                    fr.tc = MskTC.Text;
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Tc veya Şifre", "Giriş Yapılamadı");
                }
                bgl.baglanti().Close();
            }
            catch(Exception aa)
            {
                MessageBox.Show(aa.Message+" Hatalı Giriş");
            }
            finally
            {
                bgl.baglanti().Close();
            }
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

        private void hastaCikis_Click(object sender, EventArgs e)
        {
            DialogResult secenek;
            secenek=MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?","Çıkış",MessageBoxButtons.YesNo);
            if (secenek ==DialogResult.Yes) { Application.Exit(); }
            else { }
        }

        private void hastaCikis_MouseHover(object sender, EventArgs e)
        {
            hastaCikis.BackColor = Color.Orange;
        }

        private void hastaCikis_MouseLeave(object sender, EventArgs e)
        {
            hastaCikis.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }

        private void hastaEnglish_Click(object sender, EventArgs e)
        {
            lblSifre.Text = "Password:";
            lblSifre.Location = new Point(15, 150);
            hastaGirisPBtn.ButtonText = "Login";
            lnkHastaKayit.Text = "Register";
            lblHastaGirisPaneli.Text = "Patient Login";



        }

        private void hastaTurkce_Click(object sender, EventArgs e)
        {
            lblSifre.Text = "Şifre:";
            lblSifre.Location = new Point(50, 150);
            hastaGirisPBtn.ButtonText = "Giriş Yap";
            lnkHastaKayit.Text = "Kayıt";
            lblHastaGirisPaneli.Text = "Hasta Giriş";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            FrmGirisss fr = new FrmGirisss();
            fr.Show();
            this.Hide();
        }
        int tik = 0;
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tik++;
            if (tik % 2 == 1) { TxtSifre.UseSystemPasswordChar = false; }
            else { TxtSifre.UseSystemPasswordChar = true; }
        }
    }
}
