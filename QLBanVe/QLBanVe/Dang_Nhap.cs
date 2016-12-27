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
    public partial class Dang_Nhap : Form
    {
        string cnStr = @"Data Source = .; Initial Catalog = QLBanVe; Integrated Security = True";
        SqlConnection con;
        SqlCommand cmd;
        public Dang_Nhap()
        {
            InitializeComponent();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" && txtMatKhau.Text == "")
            {
                MessageBox.Show("Thông tin đang trống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult = MessageBox.Show("Bạn có muốn hủy?", "Chú ý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (DialogResult == DialogResult.OK)
                {
                    txtMaNV.Text = "";
                    txtMatKhau.Text = "";
                }
            } 
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtMatKhau.Text != "")
            {
                try
                {
                    con = new SqlConnection(cnStr);
                    con.Open();
                    string sql = "Select Count(*) From [QLBanVe].[dbo].[ThongTinNhanVien] Where MaNV = @manv And MatKhau = @pass";
                    cmd = new SqlCommand(sql, con); // chay cau lenh sql
                    cmd.Parameters.Add(new SqlParameter("@manv", txtMaNV.Text));   //tham chieu toi 2 txt 
                    cmd.Parameters.Add(new SqlParameter("@pass", txtMatKhau.Text));
                    int x = (int)cmd.ExecuteScalar(); //gan x la 1 gia tri tra ve
                    if (x == 1) //Dang nhap thanh cong
                    {
                        MessageBox.Show("Đăng nhập thành công.", "Thông báo");
                        Form frm = Application.OpenForms["Chooses"]; // goi form chooses
                        if (frm == null)
                        {
                            frm = new Chooses();
                        }
                        this.Hide();
                        frm.Show();
                    }
                    else   //Dang nhap that bai
                    {
                        lbThongBao.Text = "Thông tin đăng nhập không chính xác.";
                        txtMaNV.Text = "";
                        txtMatKhau.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Thông tin chưa được nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Dang_Nhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void chbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPass.Checked)
            {
                txtMatKhau.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true; // hien thi pass
            }
        }


    }
}
