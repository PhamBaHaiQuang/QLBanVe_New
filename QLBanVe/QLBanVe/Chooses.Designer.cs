namespace QLBanVe
{
    partial class Chooses
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
            this.picOnline = new System.Windows.Forms.PictureBox();
            this.picBanVe = new System.Windows.Forms.PictureBox();
            this.btBanVe = new System.Windows.Forms.Button();
            this.btVeOnline = new System.Windows.Forms.Button();
            this.btQuayLai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanVe)).BeginInit();
            this.SuspendLayout();
            // 
            // picOnline
            // 
            this.picOnline.Image = global::QLBanVe.Properties.Resources.Ticket_2;
            this.picOnline.Location = new System.Drawing.Point(322, 196);
            this.picOnline.Name = "picOnline";
            this.picOnline.Size = new System.Drawing.Size(235, 176);
            this.picOnline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOnline.TabIndex = 14;
            this.picOnline.TabStop = false;
            // 
            // picBanVe
            // 
            this.picBanVe.Image = global::QLBanVe.Properties.Resources.Ticket_1;
            this.picBanVe.Location = new System.Drawing.Point(28, 196);
            this.picBanVe.Name = "picBanVe";
            this.picBanVe.Size = new System.Drawing.Size(260, 176);
            this.picBanVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBanVe.TabIndex = 13;
            this.picBanVe.TabStop = false;
            // 
            // btBanVe
            // 
            this.btBanVe.Location = new System.Drawing.Point(46, 414);
            this.btBanVe.Name = "btBanVe";
            this.btBanVe.Size = new System.Drawing.Size(160, 45);
            this.btBanVe.TabIndex = 15;
            this.btBanVe.Text = "Bán vé";
            this.btBanVe.UseVisualStyleBackColor = true;
            this.btBanVe.Click += new System.EventHandler(this.btBanVe_Click);
            // 
            // btVeOnline
            // 
            this.btVeOnline.Location = new System.Drawing.Point(212, 414);
            this.btVeOnline.Name = "btVeOnline";
            this.btVeOnline.Size = new System.Drawing.Size(160, 45);
            this.btVeOnline.TabIndex = 16;
            this.btVeOnline.Text = "Vé online";
            this.btVeOnline.UseVisualStyleBackColor = true;
            this.btVeOnline.Click += new System.EventHandler(this.btVeOnline_Click);
            // 
            // btQuayLai
            // 
            this.btQuayLai.Location = new System.Drawing.Point(378, 414);
            this.btQuayLai.Name = "btQuayLai";
            this.btQuayLai.Size = new System.Drawing.Size(160, 45);
            this.btQuayLai.TabIndex = 17;
            this.btQuayLai.Text = "Quay lại";
            this.btQuayLai.UseVisualStyleBackColor = true;
            this.btQuayLai.Click += new System.EventHandler(this.btQuayLai_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 50);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chúc Bạn có ngày làm việc vui vẻ!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chooses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(614, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btQuayLai);
            this.Controls.Add(this.btVeOnline);
            this.Controls.Add(this.btBanVe);
            this.Controls.Add(this.picOnline);
            this.Controls.Add(this.picBanVe);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Chooses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lựa chọn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chooses_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBanVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBanVe;
        private System.Windows.Forms.PictureBox picOnline;
        private System.Windows.Forms.Button btBanVe;
        private System.Windows.Forms.Button btVeOnline;
        private System.Windows.Forms.Button btQuayLai;
        private System.Windows.Forms.Label label1;
    }
}