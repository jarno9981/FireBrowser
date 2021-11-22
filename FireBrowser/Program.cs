using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireTabs;
using System.Threading;
using Microsoft.Win32;
using System.IO;
using System.Diagnostics;
using FireBrowser;

namespace FireBrowser
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            #region file
            if (File.Exists("SecureShellFireBrowser.exe"))
            {
                if (FireBrowser.Properties.Settings.Default.ShellExeFile == true)
                {
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    startInfo.FileName = "SecureShellFireBrowser.exe";

                    for (int i = 0; i <= 0; i++)
                    {
                        startInfo.Arguments = "/C dbset 1 = " + i.ToString();
                        Process.Start(startInfo);
                        Thread.Sleep(3);
                    }
                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please re-install app misssing SecureShellFireBrowser", "Info");
            }
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WebContainer container = new WebContainer();

            // license system

            try
            {
                GumroadLicensing.Licensing.Validate("FireBrowser-Licenser", "7zYHRRNSS_vZ7m3N-7wmznsFwbLVGIVc7tNyei-O5uE", "wzjeL");
                FireBrowser.Properties.Settings.Default.limited = false;
                FireBrowser.Properties.Settings.Default.Password = "";
                FireBrowser.Properties.Settings.Default.Save();

            }
            catch (Exception)
            {
                MessageBox.Show("Some Funtions Are Disabled when you license it they will enable", "Not Licensed");
                FireBrowser.Properties.Settings.Default.limited = true;
                FireBrowser.Properties.Settings.Default.Password = "";
                FireBrowser.Properties.Settings.Default.Save();
            }

            // Add the initial Tab
            container.Tabs.Add(
                // Our First Tab created by default in the Application will have as content the Form1
                new FireTitleTab(container)
                {
                    Content = new BrowserWindow
                    {
                        Text = "Fire Browser"
                    }
                }
            );





            // Set initial tab the first one
            container.SelectedTabIndex = 0;

            // Create tabs and start application
            FireTitleApplicationContext applicationContext = new FireTitleApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}

