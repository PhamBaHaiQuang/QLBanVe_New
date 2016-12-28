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
            Thong_Tin_Ve frm = new Thong_Tin_Ve();
            frm.Sender(cmbPhim.Text);
            frm.message(Convert.ToString(numSoVe.Value));
            frm.send(cmbSuatChieu.Text);
            frm.mess(txtViTri.Text);
            frm.Send(cmbRapChieu.Text);
            this.Hide();
            frm.Show();
        }

        SqlConnection cn;
        string cnStr;

        private void Quan_Ly_Ban_Ve_Load(object sender, EventArgs e)
        {
            Phim();
            SuatChieu();
            RapChieu();
        }

        private void SuatChieu() //Load suat chieu len form
        {
            cmbSuatChieu.Text = "Chọn suất chiếu";
            cnStr = @"Data Source = .; Initial Catalog = QLBanVe; Integrated Security = True";
            try
            {
                cn = new SqlConnection(cnStr);
                cn.Open();
                string suat = "SELECT DISTINCT SuatChieu FROM ThongTinPhim ORDER BY SuatChieu ASC";
                SqlDataReader dt = new SqlCommand(suat, cn).ExecuteReader();
                while (dt.Read())
                {
                    cmbSuatChieu.Items.Add(dt.GetValue(0).ToString());
                }
                dt.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Phim() //Load phim len form
        {
            cmbPhim.Text = "Chọn phim";
            cnStr = @"Data Source = .; Initial Catalog = QLBanVe; Integrated Security = True";
            try
            {
                cn = new SqlConnection(cnStr);
                cn.Open();
                string phim = "SELECT TenPhim FROM Phim";
                SqlDataReader dr = new SqlCommand(phim, cn).ExecuteReader();
                while (dr.Read())
                {
                    cmbPhim.Items.Add(dr.GetValue(0).ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RapChieu() //Load du lieu cua rap chieu len form
        {
            cmbRapChieu.Text = "Chọn rạp chiếu";
            cnStr = @"Data Source = .; Initial Catalog = QLBanVe; Integrated Security = True";
            try
            {
                cn = new SqlConnection(cnStr);
                cn.Open();
                string rap = "SELECT DISTINCT RapChieu FROM ThongTinPhim ORDER BY RapChieu ASC";
                SqlDataReader ds = new SqlCommand(rap, cn).ExecuteReader();
                while (ds.Read())
                {
                    cmbRapChieu.Items.Add(ds.GetValue(0).ToString());
                }
                ds.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            string cnStr;
            SqlConnection cn;
            cnStr = @"Data Source = .; Initial Catalog = QLBanVe; Integrated Security = True";
            cn = new SqlConnection(cnStr);
            cn.Open();
            string query = "SELECT MaThe FROM TheKhachHang";
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    if (txtMaThe.Text == dr[0].ToString() && txtMaThe.Text != "")
                    {
                        MessageBox.Show("Mã thẻ chính xác.", "Thông báo.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                if (cn != null)
                {
                    cn.Close();
                }
            }
        }
    }
}
