using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztdTool.Common
{
    public class Convert2Dt
    {
        public string FiledConvert2Dt(DataTable dt,string dtName="dtInfo")
        {
            StringBuilder sb = new StringBuilder();
            if(ExDtMethod.GetRowCount(dt)>0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row != null)
                    {
                        string filed = Convert.ToString(row["COLUMN_NAME"]);
                        string filedRemark = Convert.ToString(row["COMMENTS"]);
                        string type = Convert.ToString(row["DATA_TYPE"]);
                        if (type.Equals("NUMBER"))
                        {
                            sb.AppendFormat(@"{0}.Columns.Add({1},typeof({2}));{3}", dtName, "\"" + filed.Trim() + "\"","double",string.IsNullOrWhiteSpace(filedRemark) ? string.Empty : "//" + filedRemark);
                        }
                        else
                        {
                            sb.AppendFormat(@"{0}.Columns.Add({1});{2}", dtName, "\"" + filed.Trim() + "\"", string.IsNullOrWhiteSpace(filedRemark) ? string.Empty : "//" + filedRemark);
                        }
                    }
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }
    }
}
