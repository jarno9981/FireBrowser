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


namespace FireBrowser_Extreme.forms
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

            usrm.Text = FireBrowser_Extreme.Properties.Settings.Default.user;
            psspass.Text = FireBrowser_Extreme.Properties.Settings.Default.passwordBrowser;

            if (FireBrowser_Extreme.Properties.Settings.Default.dev == true)
            {             
                tools.Checked = true;
                label9.Text = "Devtools - enabled - alpha";
            }
            else
            {
                tools.Checked = false;
                label9.Text = "Devtools - off";
            }
            if (FireBrowser_Extreme.Properties.Settings.Default.Scripts == true)
            {
                Script.Checked = true;
                label5.Text = "Scripts - enabled";
            }
            else
            {
                Script.Checked = false;
                label5.Text = "Scripts - off";
            }
            if (FireBrowser_Extreme.Properties.Settings.Default.Autofill == true)
            {
                Autofill.Checked = true;
                label7.Text = "Autofill - enabled";
            }
            else
            {
                Autofill.Checked = false;
                label7.Text = "Autofill - off";
            }
            if(FireBrowser_Extreme.Properties.Settings.Default.Engine == true)
            {
                rdGoogle.Checked = true;
              
            }
            else
            {
                rdGoogle.Checked = false;
              
            }
            if (FireBrowser_Extreme.Properties.Settings.Default.Engine == true)
            {
                rdGoogle.Checked = true;

            }
            else if (FireBrowser_Extreme.Properties.Settings.Default.Engine == false)
            {
                rdGoogle.Checked = false;

                textBox1.Text = FireBrowser_Extreme.Properties.Settings.Default.EngineDefault;
            }

            if (FireBrowser_Extreme.Properties.Settings.Default.AeroPeek == true)
            {
                AeroPeek.Checked = true;
            }
            else if (FireBrowser_Extreme.Properties.Settings.Default.AeroPeek == false)
            {
                AeroPeek.Checked = false;
            }

            if(FireBrowser_Extreme.Properties.Settings.Default.PopUp == "Modern")
            {
                md.Checked = true;
                cl.Checked = false;
                bl.Checked = false;
            }

            if (FireBrowser_Extreme.Properties.Settings.Default.PopUp == "Classic")
            {
                md.Checked = false;
                cl.Checked = true;
                bl.Checked = false;
            }

            if (FireBrowser_Extreme.Properties.Settings.Default.PopUp == "Blocked")
            {
                md.Checked = false;
                cl.Checked = false;
                bl.Checked = true;
            }
            if(FireBrowser_Extreme.Properties.Settings.Default.ispasswordProtected == true)
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
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Stop();
            timer1.Stop();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void safety_Click(object sender, EventArgs e)
        {
            if(pass.Text.Length > 3)
            {
                FireBrowser_Extreme.Properties.Settings.Default.parentsYesNo = false;
                FireBrowser_Extreme.Properties.Settings.Default.Password = pass.Text.ToString();
                FireBrowser_Extreme.Properties.Settings.Default.Save();
                unlock.Visible = true;
                safety.Visible = false;
                this.Alert("Child Protect Setup-Done", Form_Alert.enmType.Info);
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
            if(pass.Text == FireBrowser_Extreme.Properties.Settings.Default.Password)
            {
                FireBrowser_Extreme.Properties.Settings.Default.parentsYesNo = true;
                unlock.Visible = false;
                safety.Visible = true;
                unlocker();
                this.Alert("Child Protect Off",Form_Alert.enmType.Info);
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
                FireBrowser_Extreme.Properties.Settings.Default.SafeBrowse = true;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
            }
            else if (childsecure.Checked == false)
            {
                FireBrowser_Extreme.Properties.Settings.Default.SafeBrowse = false;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
            }
            if(FireBrowser_Extreme.Properties.Settings.Default.parentsYesNo == false)
            {
                locker();
            }
            else if (FireBrowser_Extreme.Properties.Settings.Default.parentsYesNo == true)
            {
                unlocker();
            }

            if(md.Checked == true)
            {
                FireBrowser_Extreme.Properties.Settings.Default.PopUp = "Modern";
                FireBrowser_Extreme.Properties.Settings.Default.Save();
            }
            if (cl.Checked == true)
            {
                FireBrowser_Extreme.Properties.Settings.Default.PopUp = "Classic";
                FireBrowser_Extreme.Properties.Settings.Default.Save();
            }
            if (bl.Checked == true)
            {
                FireBrowser_Extreme.Properties.Settings.Default.PopUp = "Blocked";
                FireBrowser_Extreme.Properties.Settings.Default.Save();
            }
        }

        private void firstsync_Tick(object sender, EventArgs e)
        {
            if (FireBrowser_Extreme.Properties.Settings.Default.check == true)
            {
                return;
            }
            else if (FireBrowser_Extreme.Properties.Settings.Default.check == false)
            {
                this.Show();
                FireBrowser_Extreme.Properties.Settings.Default.check = true;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
                Thread.Sleep(100);
                this.Close();
            }
          
        }

        private void AeroPeek_CheckedChanged(object sender, EventArgs e)
        {
            if(AeroPeek.Checked == true)
            {
                FireBrowser_Extreme.Properties.Settings.Default.AeroPeek = true;   
                FireBrowser_Extreme.Properties.Settings.Default.Save();
                FireBrowser_Extreme.Browser.ActiveForm.Refresh();
            }
            else if(AeroPeek.Checked == false)
            {
                FireBrowser_Extreme.Properties.Settings.Default.AeroPeek = false;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
                FireBrowser_Extreme.Browser.ActiveForm.Refresh();
            }
            FireBrowser_Extreme.Properties.Settings.Default.Save();
        }


        private void rdGoogle_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Save_Click(object sender, EventArgs e)
        {
            FireBrowser_Extreme.Properties.Settings.Default.Save();
            if(cs.Checked == true)
            {
                FireBrowser_Extreme.Properties.Settings.Default.EngineDefault = textBox1.Text;
                FireBrowser_Extreme.Properties.Settings.Default.Engine = false;
            }
           else if (rdGoogle.Checked == true)
            {
                FireBrowser_Extreme.Properties.Settings.Default.EngineDefault = "https://www.google.nl/";
                FireBrowser_Extreme.Properties.Settings.Default.Engine = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Script_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (Script.Checked == true)
            {
                FireBrowser_Extreme.Properties.Settings.Default.Scripts = true;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
               
                label5.Text = "Scripts - enabled";
            }
            else
            {
                FireBrowser_Extreme.Properties.Settings.Default.Scripts = false;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
           
                label5.Text = "Scripts - off";
            }
        }

        private void Autofill_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (Autofill.Checked == true)
            {
                FireBrowser_Extreme.Properties.Settings.Default.Autofill = true;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
             
                label7.Text = "Autofill - enabled";
            }
            else
            {
                FireBrowser_Extreme.Properties.Settings.Default.Autofill = false;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
                
                label7.Text = "Autofill - off";
            }
        }

        private void tools_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (tools.Checked == true)
            {
                FireBrowser_Extreme.Properties.Settings.Default.dev = true;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
                label9.Text = "Devtools - enabled";
            }
            else
            {
                FireBrowser_Extreme.Properties.Settings.Default.dev = false;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
                label9.Text = "Devtools - off";
            }
        }

        private void lockswicht_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if(lockswicht.Checked == true)
            {
                FireBrowser_Extreme.Properties.Settings.Default.ispasswordProtected = true;
                FireBrowser_Extreme.Properties.Settings.Default.passwordBrowser = psspass.Text.ToString();
                FireBrowser_Extreme.Properties.Settings.Default.Save();             
            }
            else
            {
                FireBrowser_Extreme.Properties.Settings.Default.ispasswordProtected = false;
                FireBrowser_Extreme.Properties.Settings.Default.Save();
            }
        }

        private void savepss_Click(object sender, EventArgs e)
        {
            FireBrowser_Extreme.Properties.Settings.Default.passwordBrowser = psspass.Text.ToString();
            FireBrowser_Extreme.Properties.Settings.Default.Save();
        }

        private void saveusmr_Click(object sender, EventArgs e)
        {
            FireBrowser_Extreme.Properties.Settings.Default.user = usrm.Text.ToString();
            FireBrowser_Extreme.Properties.Settings.Default.Save();
        }

        private void Update_Click(object sender, EventArgs e)
        {
          
        }

        private void rfPage_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
