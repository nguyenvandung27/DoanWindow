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

    public partial class frmKhuB : Form
    {
        OderBO odBO = new OderBO();
        CTOderBO ctBO = new CTOderBO();
        BanCoKhachBO bckBO = new BanCoKhachBO();
        public frmKhuB()
        {
            InitializeComponent();
        }

        private void btnSoDoChinh_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSoDoChinh FromSoDoChinh;
            FromSoDoChinh = new frmSoDoChinh();
            FromSoDoChinh.Show();
        }
    }
}
