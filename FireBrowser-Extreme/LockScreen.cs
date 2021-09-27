using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireBrowser_Extreme
{
    public partial class LockScreen : Form
    {
        public LockScreen()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void unlockbtn_Click(object sender, EventArgs e)
        {
            if(psscode.Text == FireBrowser_Extreme.Properties.Settings.Default.passwordBrowser)
            {
                this.Dispose();
                this.Hide();
            }
        }

        private void LockScreen_Load(object sender, EventArgs e)
        {
            account.Text = "Welcome, " + FireBrowser_Extreme.Properties.Settings.Default.user.ToString() + " " + "Please Log In";
        }
    }
}
