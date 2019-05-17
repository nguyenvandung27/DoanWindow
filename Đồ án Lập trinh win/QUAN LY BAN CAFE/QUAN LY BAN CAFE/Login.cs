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
    public partial class Login : Form
    {
        UserBO us = new UserBO();
        public Login()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmFromMenu frmMenu;
            frmMenu = new frmFromMenu();
            if (txtUser.Text == "" || txtPass.Text == "")
                MessageBox.Show("Bạn chưa nhập User hoặc PassWord", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                if (us.kiemTraLogin(txtUser.Text, txtPass.Text))
            {
                frmMenu.FormClosed += new FormClosedEventHandler(Login_FormClosed);   
                frmMenu.Show();
                this.Hide();
                txtPass.Text = "";
                txtUser.Text = "";
               
            }
            else
                MessageBox.Show("Sai User hoặc PassWord", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
