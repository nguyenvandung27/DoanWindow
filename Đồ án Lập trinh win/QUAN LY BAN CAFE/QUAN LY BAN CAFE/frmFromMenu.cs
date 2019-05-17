using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_BAN_CAFE
{
    public partial class frmFromMenu : Form
    {
        public frmFromMenu()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan;
            xacnhan = MessageBox.Show("Có chắc bạn muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacnhan == DialogResult.Yes)
            {
                this.Close();

            }
                
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmFromdoipass doipass = new frmFromdoipass();
            doipass.Show();
            this.Hide();
           
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            frmNhapXuatNguyenLieu nxnl = new frmNhapXuatNguyenLieu();
            nxnl.Show();
            this.Hide();
           
        }
        
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            DanhMucQuanLy dmql = new DanhMucQuanLy();
            dmql.Show();
            this.Hide();
           
        }

        private void frmFromMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmFromMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnSoDoChinh_Click(object sender, EventArgs e)
        {
            frmSoDoChinh FromSoDoChinh;
            FromSoDoChinh = new frmSoDoChinh();
            FromSoDoChinh.Show();
            this.Hide();
        }
    }
}
