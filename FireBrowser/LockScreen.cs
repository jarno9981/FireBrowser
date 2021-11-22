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

namespace FireBrowser
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
            if(psscode.Text == FireBrowser.Properties.Settings.Default.passwordBrowser)
            {             
                FireBrowser.Properties.Settings.Default.falseUnlock = false;
                FireBrowser.Properties.Settings.Default.Save();
                this.Dispose();
                this.Hide();
            }
        }

        private void LockScreen_Load(object sender, EventArgs e)
        {
            account.Text = "Welcome, " + FireBrowser.Properties.Settings.Default.user.ToString() + " " + "Please Log In";
        }

        private void account_Click(object sender, EventArgs e)
        {
           
        }

        private void LockScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FireBrowser.Properties.Settings.Default.falseUnlock == true)
            {
                foreach (var process in Process.GetProcessesByName("FireBrowser"))
                {
                    process.Kill();
                }
             
                this.Close();
            }
            else
            {
                return;
            }         
        }

        private void LockScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }
    }
}
