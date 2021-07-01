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

            if(FireBrowser.Properties.Settings.Default.AeroPeek == true)
            {
                AeroPeekEnabled = true;
            }
            else if (FireBrowser.Properties.Settings.Default.AeroPeek == false)
            {
                AeroPeekEnabled = false;
            }

            TabRenderer = new FireTabRenderer(this);
       
        }

        public override FireTitleTab CreateTab()
        {

            return new FireTitleTab(this)
            {
                Content = new Browser
                {
                    Text = "Fire Browser"
                }
            };
        }
    }
}
