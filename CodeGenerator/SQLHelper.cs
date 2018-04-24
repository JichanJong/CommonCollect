
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace CodeGenerator
{
    public partial class SQLHelper
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public static string ConnectionString { get; set; }
        /// <summary>
        /// 执行查询，返回影响行数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sql, params SqlParameter[] paras)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = PrepareCommand(conn, sql))
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// 执行查询，返回第一行第一列
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sql, params SqlParameter[] paras)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = PrepareCommand(conn, sql, paras))
                {
                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }
        /// <summary>
        /// 执行查询，返回数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataset(string sql, params SqlParameter[] paras)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = PrepareCommand(conn, sql, paras))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    return ds;
                }
            }
        }
        /// <summary>
        /// 执行查询，返回DataReader
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] paras)
        {
            SqlConnection conn = GetConnection();
            SqlCommand cmd = PrepareCommand(conn, sql, paras);
            conn.Open();
            return cmd.ExecuteReader();
        }

        private static SqlCommand PrepareCommand(SqlConnection conn, string sql, params SqlParameter[] paras)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (paras != null && paras.Length > 0)
            {
                cmd.Parameters.AddRange(paras);
            }
            return cmd;
        }

        private static SqlConnection GetConnection()
        {
            if (string.IsNullOrWhiteSpace(ConnectionString))
            {
                throw new Exception("连接字符串不能为空");
            }
            return new SqlConnection(ConnectionString);
        }
        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="msg"></param>
        public static void TestConnection(out string msg)
        {
            TestConnection(ConnectionString, out msg);   
        }

        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="msg"></param>
        public static void TestConnection(string connectionString, out string msg)
        {
            msg = "";
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
            }
            catch (Exception ex)
            {
                msg = "连接失败," + ex.Message + Environment.NewLine + ex.StackTrace.ToString();
            }
            finally
            {
                if (conn != null)
                {
                    conn.Dispose();
                }
            }
        }
    }
}
