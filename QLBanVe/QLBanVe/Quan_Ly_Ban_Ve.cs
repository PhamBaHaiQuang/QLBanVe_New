using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLBanVe
{
    public partial class Quan_Ly_Ban_Ve : Form
    {
        public Quan_Ly_Ban_Ve()
        {
            InitializeComponent();
        }

        private void btQuayLai_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["Chooses"];
            if (frm == null)
            {
                frm = new Chooses();
            }
            this.Hide();
            frm.Show();
        }

        private void Quan_Ly_Ban_Ve_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btGiaoDich_Click(object sender, EventArgs e)
        {

        }

        private void Quan_Ly_Ban_Ve_Load(object sender, EventArgs e)
        {

        }

        

        private void btHuy_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn hủy?", "Chú ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                txtMaThe.Text = "";
                cmbPhim.Text = "Chọn phim";
                numSoVe.Value = 0;
                dtpNgayChieu.Value = DateTime.Now;
                cmbSuatChieu.Text = "Chọn suất chiếu";
                txtViTri.Text = "";
                cmbRapChieu.Text = "Chọn rạp chiếu";
            }
        }

        private void btMaThe_Click(object sender, EventArgs e)
        {

        }
    }
}
