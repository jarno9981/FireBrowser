using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireBrowser
{
    public partial class Privacy : Form
    {
        public Privacy()
        {
            InitializeComponent();

        }

      

        private void nswict_CheckedChanged(object sender, EventArgs e)
        {
            if (nswict.Checked == false)
            {
                FireBrowser.Properties.Settings.Default.safe = false;
                FireBrowser.Properties.Settings.Default.Save();
            }
            else if(nswict.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.safe = true;
                FireBrowser.Properties.Settings.Default.Save();
            } 
        }

        private void Privacy_Load(object sender, EventArgs e)
        {
            if(FireBrowser.Properties.Settings.Default.safe == true)
            {
                nswict.Checked = true;
            }
            else
            {
                nswict.Checked = false;
            }
        }

    }
}
