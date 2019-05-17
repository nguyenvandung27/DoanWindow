using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUAN_LY_BAN_CAFE.BussinessLogic;
namespace QUAN_LY_BAN_CAFE
{
    public partial class frmFromdoipass : Form
    {
        UserBO userBO = new UserBO();
        public frmFromdoipass()
        {
            InitializeComponent();
        }
   
        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmFromMenu menu = new frmFromMenu();
            menu.Show();
            this.Hide();
        }
        private User getDataUser()
        {
            User us = new User();
            us.MaUser = txtMaUser.Text;
            us.MatKhau = txtMatKhauMoi.Text;
            return us;
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            User us = getDataUser();
            if (txtMaUser.Text == "" || txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtNhapLai.Text == "")
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (userBO.kiemTraLogin(txtMaUser.Text, txtMatKhauCu.Text))
                    if (txtMatKhauMoi.Text != txtNhapLai.Text)
                        MessageBox.Show("Mật khẩu Nhập Lại không chính xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        if (userBO.doiPass(us))
                            MessageBox.Show("Đổi mật khẩu thành công!");
                        else
                            MessageBox.Show("Lỗi xảy ra!");
                else
                    MessageBox.Show("Mã User hoặc Mật Khẩu Cũ không đúng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtMaUser.Text = "";
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtNhapLai.Text = "";
        }
    }
}
