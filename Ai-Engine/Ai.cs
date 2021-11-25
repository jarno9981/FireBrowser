using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ai_Engine
{
    public partial class Ai : Form
    {
        public Ai()
        {
            InitializeComponent();
        }

        private void Ai_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            this.Visible = false;
            this.Hide();
        }
    }
}
