using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_YeuCauSuaChua
    {
        DBconnection conn;
        public DAL_YeuCauSuaChua()
        {
            conn = new DBconnection();
        }
        public DataTable getRequestById(int _id)
        {
            string query = "select * from YEUCAUSUACHUA where MaYeuCau = @_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_id);
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getAllRequests()
        {
            string query = "select * from YEUCAUSUACHUA";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public bool insertRequest(DTO_YeuCauSuaChua yeucauDTO)
        {
            string query = "insert into YEUCAUSUACHUA(MaKH, NgayNhan, MaMonHang, SoLuong, MoTaTinhTrang, DaSuaChua, ChiTiet) " +
                                        " values(@_MaKH,@_NgayNhan,@_MaMonHang, @_SoLuong, @_MoTaTinhTrang, @_DaSuaChua, @_ChiTiet)";
            SqlParameter[] sqlParameters = new SqlParameter[7];
            sqlParameters[0] = new SqlParameter("@_MaKH", SqlDbType.VarChar);
            sqlParameters[0].Value = yeucauDTO.MaKH.ToString();
            sqlParameters[1] = new SqlParameter("@_NgayNhan", SqlDbType.VarChar);
            sqlParameters[1].Value = yeucauDTO.NgayNhan.ToString("MM-dd-yyyy");
            sqlParameters[2] = new SqlParameter("@_MaMonHang", SqlDbType.VarChar);
            sqlParameters[2].Value = yeucauDTO.MaMonHang.ToString();
            sqlParameters[3] = new SqlParameter("@_SoLuong", SqlDbType.VarChar);
            sqlParameters[3].Value = yeucauDTO.SoLuong.ToString();
            sqlParameters[4] = new SqlParameter("@_MoTaTinhTrang", SqlDbType.NVarChar);
            sqlParameters[4].Value = yeucauDTO.MoTaTinhTrang;
            sqlParameters[5] = new SqlParameter("@_DaSuaChua", SqlDbType.VarChar);
            sqlParameters[5].Value = yeucauDTO.DaSuaChua.ToString();
            sqlParameters[6] = new SqlParameter("@_ChiTiet", SqlDbType.NVarChar);
            sqlParameters[6].Value = yeucauDTO.ChiTiet;

            return conn.executeInsertQuery(query, sqlParameters);
        }

        public int getNextRequestID()
        {
            string query = "select max(MaYeuCau) from YEUCAUSUACHUA";
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


    }
}
