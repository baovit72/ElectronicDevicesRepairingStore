using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO_QuanLy;
using System.Data;
using System.Data.SqlClient;


namespace DAL_QuanLy
{
    public class DAL_HoaDon
    {
        DBconnection conn;
        public DAL_HoaDon()
        {
            conn = new DBconnection();
        }
        public DataTable getFullInfoByRequestId(int _id)
        {
            string query = "select y.MaYeuCau, TenThietBi,  NgayNhan, TenNhanHieu, Model, HoTen, SoDienThoai, DiaChi, DaSuaChua, SoLuong, MoTaTinhTrang, ChiTiet, TienCong, MoTaLoi from YEUCAUSUACHUA y inner join KHACHHANG k on y.MaKH = k.MaKhachHang join THIETBISUACHUA t on y.MaMonHang = t.MaThietBi join NHANHIEU n on t.MaNhanHieu = n.MaNhanHieu left join SUACHUA s on s.MaYeuCau = y.MaYeuCau where s.MaYeuCau = @_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_id);
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getAllFullInfos()
        {
            string query = "select y.MaYeuCau, TenThietBi,  NgayNhan, TenNhanHieu, Model, HoTen, SoDienThoai, DiaChi, DaSuaChua, SoLuong, MoTaTinhTrang, ChiTiet, TienCong, MoTaLoi from YEUCAUSUACHUA y inner join KHACHHANG k on y.MaKH = k.MaKhachHang join THIETBISUACHUA t on y.MaMonHang = t.MaThietBi join NHANHIEU n on t.MaNhanHieu = n.MaNhanHieu left join SUACHUA s on s.MaYeuCau = y.MaYeuCau";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return conn.executeSelectQuery(query, sqlParameters);
        }
        
        public DataTable getUnRepairedFullInfos()
        {
            string query = "select y.MaYeuCau, TenThietBi,  NgayNhan, TenNhanHieu, Model, HoTen, SoDienThoai, DiaChi, DaSuaChua, SoLuong, MoTaTinhTrang, ChiTiet, TienCong, MoTaLoi from YEUCAUSUACHUA y inner join KHACHHANG k on y.MaKH = k.MaKhachHang join THIETBISUACHUA t on y.MaMonHang = t.MaThietBi join NHANHIEU n on t.MaNhanHieu = n.MaNhanHieu left join SUACHUA s on s.MaYeuCau = y.MaYeuCau where DaSuaChua = 0";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public bool deleteFullInfo(DTO_HoaDon hoadonDTO)
        {
            //Nếu có thiết bị refer tới thì không xoá hoặc đã được sửa chữa thì không xoá

            

            string query = "delete from YEUCAUSUACHUA where MaYeuCau = @_id and DaSuaChua = 0 ";
                                 
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(hoadonDTO.ID);
            return conn.executeDeleteQuery(query, sqlParameters);
            //{
            //    //Xoá thành công thì xoá thiết bị liên kết
            //    query  = "delete from THIETBISUACHUA where MaThietBi in (select MaMonHang from YEUCAUSUACHUA where MaYeuCau = @_id)"; 
            //    sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            //    sqlParameters[0].Value = Convert.ToString(hoadonDTO.ID);
            //    return conn.executeDeleteQuery(query, sqlParameters);
            //}
            
        }

    }
}
