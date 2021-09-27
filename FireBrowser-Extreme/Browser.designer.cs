
namespace FireBrowser_Extreme
{
    partial class Browser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Browser));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnRefresh = new System.Windows.Forms.PictureBox();
            this.BtnForward = new System.Windows.Forms.PictureBox();
            this.BtnBack = new System.Windows.Forms.PictureBox();
            this.txtUrl = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BackTo = new Bunifu.UI.WinForms.BunifuImageButton();
            this.ValidOrNot = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.web = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.IconList = new System.Windows.Forms.ImageList(this.components);
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.UnsafeOrSafeChecker = new System.Windows.Forms.Timer(this.components);
            this.icon = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.web)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.BtnForward);
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 62);
            this.panel1.TabIndex = 1;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::FireBrowser_Extreme.Properties.Resources.settings_24px;
            this.pictureBox1.Location = new System.Drawing.Point(982, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Image = global::FireBrowser_Extreme.Properties.Resources.refresh_32px;
            this.BtnRefresh.Location = new System.Drawing.Point(116, 12);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(39, 39);
            this.BtnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnRefresh.TabIndex = 4;
            this.BtnRefresh.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.BtnRefresh, "");
            this.bunifuToolTip1.SetToolTipIcon(this.BtnRefresh, null);
            this.bunifuToolTip1.SetToolTipTitle(this.BtnRefresh, "");
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnForward
            // 
            this.BtnForward.Image = global::FireBrowser_Extreme.Properties.Resources.ForwardActive;
            this.BtnForward.Location = new System.Drawing.Point(61, 9);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(46, 46);
            this.BtnForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnForward.TabIndex = 3;
            this.BtnForward.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.BtnForward, "");
            this.bunifuToolTip1.SetToolTipIcon(this.BtnForward, null);
            this.bunifuToolTip1.SetToolTipTitle(this.BtnForward, "");
            this.BtnForward.Click += new System.EventHandler(this.BtnForward_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Image = global::FireBrowser_Extreme.Properties.Resources.BackActive;
            this.BtnBack.Location = new System.Drawing.Point(9, 9);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(46, 46);
            this.BtnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnBack.TabIndex = 2;
            this.BtnBack.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.BtnBack, "");
            this.bunifuToolTip1.SetToolTipIcon(this.BtnBack, null);
            this.bunifuToolTip1.SetToolTipTitle(this.BtnBack, "");
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.AcceptsReturn = false;
            this.txtUrl.AcceptsTab = false;
            this.txtUrl.AllowDrop = true;
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.AnimationSpeed = 200;
            this.txtUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUrl.AutoSizeHeight = true;
            this.txtUrl.BackColor = System.Drawing.Color.Transparent;
            this.txtUrl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUrl.BackgroundImage")));
            this.txtUrl.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtUrl.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUrl.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtUrl.BorderColorIdle = System.Drawing.Color.Maroon;
            this.txtUrl.BorderRadius = 30;
            this.txtUrl.BorderThickness = 1;
            this.txtUrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.DefaultText = "";
            this.txtUrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtUrl.HideSelection = true;
            this.txtUrl.IconLeft = global::FireBrowser_Extreme.Properties.Resources.secure_48px;
            this.txtUrl.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.IconPadding = 5;
            this.txtUrl.IconRight = global::FireBrowser_Extreme.Properties.Resources.search_24px;
            this.txtUrl.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.Lines = new string[0];
            this.txtUrl.Location = new System.Drawing.Point(165, 12);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUrl.Modified = false;
            this.txtUrl.Multiline = false;
            this.txtUrl.Name = "txtUrl";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUrl.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUrl.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUrl.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Maroon;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUrl.OnIdleState = stateProperties4;
            this.txtUrl.Padding = new System.Windows.Forms.Padding(3);
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUrl.PlaceholderText = "Search Here";
            this.txtUrl.ReadOnly = false;
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.ShortcutsEnabled = true;
            this.txtUrl.Size = new System.Drawing.Size(804, 41);
            this.txtUrl.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUrl.TabIndex = 1;
            this.txtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUrl.TextMarginBottom = 0;
            this.txtUrl.TextMarginLeft = 3;
            this.txtUrl.TextMarginTop = 0;
            this.txtUrl.TextPlaceholder = "Search Here";
            this.bunifuToolTip1.SetToolTip(this.txtUrl, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtUrl, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtUrl, "Type helps then enter \r\nTo go to help Form\r\nBefore helps command type f:\r\n");
            this.txtUrl.UseSystemPasswordChar = false;
            this.txtUrl.WordWrap = true;
            this.txtUrl.TextChange += new System.EventHandler(this.txtUrl_TextChange);
            this.txtUrl.OnIconLeftClick += new System.EventHandler(this.txtUrl_OnIconLeftClick);
            this.txtUrl.OnIconRightClick += new System.EventHandler(this.txtUrl_OnIconRightClick);
            this.txtUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyUp);
            this.txtUrl.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtUrl_DragDrop);
            this.txtUrl.DragOver += new System.Windows.Forms.DragEventHandler(this.txtUrl_DragOver);
            this.txtUrl.DoubleClick += new System.EventHandler(this.txtUrl_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.web);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1033, 552);
            this.panel2.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel2, "");
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Controls.Add(this.BackTo);
            this.panel4.Controls.Add(this.ValidOrNot);
            this.panel4.Controls.Add(this.bunifuImageButton1);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 32);
            this.panel4.TabIndex = 2;
            this.bunifuToolTip1.SetToolTip(this.panel4, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel4, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel4, "");
            // 
            // BackTo
            // 
            this.BackTo.ActiveImage = global::FireBrowser_Extreme.Properties.Resources.microsoft_admin_48px;
            this.BackTo.AllowAnimations = true;
            this.BackTo.AllowBuffering = false;
            this.BackTo.AllowToggling = false;
            this.BackTo.AllowZooming = false;
            this.BackTo.AllowZoomingOnFocus = false;
            this.BackTo.BackColor = System.Drawing.Color.Transparent;
            this.BackTo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BackTo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BackTo.ErrorImage")));
            this.BackTo.FadeWhenInactive = false;
            this.BackTo.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BackTo.Image = global::FireBrowser_Extreme.Properties.Resources.microsoft_admin_48px;
            this.BackTo.ActiveImage = global::FireBrowser_Extreme.Properties.Resources.microsoft_admin_48px;
            this.BackTo.ImageLocation = null;
            this.BackTo.ImageMargin = 5;
            this.BackTo.ImageSize = new System.Drawing.Size(30, 22);
            this.BackTo.ImageZoomSize = new System.Drawing.Size(35, 27);
            this.BackTo.InitialImage = ((System.Drawing.Image)(resources.GetObject("BackTo.InitialImage")));
            this.BackTo.Location = new System.Drawing.Point(182, 3);
            this.BackTo.Name = "BackTo";
            this.BackTo.Rotation = 0;
            this.BackTo.ShowActiveImage = true;
            this.BackTo.ShowCursorChanges = true;
            this.BackTo.ShowImageBorders = false;
            this.BackTo.ShowSizeMarkers = false;
            this.BackTo.Size = new System.Drawing.Size(35, 27);
            this.BackTo.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.BackTo, "");
            this.bunifuToolTip1.SetToolTipIcon(this.BackTo, null);
            this.BackTo.ToolTipText = "Automatic to Google";
            this.bunifuToolTip1.SetToolTipTitle(this.BackTo, "Back To Safe WebPage");
            this.BackTo.WaitOnLoad = false;
            this.BackTo.ImageMargin = 5;
            this.BackTo.ZoomSpeed = 10;
            this.BackTo.Click += new System.EventHandler(this.BackTo_Click);
            // 
            // ValidOrNot
            // 
            this.ValidOrNot.AutoSize = true;
            this.ValidOrNot.Location = new System.Drawing.Point(7, 6);
            this.ValidOrNot.Name = "ValidOrNot";
            this.ValidOrNot.Size = new System.Drawing.Size(103, 17);
            this.ValidOrNot.TabIndex = 4;
            this.ValidOrNot.Text = "Valid Certifcate";
            this.bunifuToolTip1.SetToolTip(this.ValidOrNot, "");
            this.bunifuToolTip1.SetToolTipIcon(this.ValidOrNot, null);
            this.bunifuToolTip1.SetToolTipTitle(this.ValidOrNot, "");
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = global::FireBrowser_Extreme.Properties.Resources.BackActive;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = false;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::FireBrowser_Extreme.Properties.Resources.BackActive;
            this.bunifuImageButton1.ActiveImage = global::FireBrowser_Extreme.Properties.Resources.BackActive;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 5;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(30, 22);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(35, 27);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(223, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = false;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(35, 27);
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuToolTip1.SetToolTip(this.bunifuImageButton1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuImageButton1, null);
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuImageButton1, "");
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.ImageMargin = 5;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // web
            // 
            this.web.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.web.CreationProperties = null;
            this.web.Cursor = System.Windows.Forms.Cursors.Hand;
            this.web.DefaultBackgroundColor = System.Drawing.Color.White;
            this.web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(1033, 552);
            this.web.Source = new System.Uri("https://www.google.nl", System.UriKind.Absolute);
            this.web.TabIndex = 0;
            this.bunifuToolTip1.SetToolTip(this.web, "");
            this.bunifuToolTip1.SetToolTipIcon(this.web, null);
            this.bunifuToolTip1.SetToolTipTitle(this.web, "");
            this.web.ZoomFactor = 1.1D;
            this.web.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.web_NavigationStarting);
            this.web.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.web_NavigationCompleted);
            this.web.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.web_SourceChanged);
            this.web.VisibleChanged += new System.EventHandler(this.web_VisibleChanged);
            // 
            // bunifuToolTip1
            // 
            this.bunifuToolTip1.Active = true;
            this.bunifuToolTip1.AlignTextWithTitle = false;
            this.bunifuToolTip1.AllowAutoClose = false;
            this.bunifuToolTip1.AllowFading = true;
            this.bunifuToolTip1.AutoCloseDuration = 5000;
            this.bunifuToolTip1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuToolTip1.BorderColor = System.Drawing.Color.Gainsboro;
            this.bunifuToolTip1.ClickToShowDisplayControl = false;
            this.bunifuToolTip1.ConvertNewlinesToBreakTags = true;
            this.bunifuToolTip1.DisplayControl = null;
            this.bunifuToolTip1.EntryAnimationSpeed = 350;
            this.bunifuToolTip1.ExitAnimationSpeed = 200;
            this.bunifuToolTip1.GenerateAutoCloseDuration = false;
            this.bunifuToolTip1.IconMargin = 6;
            this.bunifuToolTip1.InitialDelay = 0;
            this.bunifuToolTip1.Name = "bunifuToolTip1";
            this.bunifuToolTip1.Opacity = 1D;
            this.bunifuToolTip1.OverrideToolTipTitles = false;
            this.bunifuToolTip1.Padding = new System.Windows.Forms.Padding(10);
            this.bunifuToolTip1.ReshowDelay = 100;
            this.bunifuToolTip1.ShowAlways = true;
            this.bunifuToolTip1.ShowBorders = false;
            this.bunifuToolTip1.ShowIcons = true;
            this.bunifuToolTip1.ShowShadows = true;
            this.bunifuToolTip1.Tag = null;
            this.bunifuToolTip1.TextFont = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuToolTip1.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuToolTip1.TextMargin = 2;
            this.bunifuToolTip1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.bunifuToolTip1.TitleForeColor = System.Drawing.Color.Black;
            this.bunifuToolTip1.ToolTipPosition = new System.Drawing.Point(0, 0);
            this.bunifuToolTip1.ToolTipTitle = null;
            // 
            // IconList
            // 
            this.IconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("IconList.ImageStream")));
            this.IconList.TransparentColor = System.Drawing.Color.Transparent;
            this.IconList.Images.SetKeyName(0, "txt_64px.png");
            this.IconList.Images.SetKeyName(1, "code_48px.png");
            this.IconList.Images.SetKeyName(2, "css_filetype_64px.png");
            this.IconList.Images.SetKeyName(3, "file_48px.png");
            this.IconList.Images.SetKeyName(4, "pdf_64px.png");
            this.IconList.Images.SetKeyName(5, "report_file_48px.png");
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 750;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = true;
            this.bunifuSnackbar1.ShowCloseIcon = true;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // UnsafeOrSafeChecker
            // 
            this.UnsafeOrSafeChecker.Tick += new System.EventHandler(this.UnsafeOrSafeChecker_Tick);
            // 
            // icon
            // 
            this.icon.WorkerReportsProgress = true;
            this.icon.WorkerSupportsCancellation = true;
            this.icon.DoWork += new System.ComponentModel.DoWorkEventHandler(this.icon_DoWork);
            this.icon.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.icon_RunWorkerCompleted);
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 614);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Browser";
            this.Text = "Browser";
            this.Load += new System.EventHandler(this.Browser_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBack)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.web)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Web.WebView2.WinForms.WebView2 web;
        private Bunifu.UI.WinForms.BunifuTextBox txtUrl;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private System.Windows.Forms.PictureBox BtnBack;
        private System.Windows.Forms.PictureBox BtnForward;
        private System.Windows.Forms.PictureBox BtnRefresh;

        private System.Windows.Forms.ImageList IconList;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label ValidOrNot;
        private Bunifu.UI.WinForms.BunifuImageButton BackTo;
        private System.Windows.Forms.Timer UnsafeOrSafeChecker;
        private System.ComponentModel.BackgroundWorker icon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}