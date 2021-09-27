using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireBrowser_Extreme.forms
{
    public partial class FloatingPanel : Form
    {
        public FloatingPanel()
        {
            InitializeComponent();
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            forms.Settings settings = new forms.Settings();
            settings.Show();
        }

        private void TuneAudio_Click(object sender, EventArgs e)
        {
            forms.AudioTuner tuner = new forms.AudioTuner();
            tuner.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forms.BrowserTaskMan task = new forms.BrowserTaskMan();
            task.Show();
            this.Close();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            forms.Help help = new forms.Help();
            help.Show();
            this.Close();
        }

        private void Build_Click(object sender, EventArgs e)
        {
            forms.InfoBuild build = new forms.InfoBuild();
            build.Show();
            this.Close();
        }

        private void FloatingPanel_Load(object sender, EventArgs e)
        {
            label1.Text = "User: " + FireBrowser_Extreme.Properties.Settings.Default.user;
        }
    }
}
