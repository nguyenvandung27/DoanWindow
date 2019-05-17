using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_BAN_CAFE
{
    class CTNhapNL
    {
        private int maPhieuNhap;
        private string maNL;
        private string tenNL;
        private int soLuong;
        private string donViTinh;
        private float donGia;
        private float thanhTien;

        public int MaPhieuNhap
        {
            get { return maPhieuNhap; }
            set { maPhieuNhap = value; }
        }

        public string MaNL
        {
            get { return maNL; }
            set { maNL = value; }
        }

        public string TenNL
        {
            get { return tenNL; }
            set { tenNL = value; }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public float ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    }
}
