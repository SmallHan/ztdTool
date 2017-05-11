using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ztdTool.UI
{
    public class ExecSqlModel
    {
        public DataTable dt { get; set; }
        public int rowCount { get; set; }
        public string execSeconds { get; set; }

    }
}
