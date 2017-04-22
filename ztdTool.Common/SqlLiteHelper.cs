using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace ztdTool.Common
{
    public class SqlLiteHelper
    {

        /// <summary>
        /// 连接字符串
        /// </summary>
        private string _ConnectionString = string.Empty;
        /// <summary>
        /// 设置或获取连接字符串
        /// </summary>
        public string ConnectionString
        {
            get { return _ConnectionString; }
            set { _ConnectionString = value; }
        }

        /// <summary>
        /// 空构造函数
        /// </summary>
        public SqlLiteHelper() { }

        /// <summary>
        /// 带参数构造函数
        /// </summary>
        /// <param name="connectionstring">连接串</param>
        public SqlLiteHelper(string connectionstring)
        {
            if (!string.IsNullOrEmpty(connectionstring))
            {
                this._ConnectionString = connectionstring;
            }
        }
        /// <summary>
        /// 数据创建函数（自行判断是否存在数据库文件进行增加）
        /// </summary>
        public void CreateDB()
        {
            try
            {
                string sqlitedbPath = this._ConnectionString.Split(';')[0].Substring(_ConnectionString.IndexOf('=') + 1);
                //检查不存在
                if (!File.Exists(sqlitedbPath))
                {
                    using (SQLiteConnection cnn = new SQLiteConnection(_ConnectionString))
                    {
                        //创建数据库
                        SQLiteConnection.CreateFile(sqlitedbPath);
                        cnn.Open();
                        cnn.Close();
                    }
                }
            }
            catch (Exception ex)
            {
 
            }
        }

        /// <summary>
        /// 采用简单的数据运行语句函数
        /// </summary>
        /// <param name="Sql">传入需要创建的数据语句</param>
        /// <returns></returns>
        public int ExecuteSql(string Sql)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_ConnectionString))
            {
                connection.Open();
                using (SQLiteTransaction trans = connection.BeginTransaction())
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        try
                        {
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = Sql;
                            int row = cmd.ExecuteNonQuery();
                            trans.Commit();
                            return row;
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            LogHelper.Error("Sqlite执行报错", ex);
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 执行一个查询语句，返回一个包含查询结果的DataTable
        /// </summary>
        /// <param name="sql">要执行的查询语句</param>
        /// <param name="parameters">执行SQL查询语句所需要的参数，参数必须以它们在SQL语句中的顺序为准</param>
        /// <returns></returns>
        public DataTable ExecuteDataTable(string sql, IList<SQLiteParameter> parameters)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_ConnectionString))
            {
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    try
                    {
                        if (!(parameters == null || parameters.Count == 0))
                        {
                            foreach (SQLiteParameter parameter in parameters)
                            {
                                command.Parameters.Add(parameter);
                            }
                        }
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                        DataTable data = new DataTable();
                        adapter.Fill(data);
                        return data;
                    }
                    catch (Exception)
                    {
                        return null;
                    }
                }
            }
        }

        /// <summary>
        /// 执行数据库操作(新增、更新或删除)同时返回执行后查询所得的第1行第1列数据
        /// </summary>
        /// <param name="sql">Sql</param>
        /// <returns>查询所得的第1行第1列数据</returns>
        public object ExecuteScalar(string sql)
        {
            object result = 0;
            using (SQLiteConnection con = new SQLiteConnection(_ConnectionString))
            {
                con.Open();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql;

                    SQLiteTransaction trans = null;
                    PrepareCommand(cmd, con, ref trans, true, cmd.CommandType, cmd.CommandText);
                    try
                    {
                        result = cmd.ExecuteScalar();
                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        LogHelper.Error("Sqlite执行报错", ex);
                        return 0;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// 预处理Command对象,数据库链接,事务,需要执行的对象,参数等的初始化
        /// </summary>
        /// <param name="cmd">Command对象</param>
        /// <param name="conn">Connection对象</param>
        /// <param name="trans">Transcation对象</param>
        /// <param name="useTrans">是否使用事务</param>
        /// <param name="cmdType">SQL字符串执行类型</param>
        /// <param name="cmdText">SQL Text</param>
        /// <param name="cmdParms">SQLiteParameters to use in the command</param>
        public void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, ref SQLiteTransaction trans, bool useTrans, CommandType cmdType, string cmdText, params SQLiteParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }

            cmd.Connection = conn;
            cmd.CommandText = cmdText;

            if (useTrans)
            {
                trans = conn.BeginTransaction(IsolationLevel.ReadCommitted);
                cmd.Transaction = trans;
            }

            cmd.CommandType = cmdType;

            if (cmdParms != null)
            {
                foreach (SQLiteParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }
        /// <summary>
        /// 采用简单的数据运行语句函数
        /// </summary>
        /// <param name="list">传入需要添加的list集合语句</param>
        /// <returns></returns>
        public int ExecuteList(ArrayList list)
        {
            using (SQLiteConnection connection = new SQLiteConnection(_ConnectionString))
            {
                connection.Open();
                using (SQLiteTransaction trans = connection.BeginTransaction())
                {
                    using (SQLiteCommand cmd = new SQLiteCommand())
                    {
                        try
                        {
                            cmd.Connection = connection;
                            cmd.CommandType = CommandType.Text;
                            int row = 0;
                            foreach (string sql in list)
                            {
                                cmd.CommandText = sql;
                                row += cmd.ExecuteNonQuery();
                            }
                            trans.Commit();
                            return row;
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            LogHelper.Error("Sqlite执行报错", ex);
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
