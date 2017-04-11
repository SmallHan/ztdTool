using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ztdTool.Common
{
    /// <summary>
    /// 写入设计代码文件
    /// </summary>
    public class WriteToDegsinCode
    {
        private string degsinCode = string.Empty;
        private string scriptCode = string.Empty;
        private List<string> strList=new List<string>();

        public WriteToDegsinCode() { }
        public WriteToDegsinCode(string _degsinCode,string _scriptCode)
        {
            this.degsinCode = _degsinCode;
            this.scriptCode = _scriptCode;
        }
        /// <summary>
        /// 写入到配置文件
        /// </summary>
        public void WriteToDegsin()
        {
            SpiltWrapToList();
        }
        /// <summary>
        /// 转换为List数组
        /// </summary>
        private void SpiltWrapToList()
        {
            strList = scriptCode.Split(new string[] { "\r\n\r\n\r\n\r\n\r\n" }, StringSplitOptions.None).ToList();
        }
    }
}
