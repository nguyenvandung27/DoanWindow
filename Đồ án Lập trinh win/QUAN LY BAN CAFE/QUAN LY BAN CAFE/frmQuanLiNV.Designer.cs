namespace QUAN_LY_BAN_CAFE
{
    partial class frmQuanLiNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiNV));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.dgNhanVien = new System.Windows.Forms.DataGridView();
            this.clMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTrinhDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoCM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1226, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangLuong.Image = ((System.Drawing.Image)(resources.GetObject("btnBangLuong.Image")));
            this.btnBangLuong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBangLuong.Location = new System.Drawing.Point(792, 627);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Size = new System.Drawing.Size(207, 40);
            this.btnBangLuong.TabIndex = 29;
            this.btnBangLuong.Text = "XEM BẢNG LƯƠNG";
            this.btnBangLuong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBangLuong.UseVisualStyleBackColor = true;
            this.btnBangLuong.Click += new System.EventHandler(this.btnBangLuong_Click);
            // 
            // dgNhanVien
            // 
            this.dgNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaNV,
            this.clTenNV,
            this.clNgaySinh,
            this.clGioiTinh,
            this.clTrinhDo,
            this.clChucVu,
            this.clSoCMND,
            this.clDiaChi});
            this.dgNhanVien.Location = new System.Drawing.Point(218, 440);
            this.dgNhanVien.Name = "dgNhanVien";
            this.dgNhanVien.Size = new System.Drawing.Size(786, 170);
            this.dgNhanVien.TabIndex = 28;
            // 
            // clMaNV
            // 
            this.clMaNV.DataPropertyName = "MaNV";
            this.clMaNV.HeaderText = "Mã Nhân Viên";
            this.clMaNV.Name = "clMaNV";
            // 
            // clTenNV
            // 
            this.clTenNV.DataPropertyName = "TenNV";
            this.clTenNV.HeaderText = "Tên Nhân Viên";
            this.clTenNV.Name = "clTenNV";
            this.clTenNV.Width = 200;
            // 
            // clNgaySinh
            // 
            this.clNgaySinh.DataPropertyName = "NgaySinh";
            this.clNgaySinh.HeaderText = "Ngày Sinh";
            this.clNgaySinh.Name = "clNgaySinh";
            this.clNgaySinh.Width = 150;
            // 
            // clGioiTinh
            // 
            this.clGioiTinh.DataPropertyName = "GioiTinh";
            this.clGioiTinh.HeaderText = "Giới Tính";
            this.clGioiTinh.Name = "clGioiTinh";
            // 
            // clTrinhDo
            // 
            this.clTrinhDo.DataPropertyName = "TrinhDoHocVan";
            this.clTrinhDo.HeaderText = "Trình Độ Học Vấn";
            this.clTrinhDo.Name = "clTrinhDo";
            // 
            // clChucVu
            // 
            this.clChucVu.DataPropertyName = "ChucVu";
            this.clChucVu.HeaderText = "Chức Vụ";
            this.clChucVu.Name = "clChucVu";
            this.clChucVu.Width = 150;
            // 
            // clSoCMND
            // 
            this.clSoCMND.DataPropertyName = "SoCMND";
            this.clSoCMND.HeaderText = "Số CMND";
            this.clSoCMND.Name = "clSoCMND";
            this.clSoCMND.Width = 150;
            // 
            // clDiaChi
            // 
            this.clDiaChi.DataPropertyName = "DiaChi";
            this.clDiaChi.HeaderText = "Địa Chỉ";
            this.clDiaChi.Name = "clDiaChi";
            this.clDiaChi.Width = 200;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(218, 627);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(192, 40);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "THOÁT";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(876, 381);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(123, 40);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(650, 381);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 40);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(428, 381);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(123, 40);
            this.btnSua.TabIndex = 24;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(218, 381);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 40);
            this.btnThem.TabIndex = 23;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbChucVu);
            this.groupBox1.Controls.Add(this.cbGioiTinh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtNgaySinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTrinhDo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoCM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(218, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 191);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // cbChucVu
            // 
            this.cbChucVu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Items.AddRange(new object[] {
            "Quản Lý",
            "Pha Chế",
            "Thu Ngân",
            "Phục Vụ",
            "Tạp Vụ",
            "Giữ Xe"});
            this.cbChucVu.Location = new System.Drawing.Point(564, 58);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(207, 26);
            this.cbChucVu.TabIndex = 17;
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(169, 150);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(207, 26);
            this.cbGioiTinh.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Giới Tính:";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaySinh.Location = new System.Drawing.Point(169, 102);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(207, 26);
            this.dtNgaySinh.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(409, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Trình Độ Học Vấn:";
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrinhDo.Location = new System.Drawing.Point(564, 12);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(207, 26);
            this.txtTrinhDo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Ngày Sinh:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(564, 150);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(207, 26);
            this.txtDiaChi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Địa Chỉ:";
            // 
            // txtSoCM
            // 
            this.txtSoCM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoCM.Location = new System.Drawing.Point(564, 103);
            this.txtSoCM.Name = "txtSoCM";
            this.txtSoCM.Size = new System.Drawing.Size(207, 26);
            this.txtSoCM.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số CMND:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(169, 12);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(207, 26);
            this.txtMaNV.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(472, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chức Vụ:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(169, 57);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(207, 26);
            this.txtTenNV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Nhân Viên:";
            // 
            // frmQuanLiNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1223, 695);
            this.Controls.Add(this.btnBangLuong);
            this.Controls.Add(this.dgNhanVien);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmQuanLiNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nhân viên";
            this.Load += new System.EventHandler(this.frmQuanLiNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanVien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.DataGridView dgNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDiaChi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoCM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}