using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireTabs;

namespace FireBrowser
{
    public partial class WebContainer : FireTitle
    {
        public WebContainer()
        {
          
            InitializeComponent();
            TabRenderer = new FireTabRenderer(this);

            if(FireBrowser.Properties.Settings.Default.ispasswordProtected == true)
            {
                LockScreen locker = new LockScreen();
                Kimtoo.Backdrop.Show(locker);
            }
            else
            {
                return;
            }
        }

        public override FireTitleTab CreateTab()
        {
            return new FireTitleTab(this)
            {
                Content = new BrowserWindow
                {
                    Text = "Fire Browser"
                }
            };
        }

        private void WebContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("SecureShellFireBrowser"))
            {
                process.Kill();
            }
        }
    }
}
