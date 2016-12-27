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
    public partial class Thong_Tin_Ve : Form
    {
        //Khai báo delegate
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        public SendMessage mess;
        public SendMessage send;
        public SendMessage Send;
        public SendMessage message;

        public Thong_Tin_Ve()
        {
            InitializeComponent();
            //Tạo con trỏ tới các hàm
            Sender = new SendMessage(Phim);
            send = new SendMessage(Suat);
            mess = new SendMessage(ViTri);
            Send = new SendMessage(Rap);
            message = new SendMessage(Ve);
        }

        //Hàm có nhiệm vụ lấy tham số truyền vào
        private void Phim(string Message)
        {
            lbPhim.Text = Message;
        }
        private void Ve(string Message)
        {
            lbSoVe.Text = Message;        
        }

        private void Suat(string Message)
        {
            lbSuatChieu.Text = Message;
        }

        private void ViTri(string Message)
        {
            lbViTri.Text = Message;
        }

        private void Rap(string Message)
        {
            lbRapChieu.Text = Message;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms["Chooses"];
            if (frm == null)
            {
                frm = new Chooses();
                MessageBox.Show("Bạn đã giao dịch thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Hide();
            frm.Show();
        }

        private void Thong_Tin_Ve_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
