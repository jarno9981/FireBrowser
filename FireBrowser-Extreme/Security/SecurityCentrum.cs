using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireBrowser_Extreme.Security
{
    public partial class SecurityCentrum : Form
    {
        public SecurityCentrum()
        {
            //load
            InitializeComponent();
        }

        private void SecurityCentrum_Load(object sender, EventArgs e)
        {
            //bools check list
            if (FireBrowser_Extreme.Properties.Settings.Default.sc1 == true)
            {
                check.Checked = true;
                check2.Checked = false;
            }
            else
            {
                check.Checked = false;
                check2.Checked = true;
            }
        }

        private void update_Tick(object sender, EventArgs e)
        {
            
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            //auto checker values
            if(check.Checked == true)
            {
                FireBrowser_Extreme.Properties.Settings.Default.sc1 = true;
                FireBrowser_Extreme.Properties.Settings.Default.Scripts = true;
                FireBrowser_Extreme.Properties.Settings.Default.Autofill = true;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
                check.Text = "On";
                check2.Checked = false;
                sep2.LineColor = Color.Silver;
            }
            else
            {
                FireBrowser_Extreme.Properties.Settings.Default.sc1 = false;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
                check.Text = "Off";
                sep2.LineColor = Color.Maroon;
            }
        }

        private void check2_CheckedChanged(object sender, EventArgs e)
        {
            //checker2
            if (check2.Checked == true)
            {
                FireBrowser_Extreme.Properties.Settings.Default.sc2 = true;
                FireBrowser_Extreme.Properties.Settings.Default.Scripts = false;
                FireBrowser_Extreme.Properties.Settings.Default.Autofill = false;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
            
                check2.Text = "On";
                check.Checked = false;
                sep1.LineColor = Color.Silver;
            }
            else
            {
                FireBrowser_Extreme.Properties.Settings.Default.sc2 = false;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
               
                check2.Text = "Off";
                sep1.LineColor = Color.Maroon;
            }
        }
    }
}
