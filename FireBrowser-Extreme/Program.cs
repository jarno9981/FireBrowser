using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireTabs;
using System.Threading;
using Microsoft.Win32;
using System.IO;

namespace FireBrowser_Extreme
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WebContainer container = new WebContainer();

            // Add the initial Tab
            container.Tabs.Add(
                // Our First Tab created by default in the Application will have as content the Form1
                new FireTitleTab(container)
                {
                    Content = new Browser
                    {
                        Text = "Fire Browser"
                    }
                }
            );

            FireBrowser_Extreme.Security.ShellGaurd shellgaurd = new FireBrowser_Extreme.Security.ShellGaurd();
            shellgaurd.Show();

            // Set initial tab the first one
            container.SelectedTabIndex = 0;

            // Create tabs and start application
            FireTitleApplicationContext applicationContext = new FireTitleApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
