using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_BAN_CAFE
{
    class User
    {
        private string maUser;
        private string matKhau;
        private string tenThuNgan;
        public string MaUser
        {
            get { return maUser; }
            set { maUser = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public string TenThuNgan
        {
            get { return tenThuNgan; }
            set { tenThuNgan = value; }
        }
    }
}
