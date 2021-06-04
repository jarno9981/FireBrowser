using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireTabs;
using FireBrowser.Properties;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.Core.Raw;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Win32;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace FireBrowser
{
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
            InitializeAsync();
            panel3.Visible = false;
            _cachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "FireBrowser");
            bunifuPanel1.Visible = false;
        }

        private class NewTabLifespanHandler : ILifeSpanHandler
        {
            private Browser _tab;

            public NewTabLifespanHandler(Browser tab)
            {
                _tab = tab;
            }
        }


        protected FireTitle ParentTabs
        {
            get
            {
                return (ParentForm as FireTitle);
            }
        }

        private bool WebViewIsInstalled()
        {
            string regKey = @"SOFTWARE\WOW6432Node\Microsoft\EdgeUpdate\Clients";
            using (RegistryKey edgeKey = Registry.LocalMachine.OpenSubKey(regKey))
            {
                if (edgeKey != null)
                {
                    string[] productKeys = edgeKey.GetSubKeyNames();
                    if (productKeys.Any())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void web_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (!e.IsSuccess)
            {
                MessageBox.Show($"WebView2 creation failed with exception = {e.InitializationException}");
                UpdateTitleWithEvent("CoreWebView2InitializationCompleted failed");
                return;
            }

            

            this.web.CoreWebView2.SourceChanged += CoreWebView_SourceChanged;
            this.web.CoreWebView2.HistoryChanged += CoreWebView2_HistoryChanged;
            this.web.CoreWebView2.DocumentTitleChanged += CoreWebView_DocumentTitleChanged;
            this.web.CoreWebView2.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.Image);
            UpdateTitleWithEvent("CoreWebView2InitializationCompleted succeeded");
        }


        private void CoreWebView2_HistoryChanged(object sender, object e)
        {
            Task[] tasks = new Task[4];
            tasks[1] = Task.Run(() => {

                UpdateTitleWithEvent("HistoryChanged");
                return 4;
            });
        
        }

        

        private void CoreWebView_DocumentTitleChanged(object sender, object e)
        {          
            Task[] tasks = new Task[6];
            tasks[1] = Task.Run(() => {                
                UpdateTitleWithEvent("SourceChanged");
                return 6;
            });

           
        }

        private void Texter()
        {
            this.txtUrl.Text = this.web.Source.AbsoluteUri;
        }

        private void CoreWebView_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {
            UpdateTitleWithEvent("DocumentTitleChanged");
        }


        private void certifcate()
        {
            if (txtUrl.Text.Contains("https"))
            {
                ValidOrNot.Text = "Valid-Certificate";
                BackTo.Visible = false;
            }
            else
            {
                ValidOrNot.Text = "UnValid-Certificate";
                BackTo.Visible = true;
            }
        }

        private void UpdateTitleWithEvent(string message)
        {
            string currentDocumentTitle = this.web?.CoreWebView2?.DocumentTitle ?? "Uninitialized";
            this.Text = currentDocumentTitle + " " + message + "";          
        }

        private bool faviconLoaded = false;

        private void CheckYesNo()
        {
            string result = Path.GetTempPath();
            if (File.Exists(result + "Setup.ini"))
            {
                return;
                this.Visible = true;
            }
            else
            {
                this.Hide();
                Setup setup = new Setup();
                setup.ShowDialog();
                setup.BringToFront();
            }
           
        }

        private void Forbidden()
        {
            ContentCheck();

            if(ContentCheck() == true)
            {
                bunifuPanel1.Visible = true;
                bunifuPanel1.BringToFront();
                this.Text = "Unsafe";
                UpdateTitleWithEvent("Not Safe");
                UnsafeOrSafeChecker.Start();
                txtUrl.Text = "http://www.NotAllowedHere.local/pass-protected-host";
            }
        }

        private bool ContentCheck()
        {
            List<string> FilteredWords = new List<string>()
          {
 
                "sex",
            "porn",
            "dildo",
            "piemel",
            "guns",
            "gun",                  //list of censored words
            "ass",
            "tieten",
             "2 girls 1 cup",
             "2 girls one cup",
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


        private void web_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            CheckYesNo();
            certifcate();
            IconWeb();
            UpdateTitleWithEvent("");
            if (txtUrl.Text.Contains("https"))
            {
                txtUrl.IconLeft = Properties.Resources.secure_48px;
            }
            else
            {
                txtUrl.IconLeft = Properties.Resources.delete_shield_48px_MSI;
            }
            if (txtUrl.Text.Contains("file:///"))
            {
               iconFile();            
            }
            UnsafeOrSafeChecker.Start();

            if (FireBrowser.Properties.Settings.Default.SafeBrowse == true)
            {
                Forbidden();
                UnsafeOrSafeChecker.Start();
            }
            else if (FireBrowser.Properties.Settings.Default.SafeBrowse == false)
            {
                return;
                UnsafeOrSafeChecker.Stop();
            }
            if (FireBrowser.Properties.Settings.Default.History == true)
            {
                AddHistory();
              
            }
            else
            {
                return;
            }         
            if (File.Exists("LastVisited.bin"))
            {
                Thread.Sleep(10);
                string filename = "LastVisited.bin";
                File.WriteAllText(filename, txtUrl.Text);
            }
            else
            {
                File.Create("LastVisited.bin");
            }
        }

        private void AddHistory()
        {
            if (txtUrl.Text.Contains("https"))
            {
                string webad = txtUrl.Text.ToString();
                listBox1.Items.Add(webad);
                UnsafeOrSafeChecker.Stop();
            }
            else
            {
                string webad = txtUrl.Text.ToString();            
                listBox1.Items.Add(webad + "  -Unsafe");
                UnsafeOrSafeChecker.Start();
            }
           
        }

        private void iconFile()
        {
            this.Icon = DefaultIcon;
            if (txtUrl.Text.Contains(".pdf"))
            {
                txtUrl.IconLeft = FireBrowser.Properties.Resources.pdf_64px;
                
            }
            if (txtUrl.Text.Contains(".html"))
            {
                txtUrl.IconLeft = FireBrowser.Properties.Resources.code_48px;
                
            }
            if (txtUrl.Text.Contains(".txt"))
            {
                txtUrl.IconLeft = FireBrowser.Properties.Resources.txt_64px;
              
            }
        }

        private void txtUrl_OnIconRightClick(object sender, EventArgs e)
        {
            web.Source = new Uri(txtUrl.Text);
        }

        private void web_SourceChanged(object sender, CoreWebView2SourceChangedEventArgs e)
        {           
            UpdateTitleWithEvent("");
            Texter();
       
        }

        private void txtSet()
        {
            if (txtUrl.Text.Contains("settings"))
            {
                forms.FloatingPanel panel = new forms.FloatingPanel();
                panel.Show();
                
            }
            if (txtUrl.Text.Contains("history"))
            {
                if (Pauze.Visible = true)
                {
                    Pauze.PerformClick();
                    Pauze.Visible = false;
                    Return.Visible = true;
                }
            }
            if (txtUrl.Text.Contains("set:quick"))
            {
                forms.Settings settings = new forms.Settings();
                settings.Show();
            }
            if (txtUrl.Text.Contains("helps"))
            {
                forms.Help help = new forms.Help();
                help.Show();
            }
            if (txtUrl.Text.Contains("homes"))
            {
                web.CoreWebView2.Navigate(FireBrowser.Properties.Settings.Default.EngineDefault);
            }
          
            if (txtUrl.Text.Contains("last")) 
            {
                if (FireBrowser.Properties.Settings.Default.lasvisited == true)
                {
                    FireBrowser.Properties.Settings.Default.lasvisited = false;
                    FireBrowser.Properties.Settings.Default.Save();
                    bunifuSnackbar1.Show(this, "LastVisit Off",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
                else
                {
                    FireBrowser.Properties.Settings.Default.lasvisited = true;
                    FireBrowser.Properties.Settings.Default.Save();
                    bunifuSnackbar1.Show(this, "LastVisit On",
                    Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                }
               
            }
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
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
                            web.CoreWebView2.Navigate("https://www.google.nl/search?client=opera&q=" + txtUrl.Text.Trim().Replace(" ", "+") + "&sourceid=opera&ie=UTF-8&oe=UTF-8");
                        }
                        else if (FireBrowser.Properties.Settings.Default.Engine == false)
                        {
                            web.CoreWebView2.Navigate("https://www.bing.com/search?q=" + txtUrl.Text.Trim().Replace(" ", "+") + "&sourceid=opera&ie=UTF-8&oe=UTF-8");
                        }

                    }
                }                                                        
            }
        }

        public void searcherDex()
        {
            if (txtUrl.Text.Contains("http://"))
            {
                web.CoreWebView2.Navigate(txtUrl.Text);
            }
            if (txtUrl.Text.Contains("https://"))
            {
                web.CoreWebView2.Navigate(txtUrl.Text);

            }
            else if (txtUrl.Text.Contains("www"))
            {           
                    txtUrl.Text = "https://" + txtUrl.Text;
                    web.CoreWebView2.Navigate(txtUrl.Text.Trim());
            }          
            else
            {
                if (txtUrl.Text.Contains(".com"))
                {
                    txtUrl.Text = "https://www." + txtUrl.Text;
                    web.CoreWebView2.Navigate(txtUrl.Text.Trim());
                }
                if (txtUrl.Text.Contains(".nl"))
                {
                    txtUrl.Text = "https://www." + txtUrl.Text;
                    web.CoreWebView2.Navigate(txtUrl.Text.Trim());
                }
                if (txtUrl.Text.Contains(".uk"))
                {
                    txtUrl.Text = "https://www." + txtUrl.Text;
                    web.CoreWebView2.Navigate(txtUrl.Text.Trim());
                }
                if (txtUrl.Text.Contains(".us"))
                {
                    txtUrl.Text = "https://www." + txtUrl.Text;
                    web.CoreWebView2.Navigate(txtUrl.Text.Trim());
                }
            }         
        }

        private async void Browser_Load(object sender, EventArgs e)
        {
            
            panel4.Visible = false;
            if (FireBrowser.Properties.Settings.Default.History == true)
            {
                FireBrowser.Properties.Settings.Default.History = true;
                Pauze.Visible = true;
                OnOf.Text = "History-On";
            }
            else
            {
                Pauze.Visible = false;
                FireBrowser.Properties.Settings.Default.History = false;
                OnOf.Text = "History-Off";
            }
            await web.EnsureCoreWebView2Async();
            web.CoreWebView2.ContainsFullScreenElementChanged += (obj, args) =>
            {
                this.FullScreen = web.CoreWebView2.ContainsFullScreenElement;
              
            };

            if (FireBrowser.Properties.Settings.Default.lasvisited == true)
            {
                if (File.Exists("LastVisited.bin"))
                {
                    string file = "LastVisited.bin";
                    txtUrl.Text = File.ReadAllText(file);
                    Thread.Sleep(25);
                    web.CoreWebView2.Navigate(txtUrl.Text.ToString());
                }
            }          
            else
            {
                web.Source = new Uri(FireBrowser.Properties.Settings.Default.EngineDefault);
                return;
            }

           
        }

      
        async void InitializeAsync()
        {
            var webView2Environment = await CoreWebView2Environment.CreateAsync(null, _cachePath + "C:\temp");
            await web.EnsureCoreWebView2Async(webView2Environment);
            await web.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
        }

        private readonly string _cachePath;

        void UpdateAddressBar(object sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            String uri = args.TryGetWebMessageAsString();
            txtUrl.Text = uri;
            web.CoreWebView2.PostWebMessageAsString(uri);
           
        }

        private bool fullScreen = false;
        private object parameters;

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
      

        #region checkForwardBack

        private void Back()
            {
              if (web.CoreWebView2.CanGoBack)
              {
                web.GoBack();
              }
            }
            private void Forward()
            {
             if (web.CoreWebView2.CanGoForward)
             {
                web.GoForward();
             }
            }
        #endregion


        private void BtnBack_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            Forward();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            web.CoreWebView2.Reload();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
         
        }

        private void web_VisibleChanged(object sender, EventArgs e)
        {
            return;
        }

        private void IconWeb()
        {

                Invoke(new Action(() => txtUrl.Text.ToString()));

                if (txtUrl.Text.Contains("https") && !faviconLoaded)
                {

                    Uri uri = new Uri(txtUrl.Text);

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

        public static Icon DefaultIcon { get; internal set; }

        private void txtUrl_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[]; // get all files droppeds  
            if (files != null && files.Any())
               txtUrl.Text = files.First(); //select the first one  
            Thread.Sleep(200);
            web.CoreWebView2.Navigate(txtUrl.Text);
        }


        private void txtUrl_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

     

        private void txtUrl_DoubleClick(object sender, EventArgs e)
        {
            web.CoreWebView2.Stop();
           
        }

        private void History_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.BringToFront();
        }

        private void ClosePanel_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
         
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            web.CoreWebView2.Navigate(listBox1.SelectedItem.ToString());
        }

        private void Pauze_Click(object sender, EventArgs e)
        {
            OnOf.Text = "History-Off";
            Pauze.Visible = false;
            Return.Visible = true;
            FireBrowser.Properties.Settings.Default.History = false;
            FireBrowser.Properties.Settings.Default.Save();
        }

        private void Return_Click(object sender, EventArgs e)
        {
            OnOf.Text = "History-On";
            Pauze.Visible = true;
            Return.Visible = false;
            FireBrowser.Properties.Settings.Default.History = true;
            FireBrowser.Properties.Settings.Default.Save();
        }

        private void txtUrl_OnIconLeftClick(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void BackTo_Click(object sender, EventArgs e)
        {
            web.CoreWebView2.Navigate(txtUrl.Text.ToString());
            txtUrl.Text = "https://www.google.nl";
        }

        private void UnsafeOrSafeChecker_Tick(object sender, EventArgs e)
        {
            if (FireBrowser.Properties.Settings.Default.SafeBrowse == true)
            {
                Forbidden();
                UnsafeOrSafeChecker.Start();
          
            }
            else if (FireBrowser.Properties.Settings.Default.SafeBrowse == false)
            {
                return;
                UnsafeOrSafeChecker.Stop();
            }
        }

        private void CoreWebView2_WebResourceRequested(CoreWebView2 sender, CoreWebView2WebResourceRequestedEventArgs e)
        {
            // Create response object for custom response and set it
            var environment = web.CoreWebView2.Environment;
            CoreWebView2WebResourceResponse response = environment.CreateWebResourceResponse(null, 403, "Blocked", "");
            e.Response = response;

            // statusCode will now be accessible and equal to 403
            var code = e.Response.StatusCode;
        }

        private void Report_Click(object sender, EventArgs e)
        {
            string filename = "report\\report.txt";
            File.WriteAllText(filename, txtUrl.Text);
            string back = FireBrowser.Properties.Settings.Default.KidsBack;
            web.CoreWebView2.Navigate(back);
            bunifuPanel1.Visible = false;
            txtUrl.Text = "https://www.google.nl/";
        }
    }
}
