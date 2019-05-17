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
    public partial class frmKhuA : Form
    {
        OderBO odBO = new OderBO();
        CTOderBO ctBO = new CTOderBO();
        BanCoKhachBO bckBO = new BanCoKhachBO();
        public frmKhuA()
        {
            InitializeComponent();
        }

        private void frmKhuA_Load(object sender, EventArgs e)
        {
            if (bckBO.kiemTraBanCoKhach("A01"))
                btnBan1.Text = "1(CK)";
            else
                btnBan1.Text = "BÀN 1";

            if (bckBO.kiemTraBanCoKhach("A02"))
                btnBan2.Text = "2(CK)";
            else
                btnBan2.Text = "BÀN 2";

            if (bckBO.kiemTraBanCoKhach("A03"))
                btnBan3.Text = "3(CK)";
            else
                btnBan3.Text = "BÀN 3";

            if (bckBO.kiemTraBanCoKhach("A04"))
                btnBan4.Text = "4(CK)";
            else
                btnBan4.Text = "BÀN 4";

            if (bckBO.kiemTraBanCoKhach("A05"))
                btnBan5.Text = "5(CK)";
            else
                btnBan5.Text = "BÀN 5";

            if (bckBO.kiemTraBanCoKhach("A06"))
                btnBan6.Text = "6(CK)";
            else
                btnBan6.Text = "BÀN 6";

            if (bckBO.kiemTraBanCoKhach("A07"))
                btnBan7.Text = "7(CK)";
            else
                btnBan7.Text = "BÀN 7";

            if (bckBO.kiemTraBanCoKhach("A08"))
                btnBan8.Text = "8(CK)";
            else
                btnBan8.Text = "BÀN 8";

            if (bckBO.kiemTraBanCoKhach("A09"))
                btnBan9.Text = "9(CK)";
            else
                btnBan9.Text = "BÀN 9";

            if (bckBO.kiemTraBanCoKhach("A10"))
                btnBan10.Text = "10(CK)";
            else
                btnBan10.Text = "BÀN 10";

            if (bckBO.kiemTraBanCoKhach("A11"))
                btnBan11.Text = "11(CK)";
            else
                btnBan11.Text = "BÀN 11";

            if (bckBO.kiemTraBanCoKhach("A12"))
                btnBan12.Text = "12(CK)";
            else
                btnBan12.Text = "BÀN 12";

            if (bckBO.kiemTraBanCoKhach("A13"))
                btnBan13.Text = "13(CK)";
            else
                btnBan13.Text = "BÀN 13";

            if (bckBO.kiemTraBanCoKhach("A14"))
                btnBan14.Text = "14(CK)";
            else
                btnBan14.Text = "BÀN 14";

            if (bckBO.kiemTraBanCoKhach("A15"))
                btnBan15.Text = "15(CK)";
            else
                btnBan15.Text = "BÀN 15";

            if (bckBO.kiemTraBanCoKhach("A16"))
                btnBan16.Text = "16(CK)";
            else
                btnBan16.Text = "BÀN 16";

            if (bckBO.kiemTraBanCoKhach("A17"))
                btnBan17.Text = "17(CK)";
            else
                btnBan17.Text = "BÀN 17";

            if (bckBO.kiemTraBanCoKhach("A18"))
                btnBan18.Text = "18(CK)";
            else
                btnBan18.Text = "BÀN 18";

            if (bckBO.kiemTraBanCoKhach("A19"))
                btnBan19.Text = "19(CK)";
            else
                btnBan19.Text = "BÀN 19";

            if (bckBO.kiemTraBanCoKhach("A20"))
                btnBan20.Text = "20(CK)";
            else
                btnBan20.Text = "BÀN 20";

            if (bckBO.kiemTraBanCoKhach("A21"))
                btnBan21.Text = "21(CK)";
            else
                btnBan21.Text = "BÀN 21";

            if (bckBO.kiemTraBanCoKhach("A22"))
                btnBan22.Text = "22(CK)";
            else
                btnBan22.Text = "BÀN 22";

            if (bckBO.kiemTraBanCoKhach("A23"))
                btnBan23.Text = "23(CK)";
            else
                btnBan23.Text = "BÀN 23";

            if (bckBO.kiemTraBanCoKhach("A24"))
                btnBan24.Text = "24(CK)";
            else
                btnBan24.Text = "BÀN 24";

            if (bckBO.kiemTraBanCoKhach("A25"))
                btnBan25.Text = "25(CK)";
            else
                btnBan25.Text = "BÀN 25";

            if (bckBO.kiemTraBanCoKhach("A26"))
                btnBan26.Text = "26(CK)";
            else
                btnBan26.Text = "BÀN 26";

            if (bckBO.kiemTraBanCoKhach("A27"))
                btnBan27.Text = "27(CK)";
            else
                btnBan27.Text = "BÀN 27";

            if (bckBO.kiemTraBanCoKhach("A28"))
                btnBan28.Text = "28(CK)";
            else
                btnBan28.Text = "BÀN 28";

            if (bckBO.kiemTraBanCoKhach("A29"))
                btnBan29.Text = "29(CK)";
            else
                btnBan29.Text = "BÀN 29";

            if (bckBO.kiemTraBanCoKhach("A30"))
                btnBan30.Text = "30(CK)";
            else
                btnBan30.Text = "BÀN 30";
        }

        private void btnSoDoChinh_Click(object sender, EventArgs e)
        {
            this.Close();
            frmSoDoChinh FromSoDoChinh;
            FromSoDoChinh = new frmSoDoChinh();
            FromSoDoChinh.Show();
        }

        private void btnBan1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            frmCTBan FromCTBan;
            FromCTBan = new frmCTBan();
            FromCTBan.Show();
        }
    }
}
