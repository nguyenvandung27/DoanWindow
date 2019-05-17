using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_BAN_CAFE
{
    class NhanVien
    {
        private string maNV;
        private string tenNV;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string trinhDo;
        private string chucVu;
        private string soCM;
        private string diaChi;

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

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }

        public string TrinhDo
        {
            get { return trinhDo; }
            set { trinhDo = value; }
        }

        public string ChucVu
        {
            get { return chucVu; }
            set { chucVu = value; }
        }

        public string SoCM
        {
            get { return soCM; }
            set { soCM = value; }
        }

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
    }
}
