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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bql = new Sqlbaglantisi();
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnKayitYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)",bql.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAd.Text);
            komut.Parameters.AddWithValue("@p2",txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3",MskTC.Text);
            komut.Parameters.AddWithValue("@p4",MskTel.Text);
            komut.Parameters.AddWithValue("@p5",txtSifre.Text);
            komut.Parameters.AddWithValue("@p6",cmbxCinsiyet.Text);
            komut.ExecuteNonQuery();
            bql.baglanti().Close();
            MessageBox.Show("Kaydınız Başarıyla Yapılmıştır.(Şifre:"+txtSifre.Text +")","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void FrmHastaKayit_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtAd.Text==String.Empty||txtSoyad.Text==String.Empty||MskTC.Text==String.Empty||MskTel.Text==string.Empty||txtSifre.Text==string.Empty||cmbxCinsiyet.Text==string.Empty) 
            {
                txtAd.BackColor = Color.Yellow;
                txtSoyad.BackColor = Color.Yellow;
                MskTC.BackColor = Color.Yellow;
                MskTel.BackColor = Color.Yellow;
                txtSifre.BackColor = Color.Yellow;
                cmbxCinsiyet.BackColor = Color.Yellow;
                MessageBox.Show("Sarı alanlar boş geçilemez","Kayıt Yapılamadı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bql.baglanti());
                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTC.Text);
                komut.Parameters.AddWithValue("@p4", MskTel.Text);
                komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                komut.Parameters.AddWithValue("@p6", cmbxCinsiyet.Text);
                komut.ExecuteNonQuery();
                bql.baglanti().Close();
                MessageBox.Show("Kaydınız Başarıyla Yapılmıştır.(Şifre:" + txtSifre.Text + ")", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
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
    }
}
