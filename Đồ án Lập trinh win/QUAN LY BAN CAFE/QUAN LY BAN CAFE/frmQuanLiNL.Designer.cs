namespace QUAN_LY_BAN_CAFE
{
    partial class frmQuanLiNL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiNL));
            this.dgNguyenLieu = new System.Windows.Forms.DataGridView();
            this.clMaNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSoLuongCon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemDVT = new System.Windows.Forms.Button();
            this.cbDVT = new System.Windows.Forms.ComboBox();
            this.txtSoLuongCon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtTenNL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgNguyenLieu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNguyenLieu
            // 
            this.dgNguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMaNL,
            this.clTenNL,
            this.clDonGia,
            this.clDonViTinh,
            this.clSoLuongCon});
            this.dgNguyenLieu.Location = new System.Drawing.Point(171, 412);
            this.dgNguyenLieu.Name = "dgNguyenLieu";
            this.dgNguyenLieu.Size = new System.Drawing.Size(893, 217);
            this.dgNguyenLieu.TabIndex = 27;
            this.dgNguyenLieu.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNguyenLieu_RowEnter);
            // 
            // clMaNL
            // 
            this.clMaNL.DataPropertyName = "MaNL";
            this.clMaNL.HeaderText = "Mã Nguyên Liệu";
            this.clMaNL.Name = "clMaNL";
            this.clMaNL.Width = 150;
            // 
            // clTenNL
            // 
            this.clTenNL.DataPropertyName = "TenNL";
            this.clTenNL.HeaderText = "Tên Nguyên Liệu";
            this.clTenNL.Name = "clTenNL";
            this.clTenNL.Width = 250;
            // 
            // clDonGia
            // 
            this.clDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.clDonGia.DefaultCellStyle = dataGridViewCellStyle1;
            this.clDonGia.HeaderText = "Đơn Giá";
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.Width = 150;
            // 
            // clDonViTinh
            // 
            this.clDonViTinh.DataPropertyName = "DonViTinh";
            this.clDonViTinh.HeaderText = "Đơn Vị Tính";
            this.clDonViTinh.Name = "clDonViTinh";
            this.clDonViTinh.Width = 150;
            // 
            // clSoLuongCon
            // 
            this.clSoLuongCon.DataPropertyName = "SoLuongCon";
            this.clSoLuongCon.HeaderText = "Số Lượng Còn";
            this.clSoLuongCon.Name = "clSoLuongCon";
            this.clSoLuongCon.Width = 150;
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(905, 338);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(143, 37);
            this.btnHuy.TabIndex = 26;
            this.btnHuy.Text = "THOÁT";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(724, 338);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(135, 37);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(560, 338);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 37);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(405, 338);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(115, 37);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(239, 338);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 37);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemDVT);
            this.groupBox1.Controls.Add(this.cbDVT);
            this.groupBox1.Controls.Add(this.txtSoLuongCon);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.txtTenNL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaNL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(171, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 188);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // btnThemDVT
            // 
            this.btnThemDVT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDVT.Location = new System.Drawing.Point(808, 24);
            this.btnThemDVT.Name = "btnThemDVT";
            this.btnThemDVT.Size = new System.Drawing.Size(44, 24);
            this.btnThemDVT.TabIndex = 11;
            this.btnThemDVT.Text = "...";
            this.btnThemDVT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemDVT.UseVisualStyleBackColor = true;
            this.btnThemDVT.Click += new System.EventHandler(this.btnThemDVT_Click);
            // 
            // cbDVT
            // 
            this.cbDVT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDVT.FormattingEnabled = true;
            this.cbDVT.Items.AddRange(new object[] {
            "Chai",
            "Kg",
            "G",
            "Lon",
            "Hộp",
            "Gói"});
            this.cbDVT.Location = new System.Drawing.Point(595, 24);
            this.cbDVT.Name = "cbDVT";
            this.cbDVT.Size = new System.Drawing.Size(207, 26);
            this.cbDVT.TabIndex = 10;
            // 
            // txtSoLuongCon
            // 
            this.txtSoLuongCon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongCon.Location = new System.Drawing.Point(595, 79);
            this.txtSoLuongCon.Name = "txtSoLuongCon";
            this.txtSoLuongCon.Size = new System.Drawing.Size(207, 26);
            this.txtSoLuongCon.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số Lượng Còn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn Vị Tính:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(193, 138);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(207, 26);
            this.txtDonGia.TabIndex = 5;
            // 
            // txtTenNL
            // 
            this.txtTenNL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNL.Location = new System.Drawing.Point(193, 83);
            this.txtTenNL.Name = "txtTenNL";
            this.txtTenNL.Size = new System.Drawing.Size(207, 26);
            this.txtTenNL.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đơn Giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nguyên Liệu:";
            // 
            // txtMaNL
            // 
            this.txtMaNL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNL.Location = new System.Drawing.Point(193, 24);
            this.txtMaNL.Name = "txtMaNL";
            this.txtMaNL.Size = new System.Drawing.Size(207, 26);
            this.txtMaNL.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nguyên Liệu:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1189, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuanLiNL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1189, 641);
            this.Controls.Add(this.dgNguyenLieu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmQuanLiNL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí nguyên liệu";
            this.Load += new System.EventHandler(this.frmQuanLiNL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNguyenLieu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSoLuongCon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemDVT;
        private System.Windows.Forms.ComboBox cbDVT;
        private System.Windows.Forms.TextBox txtSoLuongCon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtTenNL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}