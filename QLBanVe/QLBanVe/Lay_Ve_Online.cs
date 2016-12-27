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

        public Lay_Ve_Online()
        {
            InitializeComponent();
            //Tạo con trỏ tới các hàm
            
        }

        //Hàm có nhiệm vụ lấy tham số truyền vào
        

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

        } 
    }
}
