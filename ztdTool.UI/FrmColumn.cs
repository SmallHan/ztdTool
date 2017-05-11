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
    public partial class FrmColumn : BaseFrm
    {
        public FrmColumn()
        {
            InitializeComponent();
        }
        private OracleBusiness oraBus = new OracleBusiness();
        private DataTable dt1 = new DataTable();

        public DataTable Dt1
        {
            get { return dt1; }
            set { dt1 = value; }
        }

        private DataTable dt2 = new DataTable();

        public DataTable Dt2
        {
            get { return dt2; }
            set { dt2 = value; }
        }

        private DataTable dt3 = new DataTable();

        public DataTable Dt3
        {
            get { return dt3; }
            set { dt3 = value; }
        }

        private void FrmColumn_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dt1;
            gridControl2.DataSource = dt2;
            gridControl3.DataSource = dt3;
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left //左键点击
               && e.Clicks == 2 //双击
               && e.RowHandle >= 0)//选中行
            {
                string name = this.gridView2.GetFocusedRowCellValue(this.TRIGGER_NAME).ToString();
                string sql = "SELECT TEXT FROM ALL_SOURCE WHERE TYPE='TRIGGER' AND NAME='" + name + "'";
                DataTable dt = ExcSql(sql);
                string strTxt = "";
                foreach (DataRow row in dt.Rows)
                {
                    strTxt += row["TEXT"]+"\r";
                }
                TXT frm = new TXT(strTxt);
                frm.Name = name;
                frm.Show();
            }
        }

        public DataTable ExcSql(string sql)
        {
            DataTable dtRes = oraBus.QueryToDataTable(sql);
            if (ExDtMethod.GetRowCount(dtRes) > 0)
            {
                return dtRes;
            }
            return null;
        }
    }
}
