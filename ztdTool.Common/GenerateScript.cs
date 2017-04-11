using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztdTool.Common
{
    public class GenerateScript
    {
        public string GenScript(DataTable dt, string gvName)
        {
            StringBuilder sbRes = new StringBuilder();
            string resStr = string.Empty;
            sbRes.AppendFormat(CreateObjectScript(dt));
            sbRes.AppendFormat(NewLine(4));

            sbRes.AppendFormat(NewObjectScirpt(dt));
            sbRes.AppendFormat(NewLine(4));


            sbRes.AppendFormat(ColumnConfigScript(dt));
            sbRes.AppendFormat(NewLine(4));

            
            //其实我想这样写的，但是因为 sb 中包含{}就会报错了
            // sbRes.AppendFormat(GvColumnSetScript(dt, gvName));
            //最后没办法，只能使用下面这种方法
            return sbRes + GvColumnSetScript(dt, gvName);
        }
        /// <summary>
        ///   private DevExpress.XtraGrid.Columns.GridColumn COMMENTS;
        /// </summary>
        /// <returns></returns>
        public string CreateObjectScript(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (ExDtMethod.GetRowCount(dt) > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    sb.AppendFormat("private DevExpress.XtraGrid.Columns.GridColumn {0};", Convert.ToString(row["NAME"]));
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }

        /// <summary>
        ///  this.COMMENTS = new DevExpress.XtraGrid.Columns.GridColumn();
        /// </summary>
        /// <returns></returns>
        public string NewObjectScirpt(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (ExDtMethod.GetRowCount(dt) > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    sb.AppendFormat(" this.{0} = new DevExpress.XtraGrid.Columns.GridColumn();", Convert.ToString(row["NAME"]));
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }

        /// <summary>
        ///  this.gv_TABLE.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {  this.COMMENTS})
        /// </summary>
        /// <returns></returns>
        public string GvColumnSetScript(DataTable dt,string gvName)
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sbRes = new StringBuilder();
            string res=string.Empty;
            if (ExDtMethod.GetRowCount(dt) > 0)
            {
                int index = 0;
                foreach (DataRow row in dt.Rows)
                {
                    if (index < dt.Rows.Count - 1)
                    {
                        sb.AppendFormat("this.{0},", Convert.ToString(row["NAME"]));
                        sb.AppendLine();
                    }
                    else
                    {
                        sb.AppendFormat("this.{0}", Convert.ToString(row["NAME"]));
                    }
                    index++;
                }
                res = sb.ToString();
            }
            string returnStr = "this." + gvName + ".Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {" + res + "});";
            return returnStr;
        }

        /// <summary>
        /// 列的配置
        /// </summary>
        /// <returns></returns>
        public string ColumnConfigScript(DataTable dt)
        {
            StringBuilder sb = new StringBuilder();
            if (ExDtMethod.GetRowCount(dt) > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    sb.AppendFormat("//");
                    sb.AppendLine();
                    sb.AppendFormat("//{0}", Convert.ToString(row["NAME"]));
                    sb.AppendLine();
                    sb.AppendFormat("//");
                    sb.AppendLine();
                    sb.AppendFormat("{0}.AppearanceHeader.Options.UseTextOptions = true;", Convert.ToString(row["NAME"]));
                    sb.AppendLine();
                    sb.AppendFormat("{0}.Width = {1};", Convert.ToString(row["NAME"]),Convert.ToInt32(row["WIDTH"]));
                    sb.AppendLine();
                    sb.AppendFormat("{0}.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;", Convert.ToString(row["NAME"]));
                    sb.AppendLine();
                    sb.AppendFormat("{0}.Caption = {1};", Convert.ToString(row["NAME"]),'"' + Convert.ToString(row["CAPTION"]) + '"');
                    sb.AppendLine();
                    sb.AppendFormat("{0}.FieldName = {1};",Convert.ToString(row["NAME"]), '"' + Convert.ToString(row["FILEDNAME"]) + '"');
                    sb.AppendLine();
                    sb.AppendFormat("{0}.Name = {1};", Convert.ToString(row["NAME"]), '"' + Convert.ToString(row["NAME"]) + '"');
                    sb.AppendLine();
                    if (Convert.ToBoolean(row["IsVisible"]))
                    {
                        sb.AppendFormat("{0}.Visible = {1};", Convert.ToString(row["NAME"]),Convert.ToBoolean(row["IsVisible"]).ToString().ToLower());
                        sb.AppendLine();
                    }
                    sb.AppendFormat("{0}.VisibleIndex = {1};", Convert.ToString(row["NAME"]),Convert.ToInt32(row["VISIBLEINDEX"]));
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// 生成接口
        /// </summary>
        /// <param name="methodName">接口名称</param>
        /// <param name="isSelectType">true为查询，false为保存</param>
        /// <returns></returns>
        public string GenMethodName(string methodName,bool isSelectType,string remark="")
        {
            if (!string.IsNullOrWhiteSpace(methodName))
            {
                string str = string.Empty;
                //查询
                if (isSelectType)
                {
                    str = string.Format(" private static string _qry{0} = {1};", methodName,string.Format("{0}",'"'+"qry"+methodName+'"'));
                   
                    if (!string.IsNullOrWhiteSpace(remark))
                    {
                        str += "\r\n";
                        str += "///<summary>";
                        str += "\r\n";
                        str += "///"+remark;
                        str += "\r\n";
                        str += "///<summary>";
                    }
                    str += "\r\n";
                    str += string.Format(" public static string qry{0}", methodName);
                    str += "\r\n";
                    str += "{";
                    str += "\r\n";
                    str += "    " + "get {" + " return " + "_qry" + methodName + ";" + "}";
                    str += "\r\n";
                    str += "}";
                }
                //保存
                else
                {
                    str = string.Format(" private static string _save{0} ={1};", methodName, string.Format("{0}", '"' + "save" +methodName + '"'));
                   
                    if (!string.IsNullOrWhiteSpace(remark))
                    {
                        str += "\r\n";
                        str += "///<summary>";
                        str += "\r\n";
                        str += "///"+remark;
                        str += "\r\n";
                        str += "///<summary>";
                    }
                    str += "\r\n";
                    str += string.Format(" public static string save{0}", methodName);
                    str += "\r\n";
                    str += "{";
                    str += "\r\n";
                    str += "    " + "get {" + " return " + "_save" + methodName + ";" + "}";
                    str += "\r\n";
                    str += "}";
                }
                return str;
            }
            return string.Empty;
        }
        public string NewLine(int line)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------------------------------------------------------------");
            for (var i = 1; i <= line; i++)
            {
                sb.AppendLine();
            }
            return sb.ToString();
        }
        public string GenDeginCode(string gvName,string gcName,string deginStr,List<string> list)
        {
            StringBuilder sb = new StringBuilder();
            List<string> resList = deginStr.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            foreach (var it in resList)
            {
                sb.AppendLine(it);
                if (it.Trim().Equals(string.Format("this.{0} = new DevExpress.XtraGrid.Views.Grid.GridView();",gvName.Trim())))
                {
                    List<string> list2 = list[1].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                    foreach (var it2 in list2)
                    {
                        sb.AppendLine(it2.ToString());
                    }
                }
                else if (it.Trim().Equals(string.Format("this.{0}.GridControl = this.{1};",gvName.Trim(),gcName.Trim())))
                {
                    List<string> list3 = list[3].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                    foreach (var it4 in list3)
                    {
                        sb.AppendLine(it4.ToString());
                    }
                }
                else if (it.Trim().Equals(string.Format("this.{0}.Name = \"{0}\";",gvName.Trim())))
                {
                    List<string> list3 = list[2].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                    foreach (var it3 in list3)
                    {
                        sb.AppendLine(it3.ToString());
                    }
                }
                else if (it.Trim().Equals(string.Format("private DevExpress.XtraGrid.Views.Grid.GridView {0};",gvName)))
                {
                    List<string> list1 = list[0].ToString().Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
                    foreach (var it1 in list1)
                    {
                        sb.AppendLine(it1.ToString());
                    }
                }
            }
            return sb.ToString();
        }
    }
}
