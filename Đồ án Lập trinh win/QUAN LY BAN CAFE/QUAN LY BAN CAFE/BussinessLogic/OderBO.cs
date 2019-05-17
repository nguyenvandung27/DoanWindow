using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUAN_LY_BAN_CAFE.DataAccess;



namespace QUAN_LY_BAN_CAFE.BussinessLogic
{
    class OderBO
    {
        DBAccess db = new DBAccess();

        public DataTable getDSOder()
        {
            string query = "Select * from tblOder";
            return db.getDS(query);
        }

        public DataTable getDSOder(string maOder)
        {
            string query = "Select * from tblOder where MaOder='" + maOder + "'";
            return db.getDS(query);
        }

        public DataTable getMaNV()
        {
            string query = "Select MaNV from tblNhanVien where MaNV like 'NV%'";
            return db.getDS(query);
        }
    }
}
