using DevExpress.XtraEditors;
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
        private Dictionary<XtraTabPage, DataTable> dtDic = new Dictionary<XtraTabPage, DataTable>();
        private void FrmSqlSelect_Load(object sender, EventArgs e)
        {
            try
            {
                CreateCoulnm();
                CreateTabAndText();
                InitControl();
            }
            catch(Exception ex)
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
            int pageCount=xtra_SQL.TabPages.Count;
            XtraTabPage xtra = new XtraTabPage();
            xtra.Dock = DockStyle.Fill;
            xtra.Name="xtra"+pageCount+1;
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
        }
        /// <summary>
        /// 异步执行sql
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tool_EXEC_Click(object sender, EventArgs e)
        {
            XtraTabPage xtra = xtra_SQL.SelectedTabPage;
            string qrySql = xtra.Text.Trim().ToUpper();
            var txtObject = controlDic[xtra_SQL.SelectedTabPage];
            if (string.IsNullOrWhiteSpace(txtObject.Text.Trim()))
            {
                ShowMessage("限制查询最多条数不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(qrySql))
            {
                ShowMessage("查询sql不能为空");
                return;
            }
            if (!IsSqlSafe(qrySql))
            {
                ShowMessage("查询sql格式不对");
                return;
            }
            GenColumn(qrySql);
        }

        private async void GenColumn(string qrySql)
        {
            ShowWait();
            var txtObject = controlDic[xtra_SQL.SelectedTabPage];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Task<DataTable> dtRes = ExecSql(qrySql, Convert.ToInt32(txtObject.Text.Trim()));
            DataTable dtAysnc = await dtRes;
            //根据当前选择的Xtra加入到字典里面
            if (!dtDic.ContainsKey(xtra_SQL.SelectedTabPage))
            {
                dtDic.Add(xtra_SQL.SelectedTabPage, dtAysnc);
            }
            else
            {
                dtDic[xtra_SQL.SelectedTabPage] = dtAysnc;
            }
            FrmResultDetail frm = new FrmResultDetail(dtDic[xtra_SQL.SelectedTabPage], sw.ElapsedMilliseconds / 1000 + "s");

            CloseWait();
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
        /// 异步执行
        /// </summary>
        private async Task<DataTable> ExecSql(string qrySql,int rowNumber)
        {
            return await Task.Factory.StartNew(() =>
            {
                StringBuilder sb = new StringBuilder("SELECT T.*,rownum FROM (");
                sb.AppendFormat(@"{0}) T where rownum<{1}", qrySql, rowNumber);
                DataTable dtRes = oraBus.QueryToDataTable(sb.ToString(), "TAB_FILED");
                return dtRes;
            });
        }
    }
}
