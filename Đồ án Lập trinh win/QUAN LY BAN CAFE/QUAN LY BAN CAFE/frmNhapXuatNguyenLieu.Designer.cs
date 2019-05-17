namespace QUAN_LY_BAN_CAFE
{
    partial class frmNhapXuatNguyenLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapXuatNguyenLieu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbXuatNL = new System.Windows.Forms.GroupBox();
            this.dtNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPhieuXuat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnNhapChiTiet = new System.Windows.Forms.Button();
            this.gbNhapNL = new System.Windows.Forms.GroupBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHinhThuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbXuatNL.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbNhapNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1235, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // gbXuatNL
            // 
            this.gbXuatNL.Controls.Add(this.dtNgayXuat);
            this.gbXuatNL.Controls.Add(this.label5);
            this.gbXuatNL.Controls.Add(this.txtMaPhieuXuat);
            this.gbXuatNL.Controls.Add(this.label6);
            this.gbXuatNL.Location = new System.Drawing.Point(376, 251);
            this.gbXuatNL.Name = "gbXuatNL";
            this.gbXuatNL.Size = new System.Drawing.Size(472, 150);
            this.gbXuatNL.TabIndex = 10;
            this.gbXuatNL.TabStop = false;
            this.gbXuatNL.Text = "Xuất Nguyên Liệu";
            this.gbXuatNL.Visible = false;
            // 
            // dtNgayXuat
            // 
            this.dtNgayXuat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayXuat.Location = new System.Drawing.Point(195, 87);
            this.dtNgayXuat.Name = "dtNgayXuat";
            this.dtNgayXuat.Size = new System.Drawing.Size(200, 22);
            this.dtNgayXuat.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ngày Xuất:";
            // 
            // txtMaPhieuXuat
            // 
            this.txtMaPhieuXuat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuXuat.Location = new System.Drawing.Point(195, 30);
            this.txtMaPhieuXuat.Name = "txtMaPhieuXuat";
            this.txtMaPhieuXuat.Size = new System.Drawing.Size(200, 26);
            this.txtMaPhieuXuat.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Phiếu Xuất:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnNhapChiTiet);
            this.groupBox1.Location = new System.Drawing.Point(289, 437);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(642, 87);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(477, 25);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 46);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(259, 25);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 46);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnNhapChiTiet
            // 
            this.btnNhapChiTiet.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapChiTiet.Image")));
            this.btnNhapChiTiet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapChiTiet.Location = new System.Drawing.Point(34, 25);
            this.btnNhapChiTiet.Name = "btnNhapChiTiet";
            this.btnNhapChiTiet.Size = new System.Drawing.Size(123, 46);
            this.btnNhapChiTiet.TabIndex = 0;
            this.btnNhapChiTiet.Text = "CHI TIẾT";
            this.btnNhapChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapChiTiet.UseVisualStyleBackColor = true;
            this.btnNhapChiTiet.Click += new System.EventHandler(this.btnNhapChiTiet_Click);
            // 
            // gbNhapNL
            // 
            this.gbNhapNL.Controls.Add(this.dtNgayNhap);
            this.gbNhapNL.Controls.Add(this.label4);
            this.gbNhapNL.Controls.Add(this.txtMaPhieuNhap);
            this.gbNhapNL.Controls.Add(this.label3);
            this.gbNhapNL.Location = new System.Drawing.Point(376, 251);
            this.gbNhapNL.Name = "gbNhapNL";
            this.gbNhapNL.Size = new System.Drawing.Size(472, 150);
            this.gbNhapNL.TabIndex = 9;
            this.gbNhapNL.TabStop = false;
            this.gbNhapNL.Text = "Nhập Nguyên Liệu";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayNhap.Location = new System.Drawing.Point(195, 87);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(200, 22);
            this.dtNgayNhap.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Nhập:";
            // 
            // txtMaPhieuNhap
            // 
            this.txtMaPhieuNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPhieuNhap.Location = new System.Drawing.Point(195, 30);
            this.txtMaPhieuNhap.Name = "txtMaPhieuNhap";
            this.txtMaPhieuNhap.Size = new System.Drawing.Size(200, 26);
            this.txtMaPhieuNhap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Phiếu Nhập:";
            // 
            // cbHinhThuc
            // 
            this.cbHinhThuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHinhThuc.FormattingEnabled = true;
            this.cbHinhThuc.Items.AddRange(new object[] {
            "Nhập Nguyên Liệu",
            "Xuất Nguyên Liệu"});
            this.cbHinhThuc.Location = new System.Drawing.Point(571, 164);
            this.cbHinhThuc.Name = "cbHinhThuc";
            this.cbHinhThuc.Size = new System.Drawing.Size(200, 26);
            this.cbHinhThuc.TabIndex = 8;
            this.cbHinhThuc.Text = "Nhập Nguyên Liệu";
            this.cbHinhThuc.SelectedIndexChanged += new System.EventHandler(this.cbHinhThuc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chọn hình thức:";
            // 
            // frmNhapXuatNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1235, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbXuatNL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbNhapNL);
            this.Controls.Add(this.cbHinhThuc);
            this.Controls.Add(this.label2);
            this.Name = "frmNhapXuatNguyenLieu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập và Xuất nguyên liệu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbXuatNL.ResumeLayout(false);
            this.gbXuatNL.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbNhapNL.ResumeLayout(false);
            this.gbNhapNL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbXuatNL;
        private System.Windows.Forms.DateTimePicker dtNgayXuat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaPhieuXuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnNhapChiTiet;
        private System.Windows.Forms.GroupBox gbNhapNL;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHinhThuc;
        private System.Windows.Forms.Label label2;
    }
}