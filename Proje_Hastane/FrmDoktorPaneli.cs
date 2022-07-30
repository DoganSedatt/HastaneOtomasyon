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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dtDoktorPaneli.DataSource = dt1;

            //Branşları Combobax'a Aktarma
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        

        private void dtDoktorPaneli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtDoktorPaneli.SelectedCells[0].RowIndex;
            txtAd.Text = dtDoktorPaneli.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dtDoktorPaneli.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dtDoktorPaneli.Rows[secilen].Cells[3].Value.ToString();
            MskTC.Text = dtDoktorPaneli.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dtDoktorPaneli.Rows[secilen].Cells[5].Value.ToString();
        }

      

        

       

       

        

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            SqlCommand komutguncelle = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@g1,DoktorSoyad=@g2,DoktorBrans=@g3,DoktorSifre=@g5 where DoktorTC=@g4", bgl.baglanti());
            komutguncelle.Parameters.AddWithValue("@g1", txtAd.Text);
            komutguncelle.Parameters.AddWithValue("@g2", txtSoyad.Text);
            komutguncelle.Parameters.AddWithValue("@g4", MskTC.Text);
            komutguncelle.Parameters.AddWithValue("@g3", cmbBrans.Text);
            komutguncelle.Parameters.AddWithValue("@g5", txtSifre.Text);
            komutguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Kaydı Güncellendi","Kayıt Güncelle",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == String.Empty || txtSoyad.Text == String.Empty || MskTC.Text == String.Empty || cmbBrans.Text == String.Empty || txtSifre.Text == String.Empty)
            {
                txtAd.BackColor = Color.Yellow;
                txtSoyad.BackColor = Color.Yellow;
                MskTC.BackColor = Color.Yellow;
                cmbBrans.BackColor = Color.Yellow;
                txtSifre.BackColor = Color.Yellow;
                MessageBox.Show("Sarı alanlar boş bırakılamaz", "Kayıt Yapılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              
                DialogResult secenek = MessageBox.Show("Kaydı Onaylıyor musunuz?", "Kayıt Yap", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (secenek == DialogResult.Yes)
                {
                    SqlCommand komut = new SqlCommand("Insert into Tbl_Doktorlar(DoktorAd,DoktorSoyad,DoktorTC,DoktorBrans,DoktorSifre) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", MskTC.Text);
                    komut.Parameters.AddWithValue("@p4", cmbBrans.Text);
                    komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Doktor Kaydı Yapılmıştır", "Kayıt Ekleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    bgl.baglanti().Close();
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            DialogResult secenek;
            secenek = MessageBox.Show("Kaydı Silmek İstediğinize Emin misiniz?","Kayıt Silme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                SqlCommand komut = new SqlCommand("delete from Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", MskTC.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Doktor Kaydınız Silinmiştir", "Kayıt Silme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay fr = new FrmSekreterDetay();
            fr.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Orange;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }

        

        
    }
}
