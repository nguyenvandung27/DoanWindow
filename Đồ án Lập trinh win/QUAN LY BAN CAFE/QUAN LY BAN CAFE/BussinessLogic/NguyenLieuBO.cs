using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUAN_LY_BAN_CAFE.DataAccess;

namespace QUAN_LY_BAN_CAFE.BussinessLogic
{
    class NguyenLieuBO
    {
        DBAccess db = new DBAccess();
        public DataTable getDSNL()
        {
            string query = "Select * from tblNguyenLieu";
            return db.getDS(query);
        }
        public DataTable getDSNL(string maNL)
        {
            string query = "Select * from tblNguyenLieu where MaNL='" + maNL + "'";
            return db.getDS(query);
        }
        public bool kiemTraNL(string maNL)
        {
            return db.kiemTraTonTai3(maNL);
        }
        public bool ThemNL(NguyenLieu nl)
        {
            string[] param = { "@MaNL", "@TenNL", "@DonGia", "@DonViTinh", "@SoLuongCon" };
            object[] values = { nl.MaNL, nl.TenNL, nl.DonGia, nl.DonViTinh, nl.SoLuongCon };
            string query = "Insert into tblNguyenLieu(MaNL,TenNL,DonGia,DonViTinh,SoLuongCon) values(@MaNL,@TenNL,@DonGia,@DonViTinh,@SoLuongCon)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool SuaNL(NguyenLieu nl)
        {
            string[] param = { "@MaNL", "@TenNL", "@DonGia", "@DonViTinh", "@SoLuongCon" };
            object[] values = { nl.MaNL, nl.TenNL, nl.DonGia, nl.DonViTinh, nl.SoLuongCon };
            string query = "Update tblNguyenLieu set TenNL=@TenNL,DonGia=@DonGia,DonViTinh=@DonViTinh,SoLuongCon=@SoLuongCon where MaNL=@MaNL";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool XoaNL(NguyenLieu nl)
        {
            string[] param = { "@MaNL" };
            object[] values = { nl.MaNL };
            string query = "Delete from tblNguyenLieu where MaNL=@MaNL";
            return db.ExecuteNonQueryPara(query, param, values);
        }


    }
}
    
