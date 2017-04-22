using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ztdTool.Common
{

    public static class IOHelper
    {
        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string Read(string path)
        {
            StringBuilder sbRead = new StringBuilder();
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    sbRead.AppendLine(line.ToString());
                }
            }
            return sbRead.ToString();
        }
        public static void Write(string writeStr, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                if (fs.CanWrite)
                {
                    //获得字节数组
                    byte[] data = System.Text.Encoding.UTF8.GetBytes(writeStr);
                    //开始写入
                    fs.Write(data, 0, data.Length);
                }
            }
        }
    }
}
