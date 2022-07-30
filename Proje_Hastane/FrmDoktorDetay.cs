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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        public String TC;
     
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            dtRandevuListesi.ForeColor = Color.Black;
            lblTcno.Text = TC;
            //Doktor Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorTc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTcno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                AdSoyadlbl.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='"+AdSoyadlbl.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dtRandevuListesi.DataSource = dt;

        }

        private void btnBilgiDüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle frdb = new FrmDoktorBilgiDüzenle();
            frdb.TC = lblTcno.Text;
            frdb.Show();
            
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtRandevuListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtRandevuListesi.SelectedCells[0].RowIndex;
            rchRandevuDetay.Text = dtRandevuListesi.Rows[secilen].Cells[7].Value.ToString();
        }

       

        private void doktorDetayGeri_Click_1(object sender, EventArgs e)
        {
            FrmGirisler fr = new FrmGirisler();
            fr.Show();
            this.Hide();
        }

        private void doktorDetayGeri_MouseHover_1(object sender, EventArgs e)
        {
            doktorDetayGeri.BackColor = Color.Orange;
        }

        private void doktorDetayGeri_MouseLeave(object sender, EventArgs e)
        {
            doktorDetayGeri.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }

        private void doktorDetayCikis_Click(object sender, EventArgs e)
        {
            DialogResult secenek;
            secenek = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (secenek == DialogResult.Yes) { Application.Exit(); }
            else { }
        }

        private void doktorDetayCikis_MouseHover(object sender, EventArgs e)
        {
            doktorDetayCikis.BackColor = Color.Orange;
        }

        private void doktorDetayCikis_MouseLeave(object sender, EventArgs e)
        {
            doktorDetayCikis.BackColor = System.Drawing.Color.FromArgb(34,36,49);
        }

        private void bnfDuyurularBtn_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void bnfBilgibtn_Click(object sender, EventArgs e)
        {

            FrmDoktorBilgiDüzenle frdb = new FrmDoktorBilgiDüzenle();
            frdb.TC = lblTcno.Text;
            frdb.Show();
        }
    }
}
