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

namespace FireBrowser_Extreme.forms
{
    public partial class InfoBuild : Form
    {
        public InfoBuild()
        {
            InitializeComponent();
        }

        private void InfoBuild_Load(object sender, EventArgs e)
        {
            string version = "0.0.0.8rc - BETA";
            label3.Text = "v" + version;
            string webview2Runtime = "1.0.1018-prerelease";
            label2.Text = "WebView2 Runtime: " + webview2Runtime.ToString();
            label4.Text = "Licensed To: " + FireBrowser_Extreme.Properties.Settings.Default.user;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
