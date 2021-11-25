using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireTabs;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Win32;
using System.Linq;
using Microsoft.Web.WebView2.Wpf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using Win32Interop.Enums;
using System.Text;
using System.Diagnostics;
using System.Net.Sockets;
using FireBrowser.Properties;
using FireBrowser.Converters;
using System.Net.Http;
using System.Security.Cryptography;
using Newtonsoft.Json;

namespace FireBrowser
{
    public partial class BrowserWindow : Form
    {
        #region googleapi
        const string clientID = "372651526417-bsdc7vmal1mckv5ug059jbekf6k4d10p.apps.googleusercontent.com";
        const string clientSecret = "AIzaSyBJ1bqb7DXlfLgSzygeerR_xny0PlCbGCY";
        const string authorizationEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";
        const string tokenEndpoint = "https://www.googleapis.com/oauth2/v4/token";
        const string userInfoEndpoint = "https://www.googleapis.com/oauth2/v3/userinfo";

       


        #endregion

        private bool faviconLoaded;
     
        private void imagesbuttons()
        {
            btnSettings.Image = settings;
            btnBack.Image = backim;
            btnForward.Image = forwardim;
            btnRefresh.Image = refreshim;
            pictureBox1.Image = box1im;
        }

        Bitmap settings = new Bitmap(@"Images\\Buttons\\settings.png");
        Bitmap backim = new Bitmap(@"Images\\Buttons\\back.png");
        Bitmap forwardim = new Bitmap(@"Images\\Buttons\\forward.png");
        Bitmap refreshim = new Bitmap(@"Images\\Buttons\\refresh.png");
        Bitmap box1im = new Bitmap(@"Images\\Buttons\\pnl.png");

        IOptimize optimize = new IOptimize();
        DownloadI download = new DownloadI();
        public BrowserWindow()
        {
            download.GetHashCode();
            optimize.GetType();
            InitializeComponent();
            RunningBackgroundThread();
            imagesbuttons();

         

            if (FireBrowser.Properties.Settings.Default.falseUnlock == false)
            {
                FireBrowser.Properties.Settings.Default.falseUnlock = true;
                FireBrowser.Properties.Settings.Default.Save();
            }
            else
            {
                return;
            }

            quicksearch.Visible = false;
            quicksearch.Enabled = true;

           
        }

        private bool fullScreen = false;

        [DefaultValue(false)]
        public bool FullScreen
        {

            get { return fullScreen; }
            set
            {
                fullScreen = value;
                if (value)
                {
                  panel1.Visible = false;
                }
                else
                {
                    panel1.Visible = true;
                }
            }
        }


        protected FireTitle ParentTabs
        {
            get
            {
                return (ParentForm as FireTitle);
            }
        }

        #region buttons_updaeaddres

    

        static void Delay()
        {
            return;
        }

        static void RunningBackgroundThread()
        {
            Thread background = new Thread(Delay);
            background.IsBackground = true;
            background.Start();
        }         

        private void settingsmenu()
        {
            forms.FloatingPanel panel = new forms.FloatingPanel();
            panel.Show();
        }

        private void refresh()
        {
            newWeb.CoreWebView2.Reload();
        }

        private void back()
        {
            if (newWeb.CoreWebView2.CanGoBack)
            {
                newWeb.CoreWebView2.GoBack();
            }
        }

        private void forward()
        {
            if (newWeb.CoreWebView2.CanGoForward)
            {
                newWeb.CoreWebView2.GoForward();
            }
        }

        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            txtUrl.Text = uri;
            newWeb.CoreWebView2.PostWebMessageAsString(uri);
        }
        private void UpdateTitleWithEvent(string message)
        {
            string currentDocumentTitle = this.newWeb?.CoreWebView2?.DocumentTitle ?? "Uninitialized";
            this.Text = currentDocumentTitle + " " + message + "";
        }

        #endregion

        #region initilize

        private void newWeb_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (!e.IsSuccess)
            {

                MessageBox.Show($"WebView2 creation failed with exception = {e.InitializationException}");
                UpdateTitleWithEvent("failed");
                return;
            }

           

            newWeb.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            newWeb.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");

            if (FireBrowser.Properties.Settings.Default.Autofill == true)
            {
                newWeb.CoreWebView2.Settings.IsPasswordAutosaveEnabled = true;
                newWeb.CoreWebView2.Settings.IsGeneralAutofillEnabled = true;
            }
            else
            {
                newWeb.CoreWebView2.Settings.IsPasswordAutosaveEnabled = false;
                newWeb.CoreWebView2.Settings.IsGeneralAutofillEnabled = false;
            }

            if (FireBrowser.Properties.Settings.Default.Scripts == true)
            {
                newWeb.CoreWebView2.Settings.IsScriptEnabled = true;
            }
            else
            {
                newWeb.CoreWebView2.Settings.IsScriptEnabled = false;
            }


