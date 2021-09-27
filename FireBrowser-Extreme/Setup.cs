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
using System.Diagnostics;
using System.Threading;

namespace FireBrowser_Extreme
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            gg.Checked = false;
            SaveOwb.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Costum.Checked == true)
            {
                SaveOwb.Enabled = true;
            }
            else
            {
                SaveOwb.Enabled = false;
            }
            if (gg.Checked == false)
            {
                Costum.Checked = true;
            }
            else if (Costum.Checked == false)
            {
                gg.Checked = true;
            }  
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            FireBrowser_Extreme.Properties.Settings.Default.check = false;
           
            if (File.Exists("Setup.ini"))
            {
                this.Close();
                return;
            }
            else
            {
                File.Create("Setup.ini");

                FireBrowser_Extreme.Properties.Settings.Default.user = usr.Text.ToString();
                FireBrowser_Extreme.Properties.Settings.Default.Save();


                if (agr.Checked == true)
                {                  
                    FireBrowser_Extreme.Properties.Settings.Default.Accept = true;
                    FireBrowser_Extreme.Properties.Settings.Default.Save();
                }
                else
                {
                    FireBrowser_Extreme.Properties.Settings.Default.Accept = false;
                    FireBrowser_Extreme.Properties.Settings.Default.Save();
                }
                if (gg.Checked == true)
                {
                    FireBrowser_Extreme.Properties.Settings.Default.EngineDefault = "https://www.google.nl/";
                    FireBrowser_Extreme.Properties.Settings.Default.Engine = true;
                    FireBrowser_Extreme.Properties.Settings.Default.Save();
                }
                else if (Costum.Checked == true)
                {
                    FireBrowser_Extreme.Properties.Settings.Default.EngineDefault = SaveOwb.Text.ToString();
                    FireBrowser_Extreme.Properties.Settings.Default.Engine = false;
                    FireBrowser_Extreme.Properties.Settings.Default.Save();
                }

                FireBrowser_Extreme.Properties.Settings.Default.Save();
                this.Close();
            }
            Thread.Sleep(100);
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
           
        }

        private void Next_Click(object sender, EventArgs e)
        {
            tab.SelectTab("tabPage2");
        }
    }
}
