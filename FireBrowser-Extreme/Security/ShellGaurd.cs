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
    public partial class ShellGaurd : Form
    {
        public ShellGaurd()
        {
            InitializeComponent();
        }

        private void ShellGaurd_Load(object sender, EventArgs e)
        {
            //transparent
            this.TransparencyKey = Color.White;
            IconShell.Visible = true;         
        }

        private void settings_Click(object sender, EventArgs e)
        {
            FireBrowser_Extreme.forms.Settings settings = new FireBrowser_Extreme.forms.Settings();
            settings.Show();
        }

        private void security_Click(object sender, EventArgs e)
        {
            FireBrowser_Extreme.Security.SecurityCentrum sec = new FireBrowser_Extreme.Security.SecurityCentrum();
            sec.Show();
        }
    }
}
