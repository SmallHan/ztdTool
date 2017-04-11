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

namespace ztdTool
{
    public partial class FrmConvert2Dt : BaseFrm
    {
        public FrmConvert2Dt()
        {
            InitializeComponent();
        }

        DataTable dtTable=new DataTable();
        OracleBusiness oraBus = new OracleBusiness();
        private void FrmConvert2Dt_Load(object sender, EventArgs e)
        {
            try
            {
                InitColumn();
                BindData();
                InitTxtLikeSerach();
            }
            catch (Exception ex)
            {
                ErrorMsg(ex, "加载生成DataTable出错");
            }
        }
        private void InitColumn()
        {
            dtTable.Columns.Add("TABLE_NAME");
            dtTable.Columns.Add("COMMENTS");
            dtTable.Columns.Add("SQE");
        }

        /// <summary>
        /// TextBox 实现模糊查询
        /// </summary>
        private void InitTxtLikeSerach()
        {
            this.txt_SERACH.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txt_SERACH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            List<string> list = (List<string>)ExDtMethod.Select<string>(dtTable, "TABLE_NAME");
            if (list.Count > 0)
            {
                foreach (var it in list)
                {
                    ac.Add(it);
                }
            }
            this.txt_SERACH.AutoCompleteCustomSource = ac;
        }
        private void BindData()
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
            this.gc_TABLE.DataSource = dtTable;
        }

        private void btn_SERACH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_SERACH.Text))
            {
                ShowMessage("搜索框不能为空！");
                return;
            }
            if (ExDtMethod.GetRowCount(dtTable) > 0)
            {
                DataRow[] rows=dtTable.Select(string.Format("TABLE_NAME='{0}'", txt_SERACH.Text.Trim().ToUpper()));
                if (rows.Length > 0)
                {
                    this.gv_TABLE.FocusedRowHandle = int.Parse(rows[0]["SQE"].ToString()) - 1;
                    txt_GEN_DT.Focus();
                }
                else
                {
                    ShowMessage("找不到对应的表名！");
                }
            }
        }

        private void btn_GEN_DT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TABLE_NAME.Text))
            {
                ShowMessage("表名不能为空");
                return;
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(@"SELECT T1.COLUMN_NAME,
                            T1.DATA_TYPE,
                           T2.COMMENTS
                      FROM USER_TAB_COLUMNS T1, USER_COL_COMMENTS T2
                     WHERE T1.TABLE_NAME = '{0}'
                       AND T1.TABLE_NAME = T2.TABLE_NAME
                       AND T1.COLUMN_NAME = T2.COLUMN_NAME", txt_TABLE_NAME.Text.Trim());
            DataTable dtRes = oraBus.QueryToDataTable(sb.ToString(), "TAB_FILED");
            if (ExDtMethod.GetRowCount(dtRes) > 0)
            {
                string res = string.Empty;
                if (string.IsNullOrWhiteSpace(txt_GEN_DT.Text.Trim()))
                {
                     res = new Convert2Dt().FiledConvert2Dt(dtRes);
                }
                else
                {
                    res = new Convert2Dt().FiledConvert2Dt(dtRes, txt_GEN_DT.Text.Trim());
                }
                me_Dt.Text = res;
            }
            else
            {
                me_Dt.Text = string.Empty;
            }
        }

        private void gv_TABLE_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = this.gv_TABLE.GetFocusedDataRow();
            if (row != null)
            {
                txt_TABLE_NAME.Text = Convert.ToString(row["TABLE_NAME"]);
                txt_SERACH.Text = Convert.ToString(row["TABLE_NAME"]);
            }
        }

        private void txt_SERACH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_SERACH_Click(null, null);
            }
        }

        private void txt_GEN_DT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_GEN_DT_Click(null, null);
            }
        }
    }
}
