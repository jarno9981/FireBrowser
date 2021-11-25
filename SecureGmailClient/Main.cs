using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureGmailClient
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void Main_Load(object sender, EventArgs e)
        {
            newWeb.CreationProperties = new Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties
            {
                BrowserExecutableFolder = @"FireBrowserWebView",
                UserDataFolder = @"FireBrowserWebView",
                Language = "NL-nl"
            };

        }

        string originalUserAgent = "";
        private void newWeb_NavigationStarting(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs e)
        {
            if (new Uri(e.Uri).Host.Contains("accounts.google.com"))
            {
                if (newWeb.CoreWebView2 != null)
                {
                    var settings = newWeb.CoreWebView2.Settings;
                    if (settings.UserAgent != "Chrome")
                        originalUserAgent = settings.UserAgent;

                    settings.UserAgent = "Chrome";
                }
            }
            else
            {
                if (newWeb.CoreWebView2 != null)
                {
                    var settings = newWeb.CoreWebView2.Settings;
                    if (settings.UserAgent == "Chrome")
                        settings.UserAgent = originalUserAgent;
                }
            }
        }

        private void newWeb_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (!e.IsSuccess)
            {

                MessageBox.Show($"WebView2 creation failed with exception = {e.InitializationException}");
                
                return;
            }

            newWeb.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            newWeb.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");


            this.newWeb.CoreWebView2.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.Image);
        }
    }
}
