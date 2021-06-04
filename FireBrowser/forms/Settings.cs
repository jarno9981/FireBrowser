using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Net;
using FireTabs;

namespace FireBrowser.forms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            parent.Start();
            timer1.Start();
            if(FireBrowser.Properties.Settings.Default.Engine == true)
            {
                rdGoogle.Checked = true;
                rdBing.Checked = false;
            }
            else
            {
                rdGoogle.Checked = false;
                rdBing.Checked = true;
            }
            if (FireBrowser.Properties.Settings.Default.lasvisited == true)
            {
                last.Checked = true;
            }
            else
            {
                last.Checked = false;
            }
          
        }

        private void Settings_Click(object sender, EventArgs e)
        {
           
        }    



        private void last_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if(last.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.lasvisited = true;
                label5.Text = "On";
                FireBrowser.Properties.Settings.Default.Save();
            }
            else
            {
                FireBrowser.Properties.Settings.Default.lasvisited = false;
                label5.Text = "Off";
                FireBrowser.Properties.Settings.Default.Save();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(FireBrowser.Properties.Settings.Default.lasvisited == true)
            {
                last.Checked = true;
            }
            else
            {
                last.Checked = false;
            }
            if (FireBrowser.Properties.Settings.Default.Engine == true)
            {
                rdGoogle.Checked = true;
                rdBing.Checked = false;
            }
            else
            {
                rdGoogle.Checked = false;
                rdBing.Checked = true;
            }        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void rdGoogle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGoogle.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.EngineDefault = "https://www.google.nl/";
                FireBrowser.Properties.Settings.Default.Engine = true;
                FireBrowser.Properties.Settings.Default.Save();
            }
            else
            {

                FireBrowser.Properties.Settings.Default.EngineDefault = "https://www.bing.com/?cc=nl";
            }
        }

        private void rdBing_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBing.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.EngineDefault = "https://www.bing.com/?cc=nl";
                FireBrowser.Properties.Settings.Default.Engine = false;
                FireBrowser.Properties.Settings.Default.Save();
            }
            else
            {
                FireBrowser.Properties.Settings.Default.EngineDefault = "https://www.google.nl/";

            }
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Stop();
            timer1.Stop();
        }

        private void safety_Click(object sender, EventArgs e)
        {
            if(pass.Text.Length > 3)
            {
                FireBrowser.Properties.Settings.Default.parentsYesNo = false;
                FireBrowser.Properties.Settings.Default.Password = pass.Text.ToString();
                FireBrowser.Properties.Settings.Default.Save();
                unlock.Visible = true;
                safety.Visible = false;
                locker();
                pass.UseSystemPasswordChar = true;
                pass.Text = "";
            }
            else
            {
                return;
            }  
        }

        private void unlock_Click(object sender, EventArgs e)
        {
            if(pass.Text == FireBrowser.Properties.Settings.Default.Password)
            {
                FireBrowser.Properties.Settings.Default.parentsYesNo = true;
                unlock.Visible = false;
                safety.Visible = true;
                unlocker();
                pass.UseSystemPasswordChar = false;
                pass.Text = "";
            }        
        }

        private void unlocker()
        {
            rdGoogle.Enabled = true;
            rdBing.Enabled = true;
            safety.Visible = true;
            this.Text = "Settings - Parent";
            childsecure.Enabled = true;
            label6.Text = "Off";
            childsecure.Value = false;
        }

        private void locker()
        {
            rdGoogle.Enabled = false;
            rdBing.Enabled = false;
            safety.Visible = false;
            this.Text = "Settings - Child";
            childsecure.Value = true;
            childsecure.Enabled = false;
            label6.Text = "On";
        }

        private void parent_Tick(object sender, EventArgs e)
        {
            if (childsecure.Value == true)
            {
                FireBrowser.Properties.Settings.Default.SafeBrowse = true;
                FireBrowser.Properties.Settings.Default.Save();
            }
            else if (childsecure.Value == false)
            {
                FireBrowser.Properties.Settings.Default.SafeBrowse = false;
                FireBrowser.Properties.Settings.Default.Save();
            }
            if(FireBrowser.Properties.Settings.Default.parentsYesNo == false)
            {
                locker();
            }
            else if (FireBrowser.Properties.Settings.Default.parentsYesNo == true)
            {
                unlocker();
            }
        }
    }
}
