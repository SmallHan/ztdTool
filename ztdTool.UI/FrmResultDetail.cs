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

namespace ztdTool.UI
{
    public partial class FrmResultDetail : Form
    {
        public FrmResultDetail()
        {
            InitializeComponent();
        }

        private DataTable dtTemp = new DataTable();
        private string usedSecond = string.Empty;
        public FrmResultDetail(DataTable _dtTemp, string _usedSecond)
        {
            InitializeComponent();
            this.dtTemp = _dtTemp;
            this.usedSecond = _usedSecond;
        }
        private void FrmResultDetail_Load(object sender, EventArgs e)
        {
            GenColumn(dtTemp);
        }
        /// <summary>
        /// 生成GridControl
        /// </summary>
        private  void GenColumn(DataTable dtGrid)
        {
            if (dtGrid != null)
            {
                for (var i = 0; i < dtGrid.Columns.Count; i++)
                {
                    GridColumn gridColumn = new GridColumn();
                    gv_PREVIEW.Columns.Add(gridColumn);
                    gridColumn.AppearanceHeader.Options.UseTextOptions = true;
                    gridColumn.Width = 120;
                    gridColumn.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gridColumn.Caption = dtGrid.Columns[i].ColumnName;
                    gridColumn.FieldName = dtGrid.Columns[i].ColumnName;
                    gridColumn.Name = dtGrid.Columns[i].ColumnName;
                    gridColumn.Visible = true;
                    gridColumn.VisibleIndex = i;
                }
                this.gc_PREVIEW.DataSource = dtGrid;
            }
        }
        private void ShowInfo()
        {
            lbl_TIME.Text = usedSecond;
            lbl_ROW.Text = dtTemp.Rows.Count.ToString();
        }
    }
}
