namespace QUAN_LY_BAN_CAFE
{
    partial class frmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCao));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.gbHinhThuc = new System.Windows.Forms.GroupBox();
            this.rdBanChonNhieu = new System.Windows.Forms.RadioButton();
            this.rdSLMonBan = new System.Windows.Forms.RadioButton();
            this.rdDoanhThu = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbHinhThuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 36);
            this.label1.TabIndex = 15;
            this.label1.Text = "DANH MỤC XEM BÁO CÁO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Location = new System.Drawing.Point(306, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 72);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(376, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "THOÁT";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Image = ((System.Drawing.Image)(resources.GetObject("btnXem.Image")));
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(60, 18);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(92, 40);
            this.btnXem.TabIndex = 0;
            this.btnXem.Text = "XEM";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // gbHinhThuc
            // 
            this.gbHinhThuc.Controls.Add(this.rdBanChonNhieu);
            this.gbHinhThuc.Controls.Add(this.rdSLMonBan);
            this.gbHinhThuc.Controls.Add(this.rdDoanhThu);
            this.gbHinhThuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHinhThuc.Location = new System.Drawing.Point(306, 240);
            this.gbHinhThuc.Name = "gbHinhThuc";
            this.gbHinhThuc.Size = new System.Drawing.Size(531, 191);
            this.gbHinhThuc.TabIndex = 13;
            this.gbHinhThuc.TabStop = false;
            this.gbHinhThuc.Text = "Chọn Hình Thức:";
            // 
            // rdBanChonNhieu
            // 
            this.rdBanChonNhieu.AutoSize = true;
            this.rdBanChonNhieu.Location = new System.Drawing.Point(48, 139);
            this.rdBanChonNhieu.Name = "rdBanChonNhieu";
            this.rdBanChonNhieu.Size = new System.Drawing.Size(201, 23);
            this.rdBanChonNhieu.TabIndex = 2;
            this.rdBanChonNhieu.TabStop = true;
            this.rdBanChonNhieu.Text = "Bàn Được Chọn Nhiều";
            this.rdBanChonNhieu.UseVisualStyleBackColor = true;
            // 
            // rdSLMonBan
            // 
            this.rdSLMonBan.AutoSize = true;
            this.rdSLMonBan.Location = new System.Drawing.Point(48, 92);
            this.rdSLMonBan.Name = "rdSLMonBan";
            this.rdSLMonBan.Size = new System.Drawing.Size(165, 23);
            this.rdSLMonBan.TabIndex = 1;
            this.rdSLMonBan.TabStop = true;
            this.rdSLMonBan.Text = "Chi Tiết Bán Hàng";
            this.rdSLMonBan.UseVisualStyleBackColor = true;
            // 
            // rdDoanhThu
            // 
            this.rdDoanhThu.AutoSize = true;
            this.rdDoanhThu.Location = new System.Drawing.Point(48, 41);
            this.rdDoanhThu.Name = "rdDoanhThu";
            this.rdDoanhThu.Size = new System.Drawing.Size(112, 23);
            this.rdDoanhThu.TabIndex = 0;
            this.rdDoanhThu.TabStop = true;
            this.rdDoanhThu.Text = "Doanh Thu";
            this.rdDoanhThu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1150, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1152, 637);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbHinhThuc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu";
            this.groupBox1.ResumeLayout(false);
            this.gbHinhThuc.ResumeLayout(false);
            this.gbHinhThuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.GroupBox gbHinhThuc;
        private System.Windows.Forms.RadioButton rdBanChonNhieu;
        private System.Windows.Forms.RadioButton rdSLMonBan;
        private System.Windows.Forms.RadioButton rdDoanhThu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}