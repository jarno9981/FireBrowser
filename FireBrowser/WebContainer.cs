using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FireTabs;
using Microsoft.Web.WebView2.Core;
using FireBrowser.Properties;

namespace FireBrowser
{
    public partial class WebContainer : FireTitle
    { 
        public WebContainer()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
       
        }

        public override FireTitleTab CreateTab()
        {

            return new FireTitleTab(this)
            {
                // The content will be an instance of another Form
                // In our example, we will create a new instance of the Form1
                Content = new Browser
                {
                    Text = "Fire Browser"
                }
            };
        }
    }
}
