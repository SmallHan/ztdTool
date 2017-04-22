using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ztdTool.Common;

namespace ztdTool.UI
{
    public partial class FrmConfigure :BaseFrm
    {
        public FrmConfigure()
        {
            InitializeComponent();
        }
        DataTable dtConfig = new DataTable();
        SQLiteBusiness sqlLite = new SQLiteBusiness();
        string guid = string.Empty;
        private void FrmConfigure_Load(object sender, EventArgs e)
        {
            try
            {
                InitColumn();
                Utils.CheckOrCreateTable("TAB_LIB_CONFIG", dtConfig);
                BindData();
                InitControl();
            }
            catch (Exception ex)
            {
                ErrorMsg(ex);
            }
        }
        private void InitColumn()
        {
            dtConfig.Columns.Add("GUID");
            dtConfig.Columns.Add("LIBRARY");
            dtConfig.Columns.Add("SERVICE");
            dtConfig.Columns.Add("USERNAME");
            dtConfig.Columns.Add("HOST");
            dtConfig.Columns.Add("PORT");
            dtConfig.Columns.Add("PWD");

        }
        
        /// <summary>
        /// 加载配置
        /// </summary>
        private void BindData()
        {
            DataTable dtTemp = sqlLite.GetSqlExec("SELECT * FROM TAB_LIB_CONFIG");
            if (ExDtMethod.GetRowCount(dtTemp) > 0)
            {
                dtConfig = dtTemp;
            }
        }
        
        private void InitControl()
        {
            if (ExDtMethod.GetRowCount(dtConfig) > 0)
                Utils.AddItemToComboxEdit(dtConfig, cbo_LIBRARY, "LIBRARY");
            if (cbo_LIBRARY.Properties.Items.Count > 0)
            {
                cbo_LIBRARY.SelectedIndex = 0;
            }
            Utils.SetReadOnly(pan_ADD.Controls, true);
        }
        
        /// <summary>
        /// 保存到DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyOrNull()) return;

            DataRow newRow = dtConfig.NewRow();
            newRow["GUID"] = Guid.NewGuid().ToString().Replace("-", "");
            newRow["LIBRARY"] = txt_LIBRARY.Text.Trim();
            newRow["SERVICE"] = txt_SERVICE.Text.Trim();
            newRow["USERNAME"] = txt_USERNAME.Text.Trim();
            newRow["HOST"] = txt_HOST.Text.Trim();
            newRow["PORT"] = txt_PORT.Text.Trim();
            newRow["PWD"] = txt_PWD.Text.Trim();
            dtConfig.Rows.Add(newRow);
            sqlLite.AddNewTable(dtConfig, "TAB_LIB_CONFIG");
            Utils.SetReadOnly(pan_ADD.Controls, true);
            btn_ADD.Enabled = true;
            btn_SAVE.Enabled = false;
            btn_CANCEL.Enabled = false;
            cbo_LIBRARY.Enabled = true;
            Utils.AddItemToComboxEdit(Convert.ToString(newRow["LIBRARY"]), cbo_LIBRARY,cbo_LIBRARY.Properties.Items.Count);
        }



        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbo_LIBRARY_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbo_LIBRARY.Text))
            {
                DataRow row = ExDtMethod.SingleOrDefault<string>(dtConfig, "LIBRARY", (string str) =>
                {
                    return str.Equals(cbo_LIBRARY.Text);
                });
                if (row != null)
                {
                    guid = Convert.ToString(row["GUID"]);
                    txt_LIBRARY.Text = Convert.ToString(row["LIBRARY"]);
                    txt_SERVICE.Text = Convert.ToString(row["SERVICE"]);
                    txt_USERNAME.Text = Convert.ToString(row["USERNAME"]);
                    txt_HOST.Text = Convert.ToString(row["HOST"]);
                    txt_PORT.Text = Convert.ToString(row["PORT"]);
                    txt_PWD.Text = Convert.ToString(row["PWD"]);
                }
            }
        }

        /// <summary>
        /// 新增配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_ADD_Click(object sender, EventArgs e)
        {
            Utils.SetReadOnly(pan_ADD.Controls, false);
            btn_ADD.Enabled = false;
            btn_SAVE.Enabled = true;
            cbo_LIBRARY.Enabled = false;
            btn_CANCEL.Enabled = true;
            Utils.ClearForm(this.pan_ADD.Controls);
        }

        /// <summary>
        /// 配置链接静态类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btn_LINK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbo_LIBRARY.Text))
            {
                if (!CheckEmptyOrNull()) return;
                BaseConfig.guid = guid;
                BaseConfig.service = txt_SERVICE.Text.Trim();
                BaseConfig.userName = txt_USERNAME.Text.Trim();
                BaseConfig.host = txt_HOST.Text.Trim();
                BaseConfig.port = txt_PORT.Text.Trim();
                BaseConfig.pwd = txt_PWD.Text.Trim();
                BaseConfig.library = txt_LIBRARY.Text.Trim();

                ShowWait();
                string res = Utils.IsCheckLinkSuccess() ? string.Format("链接{0}库成功", BaseConfig.library) : string.Format("链接{0}库失败", BaseConfig.library);
                CloseWait();
                ShowMessage(res);
                if (res.Equals(string.Format("链接{0}库失败", BaseConfig.library)))
                {
                    Utils.SetBaseConfigEmpty();
                }
            }
        }
        
        private bool CheckEmptyOrNull()
        {
            if (string.IsNullOrWhiteSpace(txt_LIBRARY.Text))
            {
                MessageBox.Show("类库名称不能为空");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_SERVICE.Text))
            {
                MessageBox.Show("服务器名称不能为空");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_USERNAME.Text))
            {
                MessageBox.Show("用户名不能为空");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_HOST.Text))
            {
                MessageBox.Show("HOST不能为空");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_PORT.Text))
            {
                MessageBox.Show("端口不能为空");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txt_PWD.Text))
            {
                MessageBox.Show("密码不能为空");
                return false;
            }
            return true;
        }

        private void btn_CANCEL_Click(object sender, EventArgs e)
        {
            btn_ADD.Enabled = true;
            btn_SAVE.Enabled = false;
            btn_CANCEL.Enabled = false;
            cbo_LIBRARY.Enabled = true;
        }

        private void btn_DELETE_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cbo_LIBRARY.Text))
            {
                string delSql = string.Format("DELETE FROM TAB_LIB_CONFIG WHERE GUID='{0}'", guid);
                int rows = sqlLite.ExecuteSql(delSql);
                if (rows > 0)
                {
                    ShowMessage("删除成功");
                    cbo_LIBRARY.Properties.Items.Remove(cbo_LIBRARY.Text);
                    cbo_LIBRARY.Text = string.Empty;
                    Utils.ClearForm(this.pan_ADD.Controls);
                }
                else
                {
                    ShowMessage("删除失败");
                }
            }
            else
            {
                ShowMessage("请选择对应的库");
            }
        }
    }
}
