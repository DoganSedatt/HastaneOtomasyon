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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCnumara;
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            DtBrans.ForeColor = Color.Black;
            DtDoktorlar.ForeColor = Color.Black;
            lblTC.Text = TCnumara;
            //Sekreter Ad Soyad Çekme
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1",bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();
            //Branşı DataGridView'e Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt1);
            DtBrans.DataSource = dt1;

            //Doktorları DataGridView'e Aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select DoktorAd,DoktorSoyad,DoktorBrans from Tbl_Doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            DtDoktorlar.DataSource = dt2;

            //Branşı Combobox'a çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,HastaTC) values (@r1,@r2,@r3,@r4,@r5)",bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1",mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2",mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3",cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4",cmbDoktor.Text);
            komutkaydet.Parameters.AddWithValue("@r5", mskTC.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] +" "+ dr[1]);
            }
            bgl.baglanti().Close();

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Duyurular(Duyuru) values(@d1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1",rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyurunuz Oluşturuldu");
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmBrans frb = new FrmBrans();
            frb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }

        private void btnOlusturBnf_Click(object sender, EventArgs e)
        {
            if (rchDuyuru.Text == String.Empty)
            {
                MessageBox.Show("Duyuru oluşturulamadı", "Kayıt Yapılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komut = new SqlCommand("Insert into Tbl_Duyurular(Duyuru) values(@d1)", bgl.baglanti());
                komut.Parameters.AddWithValue("@d1", rchDuyuru.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Duyurunuz Oluşturuldu");
            }
        }

        private void btnKaydetBnf_Click(object sender, EventArgs e)
        {
            if ( mskTarih.Text == String.Empty || mskSaat.Text == String.Empty || cmbBrans.Text == String.Empty || cmbDoktor.Text == String.Empty || mskTC.Text == String.Empty)
            {
                
                mskTarih.BackColor = Color.Yellow;
                mskSaat.BackColor = Color.Yellow;
                cmbBrans.BackColor = Color.Yellow;
                cmbDoktor.BackColor = Color.Yellow;
                mskTC.BackColor = Color.Yellow;
                MessageBox.Show("Sarı renkli alanlar boş geçilemez","Hata Oluştu",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
            }
            else
            {
                SqlCommand komutkaydet = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,RandevuDurum,HastaTC) values (@r1,@r2,@r3,@r4,@r5,@r6)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
                komutkaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
                komutkaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
                komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
                komutkaydet.Parameters.AddWithValue("@r5", randevuAl.Checked==true);
                komutkaydet.Parameters.AddWithValue("@r6", mskTC.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu Oluşturuldu","Kayıt Yapıldı",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void btnDoktorPaneliBnf_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
            
        }

        private void btnBransPaneliBnf_Click(object sender, EventArgs e)
        {
            FrmBrans frb = new FrmBrans();
            frb.Show();
            
        }

        private void btnRandevuListeBnf_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void btnDuyurularBnf_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }

        private void sekreterDetayGeri_Click(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            this.Hide();
        }

        private void sekreterCikis_Click(object sender, EventArgs e)
        {
            DialogResult secenek;
            secenek = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes) { Application.Exit(); }
            else { }
        }

        private void sekreterDetayGeri_MouseHover(object sender, EventArgs e)
        {
            sekreterDetayGeri.BackColor = Color.Orange;
        }

        private void sekreterDetayGeri_MouseLeave(object sender, EventArgs e)
        {
            sekreterDetayGeri.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }

        private void sekreterCikis_MouseHover(object sender, EventArgs e)
        {
            sekreterCikis.BackColor = Color.Orange;
        }

        private void sekreterCikis_MouseLeave(object sender, EventArgs e)
        {
            sekreterCikis.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }

        
    }
}
