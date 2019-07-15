using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data; 
namespace DAL_QuanLy
{
    class DBconnection
    {
        private SqlDataAdapter myAdapter;
        private SqlConnection conn;

        ///<constructor>
        ///Initialise Connection
        ///</constructor>

        public DBconnection()
        {
            myAdapter = new SqlDataAdapter();
            conn = new SqlConnection("Data Source = localhost\\SQLEXPRESS; Initial Catalog = REPAIRINGSTORE; Integrated Security = True");
        }

        ///<method>
        ///Open database connection if closed or broken
        /// </method>

        private SqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        ///<method>
        /// Select Query
        /// </method>

        public DataTable executeSelectQuery(String _query, SqlParameter[] sqlParameters)
        {
            SqlCommand sqlCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(sqlParameters);
                sqlCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = sqlCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch(SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return null;
            }

            finally
            {

            }
            return dataTable;
        }

        ///<method>
        /// Insert Query
        /// </method>

        public bool executeInsertQuery(String _query, SqlParameter[] sqlParameters)
        {
            SqlCommand sqlCommand = new SqlCommand();
            try
            {
                sqlCommand.Connection = openConnection();
                sqlCommand.CommandText = _query;
                sqlCommand.Parameters.AddRange(sqlParameters);
                myAdapter.InsertCommand = sqlCommand;
                sqlCommand.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {

            }
            return true;
        }

        ///<method>
        /// Update Query
        /// </method>

        public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameters)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameters);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {

            }
            return true;
        }

        public bool executeDeleteQuery(String _query, SqlParameter[] sqlParameters)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = openConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameters);
                myAdapter.DeleteCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeDeleteQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {

            }
            return true;
        }

    }
}
