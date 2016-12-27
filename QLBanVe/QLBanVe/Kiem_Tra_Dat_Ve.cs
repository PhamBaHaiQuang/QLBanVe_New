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
    public partial class Kiem_Tra_Dat_Ve : Form
    {
        public Kiem_Tra_Dat_Ve()
        {
            InitializeComponent();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Thông tin đang trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult = MessageBox.Show("Bạn có muốn hủy?", "Chú ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.OK)
                {
                    txtDienThoai.Text = "";
                }
            } 
        }

        private void Kiem_Tra_Dat_Ve_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btKiemTra_Click(object sender, EventArgs e)
        {

        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e) //Chi cho nhap so tu ban phim
        {

        }
    }
}
