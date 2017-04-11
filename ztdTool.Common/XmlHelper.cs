using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ztdTool.Common
{
    public static class XmlHelper
    {
        /// <summary>
        /// 将配置信息保存到xml
        /// </summary>
        public static void LoggerConfigToXml()
        {
            XDocument xmlDoc = new XDocument(
                new XElement("LIBCONFIG",
                        new XElement("GUID",BaseConfig.guid),
                        new XElement("LIBRARY",BaseConfig.library),
                        new XElement("SERVICE",BaseConfig.service),
                        new XElement("USERNAME", BaseConfig.userName),
                        new XElement("PWD", BaseConfig.pwd),
                        new XElement("HOST", BaseConfig.host),
                        new XElement("PORT", BaseConfig.port)
                    )
                );
            xmlDoc.Save(Utils.xmlPath);
        }
    }
}
