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
            if (txtDienThoai.Text != "")
            {
                string cnStr;
                SqlConnection cn;
                cnStr = @"Data Source = .; Initial Catalog = QLBanVe; Integrated Security = True";
                try
                {
                    cn = new SqlConnection(cnStr);
                    cn.Open();
                    string query = "SELECT Count(*) FROM DangKyOnline WHERE DienThoai = @dienthoai";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add(new SqlParameter("@dienthoai", txtDienThoai.Text));
                    int x = (int)cmd.ExecuteScalar();
                    if (x == 1)
                    {
                        lbThongBao.Text = "";
                        MessageBox.Show("Số điện thoại chính xác.", "Thông báo.");
                        this.Hide();
                        Lay_Ve_Online lvo = new Lay_Ve_Online(); // goi form lay ve online 
                        lvo.Sender(txtDienThoai.Text); // chuyen du lieu tu txt qua lable cua form lay ve online theo phuong thuc delegate
                        this.Hide();
                        lvo.Show();
                    }
                    else
                    {
                        lbThongBao.Text = "Số điện thoại không chính xác!";
                        txtDienThoai.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e) //Chi cho nhap so tu ban phim
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
