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
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhMucQuanLy FromMenu;
            FromMenu = new DanhMucQuanLy();
            FromMenu.Show();
        }
    }
}
