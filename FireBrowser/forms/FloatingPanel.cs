using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kimtoo;

namespace FireBrowser.forms
{
    public partial class FloatingPanel : Form
    {
        public FloatingPanel()
        {
            InitializeComponent();
        }



        private void OpenSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            FireBrowser.forms.Settings settings = new FireBrowser.forms.Settings();
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
            Kimtoo.Backdrop.Show(new InfoBuild());
            this.Close();
        }

        Bitmap image = new Bitmap(@"Images\\image.png");
        private void FloatingPanel_Load(object sender, EventArgs e)
        {
            label1.Text = "User: " + FireBrowser.Properties.Settings.Default.user;
            bunifuPictureBox1.Image = image;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
