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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular",bgl.baglanti());
            da.Fill(dt);
            dtRandevuListesi.DataSource = dt;
        }

        private void randevuListeCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void randevuListeCikis_MouseHover(object sender, EventArgs e)
        {
            randevuListeCikis.BackColor = Color.Orange;
        }

        private void randevuListeCikis_MouseLeave(object sender, EventArgs e)
        {
            randevuListeCikis.BackColor = System.Drawing.Color.FromArgb(34, 36, 49);
        }

        private void randevuListeGeri_Click(object sender, EventArgs e)
        {
            FrmSekreterDetay fr = new FrmSekreterDetay();
            fr.Show();
            this.Hide();
        }

        
    }
}
