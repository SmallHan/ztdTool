using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztdTool.Common
{
    public class OracleBusiness
    {
        public OracleHelper sh =new OracleHelper(string.Format(@"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST={0})(PORT={1})))(CONNECT_DATA=(SERVICE_NAME={2})));User ID={3};Password={4};Unicode=True", 
            BaseConfig.host,BaseConfig.port,BaseConfig.service,BaseConfig.userName,BaseConfig.pwd
            ));
         public OracleBusiness() { }

         public OracleBusiness(string path) 
         {
             sh = new OracleHelper(path);
         }

        /// <summary>
        /// 获取当前状态
        /// </summary>
        /// <returns></returns>

         public bool GetConnStatus()
         {
             return sh.GetConnStatus();
         }
        public DataTable QueryToDataTable(string sqlQry,string tableName="")
        {
            DataTable dtTemp=null;
            if (!string.IsNullOrWhiteSpace(sqlQry))
            {
                dtTemp = sh.QueryToDataTable(sqlQry, tableName);
                return dtTemp;
            }
            return dtTemp;
        }
    }
}
