using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using System.Data;

namespace ztdTool.Common
{
    public static class Utils
    {

        public static string dataPath = AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string xmlPath = AppDomain.CurrentDomain.BaseDirectory + "BaseConfig.xml";
        public static string log4Path = AppDomain.CurrentDomain.BaseDirectory + "Log4net.config";

        public static SQLiteBusiness sqlLite = new SQLiteBusiness();
        public static void CloseForm(XtraScrollableControl xtPanel)
        {
            if (xtPanel != null)
            {
                foreach (var it in xtPanel.Controls)
                {
                    if (it is Form)
                    {
                        (it as Form).Close();
                    }
                }
            }
        }
        /// <summary>
        /// 检查表是否存在，存在则不创建，不存在则创建
        /// </summary>
        /// <param name="tableName"></param>
        public static void CheckOrCreateTable(string tableName,DataTable dt)
        {
            DataTable dtExists= sqlLite.ValidateIsTable(tableName);
            if (ExDtMethod.GetRowCount(dtExists) > 0 && dtExists.Rows[0]["CNT"].ToString() == "0")
            {
                sqlLite.AddNewTable(dt, tableName);
            }
        }

        /// <summary>
        /// 设置只读
        /// </summary>
        /// <param name="controls"></param>
        public static void SetReadOnly(System.Windows.Forms.Control.ControlCollection controls, bool flg)
        {
            foreach (Control con in controls)
            {
                if (con is GroupControl || con is PanelControl)
                {
                    SetReadOnly(con.Controls, flg);
                }
                else
                {
                    if (con is TextEdit)
                    {
                        TextEdit txt = (TextEdit)con;
                        txt.Enabled = !flg;
                        continue;
                    }
                    if (con is CheckEdit)
                    {
                        CheckEdit check = (CheckEdit)con;
                        check.Properties.ReadOnly = flg;
                        continue;
                    }
                    if (con is LookUpEdit)
                    {
                        LookUpEdit lookUp = (LookUpEdit)con;
                        lookUp.Enabled = !flg;
                        continue;
                    }

                    if (con is ComboBoxEdit)
                    {
                        ComboBoxEdit combo = con as ComboBoxEdit;
                        combo.Enabled = !flg;
                        continue;
                    }
                }
            }
        }

        /// <summary>
        /// 清空窗体内容
        /// </summary>
        /// <param name="controls"></param>
        public static void ClearForm(System.Windows.Forms.Control.ControlCollection controls)
        {
            foreach (Control con in controls)
            {
                if (con is GroupControl || con is PanelControl)
                {
                    ClearForm(con.Controls);
                }
                else
                {
                    if (con.Tag != null)
                    {
                        if (con is LookUpEdit)
                        {
                            LookUpEdit lookUp = con as LookUpEdit;
                            lookUp.ItemIndex = 0;
                            continue;
                        }
                        if (con is TextEdit)
                        {
                            TextEdit txt = con as TextEdit;
                            txt.Text = string.Empty;
                        }

                        if (con is CheckEdit)
                        {
                            CheckEdit check = con as CheckEdit;
                            check.Checked = false;
                        }

                        if (con is ComboBoxEdit)
                        {
                            ComboBoxEdit combo = con as ComboBoxEdit;
                            combo.Text = string.Empty;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// ComboBoxEdit 填加对应的值
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="combox"></param>
        public static void AddItemToComboxEdit(DataTable dt, ComboBoxEdit combox,string filedName,int selectIndex=0)
        {
            if (ExDtMethod.GetRowCount(dt) > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    string value = Convert.ToString(row[filedName]);
                    AddItemToComboxEdit(value, combox);
                }
                combox.SelectedIndex = selectIndex;
            }
        }
        public static void AddItemToComboxEdit(string val, ComboBoxEdit combox,int selectIndex=0)
        {
            if (!string.IsNullOrWhiteSpace(val))
            {
                combox.Properties.Items.Add(val);
                combox.SelectedIndex = selectIndex;
            }
        }
        /// <summary>
        /// 验证是否连接成功
        /// </summary>
        /// <returns></returns>
        public static bool IsCheckLinkSuccess()
        {
            OracleBusiness oraBusiness = new OracleBusiness();
            return oraBusiness.GetConnStatus();
        }
        /// <summary>
        /// 将静态类的值设置为空
        /// </summary>
        public static void SetBaseConfigEmpty()
        {
            BaseConfig.library = string.Empty;
            BaseConfig.service = string.Empty;
            BaseConfig.userName = string.Empty;
            BaseConfig.host = string.Empty;
            BaseConfig.port = string.Empty;
            BaseConfig.pwd = string.Empty;
        }
    }
}
