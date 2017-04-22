using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ztdTool.Common;

namespace ztdTool
{
    public partial class FrmDesgnSelctCode : BaseFrm
    {
        public FrmDesgnSelctCode()
        {
            InitializeComponent();
        }
        string gvName = string.Empty;
        string gcName = string.Empty;

        private void FrmDesgnSelctCode_Load(object sender, EventArgs e)
        {

        }

        private void btn_CONFIG_Click(object sender, EventArgs e)
        {
            gvName = txt_GRID_VIEW.Text.Trim();
            gcName = txt_GRID_CONTROL.Text.Trim();
            if (string.IsNullOrWhiteSpace(gvName))
            {
                ShowMessage("GridView不能为空");
            }
            if (string.IsNullOrWhiteSpace(gcName))
            {
                ShowMessage("GridControl不能为空");
            }
            FrmSelctGenScript frm = new FrmSelctGenScript();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.WindowState = FormWindowState.Maximized;
            frm.Dock = DockStyle.Fill;
            frm.setScript = GenScript;
            frm.ShowDialog();
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
                panelControl3.Enabled = true;
            }
        }

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
            if (string.IsNullOrWhiteSpace(gvName))
            {
                ShowMessage("GridView不能为空");
            }
            if (string.IsNullOrWhiteSpace(gcName))
            {
                ShowMessage("GridControl不能为空");
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
            List<string> allList = SpiltStrToList();
            //重写配置文件
            string resStr = new GenerateScript().GenDeginCode(gvName, gcName, strAll, allList);
            IOHelper.Write(resStr, path);
            ShowMessage("写入成功");
            panelControl3.Enabled = false;
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
