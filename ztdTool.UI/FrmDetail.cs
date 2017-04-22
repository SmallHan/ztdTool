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
    public partial class FrmDetail : BaseFrm
    {
        public FrmDetail()
        {
            InitializeComponent();
        }

        public FrmDetail(string _qryStr)
        {
            InitializeComponent();
            this.qryStr = _qryStr;
        }
        private DataTable dtFiled = new DataTable();
        public DataTable dtScript = new DataTable();
        public string qryStr = string.Empty;
        OracleBusiness oraBus = new OracleBusiness();

        public delegate void SetScript(DataTable dt);
        public SetScript setScript;
        private void FrmDetail_Load(object sender, EventArgs e)
        {
            try
            {
                InitColumn();
                QryFiledAll();
                LoadListBoxData();
            }
            catch (Exception ex)
            {
                ErrorMsg(ex);
            }
        }
        private void InitColumn()
        {
            dtFiled.Columns.Add("COLUMN_NAME");
            dtFiled.Columns.Add("COMMENTS");

            dtScript.Columns.Add("NAME");//空间名
            dtScript.Columns.Add("WIDTH",typeof(int));//宽度
            dtScript.Columns.Add("CAPTION");//标题
            dtScript.Columns.Add("FILEDNAME");//字段
            dtScript.Columns.Add("IsVisible",typeof(double));//是否隐藏
            dtScript.Columns.Add("VISIBLEINDEX",typeof(int));//顺序
        }
        private void QryFiledAll()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(@"SELECT T1.COLUMN_NAME,
                           T2.COMMENTS
                      FROM USER_TAB_COLUMNS T1, USER_COL_COMMENTS T2
                     WHERE T1.TABLE_NAME = '{0}'
                       AND T1.TABLE_NAME = T2.TABLE_NAME
                       AND T1.COLUMN_NAME = T2.COLUMN_NAME", qryStr);
            DataTable dtRes = oraBus.QueryToDataTable(sb.ToString(), "TAB_FILED");
            if (ExDtMethod.GetRowCount(dtRes) > 0)
            {
                dtFiled = dtRes;
            }
            else
            {
                dtFiled.Rows.Clear();
            }
        }
        private void LoadListBoxData()
        {
            if (ExDtMethod.GetRowCount(dtFiled) > 0)
            {
                //不太清楚为什么使用DataSource不能移除
                //listBox1.DataSource = dtFiled;
                //listBox1.ValueMember = "COLUMN_NAME";
                //listBox1.DisplayMember = "COLUMN_NAME";
                foreach (DataRow row in dtFiled.Rows)
                {
                    if (row != null)
                    {
                        string comments= Convert.ToString(row["COMMENTS"]);
                        if (!string.IsNullOrWhiteSpace(comments))
                        {
                            listBox1.Items.Add(Convert.ToString(row["COLUMN_NAME"]) + "(" + comments + ")");
                        }
                        else
                        {
                            listBox1.Items.Add(Convert.ToString(row["COLUMN_NAME"]));
                        }
                    }
                }
            }
        }

        private void btn_RIGHT_SINGLE_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void btn_RIGHT_ALL_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                for (var i = 0; i < listBox1.Items.Count; i++)
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                }
                listBox1.Items.Clear();
            }
        }

        private void btn_LEFT_SINGLE_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void btn_LEFT_ALL_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                for (var i = 0; i < listBox2.Items.Count; i++)
                {
                    listBox1.Items.Add(listBox2.Items[i]);
                }
                listBox2.Items.Clear();
            }
        }

        private void btn_GEN_GRID_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count <= 0)
            {
                ShowMessage("请选择对应的内容");
                return;
            }
            btn_GEN_SCRIPT.Enabled = true;
            ClearColumn();
            GenColumn();
        }
        /// <summary>
        /// 清空所有的Column
        /// </summary>
        private void ClearColumn()
        {
            this.gv_PREVIEW.Columns.Clear();

        }
        /// <summary>
        /// 根据用户所选的字段生成Column
        /// </summary>
        private void GenColumn()
        {
            if (listBox2.Items.Count > 0)
            {
                DataRow row = null;
                for (var i = 0; i < listBox2.Items.Count; i++)
                {
                    string newStr=ReplaceBracketsEmpty(listBox2.Items[i].ToString());
                    row = ExDtMethod.SingleOrDefault(dtFiled, "COLUMN_NAME", (string str) =>
                    {
                        return str.Equals(newStr);
                    });
                    if (row != null)
                    {
                        GridColumn gridColumn = new GridColumn();
                        gv_PREVIEW.Columns.Add(gridColumn);
                        gridColumn.AppearanceHeader.Options.UseTextOptions = true;
                        gridColumn.Width = 120;
                        gridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridColumn.Caption = string.IsNullOrWhiteSpace(Convert.ToString(row["COMMENTS"])) ? Convert.ToString(row["COLUMN_NAME"]) : Convert.ToString(row["COMMENTS"]);
                        gridColumn.FieldName = newStr;
                        gridColumn.Name = newStr;
                        gridColumn.Visible = true;
                        gridColumn.VisibleIndex = i;
                    }
                }

            }
        }

        private string ReplaceBracketsEmpty(string val)
        {
            if (!string.IsNullOrWhiteSpace(val))
            {
                val= Regex.Replace(val,@"\(.+?\)",string.Empty,RegexOptions.IgnoreCase);
            }
            return val;
        }
        /// <summary>
        /// 生成datatable
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
                    int width =it.Width;
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
            }
            this.Close();
        }
    }
}
