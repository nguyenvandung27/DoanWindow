using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUAN_LY_BAN_CAFE.DataAccess;
namespace QUAN_LY_BAN_CAFE.BussinessLogic
{
    class CTOderBO
    {
        DBAccess db = new DBAccess();

        public DataTable getCTOder(int maOder, string maBan)
        {
            string query = "Select * from tblCTOder where MaOder='" + maOder + "' and MaBan='" + maBan + "'";
            return db.getDS(query);
        }
        public DataTable getCTOder(string maBan)
        {
            string query = "Select * from tblCTOder where MaBan='" + maBan + "'";
            return db.getDS(query);
        }
        public bool kiemTraMon(string MaMon, string maBan, int maOder)
        {
            return db.kiemTraTonTai9(MaMon, maBan, maOder);
        }

        public bool kiemTraGoiMon(int maOder)
        {
            return db.kiemTraTonTai10(maOder);
        }

        public bool kiemTraBan(int soBan)
        {
            return db.kiemTraTonTai11(soBan);
        }

        public string layDVT(string maMon)
        {
            return db.layDVT(maMon);
        }

        public string laySoBan(string MaBan)
        {
            return db.laySoBan(MaBan);
        }


        public string laySLMon(string maMon, string maBan)
        {
            return db.laySLMon(maMon, maBan);
        }

        public bool ThemCTOder(CTOder ct)
        {
            string[] param = { "@MaOder", "@MaBan", "@MaMon", "@SoLuong", "@DonViTinh" };
            object[] values = { ct.MaOder, ct.MaBan, ct.MaMon, ct.SoLuong, ct.DonViTinh };
            string query = "Insert into tblCTOder(MaOder,MaBan,MaMon,SoLuong,DonViTinh) values(@MaOder,@MaBan,@MaMon,@SoLuong,@DonViTinh)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool NhapSoLuong(CTOder ct)
        {
            string[] param = { "MaOder", "@MaMon", "@SoLuong" };
            object[] values = { ct.MaOder, ct.MaMon, ct.SoLuong };
            string query = "Update tblCTOder set SoLuong=@SoLuong where MaOder=@MaOder and MaMon=@MaMon";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool XoaMon(CTOder ct)
        {
            string[] param = { "@MaMon", "@MaBan" };
            object[] values = { ct.MaMon, ct.MaBan };
            string query = "Delete from tblCTOder where MaMon=@MaMon and MaBan=@MaBan";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool XoaCTOder(CTOder ct)
        {
            string[] param = { "@MaOder" };
            object[] values = { ct.MaOder };
            string query = "Delete from tblCTOder where MaOder=@MaOder";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool ChuyenBan(CTOder ct)
        {
            string[] param = { "@MaOder", "@MaBan" };
            object[] values = { ct.MaOder, ct.MaBan };
            string query = "Update tblCTOder set MaBan=@MaBan where MaOder=@MaOder";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }

}

