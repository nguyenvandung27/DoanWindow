using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUAN_LY_BAN_CAFE.DataAccess
{
    class DBAccess
    {
        SqlConnection connect;
        SqlDataAdapter da;
        SqlCommand command;

        public DBAccess()
        {
            connectDB();
        }
        public DataTable getDS(string sql)
        {
            DataTable table = new DataTable();
            da = new SqlDataAdapter(sql, connect);
            da.Fill(table);
            return table;
        }

        public void connectDB()
        {
            connect = new SqlConnection(@"Data Source=WATASHI;Initial Catalog=QuanLiCaPhe;Integrated Security=True");
            try
            {
                connect.Open();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                connect.Dispose();
            }
        }
        public bool ExecuteNonQueryPara(string sql, string[] parameters, object[] value)
        {
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                command = new SqlCommand(sql, connect);
                SqlParameter p;
                for (int i = 0; i < parameters.Length; i++)
                {
                    p = new SqlParameter(parameters[i], value[i]);
                    command.Parameters.Add(p);
                }
                number = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }
        public bool kiemTraDangNhap(string giaTri1, string giaTri2)
        {
            string query = "Select count(*) from tblUser where tblUser.MaUser='" + giaTri1 + "' and tblUser.PassWord='" + giaTri2 + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }
        public bool kiemTraTonTai2(string giaTri)
        {
            string query = "Select count (*) from tblNhanVien where MaNV='" + giaTri + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }
        public bool kiemTraTonTai3(string giaTri)
        {
            string query = "Select count (*) from tblNguyenLieu where MaNL='" + giaTri + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }
        public int layMaPhieuNhap(string tableName, string colum)
        {
            string query = "Select top 1 MaPhieuNhap from " + tableName + " order by " + colum + " DESC";
            command = new SqlCommand(query, connect);
            int number = 0;
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            number = (int)command.ExecuteScalar();

            connect.Close();
            return number;
        }
        public int layMaPhieuXuat(string tableName, string colum)
        {
            string query = "Select top 1 MaPhieuXuat from " + tableName + " order by " + colum + " DESC";
            command = new SqlCommand(query, connect);
            int number = 0;
            if (connect.State == ConnectionState.Closed)
            {
                connect.Open();
            }
            number = (int)command.ExecuteScalar();

            connect.Close();
            return number;
        }
        public bool kiemTraTonTai4(int giaTri)
        {
            string query = "Select count (*) from tblCTNhapNL where MaPhieuNhap='" + giaTri + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai5(int giaTri)
        {
            string query = "Select count (*) from tblCTXuatNL where MaPhieuXuat='" + giaTri + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai6(int giaTri1, string giaTri2)
        {
            string query = "Select count(*) from tblCTXuatNL where MaPhieuXuat='" + giaTri1 + "' and MaNL='" + giaTri2 + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai7(int giaTri1, string giaTri2)
        {
            string query = "Select count(*) from tblCTNhapNL where MaPhieuNhap='" + giaTri1 + "' and MaNL='" + giaTri2 + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }
        public string layTenNL(string maNL)
        {
            string tenNL = "";
            string query = "Select TenNL from tblNguyenLieu where MaNL='" + maNL + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblNguyenLieu");
            DataTable dt = ds.Tables["tblNguyenLieu"];
            foreach (DataRow row in dt.Rows)
                tenNL = row["TenNL"].ToString();
            return tenNL;
        }

        public string layDonViTinhNL(string maNL)
        {
            string dvtNL = "";
            string query = "Select DonViTinh from tblNguyenLieu where MaNL='" + maNL + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblNguyenLieu");
            DataTable dt = ds.Tables["tblNguyenLieu"];
            foreach (DataRow row in dt.Rows)
                dvtNL = row["DonViTinh"].ToString();
            return dvtNL;
        }
        public string layDonGia(string maNL)
        {
            string donGia = "";
            string query = "Select DonGia from tblNguyenLieu where MaNL='" + maNL + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblNguyenLieu");
            DataTable dt = ds.Tables["tblNguyenLieu"];
            foreach (DataRow row in dt.Rows)
                donGia = row["DonGia"].ToString();
            return donGia;
        }

        public string layTenNV(string maNV)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string tenNV = "";
            string query = "Select TenNV from tblNhanVien where MaNV='" + maNV + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblNhanVien");
            DataTable dt = ds.Tables["tblNhanVien"];
            foreach (DataRow row in dt.Rows)
                tenNV = row["TenNV"].ToString();
            return tenNV;
        }

        public string layMaBan(int soBan)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string maBan = "";
            string query = "Select MaBan from tblBan where SoBan='" + soBan + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblBan");
            DataTable dt = ds.Tables["tblBan"];
            foreach (DataRow row in dt.Rows)
                maBan = row["MaBan"].ToString();
            return maBan;
        }

        public string laySoBan(string maBan)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string soBan = "";
            string query = "Select SoBan from tblBan where MaBan='" + maBan + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblBan");
            DataTable dt = ds.Tables["tblBan"];
            foreach (DataRow row in dt.Rows)
                soBan = row["SoBan"].ToString();
            return soBan;
        }

        public string laySLMon(string maMon, string maBan)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string sl = "";
            string query = "Select SoLuong from tblCTOder where MaMon='" + maMon + "' and MaBan='" + maBan + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblCTOder");
            DataTable dt = ds.Tables["tblCTOder"];
            foreach (DataRow row in dt.Rows)
                sl = row["SoLuong"].ToString();
            return sl;
        }

        public string laySLNLCon(string maNL)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string slc = "";
            string query = "Select SoLuongCon from tblNguyenLieu where MaNL='" + maNL + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblNguyenLieu");
            DataTable dt = ds.Tables["tblNguyenLieu"];
            foreach (DataRow row in dt.Rows)
                slc = row["SoLuongCon"].ToString();
            return slc;
        }

        public string layDVT(string maMon)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string dvt = "";
            string query = "Select DonViTinh from tblDSMon where MaMon='" + maMon + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblDSMon");
            DataTable dt = ds.Tables["tblDSMon"];
            foreach (DataRow row in dt.Rows)
                dvt = row["DonViTinh"].ToString();
            return dvt;
        }

        public string layTenMon(string maMon)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string tenmon = "";
            string query = "Select TenMon from tblDSMon where MaMon='" + maMon + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblDSMon");
            DataTable dt = ds.Tables["tblDSMon"];
            foreach (DataRow row in dt.Rows)
                tenmon = row["TenMon"].ToString();
            return tenmon;
        }

        public string layDonGiaMon(string maMon)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string dg = "";
            string query = "Select DonGia from tblDSMon where MaMon='" + maMon + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblDSMon");
            DataTable dt = ds.Tables["tblDSMon"];
            foreach (DataRow row in dt.Rows)
                dg = row["DonGia"].ToString();
            return dg;
        }

        public string layMaHD(int maOder)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string mahd = "";
            string query = "Select MaHD from tblHoaDon where MaOder='" + maOder + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblHoaDon");
            DataTable dt = ds.Tables["tblHoaDon"];
            foreach (DataRow row in dt.Rows)
                mahd = row["MaHD"].ToString();
            return mahd;
        }
        public bool kiemTraTonTai8(string maBan)
        {
            string query = "Select count (*) from tblBanCoKhach where MaBan='" + maBan + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai9(string maMon, string maBan, int maOder)
        {
            string query = "Select count (*) from tblCTOder where MaMon='" + maMon + "' and MaBan='" + maBan + "' and MaOder='" + maOder + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai10(int maOder)
        {
            string query = "Select count (*) from tblCTOder where MaOder='" + maOder + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }
        public bool kiemTraTonTai11(int soBan)
        {
            string query = "Select count (*) from tblBanCoKhach where SoBan='" + soBan + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai12(int maHD, string maMon)
        {
            string query = "Select count (*) from tblCTHoaDon where MaHD='" + maHD + "' and MaMon='" + maMon + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai13(DateTime ngay)
        {
            string query = "Select count (*) from tblDoanhThu where Ngay='" + ngay + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai14(int thang, string maNV)
        {
            string query = "Select count (*) from tblBangLuong where Thang='" + thang + "' and MaNV='" + maNV + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai15(string maBan)
        {
            string query = "Select count (*) from tblBanSDNhieu where MaBan='" + maBan + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai16(string maMon, DateTime ngay)
        {
            string query = "Select count (*) from tblCTDoanhThu where MaMon='" + maMon + "' and Ngay='" + ngay + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }

        public bool kiemTraTonTai17(int maOder)
        {
            string query = "Select count (*) from tblOder where MaOder='" + maOder + "'";
            command = new SqlCommand(query, connect);
            int number = 0;
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }
                number = (int)command.ExecuteScalar();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            if (number > 0)
                return true;
            else
                return false;
        }
        public string layDoanhThu(DateTime ngay)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string doanhthu = "";
            string query = "Select DoanhThu from tblDoanhThu where Ngay='" + ngay + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblDoanhThu");
            DataTable dt = ds.Tables["tblDoanhThu"];
            foreach (DataRow row in dt.Rows)
                doanhthu = row["DoanhThu"].ToString();
            return doanhthu;
        }

        public string layChucVu(string maNV)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string chucvu = "";
            string query = "Select ChucVu from tblNhanVien where MaNV='" + maNV + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblNhanVien");
            DataTable dt = ds.Tables["tblNhanVien"];
            foreach (DataRow row in dt.Rows)
                chucvu = row["ChucVu"].ToString();
            return chucvu;
        }

        public string laySoGioLam(string maNV, int thang)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string sgl = "";
            string query = "Select TongGioLam from tblBangLuong where MaNV='" + maNV + "' and Thang='" + thang + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblBangLuong");
            DataTable dt = ds.Tables["tblBangLuong"];
            foreach (DataRow row in dt.Rows)
                sgl = row["TongGioLam"].ToString();
            return sgl;
        }

        public string layLuotSDBan(string maBan)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string luotsd = "";
            string query = "Select LuotSD from tblBanSDNhieu where MaBan='" + maBan + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblBanSDNhieu");
            DataTable dt = ds.Tables["tblBanSDNhieu"];
            foreach (DataRow row in dt.Rows)
                luotsd = row["LuotSD"].ToString();
            return luotsd;
        }

        public string laySLMonBan(string maMon)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            string sl = "";
            string query = "Select SoLuongBan from tblCTDoanhThu where MaMon='" + maMon + "'";
            da.SelectCommand = new SqlCommand(query, connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "tblCTDoanhThu");
            DataTable dt = ds.Tables["tblCTDoanhThu"];
            foreach (DataRow row in dt.Rows)
                sl = row["SoLuongBan"].ToString();
            return sl;
        }

    }
}
