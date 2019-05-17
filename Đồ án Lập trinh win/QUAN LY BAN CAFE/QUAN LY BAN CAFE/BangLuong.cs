using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_BAN_CAFE
{
    class BangLuong
    {
        private int thang;
        private string maNV;
        private string tenNV;
        private float tongGioLam;
        private float mucLuong;
        private float tienLuong;

        public int Thang
        {
            get { return thang; }
            set { thang = value; }
        }

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }

        public float TongGioLam
        {
            get { return tongGioLam; }
            set { tongGioLam = value; }
        }

        public float MucLuong
        {
            get { return mucLuong; }
            set { mucLuong = value; }
        }

        public float TienLuong
        {
            get { return tienLuong; }
            set { tienLuong = value; }
        }
    }
}
