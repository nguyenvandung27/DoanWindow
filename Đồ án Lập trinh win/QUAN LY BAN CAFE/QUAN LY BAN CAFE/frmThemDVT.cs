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
    public partial class frmThemDVT : Form
    {
        public frmThemDVT()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            frmQuanLiNL FromQLNL;
            FromQLNL = new frmQuanLiNL(txtDonViTinh.Text);
            FromQLNL.ShowDialog();
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtDonViTinh.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLiNL FromQLNL = new frmQuanLiNL("");
            FromQLNL.ShowDialog();
        }
    }
}
