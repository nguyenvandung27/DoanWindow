using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUAN_LY_BAN_CAFE.DataAccess;
namespace QUAN_LY_BAN_CAFE.BussinessLogic
{
    class BanCoKhachBO
    {
        DBAccess db = new DBAccess();
        public bool kiemTraBanCoKhach(string maban)
        {
            return db.kiemTraTonTai8(maban);
        }

        public string laySoBan(string maBan)
        {
            return db.laySoBan(maBan);
        }

        public bool ThemBanCoKhach(BanCoKhach ban)
        {
            string[] param = { "@MaBan", "@SoBan" };
            object[] values = { ban.MaBan, ban.SoBan };
            string query = "Insert into tblBanCoKhach(MaBan,SoBan) values(@MaBan,@SoBan)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool XoaBanCoKhach(BanCoKhach ban)
        {
            string[] param = { "@MaBan" };
            object[] values = { ban.MaBan };
            string query = "Delete from tblBanCoKhach where MaBan=@MaBan";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
