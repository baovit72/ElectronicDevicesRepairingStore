using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using DTO_QuanLy;

namespace DAL_QuanLy
{
    public class DAL_SuaChua
    {
        DBconnection conn;
        public DAL_SuaChua()
        {
            conn = new DBconnection();
        }

        public DataTable getRepairingById(int _id)
        {
            string query = "select * from SUACHUA where MaSuaChua = @_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_id);
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getRepairingByRequestId(int _id)
        {
            string query = "select * from SUACHUA where MaYeuCau = @_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_id);
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getAllRepairings()
        {
            string query = "select * from SUACHUA";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return conn.executeSelectQuery(query, sqlParameters);
        }

        public bool insertRepairing(DTO_SuaChua repairDTO)
        {
            string query = "if exists (select * from YEUCAUSUACHUA where MaYeuCau = @_MaYeuCau and DaSuaChua = 0) begin insert into SUACHUA(MaYeuCau, NgayLap, TienCong, MoTaLoi) " +
                                        " values(@_MaYeuCau,@_NgayLap, @_TienCong, @_MoTaLoi ) update YEUCAUSUACHUA set DaSuaChua = 1 where MaYeuCau = @_MaYeuCau end  ";
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@_MaYeuCau", SqlDbType.VarChar);
            sqlParameters[0].Value = repairDTO.requestID.ToString();
            sqlParameters[1] = new SqlParameter("@_NgayLap", SqlDbType.VarChar);
            sqlParameters[1].Value = repairDTO.Date.ToString("MM-dd-yyyy");
            sqlParameters[2] = new SqlParameter("@_TienCong", SqlDbType.VarChar);
            sqlParameters[2].Value = repairDTO.TienCong.ToString();
            sqlParameters[3] = new SqlParameter("@_MoTaLoi", SqlDbType.NVarChar);
            sqlParameters[3].Value = repairDTO.MoTaLoi; 

            return conn.executeInsertQuery(query, sqlParameters);
        }

        public int getNextRepairingID()
        {
            string query = "select max(MaSuaChua) from SUACHUA";
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

        public bool deleteRepairing(DTO_SuaChua repairDTO)
        {
            string query = "delete from SUACHUA where MaSuaChua = @_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(repairDTO.ID);
            return conn.executeDeleteQuery(query, sqlParameters);
        }

    }
}
