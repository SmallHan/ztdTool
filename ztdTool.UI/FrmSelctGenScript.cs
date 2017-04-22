using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ztdTool.Common;

namespace ztdTool.UI
{
    public partial class FrmSelctGenScript : BaseFrm
    {
        public FrmSelctGenScript()
        {
            InitializeComponent();
        }
        public DataTable dtScript = new DataTable();
        private DataTable dtFiled = new DataTable();
        OracleBusiness oraBus = new OracleBusiness();

        public delegate void SetScript(DataTable dt);
        public SetScript setScript;
        private void FrmSelctGenScript_Load(object sender, EventArgs e)
        {
            try
            {
                InitColumn();
            }
            catch (Exception ex)
            {
                ErrorMsg(ex);
            }
        }

        private void InitColumn()
        {

            dtScript.Columns.Add("NAME");//空间名
            dtScript.Columns.Add("WIDTH", typeof(int));//宽度
            dtScript.Columns.Add("CAPTION");//标题
            dtScript.Columns.Add("FILEDNAME");//字段
            dtScript.Columns.Add("IsVisible", typeof(double));//是否隐藏
            dtScript.Columns.Add("VISIBLEINDEX", typeof(int));//顺序
        }

        private void btn_GEN_GRID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(me_SQL.Text))
            {
                ShowMessage("查询sql不能为空");
                return;
            }
            string qrySql = me_SQL.Text.Trim().ToUpper();
            if (!IsSqlSafe(qrySql))
            {
                ShowMessage("查询sql格式不对");
                return;
            }
            StringBuilder sb = new StringBuilder("SELECT T.*,rownum FROM (");
            sb.AppendFormat(@"{0}) T where 1<>1", qrySql);
            InvokeQrySql(sb.ToString());
            if (dtFiled.Columns.Count>0)
            {
                ClearColumn();
                GenColumn();
                btn_GEN_SCRIPT.Enabled = true;
            }
            else
            {
                ShowMessage("查询失败");
            }

        }
        /// <summary>
        /// 验证sql是否符合要求
        /// </summary>
        /// <param name="qryStr"></param>
        /// <returns></returns>
        private bool IsSqlSafe(string qryStr)
        {
            string regex = @"^SELECT(.|\n)+FROM(.|\n)+";
            return Regex.IsMatch(qryStr, regex);
        }
        /// <summary>
        /// 生成GridControl
        /// </summary>
        private void GenColumn()
        {
            for (var i = 0; i < dtFiled.Columns.Count; i++)
            {
                GridColumn gridColumn = new GridColumn();
                gv_PREVIEW.Columns.Add(gridColumn);
                gridColumn.AppearanceHeader.Options.UseTextOptions = true;
                gridColumn.Width = 120;
                gridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                gridColumn.Caption = dtFiled.Columns[i].ColumnName;
                gridColumn.FieldName = dtFiled.Columns[i].ColumnName;
                gridColumn.Name = dtFiled.Columns[i].ColumnName;
                gridColumn.Visible = true;
                gridColumn.VisibleIndex = i;
            }
        }

        /// <summary>
        /// 清空所有的Column
        /// </summary>
        private void ClearColumn()
        {
            this.gv_PREVIEW.Columns.Clear();

        }
        /// <summary>
        /// 执行用户输入的sql
        /// </summary>
        private void InvokeQrySql(string sql)
        {
            DataTable dtRes = oraBus.QueryToDataTable(sql, "TAB_FILED");
            if (dtRes.Columns.Count>0)
            {
                dtFiled = dtRes;
            }
            else
            {
                dtFiled.Rows.Clear();
            }
        }

        /// <summary>
        /// 生成脚本
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_GEN_SCRIPT_Click(object sender, EventArgs e)
        {
            if (this.gv_PREVIEW.Columns.Count > 0)
            {
                dtScript.Rows.Clear();
                foreach (GridColumn it in this.gv_PREVIEW.Columns)
                {
                    DataRow row = dtScript.NewRow();
                    string name = it.Name;
                    int width = it.Width;
                    string caption = it.Caption;
                    string fieldName = it.FieldName;
                    bool isVisable = it.Visible;
                    int visableIndex = it.VisibleIndex;

                    row["NAME"] = name;
                    row["WIDTH"] = width;
                    row["CAPTION"] = caption;
                    row["FILEDNAME"] = fieldName;
                    row["IsVisible"] = isVisable;
                    row["VISIBLEINDEX"] = visableIndex;

                    dtScript.Rows.Add(row);
                }
                DataTable dtTemp = dtScript.AsEnumerable().OrderBy(p => p.Field<int>("VISIBLEINDEX")).CopyToDataTable();
                setScript(dtTemp);
                this.Close();
            }
        }
    }
}
