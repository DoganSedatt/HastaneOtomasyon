using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGirisss : Form
    {
        int tık = 0;
        public FrmGirisss()
        {
            InitializeComponent();
        }
        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            tık++;
            if (tık % 2 == 1) 
            {
                txtSifre.isPassword = false;
            }
            else 
            {
                txtSifre.isPassword = true;
            }
        }

        
    }
    }

