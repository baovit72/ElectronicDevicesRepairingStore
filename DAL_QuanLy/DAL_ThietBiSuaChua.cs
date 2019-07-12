using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using DTO_QuanLy;
namespace DAL_QuanLy
{
    public class DAL_ThietBiSuaChua
    {
        DBconnection conn;
        public DAL_ThietBiSuaChua()
        {
            conn = new DBconnection();
        }
        public DataTable getDeviceById(int _id)
        {
            string query = "select * from THIETBISUACHUA where MaThietBi = @_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_id);
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getAllDevices()
        {
            string query = "select * from THIETBISUACHUA";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public bool insertDevice(DTO_ThietBiSuaChua thietBiSuaChuaDTO)
        {
            string query = "insert into THIETBISUACHUA(TenThietBi, Model, MaNhanHieu) values(@_Ten,@_Model,@_BrandId)";
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@_Ten", SqlDbType.NVarChar);
            sqlParameters[0].Value = thietBiSuaChuaDTO.Name;
            sqlParameters[1] = new SqlParameter("@_Model", SqlDbType.VarChar);
            sqlParameters[1].Value = thietBiSuaChuaDTO.Model;
            sqlParameters[2] = new SqlParameter("@_BrandId", SqlDbType.VarChar);
            sqlParameters[2].Value = thietBiSuaChuaDTO.BrandID.ToString();
            return conn.executeInsertQuery(query, sqlParameters);
        }

        public int getNextDeviceID() 
        {
            string query = "select max(MaThietBi) from THIETBISUACHUA";
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
