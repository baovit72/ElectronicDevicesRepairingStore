using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

using System.Data.SqlClient;
using DTO_QuanLy;
namespace DAL_QuanLy
{
    public class DAL_NhapThietBi
    {
        DBconnection conn;
        public DAL_NhapThietBi()
        {
            conn = new DBconnection();
        }

        public DataTable getBoughtDeviceById(int _id)
        {
            string query = "select * from NHAPTHIETBI where MaNhap = @_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_id);
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getBoughtDevicesByRequestId(int _id)
        {
            string query = "select * from NHAPTHIETBI where MaYeuCau = @_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_id);
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getAllBoughtDevices()
        {
            string query = "select * from NHAPTHIETBI";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public bool insertBoughtDevice(DTO_NhapThietBi nhapDTO)
        {
            string query = "insert into NHAPTHIETBI(MaYeuCau, TenThietBi, SoLuong, DonGia, NgayNhap) " +
                                        " values(@_MaYeuCau,@_TenThietBi, @_SoLuong, @_DonGia, @_NgayNhap)";
            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("@_MaYeuCau", SqlDbType.VarChar);
            sqlParameters[0].Value = nhapDTO.RequestID.ToString();
            sqlParameters[1] = new SqlParameter("@_TenThietBi", SqlDbType.NVarChar);
            sqlParameters[1].Value = nhapDTO.DeviceName;
            sqlParameters[2] = new SqlParameter("@_SoLuong", SqlDbType.VarChar);
            sqlParameters[2].Value = nhapDTO.Quantity.ToString();
            sqlParameters[3] = new SqlParameter("@_DonGia", SqlDbType.VarChar);
            sqlParameters[3].Value = nhapDTO.UnitPrice.ToString();
            sqlParameters[4] = new SqlParameter("@_NgayNhap", SqlDbType.VarChar);
            sqlParameters[4].Value = nhapDTO.Date.ToString("MM-dd-yyyy");

            return conn.executeInsertQuery(query, sqlParameters);
        }

        public int getNextBoughtDeviceID()
        {
            string query = "select max(MaNhap) from NHAPTHIETBI";
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

        public bool deleteBoughtDevice(DTO_NhapThietBi nhapDTO)
        {
            string query = "delete from NHAPTHIETBI where MaNhap = @_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(nhapDTO.ID);
            return conn.executeDeleteQuery(query, sqlParameters); 
        }

    }
}


