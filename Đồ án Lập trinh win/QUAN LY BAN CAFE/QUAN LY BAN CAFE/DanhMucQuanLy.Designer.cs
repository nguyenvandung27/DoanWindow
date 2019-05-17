namespace QUAN_LY_BAN_CAFE
{
    partial class DanhMucQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhMucQuanLy));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.btnNguyenLieu = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(913, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnBaoCao);
            this.groupBox1.Controls.Add(this.btnNguyenLieu);
            this.groupBox1.Controls.Add(this.btnNhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(58, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 126);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn danh mục:";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(613, 47);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(133, 49);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Image = ((System.Drawing.Image)(resources.GetObject("btnBaoCao.Image")));
            this.btnBaoCao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaoCao.Location = new System.Drawing.Point(427, 47);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(133, 49);
            this.btnBaoCao.TabIndex = 2;
            this.btnBaoCao.Text = "BÁO CÁO";
            this.btnBaoCao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaoCao.UseVisualStyleBackColor = true;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // btnNguyenLieu
            // 
            this.btnNguyenLieu.Image = ((System.Drawing.Image)(resources.GetObject("btnNguyenLieu.Image")));
            this.btnNguyenLieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNguyenLieu.Location = new System.Drawing.Point(217, 47);
            this.btnNguyenLieu.Name = "btnNguyenLieu";
            this.btnNguyenLieu.Size = new System.Drawing.Size(161, 49);
            this.btnNguyenLieu.TabIndex = 1;
            this.btnNguyenLieu.Text = "NGUYÊN LIỆU";
            this.btnNguyenLieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNguyenLieu.UseVisualStyleBackColor = true;
            this.btnNguyenLieu.Click += new System.EventHandler(this.btnNguyenLieu_Click);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Image")));
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(37, 47);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(133, 49);
            this.btnNhanVien.TabIndex = 0;
            this.btnNhanVien.Text = "NHÂN VIÊN";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "DANH MỤC QUẢN LÝ";
            // 
            // DanhMucQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(917, 498);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Name = "DanhMucQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục bạn quản lí";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DanhMucQuanLy_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DanhMucQuanLy_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.Button btnNguyenLieu;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Label label2;
    }
}