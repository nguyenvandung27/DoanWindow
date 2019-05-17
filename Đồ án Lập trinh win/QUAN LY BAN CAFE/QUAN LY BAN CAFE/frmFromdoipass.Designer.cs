namespace QUAN_LY_BAN_CAFE
{
    partial class frmFromdoipass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFromdoipass));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDoiPass = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaUser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1093, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "Lưu ý: Mật khẩu không được quá 10 ký tự.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDoiPass);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Location = new System.Drawing.Point(153, 441);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(787, 121);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btnDoiPass
            // 
            this.btnDoiPass.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiPass.Image")));
            this.btnDoiPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiPass.Location = new System.Drawing.Point(40, 36);
            this.btnDoiPass.Name = "btnDoiPass";
            this.btnDoiPass.Size = new System.Drawing.Size(222, 51);
            this.btnDoiPass.TabIndex = 4;
            this.btnDoiPass.Text = "ĐỔI MẬT KHẨU";
            this.btnDoiPass.UseVisualStyleBackColor = true;
            this.btnDoiPass.Click += new System.EventHandler(this.btnDoiPass_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(571, 36);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(194, 51);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(317, 36);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(218, 51);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaUser);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNhapLai);
            this.groupBox1.Controls.Add(this.txtMatKhauMoi);
            this.groupBox1.Controls.Add(this.txtMatKhauCu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(351, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 227);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin:";
            // 
            // txtMaUser
            // 
            this.txtMaUser.Location = new System.Drawing.Point(190, 31);
            this.txtMaUser.Name = "txtMaUser";
            this.txtMaUser.Size = new System.Drawing.Size(192, 20);
            this.txtMaUser.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên Tài khoản";
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.Location = new System.Drawing.Point(190, 183);
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.PasswordChar = '*';
            this.txtNhapLai.Size = new System.Drawing.Size(192, 20);
            this.txtNhapLai.TabIndex = 7;
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(190, 133);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(192, 20);
            this.txtMatKhauMoi.TabIndex = 6;
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(190, 83);
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.PasswordChar = '*';
            this.txtMatKhauCu.Size = new System.Drawing.Size(192, 20);
            this.txtMatKhauCu.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập lại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu cũ:";
            // 
            // frmFromdoipass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1093, 566);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmFromdoipass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDoiPass;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaUser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}