namespace QUAN_LY_BAN_CAFE
{
    partial class frmSoDoChinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoDoChinh));
            this.btnMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKhuB = new System.Windows.Forms.Button();
            this.btnKhuA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(657, 581);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(130, 64);
            this.btnMenu.TabIndex = 10;
            this.btnMenu.Text = "TRỞ LẠI MENU";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(584, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "SƠ ĐỒ CHÍNH TẠI QUÁN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKhuB);
            this.groupBox1.Controls.Add(this.btnKhuA);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(301, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 415);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Khu:";
            // 
            // btnKhuB
            // 
            this.btnKhuB.Font = new System.Drawing.Font("Arial Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhuB.Location = new System.Drawing.Point(437, 50);
            this.btnKhuB.Name = "btnKhuB";
            this.btnKhuB.Size = new System.Drawing.Size(372, 316);
            this.btnKhuB.TabIndex = 3;
            this.btnKhuB.Text = "KHU B";
            this.btnKhuB.UseVisualStyleBackColor = true;
            this.btnKhuB.Click += new System.EventHandler(this.btnKhuB_Click);
            // 
            // btnKhuA
            // 
            this.btnKhuA.Font = new System.Drawing.Font("Arial Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhuA.Location = new System.Drawing.Point(43, 50);
            this.btnKhuA.Name = "btnKhuA";
            this.btnKhuA.Size = new System.Drawing.Size(372, 316);
            this.btnKhuA.TabIndex = 2;
            this.btnKhuA.Text = "KHU A";
            this.btnKhuA.UseVisualStyleBackColor = true;
            this.btnKhuA.Click += new System.EventHandler(this.btnKhuA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1352, 109);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmSoDoChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1352, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSoDoChinh";
            this.Text = "Sơ đồ phân khu";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKhuB;
        private System.Windows.Forms.Button btnKhuA;
    }
}