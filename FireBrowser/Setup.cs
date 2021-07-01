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

namespace FireBrowser
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            FireBrowser.Properties.Settings.Default.check = false;
            string result = Path.GetTempPath();
            if (File.Exists(result + "Setup.ini"))
            {
                this.Close();
                return;
            }
            else
            {      
                File.Create(result + "Setup.ini");
               
                if (gg.Checked == true)
                {
                    FireBrowser.Properties.Settings.Default.EngineDefault = "https://www.google.nl/";
                    FireBrowser.Properties.Settings.Default.Engine = true;
                    FireBrowser.Properties.Settings.Default.Save();
                }
                else if(Costum.Checked == true)
                {
                    FireBrowser.Properties.Settings.Default.EngineDefault = SaveOwb.Text.ToString();
                    FireBrowser.Properties.Settings.Default.Engine = false;
                    FireBrowser.Properties.Settings.Default.Save();
                }
             
                FireBrowser.Properties.Settings.Default.Save();
                this.Close();    
            }
            Thread.Sleep(100);
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

    }
}
