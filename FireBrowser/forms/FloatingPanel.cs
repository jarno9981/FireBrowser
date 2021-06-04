using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireBrowser.forms
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
    }
}
