using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;
using System.Diagnostics;
namespace DAL_QuanLy
{
    public class DAL_NhanHieu
    {
        DBconnection conn;
        public DAL_NhanHieu()
        {
            conn = new DBconnection();
        }

        public DataTable getBrandById(int _id)
        {
            string query = "select * from NhanHieu where MaNhanHieu = @_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_id);
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getAllBrands()
        {
            string query = "select * from NhanHieu";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public bool insertBrand(DTO_NhanHieu nhanHieuDTO)
        {
            string query = "insert into NhanHieu(TenNhanHieu) values(@_TenNhanHieu)";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_TenNhanHieu", SqlDbType.NVarChar);
            sqlParameters[0].Value = nhanHieuDTO.Name;
            return conn.executeInsertQuery(query, sqlParameters);
        }

        public int getNextBrandID()
        {
            string query = "select max(MaNhanHieu) from NHANHIEU";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            DataTable dataTable = conn.executeSelectQuery(query, sqlParameters);
            if (dataTable.Rows!= null)
            {
                 
                if (dataTable.Rows.Count > 0)
                    if (dataTable.Rows[0][0].ToString().Length > 0 )
                        return Int32.Parse(dataTable.Rows[0][0].ToString()) + 1;
            }
            return -1;
        }

        public int IsDuplicate(DTO_NhanHieu nhanHieuDTO)
        {
            string query = "select Count(MaNhanHieu) from NHANHIEU where TenNhanHieu = @_Name";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_Name", SqlDbType.NVarChar);
            sqlParameters[0].Value = nhanHieuDTO.Name;


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
