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
            string result = Path.GetTempPath();
            if (File.Exists(result + "Setup.ini"))
            {
                this.Close();
                return;
            }
            else
            {
                File.Create(result + "Setup.ini");
                this.Close();
               
            }
            Thread.Sleep(100);
            Application.Exit();
        }
    }
}
