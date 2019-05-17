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
    public partial class frmCTNhapNL : Form
    {
        CTNhapBO ctBO = new CTNhapBO();
        public frmCTNhapNL(string text)
        {
            InitializeComponent();
            txtMaPN.Text = text;
        }
        NXNguyenLieuBO nxBO = new NXNguyenLieuBO();
        private void frmCTNhapNL_Load(object sender, EventArgs e)
        {
            DataTable tableMaNL = new DataTable();
            tableMaNL = ctBO.getMaNL();
            cbMaNL.DataSource = tableMaNL;
            cbMaNL.DisplayMember = "MaNL";
            cbMaNL.ValueMember = "MaNL";
            cbMaNL.SelectedIndex = 0;
            binData();
        }

        public void binData()
        {
            BindingSource bindinCTNhap = new BindingSource();
            int maPN = int.Parse(txtMaPN.Text);
            bindinCTNhap.DataSource = ctBO.getDSNhapNL(maPN);
            clearBind();
            dgCTNhapNL.DataSource = bindinCTNhap;
        }
        public void clearBind()
        {
            txtDonGia.DataBindings.Clear();
            txtDonViTinh.DataBindings.Clear();
            txtMaPN.DataBindings.Clear();
            txtSoLuong.DataBindings.Clear();
            txtTenNL.DataBindings.Clear();
            dgCTNhapNL.DataBindings.Clear();
        }

        private CTNhapNL getCTNhap()
        {
            CTNhapNL ct = new CTNhapNL();
            ct.MaPhieuNhap = int.Parse(txtMaPN.Text);
            ct.MaNL = cbMaNL.SelectedValue.ToString();
            ct.TenNL = txtTenNL.Text;
            ct.SoLuong = int.Parse(txtSoLuong.Text);
            ct.DonGia = float.Parse(txtDonGia.Text);
            ct.DonViTinh = txtDonViTinh.Text;
            ct.ThanhTien = ct.DonGia * (float)ct.SoLuong;
            return ct;
        }

        private NXNguyenLieu getNhapNL()
        {
            NXNguyenLieu nl = new NXNguyenLieu();
            nl.MaPhieuNhap = int.Parse(txtMaPN.Text);
            //nl.NgayNhap = DateTime.Today();
            //nl.TongTien = 0;
            return nl;
        }

        private void cbMaNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNL.Text = ctBO.getTenNL(cbMaNL.SelectedValue.ToString());
            txtDonViTinh.Text = ctBO.getDVTNL(cbMaNL.SelectedValue.ToString());
            txtDonGia.Text = ctBO.getDonGia(cbMaNL.SelectedValue.ToString());
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int maPN = int.Parse(txtMaPN.Text);
            NXNguyenLieu nl = getNhapNL();
            if (ctBO.kiemTraNhapNL(maPN) == false)
                nxBO.XoaNhapNL(nl);
            this.Hide();
            frmNhapXuatNguyenLieu FromNhapXuatNL;
            FromNhapXuatNL = new frmNhapXuatNguyenLieu();
            FromNhapXuatNL.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtDonViTinh.Text == "" || txtMaPN.Text == "" || txtSoLuong.Text == "" || txtTenNL.Text == "")
            {
                MessageBox.Show("Không thể lưu vì để trống");
            }
            else {
                CTNhapNL nhap = getCTNhap();
                int maPN = int.Parse(txtMaPN.Text);
                string maNL = cbMaNL.Text;
                if (ctBO.kiemTraTonTai(maPN, maNL))
                    if (ctBO.SuaCTNhap(nhap))
                        MessageBox.Show("Sửa thành công");
                    else
                        MessageBox.Show("Không thể sửa");
                else
                    if (txtDonGia.Text == "" || txtDonViTinh.Text == "" || txtSoLuong.Text == "")
                    MessageBox.Show("Bạn cần nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                        if (ctBO.ThemCTNhap(nhap))
                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Không thể thêm dữ liệu");
                binData(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "" || txtDonViTinh.Text == "" || txtMaPN.Text == "" || txtSoLuong.Text == "" || txtTenNL.Text == "")
            { MessageBox.Show("Không thể xóa vì để trống"); }
            else
            {
                CTNhapNL ct = getCTNhap();
                if (MessageBox.Show("Bạn chắc muốn xóa nhập nguyên liệu: " + txtTenNL.Text + " ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (ctBO.XoaCTNhap(ct))
                        MessageBox.Show("Xóa thành công");
                    else
                        MessageBox.Show("không thể xóa");
                }
                binData();
            }
        }

        private void tbnThem_Click(object sender, EventArgs e)
        {
            txtMaPN.Enabled = true;
            txtSoLuong.Text = "";
            txtTenNL.Text = "";
            txtDonViTinh.Text = "";
            txtDonGia.Text = "";
        }

        private void dgCTNhapNL_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelect = e.RowIndex;
            txtMaPN.Text = dgCTNhapNL.Rows[rowSelect].Cells[0].Value.ToString();
            cbMaNL.Text = dgCTNhapNL.Rows[rowSelect].Cells[1].Value.ToString();
            txtTenNL.Text = dgCTNhapNL.Rows[rowSelect].Cells[2].Value.ToString();
            txtSoLuong.Text = dgCTNhapNL.Rows[rowSelect].Cells[3].Value.ToString();
            txtDonViTinh.Text = dgCTNhapNL.Rows[rowSelect].Cells[4].Value.ToString();
            txtDonGia.Text = dgCTNhapNL.Rows[rowSelect].Cells[5].Value.ToString();
        }
    }
}
