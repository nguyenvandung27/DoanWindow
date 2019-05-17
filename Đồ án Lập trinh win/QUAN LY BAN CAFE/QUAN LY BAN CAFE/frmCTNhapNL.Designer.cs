namespace QUAN_LY_BAN_CAFE
{
    partial class frmCTNhapNL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTNhapNL));
            this.label6 = new System.Windows.Forms.Label();
            this.dgCTNhapNL = new System.Windows.Forms.DataGridView();
            this.clMaPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMaNL = new System.Windows.Forms.ComboBox();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.tbnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCTNhapNL)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 28);
            this.label6.TabIndex = 27;
            this.label6.Text = "CHI TIẾT NHẬP NGUYÊN LIỆU";
            // 
            // dgCTNhapNL
            // 
            this.dgCTNhapNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCTNhapNL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaPhieuNhap,
            this.clMaNguyenLieu,
            this.clTenNguyenLieu,
            this.clSoLuong,
            this.clDonViTinh,
            this.clDonGia,
            this.clThanhTien});
            this.dgCTNhapNL.Location = new System.Drawing.Point(249, 493);
            this.dgCTNhapNL.Name = "dgCTNhapNL";
            this.dgCTNhapNL.Size = new System.Drawing.Size(827, 139);
            this.dgCTNhapNL.TabIndex = 26;
            this.dgCTNhapNL.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCTNhapNL_RowEnter);
            // 
            // clMaPhieuNhap
            // 
            this.clMaPhieuNhap.DataPropertyName = "MaPhieuNhap";
            this.clMaPhieuNhap.HeaderText = "Mã Phiếu Nhập";
            this.clMaPhieuNhap.Name = "clMaPhieuNhap";
            this.clMaPhieuNhap.Width = 120;
            // 
            // clMaNguyenLieu
            // 
            this.clMaNguyenLieu.DataPropertyName = "MaNL";
            this.clMaNguyenLieu.HeaderText = "Mã Nguyên Liệu";
            this.clMaNguyenLieu.Name = "clMaNguyenLieu";
            this.clMaNguyenLieu.Width = 120;
            // 
            // clTenNguyenLieu
            // 
            this.clTenNguyenLieu.DataPropertyName = "TenNL";
            this.clTenNguyenLieu.HeaderText = "Tên Nguyên Liệu";
            this.clTenNguyenLieu.Name = "clTenNguyenLieu";
            this.clTenNguyenLieu.Width = 250;
            // 
            // clSoLuong
            // 
            this.clSoLuong.DataPropertyName = "SoLuong";
            this.clSoLuong.HeaderText = "Số Lượng";
            this.clSoLuong.Name = "clSoLuong";
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.DataPropertyName = "DonViTinh";
            this.clDonViTinh.HeaderText = "Đơn Vị Tính";
            this.clDonViTinh.Name = "clDonViTinh";
            // 
            // clDonGia
            // 
            this.clDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.clDonGia.DefaultCellStyle = dataGridViewCellStyle3;
            this.clDonGia.HeaderText = "Đơn Giá";
            this.clDonGia.Name = "clDonGia";
            // 
            // clThanhTien
            // 
            this.clThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Format = "C0";
            dataGridViewCellStyle4.NullValue = null;
            this.clThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            this.clThanhTien.HeaderText = "Thành Tiền";
            this.clThanhTien.Name = "clThanhTien";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPN);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbMaNL);
            this.groupBox1.Controls.Add(this.txtDonViTinh);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.txtTenNL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(249, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 188);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin:";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPN.Location = new System.Drawing.Point(179, 32);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(221, 22);
            this.txtMaPN.TabIndex = 13;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(568, 141);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(221, 22);
            this.txtDonGia.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(457, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Đơn Giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mã Phiếu Nhập:";
            // 
            // cbMaNL
            // 
            this.cbMaNL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNL.FormattingEnabled = true;
            this.cbMaNL.Location = new System.Drawing.Point(179, 84);
            this.cbMaNL.Name = "cbMaNL";
            this.cbMaNL.Size = new System.Drawing.Size(221, 24);
            this.cbMaNL.TabIndex = 8;
            this.cbMaNL.SelectedIndexChanged += new System.EventHandler(this.cbMaNL_SelectedIndexChanged);
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(568, 85);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(221, 22);
            this.txtDonViTinh.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(568, 30);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(221, 22);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNL.Location = new System.Drawing.Point(179, 141);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(221, 22);
            this.txtTenNL.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(457, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn Vị Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(457, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Nguyên Liệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nguyên Liệu:";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(477, 429);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 40);
            this.btnXoa.TabIndex = 29;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1345, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Gainsboro;
            this.btnHuy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(953, 429);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(123, 40);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "THOÁT";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(710, 429);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(123, 40);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tbnThem
            // 
            this.tbnThem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnThem.Image = ((System.Drawing.Image)(resources.GetObject("tbnThem.Image")));
            this.tbnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbnThem.Location = new System.Drawing.Point(249, 429);
            this.tbnThem.Name = "tbnThem";
            this.tbnThem.Size = new System.Drawing.Size(123, 40);
            this.tbnThem.TabIndex = 23;
            this.tbnThem.Text = "THÊM";
            this.tbnThem.UseVisualStyleBackColor = true;
            this.tbnThem.Click += new System.EventHandler(this.tbnThem_Click);
            // 
            // frmCTNhapNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1345, 651);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgCTNhapNL);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCTNhapNL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết nhập nguyên liệu";
            ((System.ComponentModel.ISupportInitialize)(this.dgCTNhapNL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgCTNhapNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clThanhTien;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button tbnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMaNL;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}