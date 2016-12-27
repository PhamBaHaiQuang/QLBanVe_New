namespace QLBanVe
{
    partial class Kiem_Tra_Dat_Ve
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.btKiemTra = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.lbThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kiểm tra thông tin khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(46, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện thoại:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(319, 156);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(220, 38);
            this.txtDienThoai.TabIndex = 0;
            this.txtDienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDienThoai_KeyPress);
            // 
            // btKiemTra
            // 
            this.btKiemTra.Location = new System.Drawing.Point(112, 260);
            this.btKiemTra.Name = "btKiemTra";
            this.btKiemTra.Size = new System.Drawing.Size(160, 45);
            this.btKiemTra.TabIndex = 1;
            this.btKiemTra.Text = "Kiểm tra";
            this.btKiemTra.UseVisualStyleBackColor = true;
            this.btKiemTra.Click += new System.EventHandler(this.btKiemTra_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(312, 260);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(160, 45);
            this.btHuy.TabIndex = 2;
            this.btHuy.Text = "Hủy";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // lbThongBao
            // 
            this.lbThongBao.ForeColor = System.Drawing.Color.Red;
            this.lbThongBao.Location = new System.Drawing.Point(49, 207);
            this.lbThongBao.Name = "lbThongBao";
            this.lbThongBao.Size = new System.Drawing.Size(487, 36);
            this.lbThongBao.TabIndex = 3;
            this.lbThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Kiem_Tra_Dat_Ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(614, 404);
            this.Controls.Add(this.lbThongBao);
            this.Controls.Add(this.btHuy);
            this.Controls.Add(this.btKiemTra);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Kiem_Tra_Dat_Ve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kiểm Tra Đặt Vé";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kiem_Tra_Dat_Ve_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Button btKiemTra;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Label lbThongBao;
    }
}