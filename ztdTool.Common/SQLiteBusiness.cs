using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztdTool.Common
{
    public class SQLiteBusiness
    {
        public SqlLiteHelper sh = new SqlLiteHelper(string.Format(@"Data Source={0}LibConfig.db", Utils.dataPath));
        public SQLiteBusiness() { }

        public SQLiteBusiness(string path)
        {
            sh = new SqlLiteHelper(path);
        }

        /// <summary>
        /// 创建数据库
        /// </summary>
        public void CreateDB()
        {
            sh.CreateDB();
        }

        /// <summary>
        /// 判断数据是否存在
        /// </summary>
        /// <param name="TableName">要判断的表名</param>
        /// <returns></returns>
        public DataTable ValidateIsTable(string TableName)
        {
            string sql = "SELECT COUNT(*)  as CNT FROM sqlite_master where type='table' and name='" + TableName + "'";
            return sh.ExecuteDataTable(sql, null);
        }

        /// <summary>
        /// 运行SQL语句获取DataSet数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable GetSqlExec(string sql)
        {
            return sh.ExecuteDataTable(sql, null);
        }

        /// <summary>
        /// 查询sqlite数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="sWhere">条件</param>
        /// <returns></returns>
        public DataTable GetSqliteData(string tableName, string sWhere)
        {
            string sql = "select * from " + tableName + "  where 1=1 " + sWhere;
            return sh.ExecuteDataTable(sql, null);
        }
        /// <summary>
        /// 执行sql语句
        /// </summary>
        /// <param name="Sql"></param>
        /// <returns></returns>
        public int ExecuteSql(string Sql)
        {
            return sh.ExecuteSql(Sql);
        }
        /// <summary>
        /// 用当前DataTable覆盖sqlite表
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="TableName"></param>
        public void AddNewTable(DataTable dt, string TableName)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.AppendFormat("Drop Table If Exists [{0}]; CREATE TABLE '{1}' ( ", TableName, TableName);
            StringBuilder sbSqlInsert = new StringBuilder();
            sbSqlInsert.AppendFormat("insert into {0} ( ", TableName);

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (i == dt.Columns.Count - 1)
                {
                    if (dt.Columns[i].DataType == Type.GetType("System.Double"))
                    {
                        sbSql.Append(dt.Columns[i].ColumnName.ToString());
                        sbSql.Append(" float) ;");
                    }
                    else
                    {
                        sbSql.Append(dt.Columns[i].ColumnName.ToString());
                        sbSql.Append(" NVARCHAR) ;");
                    }
                    sbSqlInsert.Append(dt.Columns[i].ColumnName.ToString());
                    sbSqlInsert.Append(" ) ");
                }
                else
                {
                    if (dt.Columns[i].DataType == Type.GetType("System.Double"))
                    {
                        sbSql.Append(dt.Columns[i].ColumnName.ToString());
                        sbSql.Append(" float,");
                    }
                    else
                    {
                        sbSql.Append(dt.Columns[i].ColumnName.ToString());
                        sbSql.Append(" NVARCHAR,");
                    }
                    sbSqlInsert.Append(dt.Columns[i].ColumnName.ToString());
                    sbSqlInsert.Append(" ,");
                }
            }
            //创建表
            if (sbSql.Length > 0)
            {
                sh.ExecuteSql(sbSql.ToString());

                ArrayList list = new ArrayList();
                foreach (DataRow row in dt.Rows)
                {
                    StringBuilder sbSqlValue = new StringBuilder();
                    sbSqlValue.Append("values (");
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (i == dt.Columns.Count - 1)
                        {
                            sbSqlValue.Append("\"");
                            sbSqlValue.Append(row[i].ToString().Replace("\"", "'"));
                            sbSqlValue.Append("\")");
                        }
                        else
                        {
                            sbSqlValue.Append("\"");
                            sbSqlValue.Append(row[i].ToString().Replace("\"", "'"));
                            sbSqlValue.Append("\",");
                        }
                    }
                    list.Add(sbSqlInsert.ToString() + sbSqlValue.ToString());
                }
                if (list.Count > 0)
                {
                    //批量插入
                    sh.ExecuteList(list);
                }
            }
        }
    }
}
