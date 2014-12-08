using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Training.Data
{
    public class DBHelper
    {
        public static SqlConnection connection;
        public static SqlConnection Connection
        {
            get
            {
                string connectionString = ConfigurationManager.ConnectionStrings["movie"].ConnectionString;
                if (connection == null)
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Closed)
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }
        }

        #region Add,delete,update ExecuteNonQuery
        /// <summary>   
        /// add,delete or update one record   
        /// </summary>   
        /// <param name="safeSql"></param>   
        /// <returns></returns>   
        public static int ExecuteCommand(string safeSql)
        {
            try
            {
                using (var cmd = new SqlCommand(safeSql, Connection))
                {
                    var result = cmd.ExecuteNonQuery();
                    return result;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Add,delete,update ExecuteNonQuery
        /// <summary>   
        /// Add,delete,update ExecuteNonQuery with multiple records  
        /// </summary>   
        /// <param name="safeSql"></param>   
        /// <param name="values"></param>   
        /// <returns></returns>   
        public static int ExecuteCommand(string safeSql, params SqlParameter[] values)
        {
            try
            {
                using (var cmd = new SqlCommand(safeSql, Connection))
                {
                    cmd.Parameters.AddRange(values);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Add,delete,update ExecuteNonQuery with multiple records
        /// <summary>   
        /// Add,delete,update with multiple parameters
        /// </summary>   
        /// <param name="safeSql"></param>   
        /// <param name="values"></param>   
        /// <returns></returns>   
        public static int ExecuteCommand(string safeSql, CommandType type, params SqlParameter[] values)
        {
            try
            {
                using (var cmd = new SqlCommand(safeSql, Connection))
                {
                    cmd.CommandType = type;
                    cmd.Parameters.AddRange(values);
                    cmd.ExecuteNonQuery();
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Add,delete,update with multiple parameters
        /// <summary>   
        /// Add,delete,update with multiple parameters   
        /// </summary>   
        /// <param name="safeSql"></param>   
        /// <param name="values"></param>   
        /// <returns></returns>   
        public static int ExecuteCommand(string safeSql, CommandType type, int index)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand(safeSql, Connection))
                {
                    cmd.CommandType = type;
                    var paramOne = new SqlParameter("@rid", SqlDbType.Int) { Value = index };
                    cmd.Parameters.Add(paramOne);
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Search ExecuteScalar
        /// <summary>   
        /// one parameter  
        /// </summary>   
        /// <param name="safeSql"></param>   
        /// <returns></returns>   
        public static int GetScalar(string safeSql)
        {
            try
            {
                using (var cmd = new SqlCommand(safeSql, Connection))
                {
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ExecuteScalar with parameter
        /// <summary>   
        /// ExecuteScalar with parameter  
        /// </summary>   
        /// <param name="sql"></param>   
        /// <param name="values"></param>   
        /// <returns></returns>   
        public static int GetScalar(string sql, params SqlParameter[] values)
        {
            try
            {
                using (var cmd = new SqlCommand(sql, Connection))
                {
                    cmd.Parameters.AddRange(values);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ExecuteScalar with type
        /// <summary>   
        ///ExecuteScalar with type
        /// </summary>   
        /// <param name="sql"></param>   
        /// <param name="type"></param>   
        /// <param name="values"></param>   
        /// <returns></returns>   
        public static int GetScalar(string sql, CommandType type, params SqlParameter[] values)
        {
            try
            {
                using (var cmd = new SqlCommand(sql, Connection))
                {
                    cmd.CommandType = type;
                    cmd.Parameters.AddRange(values);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region return DataReader
        /// <summary>   
        /// Get data records  
        /// </summary>   
        /// <param name="safeSql"></param>   
        /// <returns></returns>   
        public static SqlDataReader GetReader(string safeSql)
        {
            try
            {
                using (var cmd = new SqlCommand(safeSql, Connection))
                {
                    var reader = cmd.ExecuteReader();
                    return reader;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Get data records with parameters
        /// <summary>   
        /// Get data records with parameters  
        /// </summary>   
        /// <param name="sql"></param>   
        /// <param name="values"></param>   
        /// <returns></returns>   
        public static SqlDataReader GetReader(string sql, params SqlParameter[] values)
        {
            try
            {
                using (var cmd = new SqlCommand(sql, Connection))
                {
                    cmd.Parameters.AddRange(values);
                    SqlDataReader reader = cmd.ExecuteReader();
                    return reader;
                }
            }
            catch (SqlException)
            {
                throw;
            }
        }
        #endregion

        #region Get data records with parameters
        /// <summary>   
        /// Get data records with parameters   
        /// </summary>   
        /// <param name="safeSql"></param>   
        /// <param name="cmdType"></param>   
        /// <param name="values"></param>   
        /// <returns></returns>   
        public static SqlDataReader GetReader(string safeSql, CommandType cmdType, params SqlParameter[] values)
        {
            try
            {
                using (var cmd = new SqlCommand(safeSql, Connection))
                {
                    cmd.CommandType = cmdType;
                    cmd.Parameters.AddRange(values);
                    SqlDataReader reader = cmd.ExecuteReader();
                    return reader;
                }

            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }
        #endregion

        #region return dataTable
        /// <summary>   
        /// return datatable   
        /// </summary>   
        /// <param name="safeSql"></param>   
        /// <returns></returns>   
        public static DataTable GetDataSet(string safeSql)
        {
            var ds = new DataSet();
            var cmd = new SqlCommand(safeSql, Connection);
            var da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
        #endregion

        #region return dataTable with parameter
        /// <summary>   
        ///  return dataTable with parameter   
        /// </summary>   
        /// <param name="sql"></param>   
        /// <param name="values"></param>   
        /// <returns></returns>   
        public static DataTable GetDataSet(string sql, params SqlParameter[] values)
        {
            var ds = new DataSet();
            var cmd = new SqlCommand(sql, Connection);
            cmd.Parameters.AddRange(values);
            var da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds.Tables[0];
        }
        #endregion
    }
}
