
namespace FireBrowser
{
    partial class BrowserWindow
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
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserWindow));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSettings = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnRefresh = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnForward = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnBack = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.txtUrl = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLoader1 = new Bunifu.UI.WinForms.BunifuLoader();
            this.newWeb = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.snack = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.quicksearch = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.keyword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rnd = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newWeb)).BeginInit();
            this.quicksearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.txtUrl);
            this.panel1.Controls.Add(this.bunifuLoader1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1113, 53);
            this.panel1.TabIndex = 5;
            this.bunifuToolTip1.SetToolTip(this.panel1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.panel1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.panel1, "");
            // 
            // btnSettings
            // 
            this.btnSettings.AllowAnimations = true;
            this.btnSettings.AllowBorderColorChanges = true;
            this.btnSettings.AllowMouseEffects = true;
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.AnimationSpeed = 200;
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderRadius = 1;
            this.btnSettings.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnSettings.BorderThickness = 0;
            this.btnSettings.ColorContrastOnClick = 30;
            this.btnSettings.ColorContrastOnHover = 30;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSettings.CustomizableEdges = borderEdges1;
            this.btnSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSettings.Image = global::FireBrowser.Properties.Resources.icons8_settings_321;
            this.btnSettings.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Location = new System.Drawing.Point(1061, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.RoundBorders = false;
            this.btnSettings.ShowBorders = true;
            this.btnSettings.Size = new System.Drawing.Size(44, 44);
            this.btnSettings.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Flat;
            this.btnSettings.TabIndex = 10;
            this.bunifuToolTip1.SetToolTip(this.btnSettings, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnSettings, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnSettings, "");
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AllowAnimations = true;
            this.btnRefresh.AllowBorderColorChanges = true;
            this.btnRefresh.AllowMouseEffects = true;
            this.btnRefresh.AnimationSpeed = 200;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 1;
            this.btnRefresh.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnRefresh.BorderThickness = 0;
            this.btnRefresh.ColorContrastOnClick = 30;
            this.btnRefresh.ColorContrastOnHover = 30;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnRefresh.CustomizableEdges = borderEdges2;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.Image = global::FireBrowser.Properties.Resources.icons8_refresh_32;
            this.btnRefresh.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnRefresh.Location = new System.Drawing.Point(110, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RoundBorders = false;
            this.btnRefresh.ShowBorders = true;
            this.btnRefresh.Size = new System.Drawing.Size(44, 44);
            this.btnRefresh.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Flat;
            this.btnRefresh.TabIndex = 9;
            this.bunifuToolTip1.SetToolTip(this.btnRefresh, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnRefresh, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnRefresh, "");
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnForward
            // 
            this.btnForward.AllowAnimations = true;
            this.btnForward.AllowBorderColorChanges = true;
            this.btnForward.AllowMouseEffects = true;
            this.btnForward.AnimationSpeed = 200;
            this.btnForward.BackColor = System.Drawing.Color.Transparent;
            this.btnForward.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnForward.BorderColor = System.Drawing.Color.Transparent;
            this.btnForward.BorderRadius = 1;
            this.btnForward.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnForward.BorderThickness = 0;
            this.btnForward.ColorContrastOnClick = 30;
            this.btnForward.ColorContrastOnHover = 30;
            this.btnForward.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnForward.CustomizableEdges = borderEdges3;
            this.btnForward.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnForward.Image = global::FireBrowser.Properties.Resources.forward_64px;
            this.btnForward.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnForward.Location = new System.Drawing.Point(57, 5);
            this.btnForward.Name = "btnForward";
            this.btnForward.RoundBorders = false;
            this.btnForward.ShowBorders = true;
            this.btnForward.Size = new System.Drawing.Size(42, 42);
            this.btnForward.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Flat;
            this.btnForward.TabIndex = 8;
            this.bunifuToolTip1.SetToolTip(this.btnForward, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnForward, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnForward, "");
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBack
            // 
            this.btnBack.AllowAnimations = true;
            this.btnBack.AllowBorderColorChanges = true;
            this.btnBack.AllowMouseEffects = true;
            this.btnBack.AnimationSpeed = 200;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderColor = System.Drawing.Color.Transparent;
            this.btnBack.BorderRadius = 1;
            this.btnBack.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnBack.BorderThickness = 0;
            this.btnBack.ColorContrastOnClick = 30;
            this.btnBack.ColorContrastOnHover = 30;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnBack.CustomizableEdges = borderEdges4;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.Image = global::FireBrowser.Properties.Resources.icons8_back_32;
            this.btnBack.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnBack.Location = new System.Drawing.Point(8, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.RoundBorders = false;
            this.btnBack.ShowBorders = true;
            this.btnBack.Size = new System.Drawing.Size(42, 42);
            this.btnBack.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Flat;
            this.btnBack.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.btnBack, "");
            this.bunifuToolTip1.SetToolTipIcon(this.btnBack, null);
            this.bunifuToolTip1.SetToolTipTitle(this.btnBack, "");
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.AcceptsReturn = false;
            this.txtUrl.AcceptsTab = true;
            this.txtUrl.AllowDrop = true;
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.AnimationSpeed = 200;
            this.txtUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUrl.AutoSizeHeight = true;
            this.txtUrl.BackColor = System.Drawing.Color.Transparent;
            this.txtUrl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtUrl.BackgroundImage")));
            this.txtUrl.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUrl.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUrl.BorderColorHover = System.Drawing.Color.Yellow;
            this.txtUrl.BorderColorIdle = System.Drawing.Color.Gray;
            this.txtUrl.BorderRadius = 25;
            this.txtUrl.BorderThickness = 1;
            this.txtUrl.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtUrl.DefaultText = "";
            this.txtUrl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.txtUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtUrl.HideSelection = true;
            this.txtUrl.IconLeft = global::FireBrowser.Properties.Resources.secure_48px;
            this.txtUrl.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.IconPadding = 6;
            this.txtUrl.IconRight = null;
            this.txtUrl.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUrl.Lines = new string[0];
            this.txtUrl.Location = new System.Drawing.Point(169, 5);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtUrl.Modified = false;
            this.txtUrl.Multiline = false;
            this.txtUrl.Name = "txtUrl";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUrl.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUrl.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Yellow;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUrl.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Gray;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtUrl.OnIdleState = stateProperties4;
            this.txtUrl.Padding = new System.Windows.Forms.Padding(3);
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtUrl.PlaceholderText = "Enter Url Or Search Here";
            this.txtUrl.ReadOnly = false;
            this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.ShortcutsEnabled = true;
            this.txtUrl.Size = new System.Drawing.Size(880, 43);
            this.txtUrl.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtUrl.TabIndex = 5;
            this.txtUrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUrl.TextMarginBottom = 0;
            this.txtUrl.TextMarginLeft = 3;
            this.txtUrl.TextMarginTop = 1;
            this.txtUrl.TextPlaceholder = "Enter Url Or Search Here";
            this.bunifuToolTip1.SetToolTip(this.txtUrl, "");
            this.bunifuToolTip1.SetToolTipIcon(this.txtUrl, null);
            this.bunifuToolTip1.SetToolTipTitle(this.txtUrl, "");
            this.txtUrl.UseSystemPasswordChar = false;
            this.txtUrl.WordWrap = true;
            this.txtUrl.TextChange += new System.EventHandler(this.txtUrl_TextChange_1);
            this.txtUrl.OnIconLeftClick += new System.EventHandler(this.txtUrl_OnIconLeftClick);
            this.txtUrl.OnIconRightClick += new System.EventHandler(this.txtUrl_OnIconRightClick);
            this.txtUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyUp_1);
            this.txtUrl.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtUrl_DragDrop_1);
            this.txtUrl.DragOver += new System.Windows.Forms.DragEventHandler(this.txtUrl_DragOver);
            // 
            // bunifuLoader1
            // 
            this.bunifuLoader1.AllowStylePresets = false;
            this.bunifuLoader1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuLoader1.CapStyle = Bunifu.UI.WinForms.BunifuLoader.CapStyles.Round;
            this.bunifuLoader1.Color = System.Drawing.Color.DodgerBlue;
            this.bunifuLoader1.Colors = new Bunifu.UI.WinForms.Bloom[0];
            this.bunifuLoader1.Customization = "";
            this.bunifuLoader1.DashWidth = 0.5F;
            this.bunifuLoader1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLoader1.Image = null;
            this.bunifuLoader1.Location = new System.Drawing.Point(110, 6);
            this.bunifuLoader1.Name = "bunifuLoader1";
            this.bunifuLoader1.NoRounding = false;
            this.bunifuLoader1.Preset = Bunifu.UI.WinForms.BunifuLoader.StylePresets.Solid;
            this.bunifuLoader1.RingStyle = Bunifu.UI.WinForms.BunifuLoader.RingStyles.Dotted;
            this.bunifuLoader1.ShowText = false;
            this.bunifuLoader1.Size = new System.Drawing.Size(45, 40);
            this.bunifuLoader1.Speed = 5;
            this.bunifuLoader1.TabIndex = 6;
            this.bunifuLoader1.Text = "...";
            this.bunifuLoader1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuLoader1.Thickness = 5;
            this.bunifuToolTip1.SetToolTip(this.bunifuLoader1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.bunifuLoader1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.bunifuLoader1, "");
            this.bunifuLoader1.Transparent = true;
            this.bunifuLoader1.Click += new System.EventHandler(this.bunifuLoader1_Click);
            // 
            // newWeb
            // 
            this.newWeb.CreationProperties = null;
            this.newWeb.DefaultBackgroundColor = System.Drawing.Color.White;
            this.newWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newWeb.Location = new System.Drawing.Point(0, 53);
            this.newWeb.Name = "newWeb";
            this.newWeb.Size = new System.Drawing.Size(1113, 578);
            this.newWeb.TabIndex = 6;
            this.bunifuToolTip1.SetToolTip(this.newWeb, "");
            this.bunifuToolTip1.SetToolTipIcon(this.newWeb, null);
            this.bunifuToolTip1.SetToolTipTitle(this.newWeb, "");
            this.newWeb.ZoomFactor = 1D;
            this.newWeb.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.newWeb_CoreWebView2InitializationCompleted);
            this.newWeb.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.newWeb_NavigationStarting);
            this.newWeb.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.newWeb_NavigationCompleted);
            this.newWeb.SourceChanged += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs>(this.newWeb_SourceChanged);
            this.newWeb.Click += new System.EventHandler(this.newWeb_Click);
            this.newWeb.DragDrop += new System.Windows.Forms.DragEventHandler(this.newWeb_DragDrop);
            this.newWeb.DragOver += new System.Windows.Forms.DragEventHandler(this.newWeb_DragOver);
            // 
            // snack
            // 
            this.snack.AllowDragging = false;
            this.snack.AllowMultipleViews = true;
            this.snack.ClickToClose = true;
            this.snack.DoubleClickToClose = true;
            this.snack.DurationAfterIdle = 3000;
            this.snack.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snack.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snack.ErrorOptions.ActionBorderRadius = 1;
            this.snack.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snack.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snack.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.snack.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.snack.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.snack.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snack.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.snack.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.snack.ErrorOptions.IconLeftMargin = 12;
            this.snack.FadeCloseIcon = false;
            this.snack.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.snack.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snack.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snack.InformationOptions.ActionBorderRadius = 1;
            this.snack.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snack.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snack.InformationOptions.BackColor = System.Drawing.Color.White;
            this.snack.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.snack.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.snack.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snack.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.snack.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.snack.InformationOptions.IconLeftMargin = 12;
            this.snack.Margin = 10;
            this.snack.MaximumSize = new System.Drawing.Size(0, 0);
            this.snack.MaximumViews = 7;
            this.snack.MessageRightMargin = 15;
            this.snack.MinimumSize = new System.Drawing.Size(0, 0);
            this.snack.ShowBorders = false;
            this.snack.ShowCloseIcon = false;
            this.snack.ShowIcon = true;
            this.snack.ShowShadows = true;
            this.snack.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snack.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snack.SuccessOptions.ActionBorderRadius = 1;
            this.snack.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snack.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snack.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.snack.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.snack.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.snack.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snack.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.snack.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.snack.SuccessOptions.IconLeftMargin = 12;
            this.snack.ViewsMargin = 7;
            this.snack.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snack.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.snack.WarningOptions.ActionBorderRadius = 1;
            this.snack.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.snack.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.snack.WarningOptions.BackColor = System.Drawing.Color.White;
            this.snack.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.snack.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.snack.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.snack.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.snack.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.snack.WarningOptions.IconLeftMargin = 12;
            this.snack.ZoomCloseIcon = true;
            // 
            // quicksearch
            // 
            this.quicksearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.quicksearch.Controls.Add(this.pictureBox1);
            this.quicksearch.Controls.Add(this.keyword);
            this.quicksearch.Location = new System.Drawing.Point(5, 60);
            this.quicksearch.Name = "quicksearch";
            this.quicksearch.Size = new System.Drawing.Size(654, 54);
            this.quicksearch.TabIndex = 7;
            this.bunifuToolTip1.SetToolTip(this.quicksearch, "");
            this.bunifuToolTip1.SetToolTipIcon(this.quicksearch, null);
            this.bunifuToolTip1.SetToolTipTitle(this.quicksearch, "");
            this.quicksearch.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::FireBrowser.Properties.Resources.close_window_48px;
            this.pictureBox1.Location = new System.Drawing.Point(589, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.bunifuToolTip1.SetToolTip(this.pictureBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pictureBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pictureBox1, "");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // keyword
            // 
            this.keyword.AcceptsReturn = false;
            this.keyword.AcceptsTab = false;
            this.keyword.AnimationSpeed = 200;
            this.keyword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.keyword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.keyword.AutoSizeHeight = true;
            this.keyword.BackColor = System.Drawing.Color.Transparent;
            this.keyword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("keyword.BackgroundImage")));
            this.keyword.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.keyword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.keyword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.keyword.BorderColorIdle = System.Drawing.Color.Silver;
            this.keyword.BorderRadius = 25;
            this.keyword.BorderThickness = 1;
            this.keyword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.keyword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyword.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.keyword.DefaultText = "";
            this.keyword.FillColor = System.Drawing.Color.White;
            this.keyword.HideSelection = true;
            this.keyword.IconLeft = null;
            this.keyword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.keyword.IconPadding = 10;
            this.keyword.IconRight = null;
            this.keyword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.keyword.Lines = new string[0];
            this.keyword.Location = new System.Drawing.Point(7, 6);
            this.keyword.MaxLength = 32767;
            this.keyword.MinimumSize = new System.Drawing.Size(1, 1);
            this.keyword.Modified = false;
            this.keyword.Multiline = false;
            this.keyword.Name = "keyword";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.keyword.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.keyword.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.keyword.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.keyword.OnIdleState = stateProperties8;
            this.keyword.Padding = new System.Windows.Forms.Padding(3);
            this.keyword.PasswordChar = '\0';
            this.keyword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.keyword.PlaceholderText = "Enter KeyWord";
            this.keyword.ReadOnly = false;
            this.keyword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.keyword.SelectedText = "";
            this.keyword.SelectionLength = 0;
            this.keyword.SelectionStart = 0;
            this.keyword.ShortcutsEnabled = true;
            this.keyword.Size = new System.Drawing.Size(564, 43);
            this.keyword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.keyword.TabIndex = 0;
            this.keyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.keyword.TextMarginBottom = 0;
            this.keyword.TextMarginLeft = 3;
            this.keyword.TextMarginTop = 1;
            this.keyword.TextPlaceholder = "Enter KeyWord";
            this.bunifuToolTip1.SetToolTip(this.keyword, "");
            this.bunifuToolTip1.SetToolTipIcon(this.keyword, null);
            this.bunifuToolTip1.SetToolTipTitle(this.keyword, "");
            this.keyword.UseSystemPasswordChar = false;
            this.keyword.WordWrap = true;
            this.keyword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyword_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rnd
            // 
            this.rnd.ElipseRadius = 10;
            this.rnd.TargetControl = this.quicksearch;
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
            // BrowserWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 631);
            this.Controls.Add(this.quicksearch);
            this.Controls.Add(this.newWeb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowserWindow";
            this.Text = "BrowserWindow";
            this.Load += new System.EventHandler(this.BrowserWindow_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newWeb)).EndInit();
            this.quicksearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Web.WebView2.WinForms.WebView2 newWeb;
        private Bunifu.UI.WinForms.BunifuSnackbar snack;
        private System.Windows.Forms.Panel quicksearch;
        private Bunifu.UI.WinForms.BunifuTextBox keyword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuTextBox txtUrl;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuElipse rnd;
        private Bunifu.UI.WinForms.BunifuLoader bunifuLoader1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnBack;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnForward;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnRefresh;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnSettings;
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
    }
}