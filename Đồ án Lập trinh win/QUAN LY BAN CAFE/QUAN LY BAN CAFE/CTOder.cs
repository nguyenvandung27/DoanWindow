using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_BAN_CAFE
{
    class CTOder
    {
        private int maOder;
        private string maBan;
        private string maMon;
        private int soLuong;
        private string donViTinh;

        public int MaOder
        {
            get { return maOder; }
            set { maOder = value; }
        }

        public string MaBan
        {
            get { return maBan; }
            set { maBan = value; }
        }

        public string MaMon
        {
            get { return maMon; }
            set { maMon = value; }
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
