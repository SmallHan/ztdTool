using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ztdTool.Common;

namespace ztdTool
{
    public class BaseFrm:Form
    {
        protected  void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }
        protected void ErrorMsg(Exception ex, string errorInfo = "")
        {
            LogHelper.Error(errorInfo, ex);
        }
        #region 等待消息提醒
        /// <summary>
        /// 启动信息等待图标
        /// </summary>
        protected void ShowWait()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this, typeof(WaitForm1), false, false, false);
            SetWaitCaption("请稍候");
            SetWaitDescription("加载中...");
        }
        /// <summary>
        /// 关闭信息等待图标
        /// </summary>
        protected void CloseWait()
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
        }
        /// <summary>
        /// 设置等待进度信息内容
        /// </summary>
        /// <param name="Description"></param>
        protected static void SetWaitDescription(string Description)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription(Description);
        }
        /// <summary>
        /// 设置等待主要信息内容
        /// </summary>
        /// <param name="Caption"></param>
        protected static void SetWaitCaption(string Caption)
        {
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormCaption(Caption);
        }
        #endregion
    }
}
