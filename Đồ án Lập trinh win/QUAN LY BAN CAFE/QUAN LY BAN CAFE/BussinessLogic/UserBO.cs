using QUAN_LY_BAN_CAFE.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUAN_LY_BAN_CAFE.BussinessLogic
{
    class UserBO
    {
        DBAccess db = new DBAccess();

        public bool kiemTraLogin(string user, string matKhau)
        {
            return db.kiemTraDangNhap(user, matKhau);
        }

        public bool doiPass(User us)
        {
            string[] param = { "@MaUser", "@MatKhau" };
            object[] value = { us.MaUser, us.MatKhau };
            string query = "Update tblUser set PassWord=MatKhau where MaUser=MaUser";
            return db.ExecuteNonQueryPara(query, param, value);
        }
    }
}
