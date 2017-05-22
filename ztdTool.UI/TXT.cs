using DevExpress.XtraRichEdit.Services;
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
    public partial class TXT : Form
    {
        public TXT()
        {
            InitializeComponent();
        }
        public TXT(string txt)
        {
            InitializeComponent();
            this.txt=txt;
        }
        string txt = "";

        private void TXT_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = txt;
        }
    }
}
