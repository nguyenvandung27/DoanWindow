using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUAN_LY_BAN_CAFE.DataAccess;
namespace QUAN_LY_BAN_CAFE.BussinessLogic
{
    class NXNguyenLieuBO
    {
        DBAccess db = new DBAccess();
        int i = 0;
        public int layMaPhieuNhap()
        {
            i = db.layMaPhieuNhap("tblNhapNL", "MaPhieuNhap");
            return i;
        }

        public int layMaPhieuXuat()
        {
            i = db.layMaPhieuXuat("tblXuatNL", "MaPhieuXuat");
            return i;
        }

        public bool NhapNL(NXNguyenLieu nl)
        {
            string[] param = { "@MaPN", "@NgayNhap", "@TongTien" };
            object[] values = { nl.MaPhieuNhap, nl.NgayNhap, nl.TongTien };
            string query = "Insert into tblNhapNL(MaPhieuNhap,NgayNhap,TongTien) values(@MaPN,@NgayNhap, @TongTien)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool XoaNhapNL(NXNguyenLieu nl)
        {
            string[] param = { "@MaPN" };
            object[] values = { nl.MaPhieuNhap };
            string query = "Delete from tblNhapNL where MaPhieuNhap=@MaPN";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool XuatNL(NXNguyenLieu nl)
        {
            string[] param = { "@MaPX", "@NgayXuat" };
            object[] values = { nl.MaPhieuXuat, nl.NgayXuat };
            string query = "Insert into tblXuatNL(MaPhieuXuat,NgayXuat) values (@MaPX,@NgayXuat)";
            return db.ExecuteNonQueryPara(query, param, values);
        }

        public bool XoaXuatNL(NXNguyenLieu nl)
        {
            string[] param = { "@MaPX" };
            object[] values = { nl.MaPhieuXuat };
            string query = "Delete from tblXuatNL where MaPhieuXuat=@MaPX";
            return db.ExecuteNonQueryPara(query, param, values);
        }
    }
}
