using Microsoft.Web.WebView2.Core;
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

namespace FireBrowser.forms
{
    public partial class InfoBuild : Form
    {
        public InfoBuild()
        {
            InitializeComponent();
        }

        private void InfoBuild_Load(object sender, EventArgs e)
        {
            string version = "0.0.4.7 - public release";
            label3.Text = "v" + version;
            label4.Text = "Licensed To: " + FireBrowser.Properties.Settings.Default.user;
            label2.Text = "WebView2 Runtime : 96.0.1054.29 fixed";
        }
    }
}
