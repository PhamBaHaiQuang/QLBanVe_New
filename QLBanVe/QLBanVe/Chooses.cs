using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBanVe
{
    public partial class Chooses : Form
    {
        public Chooses()
        {
            InitializeComponent();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["Dang_Nhap"];
            if (frm == null)
            {
                frm = new Dang_Nhap();
            }
            this.Hide();
            frm.Show();
        }

        private void btBanVe_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["Quan_Ly_Ban_Ve"];
            if (frm == null)
            {
                frm = new Quan_Ly_Ban_Ve();
            }
            this.Hide();
            frm.Show();
        }

        private void btVeOnline_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["Kiem_Tra_Dat_Ve"];
            if (frm == null)
            {
                frm = new Kiem_Tra_Dat_Ve();
            }
            this.Hide();
            frm.Show();
        }

        private void Chooses_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
