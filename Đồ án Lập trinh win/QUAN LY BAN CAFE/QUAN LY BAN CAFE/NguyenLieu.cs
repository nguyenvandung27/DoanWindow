using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_BAN_CAFE
{
    class NguyenLieu
    {
        private string maNL;
        private string tenNL;
        private float donGia;
        private string donViTinh;
        private int soLuongCon;

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

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }

        public int SoLuongCon
        {
            get { return soLuongCon; }
            set { soLuongCon = value; }
        }
    }
}
