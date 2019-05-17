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
    public partial class frmQuanLiNV : Form
    {
        NhanVienBO nvBO = new NhanVienBO();
        public frmQuanLiNV()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DanhMucQuanLy FromMenu;
            FromMenu = new DanhMucQuanLy();
            FromMenu.Show();
            this.Hide();
        }

        private void frmQuanLiNV_Load(object sender, EventArgs e)
        {
            DataTable tableNV = new DataTable();
            tableNV = nvBO.getDSNV();
            dgNhanVien.DataSource = tableNV;
        }
        private void dgNhanVien_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int rowSelect = e.RowIndex;
            txtMaNV.Text = dgNhanVien.Rows[rowSelect].Cells[0].Value.ToString();
            txtTenNV.Text = dgNhanVien.Rows[rowSelect].Cells[1].Value.ToString();
            dtNgaySinh.Value = Convert.ToDateTime(dgNhanVien.Rows[rowSelect].Cells[2].Value);
            cbGioiTinh.Text = dgNhanVien.Rows[rowSelect].Cells[3].Value.ToString();
            txtTrinhDo.Text = dgNhanVien.Rows[rowSelect].Cells[4].Value.ToString();
            cbChucVu.Text = dgNhanVien.Rows[rowSelect].Cells[5].Value.ToString();
            txtSoCM.Text = dgNhanVien.Rows[rowSelect].Cells[6].Value.ToString();
            txtDiaChi.Text = dgNhanVien.Rows[rowSelect].Cells[7].Value.ToString();
        }
        private NhanVien getDataNV()
        {
            NhanVien nv = new NhanVien();
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            nv.NgaySinh = Convert.ToDateTime(dtNgaySinh.Value.ToShortDateString());
            nv.GioiTinh = cbGioiTinh.Text;
            nv.TrinhDo = txtTrinhDo.Text;
            nv.ChucVu = cbChucVu.Text;
            nv.DiaChi = txtDiaChi.Text;
            nv.SoCM = txtSoCM.Text;
            return nv;
        }

        private void clearBind()
        {
            txtMaNV.DataBindings.Clear();
            txtTenNV.DataBindings.Clear();
            dtNgaySinh.DataBindings.Clear();
            txtTrinhDo.DataBindings.Clear();
            txtSoCM.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
        }

        private void bindData()
        {
            BindingSource binSourceNV = new BindingSource();
            binSourceNV.DataSource = nvBO.getDSNV();
            clearBind();
            txtMaNV.DataBindings.Add("Text", binSourceNV, "MaNV");
            txtTenNV.DataBindings.Add("Text", binSourceNV, "TenNV");
            dtNgaySinh.DataBindings.Add("Value", binSourceNV, "NgaySinh");
            txtTrinhDo.DataBindings.Add("Text", binSourceNV, "TrinhDoHocVan");
            txtDiaChi.DataBindings.Add("Text", binSourceNV, "DiaChi");
            txtSoCM.DataBindings.Add("Text", binSourceNV, "SoCMND");
            dgNhanVien.DataSource = binSourceNV;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.ReadOnly == true)
                txtMaNV.ReadOnly = false;
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtTrinhDo.Text = "";
            txtDiaChi.Text = "";
            txtSoCM.Text = "";
            btnSua.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {         
            txtMaNV.ReadOnly = true;          
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVien nv = getDataNV();
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác Nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (nvBO.XoaNV(nv))
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Không thể xóa");
            }
            bindData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            NhanVien nv = getDataNV();
            if (txtMaNV.Text == "" || txtSoCM.Text == "" || txtTrinhDo.Text == "" || txtDiaChi.Text == "" || txtTenNV.Text == "" || cbChucVu.Text == "" | cbGioiTinh.Text == "")
                MessageBox.Show("Bạn cần nhập đủ thông tin");
            else
            {
                if (btnSua.Enabled == false)
                {
                    if (nvBO.kiemTraNhanVien(txtMaNV.Text) == false)
                    {
                        if (nvBO.ThemNV(nv))
                            MessageBox.Show("Lưu thành công");
                        else
                            MessageBox.Show("Lỗi nhập dữ liệu");
                    }
                    else
                        MessageBox.Show("Đã có mã nhân viên " + txtMaNV.Text + " trong hệ thống");
                }
                else
                {
                    if (nvBO.SuaNV(nv))
                        MessageBox.Show("Sửa thành công");
                    else
                        MessageBox.Show("Không thể sửa thông tin");
                }
            }
            bindData();
            btnSua.Enabled = true;
        }

        private void btnBangLuong_Click(object sender, EventArgs e)
        {
            frmBangLuong BangLuong = new frmBangLuong();
            BangLuong.Show();
            this.Hide();
        }
    }
}
