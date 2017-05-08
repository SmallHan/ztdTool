using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using ztdTool.Common;

namespace ztdTool.UI
{
    public partial class FrmMain : BaseFrm
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        SQLiteBusiness sqliteDB = null;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                InitConfig();
                GetConfigForXml();
                LinkConfig();
                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                ErrorMsg(ex);
            }
        }

        /// <summary>
        /// 从xml加载配置
        /// </summary>
        private void GetConfigForXml()
        {
            if (!File.Exists(Utils.xmlPath))
            {
                return;
            }
            XDocument xdoc = XDocument.Load(Utils.xmlPath);
            BaseConfig.guid = xdoc.Element("LIBCONFIG").Element("GUID").Value;
            BaseConfig.library = xdoc.Element("LIBCONFIG").Element("LIBRARY").Value;
            BaseConfig.service = xdoc.Element("LIBCONFIG").Element("SERVICE").Value;
            BaseConfig.userName = xdoc.Element("LIBCONFIG").Element("USERNAME").Value;
            BaseConfig.pwd = xdoc.Element("LIBCONFIG").Element("PWD").Value;
            BaseConfig.host = xdoc.Element("LIBCONFIG").Element("HOST").Value;
            BaseConfig.port = xdoc.Element("LIBCONFIG").Element("PORT").Value;
        }
        private void LinkConfig()
        {
            if (string.IsNullOrWhiteSpace(BaseConfig.service)) return;
            ShowWait();
            string res = Utils.IsCheckLinkSuccess() ? string.Format("链接{0}库成功", BaseConfig.library) : string.Format("链接{0}库失败", BaseConfig.library);
            CloseWait();
            ShowMessage(res);
            if (res.Equals(string.Format("链接{0}库失败", BaseConfig.library)))
            {
                Utils.SetBaseConfigEmpty();
            }
        }
        /// <summary>
        /// 初始化配置
        /// </summary>
        private void InitConfig()
        {
            Utils.dataPath = string.Format("{0}DB\\", Utils.dataPath);
            if (!Directory.Exists(Utils.dataPath))
            {
                Directory.CreateDirectory(Utils.dataPath);
            }
            sqliteDB = new SQLiteBusiness(string.Format(@"Data Source={0}LibConfig.db", Utils.dataPath));
            sqliteDB.CreateDB();
        }

        /// <summary>
        /// 生成DataTable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_GENDT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckConfig()) return;
            Utils.CloseForm(xtMain);
            FrmConvert2Dt frm = new FrmConvert2Dt();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            xtMain.Controls.Add(frm);
            frm.Show();
        }

        /// <summary>
        /// 生成设计器代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_GENCODE_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckConfig()) return;
            Utils.CloseForm(xtMain);
            FrmDisgnCode frm = new FrmDisgnCode();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            xtMain.Controls.Add(frm);
            frm.Show();
        }

        /// <summary>
        /// 生成接口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_GENINTER_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckConfig()) return;
            Utils.CloseForm(xtMain);
            FrmGenInterFace frm = new FrmGenInterFace();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            xtMain.Controls.Add(frm);
            frm.Show();
            
        }

        /// <summary>
        /// 配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bar_SYS_CONFIG_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utils.CloseForm(xtMain);
            FrmConfigure frm = new FrmConfigure();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            xtMain.Controls.Add(frm);
            frm.Show();
        }
        private void barSelect_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckConfig()) return;
            Utils.CloseForm(xtMain);
            FrmDesgnSelctCode frm = new FrmDesgnSelctCode();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            xtMain.Controls.Add(frm);
            frm.Show();
        }
        private void barScript_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!CheckConfig()) return;
            Utils.CloseForm(xtMain);
            SetFormAttributeAndShow(new FrmSqlSelect());
        }
        private void SetFormAttributeAndShow(Form frm)
        {
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            xtMain.Controls.Add(frm);
            frm.Show();
        }
        /// <summary>
        /// 检验是否有配置
        /// </summary>
        /// <returns></returns>
        private bool CheckConfig()
        {
            if (string.IsNullOrWhiteSpace(BaseConfig.host))
            {
                ShowMessage("请先选择对应的库");
                return false;
            }
            return true;
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(BaseConfig.service))
            {
                XmlHelper.LoggerConfigToXml();
            }
        }




    }
}
