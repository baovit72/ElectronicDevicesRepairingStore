using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{

    public class DAL_KhachHang
    {
        private DBconnection conn;
        public DAL_KhachHang()
        {
            conn = new DBconnection();
        }

        public DataTable getCustomerById(int _id)
        {
            string query = "select * from KhachHang where MaKhachHang = @_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_id);
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getAllCustomers()
        {
            string query = "select * from KhachHang ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public bool insertCustomer(DTO_KhachHang khachHangDTO)
        {
            string query = "insert into KhachHang(HoTen, DiaChi, SoDienThoai) values(@_HoTen, @_DiaChi, @_SDT)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@_HoTen", SqlDbType.NVarChar);
            sqlParameters[0].Value = khachHangDTO.HoTen;
            sqlParameters[1] = new SqlParameter("@_DiaChi", SqlDbType.NVarChar);
            sqlParameters[1].Value = khachHangDTO.DiaChi;
            sqlParameters[2] = new SqlParameter("@_SDT", SqlDbType.VarChar);
            sqlParameters[2].Value = khachHangDTO.SDT;

            return conn.executeInsertQuery(query, sqlParameters);
        }

        public int getNextCustomerID()
        {
            string query = "select max(MaKhachHang) from KHACHHANG";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = conn.executeSelectQuery(query, sqlParameters);
            if (dataTable.Rows != null)
            {
                if (dataTable.Rows.Count > 0)
                    if (dataTable.Rows[0][0].ToString().Length > 0)
                        return Int32.Parse(dataTable.Rows[0][0].ToString()) + 1;
            }
            return -1;
        }

        public int IsDuplicate(DTO_KhachHang khachHangDTO)
        {
            string query = "select Count(MaKhachHang) from KHACHHANG where SoDienThoai = @_SDT and HoTen = @_HoTen";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@_SDT", SqlDbType.VarChar);
            sqlParameters[0].Value = khachHangDTO.SDT;
            sqlParameters[1] = new SqlParameter("@_HoTen", SqlDbType.NVarChar);
            sqlParameters[1].Value = khachHangDTO.HoTen;
            DataTable dataTable = conn.executeSelectQuery(query, sqlParameters);
            if (dataTable.Rows != null)
            {
             
                if (dataTable.Rows.Count > 0)
                    if (dataTable.Rows[0][0].ToString().Length > 0)
                        return Int32.Parse(dataTable.Rows[0][0].ToString());
            }
            return -1;

        }

    }
}
