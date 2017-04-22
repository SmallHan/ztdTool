using DevExpress.XtraGrid.Columns;
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
using System.IO;
using System.Text.RegularExpressions;

namespace ztdTool.UI
{
    public partial class FrmDisgnCode : BaseFrm
    {
        public FrmDisgnCode()
        {
            InitializeComponent();
        }

        DataTable dtTable = new DataTable();
        OracleBusiness oraBus = new OracleBusiness();
        private void FrmDisgnCode_Load(object sender, EventArgs e)
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
                DataRow[] rows = dtTable.Select(string.Format("TABLE_NAME='{0}'", txt_SERACH.Text.Trim().ToUpper()));
                if (rows.Length > 0)
                {
                    this.gv_TABLE.FocusedRowHandle = int.Parse(rows[0]["SQE"].ToString()) - 1;
                }
                else
                {
                    ShowMessage("找不到对应的表名！");
                }
            }
        }

        private void txt_SERACH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_SERACH_Click(null, null);
            }
        }

        private void btn_SELECT_FILED_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_GRID_VIEW.Text))
            {
                ShowMessage("请输入对应的窗体名称");
                return;
            }
            DataRow row = this.gv_TABLE.GetFocusedDataRow();
            if (row != null)
            {
                FrmDetail frm = new FrmDetail(Convert.ToString(row["TABLE_NAME"]));
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.WindowState = FormWindowState.Maximized;
                frm.Dock = DockStyle.Fill;
                frm.setScript = GenScript;
                frm.ShowDialog();
            }
            
        }

        private void gv_TABLE_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
             DataRow row = this.gv_TABLE.GetFocusedDataRow();
             if (row != null)
             {
                 txt_SERACH.Text = Convert.ToString(row["TABLE_NAME"]);
             }
        }

        /// <summary>
        /// 生成脚本
        /// </summary>
        /// <param name="dtTemp"></param>
        private void GenScript(DataTable dtTemp)
        {
            me_TEXT.Text = string.Empty;
            if (ExDtMethod.GetRowCount(dtTemp) > 0)
            {
                me_TEXT.Text = new GenerateScript().GenScript(dtTemp, txt_GRID_VIEW.Text.Trim());
                btn_WRITE.Enabled = true;
            }
        }

        /// <summary>
        /// 写入到设计文件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_WRITE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_PATH.Text))
            {
                ShowMessage("路径不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_FRM_NAME.Text))
            {
                ShowMessage("窗体名不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_GRID_VIEW.Text))
            {
                ShowMessage("GRIDVIEW不能为空");
                return;
            }
            if (string.IsNullOrWhiteSpace(txt_GC_NAME.Text))
            {
                ShowMessage("GridControl不能为空");
                return;
            }
            //读取文件内容
            StringBuilder sbRead = new StringBuilder();
            string path = string.Format(@"{0}\{1}.Designer.cs", txt_PATH.Text, txt_FRM_NAME.Text);
            if (!File.Exists(path))
            {
                ShowMessage("该文件不存在！");
                return;
            }
            //读取对应窗体的设计代码
            string strAll = IOHelper.Read(path);
            //将程序生成的设计代码分割
            List<string>  allList = SpiltStrToList();
            //重写配置文件
            string resStr=new GenerateScript().GenDeginCode(txt_GRID_VIEW.Text.Trim(),txt_GC_NAME.Text.Trim(), strAll, allList);
            IOHelper.Write(resStr, path);
            ShowMessage("写入成功");
        }
        /// <summary>
        /// 分割生成的List
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private List<string> SpiltStrToList()
        {
            Regex regex = new Regex("\r\n\r\n\r\n\r\n\r\n");
            //-------------------------------------------------------------
            var list = me_TEXT.Text.Split(new string[] { "-------------------------------------------------------------" }, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            var newList = new List<string>();
            foreach (var it in list)
            {
                var resStr = regex.Replace(it, string.Empty);
                newList.Add(resStr);
            }
            return newList;

        }
    }
}
