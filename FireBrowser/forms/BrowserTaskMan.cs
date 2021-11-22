using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using System.Dynamic;

namespace FireBrowser.forms
{
    public partial class BrowserTaskMan : Form
    {
        public BrowserTaskMan()
        {
            InitializeComponent();
        }

        Process[] processList = Process.GetProcessesByName("FireBrowser");

        private void BrowserTaskMan_Load(object sender, EventArgs e)
        {

            lsbox.Items.Add(processList);

        }
    }
}
