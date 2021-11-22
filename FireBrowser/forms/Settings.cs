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
            timer1.Start();
            firstsync.Start();
            checklist();
         
          
            if (FireBrowser.Properties.Settings.Default.Engine == false)
            {
                FireBrowser.Properties.Settings.Default.EngineDefault = textBox1.Text;
                rdGoogle.Checked = false;
                cs.Checked = true;
            }
            else
            {
                FireBrowser.Properties.Settings.Default.EngineDefault = "https://www.google.nl/";
                rdGoogle.Checked = true;
                cs.Checked = false;
            }


            placeTxt.Text = FireBrowser.Properties.Settings.Default.Placeholder;

            if(FireBrowser.Properties.Settings.Default.limited == true)
            {
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox2.Enabled = false;
                groupBox6.Enabled = false;
                groupBox5.Enabled = false;
                this.Text = "Settings - Unlicensed";
            }
            else
            {
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox2.Enabled = true;
                groupBox6.Enabled = true;
                groupBox5.Enabled = true;
            }
            
            if (FireBrowser.Properties.Settings.Default.PopUp == "Modern")
            {
                md.Checked = true;
                cl.Checked = false;
                bl.Checked = false;
            }
            if (FireBrowser.Properties.Settings.Default.PopUp == "Classic")
            {
                cl.Checked = true;
                md.Checked = false;
                bl.Checked = false;
            }
            if (FireBrowser.Properties.Settings.Default.PopUp == "Blocked")
            {
                bl.Checked = true;
                md.Checked = false;
                cl.Checked = false;
            }

            usrm.Text = FireBrowser.Properties.Settings.Default.user;
            psspass.Text = FireBrowser.Properties.Settings.Default.passwordBrowser;

            
        }

        private void checklist()
        {
            if (FireBrowser.Properties.Settings.Default.dev == true)
            {
                tools.Checked = true;
                label9.Text = "Devtools - enabled - alpha";
            }
            else
            {
                tools.Checked = false;
                label9.Text = "Devtools - off";
            }
            if (FireBrowser.Properties.Settings.Default.Scripts == true)
            {
                Script.Checked = true;
                label5.Text = "Scripts - enabled";
            }
            else
            {
                Script.Checked = false;
                label5.Text = "Scripts - off";
            }
            if (FireBrowser.Properties.Settings.Default.Autofill == true)
            {
                Autofill.Checked = true;
                label7.Text = "Autofill - enabled";
            }
            else
            {
                Autofill.Checked = false;
                label7.Text = "Autofill - off";
            }
            if (FireBrowser.Properties.Settings.Default.Engine == true)
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

            if (FireBrowser.Properties.Settings.Default.PopUp == "Modern")
            {
                md.Checked = true;
                cl.Checked = false;
                bl.Checked = false;
            }

            if (FireBrowser.Properties.Settings.Default.PopUp == "Classic")
            {
                md.Checked = false;
                cl.Checked = true;
                bl.Checked = false;
            }

            if (FireBrowser.Properties.Settings.Default.PopUp == "Blocked")
            {
                md.Checked = false;
                cl.Checked = false;
                bl.Checked = true;
            }
            if (FireBrowser.Properties.Settings.Default.ispasswordProtected == true)
            {
                lockswicht.Checked = true;
            }
            else
            {
                lockswicht.Checked = false;
            }
        }

        private void Settings_Click(object sender, EventArgs e)
        {
           
        }      

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (psspass.TextLength > 3)
            {
                lockswicht.Enabled = true;
            }
            else
            {
                lockswicht.Enabled = false;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    


        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
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
            }
          
        }

        private void AeroPeek_CheckedChanged(object sender, EventArgs e)
        {
            if(AeroPeek.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.AeroPeek = true;   
                FireBrowser.Properties.Settings.Default.Save();
               
            }
            else if(AeroPeek.Checked == false)
            {
                FireBrowser.Properties.Settings.Default.AeroPeek = false;
                FireBrowser.Properties.Settings.Default.Save();
             
            }
            FireBrowser.Properties.Settings.Default.Save();
        }


        private void rdGoogle_CheckedChanged(object sender, EventArgs e)
        {
            if (rdGoogle.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.EngineDefault = "https://www.google.nl/";
                FireBrowser.Properties.Settings.Default.Engine = true;
            }
        }

   

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Script_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (Script.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.Scripts = true;
                FireBrowser.Properties.Settings.Default.Save();
               
                label5.Text = "Scripts - enabled";
            }
            else
            {
                FireBrowser.Properties.Settings.Default.Scripts = false;
                FireBrowser.Properties.Settings.Default.Save();
           
                label5.Text = "Scripts - off";
            }
        }

        private void Autofill_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (Autofill.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.Autofill = true;
                FireBrowser.Properties.Settings.Default.Save();
             
                label7.Text = "Autofill - enabled";
            }
            else
            {
                FireBrowser.Properties.Settings.Default.Autofill = false;
                FireBrowser.Properties.Settings.Default.Save();
                
                label7.Text = "Autofill - off";
            }
        }

        private void tools_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (tools.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.dev = true;
                FireBrowser.Properties.Settings.Default.Save();
                label9.Text = "Devtools - enabled";
            }
            else
            {
                FireBrowser.Properties.Settings.Default.dev = false;
                FireBrowser.Properties.Settings.Default.Save();
                label9.Text = "Devtools - off";
            }
        }

        private void lockswicht_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (lockswicht.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.ispasswordProtected = true;
                FireBrowser.Properties.Settings.Default.passwordBrowser = psspass.Text.ToString();
                FireBrowser.Properties.Settings.Default.Save();
            }
            else
            {
                FireBrowser.Properties.Settings.Default.ispasswordProtected = false;
                FireBrowser.Properties.Settings.Default.Save();
            }
            FireBrowser.Properties.Settings.Default.Save();
        }

        private void savepss_Click(object sender, EventArgs e)
        {
            if(psspass.TextLength > 3)
            {
                lockswicht.Enabled = true;
            }
            else
            {
                lockswicht.Enabled = false;
            }
         
            FireBrowser.Properties.Settings.Default.passwordBrowser = psspass.Text.ToString();
            FireBrowser.Properties.Settings.Default.Save();
        }

        private void saveusmr_Click(object sender, EventArgs e)
        {
            FireBrowser.Properties.Settings.Default.user = usrm.Text.ToString();
            FireBrowser.Properties.Settings.Default.Save();
        }
        private void rfPage_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void placeHd_Click(object sender, EventArgs e)
        {
            FireBrowser.Properties.Settings.Default.Placeholder = placeTxt.Text.ToString();
            FireBrowser.Properties.Settings.Default.ForeColor = Color.FromName(forc.Text.ToString());
            FireBrowser.Properties.Settings.Default.Save();
        }

        private void md_CheckedChanged(object sender, EventArgs e)
        {
            FireBrowser.Properties.Settings.Default.PopUp = "Modern";
            FireBrowser.Properties.Settings.Default.Save();
        }

        private void cl_CheckedChanged(object sender, EventArgs e)
        {
            FireBrowser.Properties.Settings.Default.PopUp = "Classic";
            FireBrowser.Properties.Settings.Default.Save();
        }

        private void bl_CheckedChanged(object sender, EventArgs e)
        {
            FireBrowser.Properties.Settings.Default.PopUp = "Blocked";
            FireBrowser.Properties.Settings.Default.Save();
        }

        private void Navs_Click(object sender, EventArgs e)
        {

        }

        private void SearchPage_Click(object sender, EventArgs e)
        {
            uisettings.SelectTab(0);
        }

        private void Privacybtn_Click(object sender, EventArgs e)
        {
            uisettings.SelectTab(1);
        }

        private void btnpop_Click(object sender, EventArgs e)
        {
            uisettings.SelectTab(2);
        }

        private void btnCostum_Click(object sender, EventArgs e)
        {
            uisettings.SelectTab(3);
        }

        private void btnchild_Click(object sender, EventArgs e)
        {
            uisettings.SelectTab(4);
        }

        private void btnNav_Click(object sender, EventArgs e)
        {
            uisettings.SelectTab(4);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if (File.Exists("Setup.ini"))
            {
                File.Delete("Setup.ini");
                MessageBox.Show("Please Re-Open App To Start Process", "Info");
            }
            else
            {
                MessageBox.Show("No Setup.ini Found No Reset Started","Info");
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
           
            if (cs.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.EngineDefault = textBox1.Text;
                FireBrowser.Properties.Settings.Default.Engine = false;         
                FireBrowser.Properties.Settings.Default.Save();

            }
            else if (rdGoogle.Checked == true)
            {
                FireBrowser.Properties.Settings.Default.EngineDefault = "https://www.google.nl/";
                FireBrowser.Properties.Settings.Default.Engine = true;
                FireBrowser.Properties.Settings.Default.Save();

            }
            FireBrowser.Properties.Settings.Default.Save();
        }
    }
}
