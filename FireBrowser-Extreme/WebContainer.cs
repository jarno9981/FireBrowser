using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireTabs;

namespace FireBrowser_Extreme
{
    public partial class WebContainer : FireTitle
    {

        public WebContainer()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            if (FireBrowser_Extreme.Properties.Settings.Default.AeroPeek == true)
            {
                AeroPeekEnabled = true;
            }
            else if (FireBrowser_Extreme.Properties.Settings.Default.AeroPeek == false)
            {
                AeroPeekEnabled = false;
            }

            TabRenderer = new FireTabRenderer(this);

            
           

            if (FireBrowser_Extreme.Properties.Settings.Default.ispasswordProtected == true)
            {
                FireBrowser_Extreme.LockScreen lockScreen = new FireBrowser_Extreme.LockScreen();
                lockScreen.Show();
            }
            else
            {

            }
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
