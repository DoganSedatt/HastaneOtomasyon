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
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmBrans_Load(object sender, EventArgs e)
        {
            dtBrans.ForeColor = Color.Black;
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar",bgl.baglanti());
            da.Fill(dt);
            dtBrans.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("Insert into Tbl_Branslar (BransAd) values (@e1)",bgl.baglanti());
            ekle.Parameters.AddWithValue("@e1",txtBransAd.Text);
            ekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Kaydı Yapıldı");
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete From Tbl_Branslar where Bransid=@s1",bgl.baglanti());
            sil.Parameters.AddWithValue("@s1",txtBransid.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void dtBrans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtBrans.SelectedCells[0].RowIndex;
            txtBransid.Text = dtBrans.Rows[secilen].Cells[0].Value.ToString();
            txtBransAd.Text = dtBrans.Rows[secilen].Cells[1].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand updt = new SqlCommand("Update Tbl_Branslar set BransAd=@p1 where Bransid=@p2",bgl.baglanti());
            updt.Parameters.AddWithValue("@p1",txtBransAd.Text);
            updt.Parameters.AddWithValue("@p2",txtBransid.Text);
            updt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");
        }

        private void bnnBtnEkle_Click(object sender, EventArgs e)
        {
            if (txtBransAd.Text == String.Empty)
            {
                txtBransAd.BackColor = Color.Yellow;
                MessageBox.Show("Sarı alan boş bırakılamaz", "Kayıt Yapılamadı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                SqlCommand ekle = new SqlCommand("Insert into Tbl_Branslar (BransAd) values (@e1)", bgl.baglanti());
                ekle.Parameters.AddWithValue("@e1", txtBransAd.Text);
                ekle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Branş Kaydı Yapıldı", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bnfbtnsil_Click(object sender, EventArgs e)
        {
            DialogResult secenek;
            secenek = MessageBox.Show("Kaydı Silmek İstediğinize Emin misiniz?", "Kayıt Silme", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes)
            {
                SqlCommand sil = new SqlCommand("Delete From Tbl_Branslar where Bransid=@s1", bgl.baglanti());
                sil.Parameters.AddWithValue("@s1", txtBransid.Text);
                sil.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Branş Silindi", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bnfbtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand updt = new SqlCommand("Update Tbl_Branslar set BransAd=@p1 where", bgl.baglanti());
            updt.Parameters.AddWithValue("@p1", txtBransAd.Text);
            
            updt.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");
        }

        private void bransGeri_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay fr = new FrmSekreterDetay();
            fr.Show();
            this.Hide();
        }

        private void bransCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void bransCikis_MouseHover(object sender, EventArgs e)
        {
            bransCikis.BackColor = Color.Orange;
        }

        private void bransCikis_MouseLeave(object sender, EventArgs e)
        {
            bransCikis.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
        }

       
    }
}
