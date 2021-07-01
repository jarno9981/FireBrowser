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
            firstsync.Start();
            if(FireBrowser.Properties.Settings.Default.Engine == true)
            {
                rdGoogle.Checked = true;
              
            }
            else
            {
                rdGoogle.Checked = false;
              
            }
            if (FireBrowser.Properties.Settings.Default.Engine == true)
            {
                rdGoogle.Checked = true;

            }
            else if (FireBrowser.Properties.Settings.Default.Engine == false)
            {
                rdGoogle.Checked = false;

                textBox1.Text = FireBrowser.Properties.Settings.Default.EngineDefault;
            }

            if (FireBrowser.Properties.Settings.Default.AeroPeek == true)
            {
                AeroPeek.Checked = true;
            }
            else if (FireBrowser.Properties.Settings.Default.AeroPeek == false)
            {
                AeroPeek.Checked = false;
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
           
        }      

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
         ;
            safety.Visible = true;
            this.Text = "Settings - Parent";
            childsecure.Enabled = true;
            label6.Text = "Off";
            childsecure.Checked = false;
        }

        private void locker()
        {
            rdGoogle.Enabled = false;
          
            safety.Visible = false;
            this.Text = "Settings - Child";
            childsecure.Checked = true;
            childsecure.Enabled = false;
            label6.Text = "On";
        }

        private void parent_Tick(object sender, EventArgs e)
        {
            if (childsecure.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.SafeBrowse = true;
                FireBrowser.Properties.Settings.Default.Save();
            }
            else if (childsecure.Checked == false)
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

        private void firstsync_Tick(object sender, EventArgs e)
        {
            if (FireBrowser.Properties.Settings.Default.check == true)
            {
                return;
            }
            else if (FireBrowser.Properties.Settings.Default.check == false)
            {
                this.Show();
                FireBrowser.Properties.Settings.Default.check = true;
                FireBrowser.Properties.Settings.Default.Save();
                Thread.Sleep(100);
                this.Close();
            }
          
        }

        private void AeroPeek_CheckedChanged(object sender, EventArgs e)
        {
            if(AeroPeek.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.AeroPeek = true;   
                FireBrowser.Properties.Settings.Default.Save();
                FireBrowser.Browser.ActiveForm.Refresh();
            }
            else if(AeroPeek.Checked == false)
            {
                FireBrowser.Properties.Settings.Default.AeroPeek = false;
                FireBrowser.Properties.Settings.Default.Save();
                FireBrowser.Browser.ActiveForm.Refresh();
            }
            FireBrowser.Properties.Settings.Default.Save();
        }


        private void rdGoogle_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FireBrowser.Properties.Settings.Default.Save();
            if(cs.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.EngineDefault = textBox1.Text;
                FireBrowser.Properties.Settings.Default.Engine = false;
            }
           else if (rdGoogle.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.EngineDefault = "https://www.google.nl/";
                FireBrowser.Properties.Settings.Default.Engine = true;
            }
        }
    }
}
