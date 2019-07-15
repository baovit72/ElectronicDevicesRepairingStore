using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using DTO_QuanLy;

namespace DAL_QuanLy
{
   
    public class DAL_Statistics
    {
        DBconnection conn;
        public DAL_Statistics()
        {
            conn = new DBconnection();
        }

        public DataTable getRequestSpecificDayStatistic(DateTime date)
        {
            string query = "select count(*) from YEUCAUSUACHUA where NgayNhan = @_date";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_date", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(date.ToString("MM-dd-yyyy"));
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getWageSpecificDayStatistic(DateTime date)
        {
            string query = "select sum(tiencong) from YEUCAUSUACHUA join SUACHUA on YEUCAUSUACHUA.MaYeuCau = SUACHUA.MaYeuCau where NgayNhan = @_date" ;
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_date", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(date.ToString("MM-dd-yyyy"));
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getWageSpecificMonthStatistic(DateTime date)
        {
            string query = "select sum(tiencong) from YEUCAUSUACHUA join SUACHUA on YEUCAUSUACHUA.MaYeuCau = SUACHUA.MaYeuCau where MONTH(NgayNhan) = @_month and YEAR(NgayNhan) = @_year";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@_month", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(date.ToString("MM")); 
            sqlParameters[1] = new SqlParameter("@_year", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(date.ToString("yyyy"));
            return conn.executeSelectQuery(query, sqlParameters);
        }
        public DataTable getRequestSpecificMonthStatistic(DateTime date)
        {
            string query = "select count(*) from YEUCAUSUACHUA where MONTH(NgayNhan) = @_month and YEAR(NgayNhan) = @_year";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@_month", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(date.ToString("MM"));
            sqlParameters[1] = new SqlParameter("@_year", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(date.ToString("yyyy"));
            return conn.executeSelectQuery(query, sqlParameters);
        }
    }
}
