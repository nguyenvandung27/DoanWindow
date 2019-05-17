using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_BAN_CAFE
{
    class CTXuatNL
    {
        private int maPhieuXuat;
        private string maNL;
        private string tenNL;
        private int soLuong;
        private string donViTinh;

        public int MaPhieuXuat
        {
            get { return maPhieuXuat; }
            set { maPhieuXuat = value; }
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
    }
}
