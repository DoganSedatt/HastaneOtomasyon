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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            dtGecmisRandevular.ForeColor = Color.Black;
            dtAktifRandevular.ForeColor=Color.Black;
            //Ad Soyad Çekme
            LblKimlik.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblKimlik.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoy.Text = dr[0] + " " + dr[1];

            }
            bgl.baglanti().Close();
            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTc="+tc,bgl.baglanti());
            da.Fill(dt);
            dtGecmisRandevular.DataSource=dt;

            //Branş çekme
            SqlCommand komut2 = new SqlCommand("Select * From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbxBrans.Items.Add(dr2[1]);
            }
            bgl.baglanti().Close();


        }

        private void cmbxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbxDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmbxBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbxDoktor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();
        }

        private void cmbxDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='"+cmbxBrans.Text+"'"+" and RandevuDoktor='"+cmbxDoktor.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dtAktifRandevular.DataSource = dt;
        }

        private void LnkGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiGuncelle fr = new FrmBilgiGuncelle();
            fr.TCno = LblKimlik.Text;
            fr.Show();
        }

        private void dtAktifRandevular_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtAktifRandevular.SelectedCells[0].RowIndex;
            txtId.Text = dtAktifRandevular.Rows[secilen].Cells[0].Value.ToString();
        }

       

        private void bnfbtnRandevuAl_Click(object sender, EventArgs e)
        {
            if (mskTarih.Text == String.Empty || mskSaat.Text == String.Empty || cmbxBrans.Text == String.Empty || cmbxDoktor.Text == String.Empty)
            {
                mskTarih.BackColor = Color.Yellow;
                mskSaat.BackColor = Color.Yellow;
                cmbxBrans.BackColor = Color.Yellow;
                cmbxDoktor.BackColor = Color.Yellow;
                MessageBox.Show("Sarı renkli alanlar boş geçilemez", "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand komutkaydet = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor,RandevuDurum,HastaTC,HastaSikayet) values (@r1,@r2,@r3,@r4,@r5,@r6,@r7)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
                komutkaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
                komutkaydet.Parameters.AddWithValue("@r3", cmbxBrans.Text);
                komutkaydet.Parameters.AddWithValue("@r4", cmbxDoktor.Text);
                komutkaydet.Parameters.AddWithValue("@r5", randevuAl.Checked == true);
                komutkaydet.Parameters.AddWithValue("@r6", LblKimlik.Text);
                komutkaydet.Parameters.AddWithValue("@r7", rtxtSikayet.Text);
                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Randevu Oluşturuldu", "Kayıt Yapıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bnfbtnGuncelle_Click(object sender, EventArgs e)
        {
            FrmBilgiGuncelle fr = new FrmBilgiGuncelle();
            fr.TCno = LblKimlik.Text;
            fr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult secenek;
            secenek = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes) { Application.Exit(); }
            else { }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Orange;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Orange;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }
    }
}
