﻿using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ztdTool.Common;

namespace ztdTool.UI
{
    public partial class FrmSqlSelect : BaseFrm
    {
        public FrmSqlSelect()
        {
            InitializeComponent();
        }

        private DataTable dtTable = new DataTable();
        private OracleBusiness oraBus = new OracleBusiness();
        private Dictionary<XtraTabPage, MemoEdit> controlDic = new Dictionary<XtraTabPage, MemoEdit>();
        private Dictionary<XtraTabPage, ExecSqlModel> dtDic = new Dictionary<XtraTabPage, ExecSqlModel>();

        private void FrmSqlSelect_Load(object sender, EventArgs e)
        {
            try
            {
                CreateCoulnm();
                CreateTabAndText();
                InitControl();
            }
            catch (Exception ex)
            {
                ErrorMsg(ex);
            }
        }
        private void CreateCoulnm()
        {
            dtTable.Columns.Add("TABLE_NAME");
            dtTable.Columns.Add("COMMENTS");
            dtTable.Columns.Add("SQE");
        }
        private async void InitControl()
        {
            Task<DataTable> dtRes = InitTable();
            var dtTemp = await dtRes;
            list_TABLE.DisplayMember = "TABLE_NAME";
            list_TABLE.ValueMember = "TABLE_NAME";
            list_TABLE.DataSource = dtTemp;
            InitTxtLikeSerach(dtTable);
        }
        private async Task<DataTable> InitTable()
        {
            return await Task.Factory.StartNew(() =>
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat(@"SELECT T2.TABLE_NAME,T2.COMMENTS,ROWNUM AS SQE FROM USER_TABLES T1,USER_TAB_COMMENTS T2 WHERE T1.TABLE_NAME=T2.TABLE_NAME");
                DataTable dtRes = oraBus.QueryToDataTable(sb.ToString(), "TAB_NAME");
                if (ExDtMethod.GetRowCount(dtRes) > 0)
                {
                    dtTable = dtRes;
                }
                else
                {
                    dtTable.Rows.Clear();
                }
                return dtTable;
            });

        }

        /// <summary>
        /// TextBox 实现模糊查询
        /// </summary>
        private async void InitTxtLikeSerach(DataTable dtTemp)
        {
            this.txt_SERACH_TABLE.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txt_SERACH_TABLE.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            List<string> list = (List<string>)ExDtMethod.Select<string>(dtTemp, "TABLE_NAME");
            if (list.Count > 0)
            {
                foreach (var it in list)
                {
                    ac.Add(it);
                }
            }
            this.txt_SERACH_TABLE.AutoCompleteCustomSource = ac;
        }

