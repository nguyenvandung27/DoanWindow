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
    public partial class DanhMucQuanLy : Form
    {
        public DanhMucQuanLy()
        {
            InitializeComponent();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
           
            frmQuanLiNV FromQuanLiNV;
            FromQuanLiNV = new frmQuanLiNV();
            FromQuanLiNV.Show();
            this.Hide();
          
           
        }

        private void btnNguyenLieu_Click(object sender, EventArgs e)
        {
            
            frmQuanLiNL FromQuanLiNL;
            FromQuanLiNL = new frmQuanLiNL("");
            FromQuanLiNL.Show();
            this.Hide();
           
           
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            
            frmBaoCao BaoCao = new frmBaoCao();
            BaoCao.Show();
            this.Hide();
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            frmFromMenu mn = new frmFromMenu();
            mn.Show();
            this.Hide();
        }

        private void DanhMucQuanLy_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void DanhMucQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
