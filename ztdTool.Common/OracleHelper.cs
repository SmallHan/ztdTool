using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OracleClient;
using System.Data;

namespace ztdTool.Common
{
    public class OracleHelper
    {
        public static string ConnectionString = string.Empty;
        public OracleHelper() { }

                /// <summary>
        /// 带参数构造函数
        /// </summary>
        /// <param name="connectionstring">连接串</param>
        public OracleHelper(string connectionstring)
        {
            if (!string.IsNullOrEmpty(connectionstring))
            {
                ConnectionString = connectionstring;
            }
        }

        public bool GetConnStatus()
        {
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                        conn.Dispose();
                        return true;
                    }
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
        /// <summary>
        /// 查询语句函数
        /// </summary>
        /// <param name="Sqlstr"></param>
        /// <returns>DataSet.table["ds"]或者table[0]</returns>
        public DataTable QueryToDataTable(string Sqlstr, string tableName="")
        {
            DataTable dtTemp = new DataTable();
            using (OracleConnection conn = new OracleConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    OracleDataAdapter da = new OracleDataAdapter(Sqlstr, conn);
                    if (!string.IsNullOrWhiteSpace(tableName))
                    {
                        dtTemp.TableName = tableName;
                    }
                    da.Fill(dtTemp);
                }
                catch (System.Data.OracleClient.OracleException ex)
                {
                    LogHelper.Error("服务端查询异常日志:", ex);
                }
            }
            return dtTemp;
        }
    }
}
