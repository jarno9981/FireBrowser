using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireBrowser
{
    public partial class ByPass : Form
    {
        public ByPass()
        {
            InitializeComponent();
            pass.Enabled = false;
            textBox1.UseSystemPasswordChar = true;
            textBox1.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == FireBrowser.Properties.Settings.Default.AdminPass)
            {
                pass.Enabled = true;

            }
            else
            {
                pass.Enabled = false;
            }
        }

        private void pass_Click(object sender, EventArgs e)
        {
            File.Create("Setup.ini");
            Application.Restart();
        }
    }
}
