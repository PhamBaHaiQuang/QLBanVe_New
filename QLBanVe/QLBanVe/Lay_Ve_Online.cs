using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLBanVe
{
    public partial class Lay_Ve_Online : Form
    {
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        string cnStr = "";
        DataSet ds;
        SqlConnection cn;
        public Lay_Ve_Online()
        {
            InitializeComponent();
            //Tạo con trỏ tới các hàm
            Sender = new SendMessage(DienThoai);
        }
        //Hàm có nhiệm vụ lấy tham số truyền vào
        public void DienThoai(string Message)
        {
            lbDienThoai.Text = Message;
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

        private void btLayVe_Click(object sender, EventArgs e)
        {
            Thong_Tin_Ve frm = new Thong_Tin_Ve();
            frm.Sender(lbPhim.Text);
            frm.Send(lbSoVe.Text);
            frm.send(lbHangGhe.Text);
            frm.mess(lbSuatChieu.Text);
            frm.message(lbRapChieu.Text);
            this.Hide();
            frm.Show();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["Chooses"];
            if (frm == null)
            {
                frm = new Chooses();
            }
            this.Hide();
            frm.Show();
        }

        private void Lay_Ve_Online_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Lay_Ve_Online_Load(object sender, EventArgs e)
        {
            cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            cn = new SqlConnection(cnStr);
            string sql = "SELECT KH.HoKH, KH.TenKH, DK.TenPhim, DK.ViTri, DK.RapChieu, DK.SoLuong, DK.SuatChieu, DK.Gia FROM KhachHang KH, DangKyOnline DK WHERE KH.DienThoai = DK.DienThoai AND DK.DienThoai = " + lbDienThoai.Text;
            dgvLayVe.DataSource = GetHoaDon(sql).Tables[0];
            lbHo.Text = dgvLayVe.Rows[0].Cells[0].Value.ToString();
            lbTen.Text = dgvLayVe.Rows[0].Cells[1].Value.ToString();
            lbPhim.Text = dgvLayVe.Rows[0].Cells[2].Value.ToString();
            lbSoVe.Text = dgvLayVe.Rows[0].Cells[3].Value.ToString();
            lbSuatChieu.Text = dgvLayVe.Rows[0].Cells[4].Value.ToString();
            lbHangGhe.Text = dgvLayVe.Rows[0].Cells[5].Value.ToString(); ;
            lbRapChieu.Text = dgvLayVe.Rows[0].Cells[6].Value.ToString();
            dgvLayVe.Hide();
        }
        public DataSet GetHoaDon(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cn);
                ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                cn.Close();
            }

        }

        
    }
}
