﻿using DevExpress.XtraGrid.Columns;
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
        private DataTable dtSerach = new DataTable();
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
                BindDtSerach();
                LoadListBoxData();
            }
            catch (Exception ex)
            {
                ErrorMsg(ex);
            }
        }
        private void InitColumn()
        {

            dtSerach.Columns.Add("SERACH_FIELD");

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
        private void BindDtSerach()
        {
            if (ExDtMethod.GetRowCount(dtFiled) > 0)
            {
                foreach (DataRow row in dtFiled.Rows)
                {
                    DataRow newRow = dtSerach.NewRow();
                    string comments = Convert.ToString(row["COMMENTS"]);
                    string columnName = Convert.ToString(row["COLUMN_NAME"]);
                    newRow["SERACH_FIELD"] = columnName + "(" + comments + ")";
                    dtSerach.Rows.Add(newRow);
                }
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
                dtSerach.Rows.RemoveAt(listBox1.SelectedIndex);
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
                dtSerach.Rows.Clear();
                listBox1.Items.Clear();
            }
        }

        private void btn_LEFT_SINGLE_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                AddDtSerachRow(listBox2.SelectedItem.ToString());
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
                    AddDtSerachRow(listBox2.Items[i].ToString());
                }
                listBox2.Items.Clear();
            }
        }

        public void AddDtSerachRow(string val)
        {
            DataRow row = dtSerach.NewRow();
            row["SERACH_FIELD"] = val;
            dtSerach.Rows.Add(row);
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
                //val= Regex.Replace(val,@"\(.+?\)",string.Empty,RegexOptions.IgnoreCase);
                val = val.Substring(0, val.IndexOf('('));
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

        private void txt_SERACH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SerachFieldIndex(txt_SERACH.Text.Trim());
            }
        }
        /// <summary>
        /// 搜索字段对应的索引
        /// </summary>
        private void SerachFieldIndex(string fieldName)
        {
            if (!string.IsNullOrWhiteSpace(fieldName))
            {
                DataRow[] row = dtSerach.Select(string.Format("SERACH_FIELD LIKE '%{0}%'", fieldName));
                int index = -1;
                if (row.Length > 0)
                {
                    string columnName = Convert.ToString(row[0]["SERACH_FIELD"]);
                    //判断当前值是否在listbox存在，不存在默认选择0
                    //int index = listBox1.Items.Contains(string.Format("{0}({1})", columnName, comments)) ? dtFiled.Rows.IndexOf(row[0])-listBox2.Items.Count : -1;
                     index = listBox1.Items.IndexOf(string.Format("{0}", columnName));
                }
                PositionFieldIndex(index);
            }
            
        }
        /// <summary>
        /// 定位到字段对应的位置
        /// </summary>
        private void PositionFieldIndex(int index)
        {
            listBox1.SelectedIndex = index;
        }
    }
}