        /// <summary>
        /// 定位到对应的表名
        /// </summary>
        private void GoToTable()
        {
            if (string.IsNullOrWhiteSpace(txt_SERACH_TABLE.Text.Trim()))
            {
                ShowMessage("表名不能为空");
                return;
            }


        }
        private void txt_SERACH_TABLE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GoToTable();
            }
        }

        private void list_TABLE_DoubleClick(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 创建一个新的SQL插页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void tool_SQL_Click(object sender, EventArgs e)
        {
            CreateTabAndText();
        }
        /// <summary>
        /// 创建新的Tab和Text
        /// </summary>
        private void CreateTabAndText()
        {
            int pageCount = xtra_SQL.TabPages.Count;
            XtraTabPage xtra = new XtraTabPage();
            xtra.Dock = DockStyle.Fill;
            xtra.Name = "xtra" + pageCount + 1;
            xtra.Text = "SQL";
            MemoEdit momoEdit = new MemoEdit();
            momoEdit.Name = "momoEdit" + pageCount + 1;
            momoEdit.Dock = DockStyle.Fill;
            xtra.Controls.Add(momoEdit);
            xtra_SQL.SelectedTabPage = xtra;
            momoEdit.Focus();
            xtra_SQL.TabPages.Add(xtra);
            if (!controlDic.ContainsKey(xtra))
            {
                controlDic.Add(xtra, momoEdit);
            }
            SetBarValue("0");
        }
        /// <summary>
        /// 异步执行sql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tool_EXEC_Click(object sender, EventArgs e)
        {
            var txtObject = controlDic[xtra_SQL.SelectedTabPage];
            string qrySql = txtObject.SelectedText == string.Empty ? txtObject.Text.Trim().ToUpper() : txtObject.SelectedText.Trim().ToUpper();
            if (string.IsNullOrWhiteSpace(qrySql))
            {
                ShowMessage("查询sql不能为空");
                return;
            }
            if (ck_MORE_NUMBER.Checked && string.IsNullOrWhiteSpace(txt_NUMBER.Text))
            {
                ShowMessage("限制查询最多条数不能为空");
                return;
            }
            if (!IsSqlSafe(qrySql))
            {
                ShowMessage("查询sql格式不对");
                return;
            }
            GenColumn(qrySql);
        }

        private void GenColumn(string qrySql)
        {
            ShowWait();
            var txtObject = controlDic[xtra_SQL.SelectedTabPage];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            DataTable dtRes = ExecSql(qrySql, ck_MORE_NUMBER.Checked, ck_MORE_NUMBER.Checked ? Convert.ToInt32(txt_NUMBER.Text.Trim()) : 0);
            sw.Stop();
            var costSeconds = sw.ElapsedMilliseconds / 1000.0 + "s";
            //根据当前选择的Xtra加入到字典里面
            if (!dtDic.ContainsKey(xtra_SQL.SelectedTabPage))
            {
                ExecSqlModel ex = new ExecSqlModel()
                {
                    dt = dtRes,
                    rowCount = dtRes.Rows.Count,
                    execSeconds = costSeconds
                };
                dtDic.Add(xtra_SQL.SelectedTabPage, ex);
            }
            else
            {
                var exec = dtDic[xtra_SQL.SelectedTabPage];
                exec.dt = dtRes;
                exec.rowCount = dtRes.Rows.Count;
                exec.execSeconds = costSeconds;
            }
            Utils.CloseForm(panelControl6);
            ShowExceSqlView(dtDic[xtra_SQL.SelectedTabPage].dt);
            SetBarValue(costSeconds, dtRes.Rows.Count);
            CloseWait();
        }
        /// <summary>
        /// 打开sql查询结果的界面
        /// </summary>
        private void ShowExceSqlView(DataTable dtTemp = null)
        {
            FrmResultDetail frm = dtTemp != null ? new FrmResultDetail(dtTemp) : new FrmResultDetail();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelControl6.Controls.Add(frm);
            frm.Show();
        }
        /// <summary>
        /// 设置底部的值
        /// </summary>
        private void SetBarValue(string costSecond, int rowCount = 0)
        {
            this.lbl_TIME.Text = costSecond;
            this.lbl_ROW.Text = rowCount.ToString();
        }
        /// <summary>
        /// 验证sql是否符合要求
        /// </summary>
        /// <param name="qryStr"></param>
        /// <returns></returns>
        private bool IsSqlSafe(string qryStr)
        {
            string regex = @"^SELECT(.|\n)+FROM(.|\n)+";
            return Regex.IsMatch(qryStr, regex, RegexOptions.IgnoreCase);
        }
        /// <summary>
        /// 异步执行
        /// </summary>
        private DataTable ExecSql(string qrySql, bool isCheckFkg, int rowNumber)
        {
            StringBuilder sb = new StringBuilder("SELECT ROWNUM,T.* FROM (");
            if (isCheckFkg)
            {
                sb.AppendFormat(@"{0}) T where rownum<={1}", qrySql, rowNumber);
            }
            else
            {
                sb.AppendFormat(@"{0}) T", qrySql);
            }
            DataTable dtRes = oraBus.QueryToDataTable(sb.ToString(), "TAB_FILED");
            return dtRes;
        }

        private void xtra_SQL_SelectedPageChanged(object sender, TabPageChangedEventArgs e)
        {
            Utils.CloseForm(panelControl6);
            if (dtDic.ContainsKey(xtra_SQL.SelectedTabPage))
            {
                //获取当前选中的TabPage
                var exec = dtDic[xtra_SQL.SelectedTabPage];
                ShowExceSqlView(exec != null ? exec.dt : null);
                SetBarValue(exec.execSeconds, exec.rowCount);
            }
            else
            {
                SetBarValue("0");
            }
        }
    }
}
