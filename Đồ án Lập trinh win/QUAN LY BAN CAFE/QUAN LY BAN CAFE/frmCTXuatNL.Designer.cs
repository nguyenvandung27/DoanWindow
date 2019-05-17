namespace QUAN_LY_BAN_CAFE
{
    partial class frmCTXuatNL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTXuatNL));
            this.label6 = new System.Windows.Forms.Label();
            this.dgCTXuatNL = new System.Windows.Forms.DataGridView();
            this.clMaPhieuXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPX = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgCTXuatNL)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(352, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "CHI TIẾT XUẤT NGUYÊN LIỆU";
            // 
            // dgCTXuatNL
            // 
            this.dgCTXuatNL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCTXuatNL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaPhieuXuat,
            this.clMaNguyenLieu,
            this.clTenNguyenLieu,
            this.clSoLuong,
            this.clDonViTinh});
            this.dgCTXuatNL.Location = new System.Drawing.Point(262, 443);
            this.dgCTXuatNL.Name = "dgCTXuatNL";
            this.dgCTXuatNL.Size = new System.Drawing.Size(827, 139);
            this.dgCTXuatNL.TabIndex = 25;
            this.dgCTXuatNL.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCTXuatNL_RowEnter);
            // 
            // clMaPhieuXuat
            // 
            this.clMaPhieuXuat.DataPropertyName = "MaPhieuXuat";
            this.clMaPhieuXuat.HeaderText = "Mã Phiếu Xuất";
            this.clMaPhieuXuat.Name = "clMaPhieuXuat";
            this.clMaPhieuXuat.Width = 150;
            // 
            // clMaNguyenLieu
            // 
            this.clMaNguyenLieu.DataPropertyName = "MaNL";
            this.clMaNguyenLieu.HeaderText = "Mã Nguyên Liệu";
            this.clMaNguyenLieu.Name = "clMaNguyenLieu";
            this.clMaNguyenLieu.Width = 150;
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
            this.clSoLuong.Width = 120;
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.DataPropertyName = "DonViTinh";
            this.clDonViTinh.HeaderText = "Đơn Vị Tính";
            this.clDonViTinh.Name = "clDonViTinh";
            this.clDonViTinh.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPX);
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
            this.groupBox1.Location = new System.Drawing.Point(262, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 153);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Thông Tin:";
            // 
            // txtMaPX
            // 
            this.txtMaPX.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPX.Location = new System.Drawing.Point(183, 27);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(221, 22);
            this.txtMaPX.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mã Phiếu Xuất:";
            // 
            // cbMaNL
            // 
            this.cbMaNL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNL.FormattingEnabled = true;
            this.cbMaNL.Location = new System.Drawing.Point(183, 71);
            this.cbMaNL.Name = "cbMaNL";
            this.cbMaNL.Size = new System.Drawing.Size(221, 24);
            this.cbMaNL.TabIndex = 8;
            this.cbMaNL.SelectedIndexChanged += new System.EventHandler(this.cbMaNL_SelectedIndexChanged);
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(562, 69);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(221, 22);
            this.txtDonViTinh.TabIndex = 7;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(562, 27);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(221, 22);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNL.Location = new System.Drawing.Point(183, 115);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(221, 22);
            this.txtTenNL.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(436, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn Vị Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(436, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số Lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Nguyên Liệu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 71);
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
            this.btnXoa.Location = new System.Drawing.Point(490, 386);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 40);
            this.btnXoa.TabIndex = 28;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1368, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(966, 386);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(123, 40);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "THOÁT";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(734, 386);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(123, 40);
            this.btnLuu.TabIndex = 23;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tbnThem
            // 
            this.tbnThem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnThem.Image = ((System.Drawing.Image)(resources.GetObject("tbnThem.Image")));
            this.tbnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbnThem.Location = new System.Drawing.Point(262, 386);
            this.tbnThem.Name = "tbnThem";
            this.tbnThem.Size = new System.Drawing.Size(123, 40);
            this.tbnThem.TabIndex = 22;
            this.tbnThem.Text = "THÊM";
            this.tbnThem.UseVisualStyleBackColor = true;
            this.tbnThem.Click += new System.EventHandler(this.tbnThem_Click);
            // 
            // frmCTXuatNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1366, 602);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgCTXuatNL);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbnThem);
            this.Name = "frmCTXuatNL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết xuất nguyên liệu";
            this.Load += new System.EventHandler(this.frmCTXuatNL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCTXuatNL)).EndInit();
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
        private System.Windows.Forms.DataGridView dgCTXuatNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonViTinh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaPX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMaNL;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tbnThem;
    }
}