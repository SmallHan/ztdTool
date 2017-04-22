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
    public partial class FrmGenInterFace : BaseFrm
    {
        public FrmGenInterFace()
        {
            InitializeComponent();
        }

        private void btn_GEN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TABLE_NAME.Text))
            {
                ShowMessage("表名不能为空");
                return;
            }
            if (!ck_SERACH.Checked && !ck_SAVE.Checked)
            {
                ShowMessage("请勾选查询或保存");
                return;
            }
            string res = new GenerateScript().GenMethodName(txt_TABLE_NAME.Text.Trim().ToUpper(), ck_SERACH.Checked, me_REMARK.Text.Trim());
            me_SHOW.Text = res;
        }

        private void ck_SERACH_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_SERACH.Checked)
            {
                ck_SAVE.Checked = false;
            }
        }

        private void ck_SAVE_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_SAVE.Checked)
            {
                ck_SERACH.Checked = false;
            }
        }
    }
}
