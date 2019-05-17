using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUAN_LY_BAN_CAFE.DataAccess;
namespace QUAN_LY_BAN_CAFE.BussinessLogic
{
    class CTXuatBO
    {
        DBAccess db = new DBAccess();

        public DataTable getDSXuatNL(int maPX)
        {
            string query = "Select * from tblCTXuatNL where MaPhieuXuat='" + maPX + "'";
            return db.getDS(query);
        }

        public DataTable getMaNL()
        {
            return db.getDS("Select MaNL from tblNguyenLieu");
        }

        public string getTenNL(string maNL)
        {
            return db.layTenNL(maNL);
        }

        public string getDVTNL(string maNL)
        {
            return db.layDonViTinhNL(maNL);
        }

        public bool kiemTraXuatNL(int maPX)
        {
            return db.kiemTraTonTai5(maPX);
        }

        public bool kiemTraTonTai(int maPX, string maNL)
        {
            return db.kiemTraTonTai6(maPX, maNL);
        }

        public string laySLCon(string maNL)
        {
            return db.laySLNLCon(maNL);
        }

        public bool ThemCTXuat(CTXuatNL ct)
        {
            string[] param = { "@MaPX", "@MaNL", "@TenNL", "@SoLuong", "@DonViTinh" };
            object[] values = { ct.MaPhieuXuat, ct.MaNL, ct.TenNL, ct.SoLuong, ct.DonViTinh };
            string query = "Insert into tblCTXuatNL(MaPhieuXuat,MaNL,TenNL,SoLuong,DonViTinh) values (@MaPX,@MaNL,@TenNL,@SoLuong,@DonViTinh)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool SuaCTXuat(CTXuatNL ct)
        {
            string[] param = { "@MaPX", "@MaNL", "@SoLuong" };
            object[] values = { ct.MaPhieuXuat, ct.MaNL, ct.SoLuong };
            string query = "Update tblCTXuatNL set SoLuong=@SoLuong where MaPhieuXuat=@MaPX and MaNL=@MaNL";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool XoaCTXuat(CTXuatNL ct)
        {
            string[] param = { "@MaPX", "@MaNL" };
            object[] values = { ct.MaPhieuXuat, ct.MaNL };
            string query = "Delete from tblCTXuatNL where MaPhieuXuat=@MaPX and MaNL=@MaNL";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
