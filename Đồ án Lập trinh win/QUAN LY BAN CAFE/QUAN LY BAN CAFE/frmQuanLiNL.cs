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
    public partial class frmQuanLiNL : Form
    {
        NguyenLieuBO nlBO = new NguyenLieuBO();
        public frmQuanLiNL(string text)
        {
            InitializeComponent();
            cbDVT.Items.Add(Text);
            cbDVT.Text = Text;
        }
        private void reload()
        {
            txtMaNL.Text = "";
            txtDonGia.Text = "";
            txtSoLuongCon.Text = "";
            txtTenNL.Text = "";

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NguyenLieu nl = getDataNL();
            if (txtMaNL.Text == "" || txtDonGia.Text == "" || cbDVT.Text == "" || txtSoLuongCon.Text == "" || txtTenNL.Text == "")
                MessageBox.Show("Bạn cần nhập đủ thông tin");
            else
            {
                if (btnSua.Enabled == false)
                {
                    if (nlBO.kiemTraNL(txtMaNL.Text) == false)
                    {
                        if (nlBO.ThemNL(nl))
                            MessageBox.Show("Thêm thành công");
                        else
                            MessageBox.Show("Lỗi nhập dữ liệu");
                    }
                    else
                        MessageBox.Show("Đã có mã nguyên liệu " + txtMaNL.Text + " trong hệ thống");
                }
                else
                {
                    if (nlBO.SuaNL(nl))
                    {
                        MessageBox.Show("Sửa thành công");
                        reload();
                    }
                    else
                        MessageBox.Show("Không thể sửa thông tin");
                }
            }
            bindData();
            btnSua.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DanhMucQuanLy dmql = new DanhMucQuanLy();
            dmql.Show();
            this.Hide();
        }

        private void frmQuanLiNL_Load(object sender, EventArgs e)
        {
            DataTable tableNV = new DataTable();
            tableNV = nlBO.getDSNL();
            dgNguyenLieu.DataSource = tableNV;
        }

        private void dgNguyenLieu_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelect = e.RowIndex;
            txtMaNL.Text = dgNguyenLieu.Rows[rowSelect].Cells[0].Value.ToString();
            txtTenNL.Text = dgNguyenLieu.Rows[rowSelect].Cells[1].Value.ToString();
            txtDonGia.Text = dgNguyenLieu.Rows[rowSelect].Cells[2].Value.ToString();
            cbDVT.Text = dgNguyenLieu.Rows[rowSelect].Cells[3].Value.ToString();
            txtSoLuongCon.Text = dgNguyenLieu.Rows[rowSelect].Cells[4].Value.ToString();
        }
        private NguyenLieu getDataNL()
        {
            NguyenLieu nl = new NguyenLieu();
            float dg = 0;
            int sl = 0;
            nl.MaNL = txtMaNL.Text;
            nl.TenNL = txtTenNL.Text;
            dg = float.Parse(txtDonGia.Text);
            nl.DonGia = dg;
            sl = int.Parse(txtSoLuongCon.Text);
            nl.DonViTinh = cbDVT.Text;
            nl.SoLuongCon = sl;
            return nl;
        }
        private void clearBind()
        {
            txtMaNL.DataBindings.Clear();
            txtTenNL.DataBindings.Clear();
            txtDonGia.DataBindings.Clear();
            txtSoLuongCon.DataBindings.Clear();
        }

        private void bindData()
        {
            BindingSource binSourceNL = new BindingSource();
            binSourceNL.DataSource = nlBO.getDSNL();
            clearBind();
            txtMaNL.DataBindings.Add("Text", binSourceNL, "MaNL");
            txtTenNL.DataBindings.Add("Text", binSourceNL, "TenNL");
            txtDonGia.DataBindings.Add("Text", binSourceNL, "DonGia");
            //.DataBindings.Add("Text", binSourceNL, "DonViTinh");
            txtSoLuongCon.DataBindings.Add("Text", binSourceNL, "SoLuongCon");
            dgNguyenLieu.DataSource = binSourceNL;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNL.Text = "";
            txtTenNL.Text = "";
            txtDonGia.Text = "";
            txtSoLuongCon.Text = "";
            btnSua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNL.ReadOnly = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NguyenLieu nl = getDataNL();
            if (MessageBox.Show("Bạn có chắc muốn xóa nguyên liệu này?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (nlBO.XoaNL(nl))
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Không thể xóa");
            }
            bindData();
        }

        private void btnThemDVT_Click(object sender, EventArgs e)
        {
            frmThemDVT FromThemDVT = new frmThemDVT();
            FromThemDVT.Show();
            this.Hide();
        }
    }
}