            this.newWeb.CoreWebView2.WebResourceRequested += CoreWebView2WebResourceRequest_request;
            this.newWeb.CoreWebView2.SourceChanged += CoreWebView_SourceChanged;
            this.newWeb.CoreWebView2.HistoryChanged += CoreWebView2_HistoryChanged;
            this.newWeb.CoreWebView2.DocumentTitleChanged += CoreWebView_DocumentTitleChanged;
            newWeb.CoreWebView2.Settings.IsBuiltInErrorPageEnabled = false;
            this.newWeb.CoreWebView2.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.Image);
            UpdateTitleWithEvent("");
        }

        private void CoreWebView_DocumentTitleChanged(object sender, object e)
        {
            UpdateTitleWithEvent("");
        }
            
        private void CoreWebView2_HistoryChanged(object sender, object e)
        {
            UpdateTitleWithEvent("");
        }

        private void CoreWebView2WebResourceRequest_request(object sender, CoreWebView2WebResourceRequestedEventArgs e)
        {
           
            // Create response object for custom response and set it
            var environment = newWeb.CoreWebView2.Environment;

        }

        private void CoreWebView_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            UpdateTitleWithEvent("");
        }

        #endregion


        private readonly HttpClient _httpClient = new HttpClient();

        #region asyncbrowserwindow
        private async void BrowserWindow_Load(object sender, EventArgs e)
        {
            newWeb.CreationProperties = new Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties
            {
                BrowserExecutableFolder = @"FireBrowserWebView",
                UserDataFolder = @"FireBrowserWebView",
                Language = "NL-nl"
            };

  

            txtUrl.PlaceholderText = FireBrowser.Properties.Settings.Default.Placeholder;
            txtUrl.ForeColor = FireBrowser.Properties.Settings.Default.ForeColor;

            newWeb.Source = new Uri(FireBrowser.Properties.Settings.Default.EngineDefault);
        }
        #endregion

       

        #region done/start

        string originalUserAgent = "";

        private void newWeb_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {

            bunifuLoader1.BringToFront();
            bunifuLoader1.Visible = true;

            ThreadPool.SetMinThreads(2, 2);

            btnRefresh.Enabled = false;

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
            // Note: Oversimplified test. Need to support idn, case-insensitivity, etc.
            certifcate();
         
          
        }

        Bitmap iconleft = new Bitmap(@"Images\\textboxicon\\left.png");
        private void newWeb_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            CheckYesNo();
            if(FireBrowser.Properties.Settings.Default.safe == true)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
            bunifuLoader1.SendToBack();
            bunifuLoader1.Visible = false;
            IconWeb();
         
            checkListBools();
            newWeb.CoreWebView2.NewWindowRequested += CoreWebView2_NewWindowRequested;
            btnRefresh.Enabled = true;
            UpdateTitleWithEvent("");
            if(txtUrl.IconLeft == iconleft)
            {
                return;
            }
            {
                if (txtUrl.Text.Contains("https"))
                {
                    txtUrl.IconLeft = iconleft;
                }
                else
                {
                    txtUrl.IconLeft = FireBrowser.Properties.Resources.delete_shield_48px_MSI;
                }
            }

            youtubeBoost();

            newWeb.CoreWebView2.ContainsFullScreenElementChanged += (obj, args) =>
            {
                this.FullScreen = newWeb.CoreWebView2.ContainsFullScreenElement;
            };

            if (txtUrl.Text.Contains("youtube"))
            {

            }
            else
            {
                if (txtUrl.Text.Contains("brave"))
                {

                }
                else
                {
                    if (txtUrl.Text.Contains("google"))
                    {

                    }
                    else
                    {
                        if (e.IsSuccess == false)
                        {
                            Thread.Sleep(100);
                            newWeb.CoreWebView2.Navigate(error);

                        }

                    }
                }
            }
        }

        #endregion

        #region alart_small
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void youtubeBoost()
        {
            if (txtUrl.Text.Contains("www.youtube.com"))
            {
                snack.Show(this, "Audio Boost On");
            }
        }

        private void CoreWebView2_NewWindowRequested(object sender, CoreWebView2NewWindowRequestedEventArgs e)
        {
            if (FireBrowser.Properties.Settings.Default.PopUp == "Modern")
            {
                e.NewWindow = (CoreWebView2)sender;
                newWeb.CoreWebView2.Resume();
            }
            else if (FireBrowser.Properties.Settings.Default.PopUp == "Blocked")
            {
                e.Handled = true;

                newWeb.CoreWebView2.Resume();
            }
            else if (FireBrowser.Properties.Settings.Default.PopUp == "Classic")
            {
                e.Handled = false;
                newWeb.CoreWebView2.Resume();
            }
        }

        private void newWeb_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            newWeb.CoreWebView2.Settings.IsBuiltInErrorPageEnabled = false;
            UpdateTitleWithEvent("");
            Texter();
        }


        public class CoreWebView2CompositionController2
        {
            public UInt32 SystemCursorId { get; }
        }
        #endregion

        #region checkbools
        private void checkListBools()
        {
            if (FireBrowser.Properties.Settings.Default.dev == true)
            {
                newWeb.CoreWebView2.Settings.AreDevToolsEnabled = true;
            }
            else
            {
                newWeb.CoreWebView2.Settings.AreDevToolsEnabled = false;
            }

            if (FireBrowser.Properties.Settings.Default.Scripts == true)
            {
                newWeb.CoreWebView2.Settings.IsScriptEnabled = true;
            }
            else
            {
                newWeb.CoreWebView2.Settings.IsScriptEnabled = false;
            }
            if (FireBrowser.Properties.Settings.Default.Autofill == true)
            {
                newWeb.CoreWebView2.Settings.IsPasswordAutosaveEnabled = true;
            }
            else
            {
                newWeb.CoreWebView2.Settings.IsPasswordAutosaveEnabled = false;
            }
        }
        #endregion

        #region icontabs
        private void IconWeb()
        {

            Invoke(new Action(() => txtUrl.Text.ToString()));

            if (txtUrl.Text.Contains("https") && !faviconLoaded)
            {

                Uri uri = new Uri(txtUrl.Text + newWeb.Source.AbsoluteUri);

                if (uri.Scheme == "https")
                {


                    try
                    {
                        HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(uri.Scheme + "://" + uri.Host + "/favicon.ico");
                        webRequest.UserAgent = "0Host";
                        webRequest.KeepAlive = false;
                        webRequest.AllowAutoRedirect = true;

                        WebResponse response = webRequest.GetResponse();
                        Stream stream = response.GetResponseStream();


                        if (stream != null)
                        {
                            byte[] buffer = new byte[2056];

                            using (MemoryStream ms = new MemoryStream())
                            {
                                int read;

                                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                                    ms.Write(buffer, 0, read);

                                ms.Seek(0, SeekOrigin.Begin);

                                Invoke(new Action(() =>
                                {
                                    Icon = new Icon(ms);

                                    ParentTabs.UpdateThumbnailPreviewIcon(ParentTabs.Tabs.Single(t => t.Content == this));
                                    ParentTabs.RedrawTabs();
                                }));
                            }
                        }
                    }

                    catch
                    {
                        Invoke(new Action(() => Icon = Resources.DefaultIcon));
                    }
                }


                faviconLoaded = false;
            }
        }

        #endregion

        #region textboxchecks 
        public void searcherDex()
        {
            if (txtUrl.Text.Contains("http://"))
            {
                newWeb.CoreWebView2.Navigate(txtUrl.Text);
            }
            if (txtUrl.Text.Contains("https://"))
            {
                newWeb.CoreWebView2.Navigate(txtUrl.Text);

            }
            else if (txtUrl.Text.Contains("www"))
            {
                txtUrl.Text = "https://" + txtUrl.Text;
                newWeb.CoreWebView2.Navigate(txtUrl.Text.Trim());
            }
            else
            {
                if (txtUrl.Text.Contains(".com"))
                {
                    txtUrl.Text = "https://www." + txtUrl.Text;
                    newWeb.CoreWebView2.Navigate(txtUrl.Text.Trim());
                }
                if (txtUrl.Text.Contains(".nl"))
                {
                    txtUrl.Text = "https://www." + txtUrl.Text;
                    newWeb.CoreWebView2.Navigate(txtUrl.Text.Trim());
                }
                if (txtUrl.Text.Contains(".uk"))
                {
                    txtUrl.Text = "https://www." + txtUrl.Text;
                    newWeb.CoreWebView2.Navigate(txtUrl.Text.Trim());
                }
                if (txtUrl.Text.Contains(".us"))
                {
                    txtUrl.Text = "https://www." + txtUrl.Text;
                    newWeb.CoreWebView2.Navigate(txtUrl.Text.Trim());
                }
                if (txtUrl.Text.Contains(".com.tr"))
                {
                    txtUrl.Text = "https://www." + txtUrl.Text;
                    newWeb.CoreWebView2.Navigate(txtUrl.Text.Trim());
                }
                if (txtUrl.Text.Contains(".org"))
                {
                    txtUrl.Text = "https://www." + txtUrl.Text;
                    newWeb.CoreWebView2.Navigate(txtUrl.Text.Trim());
                }
            }
        }

        private void txtSet()
        {
            if (txtUrl.Text.Contains("settings"))
            {
                FireBrowser.forms.FloatingPanel panel = new FireBrowser.forms.FloatingPanel();
                panel.Show();
            }
            if (txtUrl.Text.Contains("contact"))
            {
                FireBrowser.forms.Contact ctn = new FireBrowser.forms.Contact();
                ctn.Show();
            }
            if (txtUrl.Text.Contains("lock"))
            {
                if (FireBrowser.Properties.Settings.Default.ispasswordProtected == true)
                {
                    Kimtoo.Backdrop.Show(new LockScreen());
                }
                else
                {
                    return;
                }
            }

            if (txtUrl.Text.Contains("set:quick"))
            {
                FireBrowser.forms.Settings settings = new FireBrowser.forms.Settings();
                settings.Show();
            }
            if (txtUrl.Text.Contains("helps"))
            {
                FireBrowser.forms.Help help = new FireBrowser.forms.Help();
                help.Show();
            }
            if (txtUrl.Text.Contains("homes"))
            {
                newWeb.CoreWebView2.Navigate(FireBrowser.Properties.Settings.Default.EngineDefault);
            }
            if (txtUrl.Text.Contains("infoApp"))
            {
                FireBrowser.forms.InfoBuild build = new FireBrowser.forms.InfoBuild();
                build.Show();
            }
        }

        #endregion

        #region tests
        private void Texter()
        {
            this.txtUrl.Text = this.newWeb.Source.AbsoluteUri;
        }

        private void certifcate()
        {
            if (txtUrl.Text.Contains("https"))
            {


            }
            else
            {

            }
        }

        private void CheckYesNo()
        {
            if (File.Exists("Setup.ini"))
            {
                return;
            }
            else
            {
                this.Hide();
                Kimtoo.Backdrop.Show(new Setup());
            }
        }
        #endregion

        string error = Application.StartupPath + "/" + @"ErrorPage/index.html";



        #region quicks



        private void quicks()
        {
            if (txtUrl.Text == "youtube/")
            {
                txtUrl.Text = "https://www.youtube.com/results?search_query=";
                keyword.Focus();
                quicksearch.Visible = true;
                quicksearch.Enabled = true;
                keyword.PlaceholderText = "Search Keyword Youtube Here And Then Enter";
                keyword.Text = "";
            }
            if (txtUrl.Text == "bol/")
            {
                txtUrl.Text = "https://www.bol.com/nl/nl/s/?searchtext=";
                keyword.Focus();
                quicksearch.Visible = true;
                quicksearch.Enabled = true;
                keyword.PlaceholderText = "Search Keyword Bol.com Here And Then Enter";
                keyword.Text = "";
            }
            if (txtUrl.Text == "bva/")
            {
                txtUrl.Text = "https://www.bva-auctions.com/nl/search?searchQuery=";
                keyword.Focus();
                quicksearch.Visible = true;
                quicksearch.Enabled = true;
                keyword.PlaceholderText = "Search Keyword bva.com Here And Then Enter";
                keyword.Text = "";
            }
            if (txtUrl.Text == "google/")
            {
                txtUrl.Text = "https://www.google.com/search?q=";
                keyword.Focus();
                quicksearch.Visible = true;
                quicksearch.Enabled = true;
                keyword.PlaceholderText = "Search Keyword google.com Here And Then Enter";
                keyword.Text = "";
            }
            if (txtUrl.Text == "amazon/")
            {
                txtUrl.Text = "https://www.amazon.com/s?k=";
                keyword.Focus();
                quicksearch.Visible = true;
                quicksearch.Enabled = true;
                keyword.PlaceholderText = "Search Keyword amazon.com Here And Then Enter";
                keyword.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            quicksearch.Enabled = false;
            quicksearch.Visible = false;
        }

        private void keyword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && keyword.Text.Trim().Length > 0)
            {
                txtUrl.Text = txtUrl.Text + keyword.Text;
                newWeb.CoreWebView2.Navigate(txtUrl.Text);
                quicksearch.Visible = false;
                quicksearch.Enabled = false;
            }
        }

        #endregion

        #region keyup
        private void txtUrl_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtUrl.Text.Trim().Length > 0)
            {
                if (txtUrl.Text.Contains("f:"))
                {
                    txtSet();
                }
                else
                {
                    if (txtUrl.Text.Contains("."))
                    {
                        searcherDex();
                    }
                    else
                    {
                        if (FireBrowser.Properties.Settings.Default.Engine == true)
                        {
                            newWeb.CoreWebView2.Navigate("https://www.google.nl/search?client=opera&q=" + txtUrl.Text.Trim().Replace(" ", "+") + "&sourceid=opera&ie=UTF-8&oe=UTF-8");
                        }
                        else if (FireBrowser.Properties.Settings.Default.Engine == false)
                        {
                            newWeb.CoreWebView2.Navigate(FireBrowser.Properties.Settings.Default.EngineDefault + "search?q=" + txtUrl.Text.Trim().Replace(" ", "+"));
                        }
                    }
                }
            }
        }
        #endregion


        private void txtUrl_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
                txtUrl.Text = files.First(); //select the first one  
            Thread.Sleep(200);
            newWeb.CoreWebView2.Navigate(txtUrl.Text);
        }

      

        private void newWeb_Click(object sender, EventArgs e)
        {

        }

        private void txtUrl_TextChange_1(object sender, EventArgs e)
        {
            quicks();
        }

        private void txtUrl_DragDrop_1(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
                txtUrl.Text = files.First(); //select the first one  
            Thread.Sleep(200);
            newWeb.CoreWebView2.Navigate(txtUrl.Text);
            if (txtUrl.Text.Contains("file"))
            {
                txtUrl.IconLeft = FireBrowser.Properties.Resources.file_48px;
            }
        }

        private void txtUrl_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }


        private void Forbidden()
        {
            contentcheck();

            if (contentcheck() == true)
            {
                txtUrl.Text = FireBrowser.Properties.Settings.Default.EngineDefault.ToString();
                newWeb.CoreWebView2.Navigate(txtUrl.Text);        
            }
        }

        private bool contentcheck()
        {
            List<string> FilteredWords = new List<string>()
          {

                "sex",
            "porn",
            "dildo",
            "hoer",
            "Hoer",
            "Kut",
            "kut",
            "piemel",
            "guns",
            "gun",                  //list of censored words
            "ass",
            "tieten",
            "fake-s-e-x",
            "s-e-x",
             "2 girls 1 cup",
             "2 girls one cup",
             "bluewafel",
             "blue-wafel",
             "Blue-wafel",
             "Bluewafel",
             "Bleuwafel",
             "2g1c",
             "4r5e",
             "5h1t",
             "5hit",
             "8===D",
             "8==D",
             "8=D",
             "a$$",
             "a$$hole",
             "a_s_s",
             "a2m",
             "a55",
             "a55hole",
             "acrotomophilia",
             "aeolus",
             "ahole",
             "alabama hot pocket",
             "alaskan pipeline",
             "anal",
             "anal impaler",
             "anal leakage",
             "analprobe",
             "anilingus",
             "angrydragon",
             "angry dragon",
             "anus",
             "apeshit",
             "ar5e",
             "arian",
             "arrse",
             "arse",
             "arses",
             "arsehole",
             "aryan",
             "ass",
             "ass fuck",
             "ass hole",
             "assbag",
             "assbandit",
             "assbang",
             "assbanged",
             "assbanger",
             "assbangs",
             "assbite",
             "assclown",
             "asscock",
             "asscracker",
             "asses",
             "assface",
             "assfaces",
             "assfuck",
             "assfucker",
             "ass-fucker",
             "assfukka",
             "assgoblin",
             "assh0le",
             "asshat",
             "ass-hat",
             "asshead",
             "assho1e",
             "asshole",
             "assholes",
             "asshopper",
             "ass-jabber",
             "assjacker",
             "asslick",
             "asslicker",
             "assmaster",
             "assmonkey",
             "assmucus",
             "assmunch",
             "assmuncher",
             "assnigger",
             "asspirate",
             "ass-pirate",
             "assshit",
             "assshole",
             "asssucker",
             "asswad",
             "asswhole",
             "asswipe",
             "asswipes",
             "auto erotic",
             "autoerotic",
             "axwound",
             "axewound",
             "axe wound",
             "azazel",
             "azz",
             "b!tch",
             "b00bs",
             "b17ch",
             "b1tch",
             "babeland",
             "baby batter",
             "baby juice",
             "ball gag",
             "ball gravy",
             "ball kicking",
             "ball licking",
             "ball sack",
             "ball sucking",
             "ballbag",
             "balls",
             "ballsack",
             "bampot",
             "bang (one's) box",
             "bangbros",
             "bareback",
             "barely legal",
             "barenaked",
             "barf",
             "bastard",
             "bastardo",
             "bastards",
             "bastinado",
             "batty boy",
             "bawdy",
             "bbw",
             "bdsm",
             "beaner",
             "beaners",
             "beardedclam",
             "beastial",
             "beastiality",
             "beatch",
             "beaver",
             "beaver cleaver",
             "beaver lips",
             "beef curtain",
             "beef curtains",
             "beeyotch",
             "bellend",
             "bender",
             "beotch",
             "bescumber",
             "bestial",
             "bestiality",
             "bi+ch",
             "biatch",
             "big black",
             "big breasts",
             "big knockers",
             "big tits",
             "bigtits",
             "bimbo",
             "bimbos",
             "bint",
             "birdlock",
             "bitch",
             "bitch tit",
             "bitchass",
             "bitched",
             "bitcher",
             "bitchers",
             "bitches",
             "bitchin",
             "bitching",
             "bitchtits",
             "bitchy",
             "black cock",
             "blonde action",
             "blonde on blonde action",
             "bloodclaat",
             "bloody",
             "bloody hell",
             "blow job",
             "blow me",
             "blow mud",
             "blow your load",
             "blowjob",
             "blowjobs",
             "blue waffle",
             "blumpkin",
             "bod",
             "bodily",
             "boink",
             "boiolas",
             "bollock",
             "bollocks",
             "bollok",
             "bollox",
             "bondage",
             "boned",
             "boner",
             "boners",
             "bong",
             "boob",
             "boobies",
             "boobs",
             "booby",
             "booger",
             "bookie",
             "boong",
             "booobs",
             "boooobs",
             "booooobs",
             "booooooobs",
             "bootee",
             "bootie",
             "booty",
             "booty call",
             "booze",
             "boozer",
             "boozy",
             "bosom",
             "bosomy",
             "breasts",
             "breeder",
             "brotherfucker",
             "brown showers",
             "brunette action",
             "buceta",
             "bugger",
             "bukkake",
             "bull shit",
             "bulldyke",
             "bullet vibe",
             "bullshit",
             "bullshits",
             "bullshitted",
             "bullturds",
             "bum",
             "bum boy",
             "bumblefuck",
             "bumclat",
             "bummer",
             "buncombe",
             "bung",
             "bung hole",
             "bunghole",
             "bunny fucker",
             "bust a load",
             "busty",
             "butt",
             "butt fuck",
             "butt plug",
             "buttcheeks",
             "buttfuck",
             "buttfucka",
             "buttfucker",
             "butthole",
             "buttmuch",
             "buttmunch",
             "butt-pirate",
             "buttplug",
             "c.0.c.k",
             "c.o.c.k.",
             "c.u.n.t",
             "c0ck",
             "c-0-c-k",
             "c0cksucker",
             "caca",
             "cacafuego",
             "cahone",
             "camel toe",
             "cameltoe",
             "camgirl",
             "camslut",
             "camwhore",
             "carpet muncher",
             "carpetmuncher",
             "cawk",
             "cervix",
             "chesticle",
             "chi-chi man",
             "chick with a dick",
             "child-fucker",
             "chinc",
             "chincs",
             "chink",
             "chinky",
             "choad",
             "choade",
             "choc ice",
             "chocolate rosebuds",
             "chode",
              "chodes",
             "chota bags",
             "cipa",
             "circlejerk",
             "cl1t",
             "cleveland steamer",
             "climax",
             "clit",
             "clit licker",
             "clitface",
             "clitfuck",
             "clitoris",
             "clits",
             "clitty",
             "clitty litter",
             "clover clamps",
             "clunge",
             "clusterfuck",
             "cnut",
             "cocain",
             "cocaine",
             "coccydynia",
             "cock",
             "c-o-c-k",
             "cock pocket",
             "cock snot",
             "cock sucker",
             "cockass",
             "cockbite",
             "cockblock",
             "cockburger",
             "cockeye",
             "cockface",
             "cockfucker",
             "cockhead",
             "cockholster",
             "cockjockey",
             "cockknocker",
             "cockknoker",
             "cocklump",
             "cockmaster",
             "cockmongler",
             "cockmongruel",
             "cockmonkey",
             "cockmunch",
             "cockmuncher",
             "cocknose",
             "cocknugget",
             "cocks",
             "cockshit",
             "cocksmith",
             "cocksmoke",
             "cocksmoker",
             "cocksniffer",
             "cocksuck",
             "cocksucked",
             "cocksucker",
             "cock-sucker",
             "cocksuckers",
             "cocksucking",
             "cocksucks",
             "cocksuka",
             "cocksukka",
             "cockwaffle",
             "coffin dodger",
             "coital",
             "cok",
             "cokmuncher",
             "coksucka",
             "commie",
             "condom",
             "coochie",
             "coochy",
             "coon",
             "coonnass",
             "coons",
             "cooter",
             "cop some wood",
             "coprolagnia",
             "coprophilia",
             "corksucker",
             "cornhole",
             "corp whore",
             "corpulent",
             "cox",
             "crabs",
             "crack",
             "cracker",
             "crackwhore",
             "crap",
             "crappy",
             "creampie",
             "cretin",
             "crikey",
             "cripple",
             "crotte",
             "cum",
             "cum chugger",
             "cum dumpster",
             "cum freak",
             "cum guzzler",
             "cumbubble",
             "cumdump",
             "cumdumpster",
             "cumguzzler",
             "cumjockey",
             "cummer",
             "cummin",
             "cumming",
             "cums",
             "cumshot",
             "cumshots",
             "cumslut",
             "cumstain",
             "cumtart",
             "cunilingus",
             "cunillingus",
             "cunnie",
             "cunnilingus",
             "cunny",
             "cunt",
             "c-u-n-t",
             "cunt hair",
             "cuntass",
             "cuntbag",
             "cuntface",
             "cunthole",
             "cunthunter",
             "cuntlick",
             "cuntlicker",
             "cuntrag",
             "cunts",
             "cuntsicle",
             "cuntslut",
             "cunt-struck",
             "cus",
             "cut rope",
             "cyalis",
             "cyberfuc",
             "cyberfuck",
             "cyberfucked",
             "cyberfucker",
             "cyberfucking",
             "d0ng",
             "d0uch3",
             "d0uche",
             "d1ck",
             "d1ld0",
             "d1ldo",
             "dago",
             "dagos",
             "dammit",
             "damn",
             "damned",
             "damnit",
             "darkie",
             "darn",
             "date rape",
             "daterape",
             "dawgie-style",
             "deep throat",
             "deepthroat",
             "deggo",
             "dendrophilia",
             "dick",
             "dick head",
             "dick hole",
             "dick shy",
             "dickbag",
             "dickbeaters",
             "dickdipper",
             "dickface",
             "dickflipper",
             "dickfuck",
             "dickfucker",
             "dickhead",
             "dickheads",
             "dickhole",
             "dickish",
             "dick-ish",
             "dickjuice",
             "dickmilk",
             "dickmonger",
             "dickripper",
             "dicks",
             "dicksipper",
             "dickslap",
             "dick-sneeze",
             "dicksucker",
             "dicksucking",
             "dicktickler",
             "dickwad",
             "dickweasel",
             "dickweed",
             "dickwhipper",
             "dickwod",
             "dickzipper",
             "diddle",
             "dike",
             "dildo",
             "dildos",
             "diligaf",
             "dillweed",
             "dimwit",
             "dingle",
             "dingleberries",
             "dingleberry",
             "dink",
             "dinks",
             "dipship",
             "dirsa",
             "dirty",
             "dirty pillows",
             "dirty sanchez",
             "div",
             "dlck",
             "dog style",
             "dog-fucker",
             "doggie style",
             "doggiestyle",
             "doggie-style",
             "doggin",
             "dogging",
             "doggy style",
             "doggystyle",
             "doggy-style",
             "dolcett",
             "domination",
             "dominatrix",
             "dommes",
             "dong",
             "donkey punch",
             "donkeypunch",
             "donkeyribber",
             "doochbag",
             "doofus",
             "dookie",
             "doosh",
             "dopey",
             "double dong",
             "double penetration",
             "doublelift",
             "douch3",
             "douche",
             "douchebag",
             "douchebags",
             "douche-fag",
             "douchewaffle",
             "douchey",
             "dp action",
             "drunk",
             "dry hump",
             "duche",
             "dumass",
             "dumb ass",
             "dumbass",
             "dumbasses",
             "dumbcunt",
             "dumbfuck",
             "dumbshit",
             "dummy",
             "dumshit",
             "dvda",
             "dyke",
             "dykes",
             "eat a dick",
             "eat hair pie",
             "eat my ass",
             "ecchi",
             "ejaculate",
             "ejaculated",
             "ejaculates",
             "ejaculating",
             "ejaculatings",
             "ejaculation",
             "ejakulate",
             "erect",
             "erection",
             "erotic",
             "erotism",
             "escort",
             "essohbee",
             "eunuch",
             "extacy",
             "extasy",
             "f u c k",
             "f u c k e r",
             "f.u.c.k",
             "f_u_c_k",
             "f4nny",
             "facial",
             "fack",
             "fag",
             "fagbag",
             "fagfucker",
             "fagg",
             "fagged",
             "fagging",
             "faggit",
             "faggitt",
             "faggot",
             "faggotcock",
             "faggots",
             "faggs",
             "fagot",
             "fagots",
             "fags",
             "fagtard",
             "faig",
             "faigt",
             "fanny",
             "fannybandit",
             "fannyflaps",
             "fannyfucker",
             "fanyy",
             "fart",
             "fartknocker",
             "fatass",
             "fcuk",
             "fcuker",
             "fcuking",
             "fecal",
             "feck",
             "fecker",
             "feist",
             "felch",
             "felcher",
             "felching",
             "fellate",
             "fellatio",
             "feltch",
             "feltcher",
             "female squirting",
             "femdom",
             "fenian",
             "fice",
             "figging",
             "fingerbang",
             "fingerfuck",
             "fingerfucked",
             "fingerfucker",
             "fingerfuckers",
             "fingerfucking",
             "fingerfucks",
             "fingering",
             "fist fuck",
             "fisted",
             "fistfuck",
             "fistfucked",
             "fistfucker",
             "fistfuckers",
             "fistfuckings",
             "fistfucks",
             "fisting",
             "fisty",
             "flamer",
             "flange",
             "flaps",
             "fleshflute",
             "flog the log",
             "floozy",
             "foad",
             "foah",
             "fondle",
             "foobar",
             "fook",
             "fooker",
             "foot fetish",
             "footjob",
             "foreskin",
             "freex",
             "frenchify",
             "frigg",
             "frigga",
             "frotting",
             "fubar",
             "fuc",
             "fuck",
             "f-u-c-k",
             "fuck buttons",
             "fuck hole",
             "fuck off",
             "fuck puppet",
             "fuck trophy",
             "fuck yo mama",
             "fuck you",
             "fucka",
             "fuckass",
             "fuck-ass",
             "fuckbag",
             "fuck bag",
             "fuck-bitch",
             "fuckboy",
             "fuckbrain",
             "fuckbutt",
             "fuckbutter",
             "fucked",
             "fuckedup",
             "fucked up",
             "fucker",
             "fuckers",
             "fuckersucker",
             "fuckface",
             "fuckhead",
             "fuckheads",
             "fuckhole",
             "fuckin",
             "fucking",
             "fuckings",
             "fuckme",
             "fuck me",
             "fuckmeat",
             "fucknugget",
             "fucknut",
             "fucknutt",
             "fuckoff",
             "fucks",
             "fuckstick",
             "fucktard",
             "fuck-tard",
             "fucktards",
             "fucktart",
             "fucktoy",
             "fucktwat",
             "fuckup",
             "fuckwad",
             "fuckwhit",
             "fuckwit",
             "fuckwitt",
             "fudge packer",
             "fudgepacker",
             "fudge-packer",
             "fuk",
             "fuker",
             "fukker",
             "fukkers",
             "fukkin",
             "fuks",
             "fukwhit",
             "fukwit",
             "fuq",
             "futanari",
             "fux",
             "fux0r",
             "fvck",
             "fxck",
             "gae",
             "gai",
             "gang bang",
             "gangbang",
             "gang-bang",
             "gangbanged",
             "gangbangs",
             "ganja",
             "gash",
             "gassy ass",
             "gay sex",
             "gayass",
             "gaybob",
             "gaydo",
             "gayfuck",
             "gayfuckist",
             "gaylord",
             "gays",
             "gaysex",
             "gaytard",
             "gaywad",
             "gender bender",
             "genitals",
             "gey",
             "gfy",
             "ghay",
             "ghey",
             "giant cock",
             "gigolo",
             "ginger",
             "gippo",
             "girl on",
             "girl on top",
             "girls gone wild",
             "glans",
             "goatcx",
             "goatse",
             "god",
             "god damn",
             "godamn",
             "godamnit",
             "goddam",
             "god-dam",
             "goddammit",
             "goddamn",
             "goddamned",
             "god-damned",
             "goddamnit",
             "godsdamn",
             "gokkun",
             "golden shower",
             "goldenshower",
             "golliwog",
             "gonad",
             "gonads",
             "goo girl",
             "gooch",
             "goodpoop",
             "gook",
             "gooks",
             "goregasm",
             "gringo",
             "grope",
             "group sex",
             "gspot",
             "g-spot",
             "gtfo",
             "guido",
             "guro",
             "h0m0",
             "h0mo",
             "ham flap",
             "hand job",
             "handjob",
             "hard core",
             "hard on",
             "hardcore",
             "hardcoresex",
             "he11",
             "hebe",
             "heeb",
             "hell",
             "hemp",
             "hentai",
             "heroin",
             "herp",
             "herpes",
             "herpy",
             "heshe",
             "he-she",
             "hircismus",
             "hitler",
             "hiv",
             "hoar",
             "hoare",
             "hobag",
             "hoe",
             "hoer",
             "holy shit",
             "hom0",
             "homey",
             "homo",
             "homodumbshit",
             "homoerotic",
             "homoey",
             "honkey",
             "honky",
             "hooch",
             "hookah",
             "hooker",
             "hoor",
             "hootch",
             "hooter",
             "hooters",
             "hore",
             "horniest",
             "horny",
             "hot carl",
             "hot chick",
             "hotsex",
             "how to kill",
             "how to murdep",
             "how to murder",
             "huge fat",
             "hump",
             "humped",
             "humping",
             "hun",
             "hussy",
             "hymen",
             "iap",
             "iberian slap",
             "inbred",
             "incest",
             "injun",
             "intercourse",
             "jack off",
             "jackass",
             "jackasses",
             "jackhole",
             "jackoff",
             "jack-off",
             "jaggi",
             "jagoff"
          };
            foreach (var e in FilteredWords)
            {
                if (txtUrl.Text.Contains(e))
                {
                    return true;

                }
            }
            return false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
                Forbidden();
                 
        }

        private void txtUrl_OnIconLeftClick(object sender, EventArgs e)
        {
            Privacy prv = new Privacy();
            prv.Show();
            
            
        }

        private void bunifuLoader1_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            back();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            forward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsmenu();
        }

        private void newWeb_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
                txtUrl.Text = files.First(); //select the first one  
            Thread.Sleep(200);
            newWeb.CoreWebView2.Navigate(txtUrl.Text);
          
        }

        private void newWeb_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void txtUrl_OnIconRightClick(object sender, EventArgs e)
        {
            
        }
    }
}
