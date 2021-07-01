
namespace FireBrowser.forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuToolTip1 = new Bunifu.UI.WinForms.BunifuToolTip(this.components);
            this.rdGoogle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new Bunifu.UI.WinForms.BunifuTextBox();
            this.safety = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.unlock = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label6 = new System.Windows.Forms.Label();
            this.childsecure = new System.Windows.Forms.CheckBox();
            this.AeroPeek = new System.Windows.Forms.CheckBox();
            this.cs = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.parent = new System.Windows.Forms.Timer(this.components);
            this.firstsync = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            // rdGoogle
            // 
            this.rdGoogle.AutoSize = true;
            this.rdGoogle.Checked = true;
            this.rdGoogle.Location = new System.Drawing.Point(42, 40);
            this.rdGoogle.Name = "rdGoogle";
            this.rdGoogle.Size = new System.Drawing.Size(73, 20);
            this.rdGoogle.TabIndex = 10;
            this.rdGoogle.TabStop = true;
            this.rdGoogle.Text = "Google";
            this.bunifuToolTip1.SetToolTip(this.rdGoogle, "");
            this.bunifuToolTip1.SetToolTipIcon(this.rdGoogle, null);
            this.bunifuToolTip1.SetToolTipTitle(this.rdGoogle, "");
            this.rdGoogle.UseVisualStyleBackColor = true;
            this.rdGoogle.CheckedChanged += new System.EventHandler(this.rdGoogle_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 521);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "QuickNav";
            this.bunifuToolTip1.SetToolTip(this.groupBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.groupBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.groupBox1, "");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "settings = normal panel";
            this.bunifuToolTip1.SetToolTip(this.label3, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label3, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label3, "");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "set:quick = snel settings";
            this.bunifuToolTip1.SetToolTip(this.label2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label2, "");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "homes = homepage";
            this.bunifuToolTip1.SetToolTip(this.label1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label1, "");
            // 
            // pass
            // 
            this.pass.AcceptsReturn = false;
            this.pass.AcceptsTab = false;
            this.pass.AnimationSpeed = 200;
            this.pass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.pass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.pass.BackColor = System.Drawing.Color.Transparent;
            this.pass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pass.BackgroundImage")));
            this.pass.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.pass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.pass.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.pass.BorderColorIdle = System.Drawing.Color.Silver;
            this.pass.BorderRadius = 25;
            this.pass.BorderThickness = 1;
            this.pass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.pass.DefaultText = "";
            this.pass.FillColor = System.Drawing.Color.White;
            this.pass.HideSelection = true;
            this.pass.IconLeft = null;
            this.pass.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.IconPadding = 10;
            this.pass.IconRight = null;
            this.pass.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.pass.Lines = new string[0];
            this.pass.Location = new System.Drawing.Point(403, 580);
            this.pass.MaxLength = 32767;
            this.pass.MinimumSize = new System.Drawing.Size(1, 1);
            this.pass.Modified = false;
            this.pass.Multiline = false;
            this.pass.Name = "pass";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.pass.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.pass.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.pass.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.pass.OnIdleState = stateProperties4;
            this.pass.Padding = new System.Windows.Forms.Padding(3);
            this.pass.PasswordChar = '\0';
            this.pass.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.pass.PlaceholderText = "Enter Password";
            this.pass.ReadOnly = false;
            this.pass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pass.SelectedText = "";
            this.pass.SelectionLength = 0;
            this.pass.SelectionStart = 0;
            this.pass.ShortcutsEnabled = true;
            this.pass.Size = new System.Drawing.Size(514, 41);
            this.pass.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.pass.TabIndex = 13;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pass.TextMarginBottom = 0;
            this.pass.TextMarginLeft = 3;
            this.pass.TextMarginTop = 0;
            this.pass.TextPlaceholder = "Enter Password";
            this.bunifuToolTip1.SetToolTip(this.pass, "");
            this.bunifuToolTip1.SetToolTipIcon(this.pass, null);
            this.bunifuToolTip1.SetToolTipTitle(this.pass, "");
            this.pass.UseSystemPasswordChar = false;
            this.pass.WordWrap = true;
            // 
            // safety
            // 
            this.safety.AllowAnimations = true;
            this.safety.AllowMouseEffects = true;
            this.safety.AllowToggling = false;
            this.safety.AnimationSpeed = 200;
            this.safety.AutoGenerateColors = false;
            this.safety.AutoRoundBorders = false;
            this.safety.AutoSizeLeftIcon = true;
            this.safety.AutoSizeRightIcon = true;
            this.safety.BackColor = System.Drawing.Color.Transparent;
            this.safety.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.safety.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("safety.BackgroundImage")));
            this.safety.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.safety.ButtonText = "Setup Child Protect";
            this.safety.ButtonTextMarginLeft = 0;
            this.safety.ColorContrastOnClick = 45;
            this.safety.ColorContrastOnHover = 45;
            this.safety.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.safety.CustomizableEdges = borderEdges1;
            this.safety.DialogResult = System.Windows.Forms.DialogResult.None;
            this.safety.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.safety.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.safety.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.safety.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.safety.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.safety.ForeColor = System.Drawing.Color.Black;
            this.safety.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.safety.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.safety.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.safety.IconMarginLeft = 11;
            this.safety.IconPadding = 10;
            this.safety.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.safety.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.safety.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.safety.IconSize = 25;
            this.safety.IdleBorderColor = System.Drawing.Color.Red;
            this.safety.IdleBorderRadius = 25;
            this.safety.IdleBorderThickness = 1;
            this.safety.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.safety.IdleIconLeftImage = null;
            this.safety.IdleIconRightImage = null;
            this.safety.IndicateFocus = false;
            this.safety.Location = new System.Drawing.Point(923, 580);
            this.safety.Name = "safety";
            this.safety.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.safety.OnDisabledState.BorderRadius = 25;
            this.safety.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.safety.OnDisabledState.BorderThickness = 1;
            this.safety.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.safety.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.safety.OnDisabledState.IconLeftImage = null;
            this.safety.OnDisabledState.IconRightImage = null;
            this.safety.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.safety.onHoverState.BorderRadius = 25;
            this.safety.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.safety.onHoverState.BorderThickness = 1;
            this.safety.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.safety.onHoverState.ForeColor = System.Drawing.Color.White;
            this.safety.onHoverState.IconLeftImage = null;
            this.safety.onHoverState.IconRightImage = null;
            this.safety.OnIdleState.BorderColor = System.Drawing.Color.Red;
            this.safety.OnIdleState.BorderRadius = 25;
            this.safety.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.safety.OnIdleState.BorderThickness = 1;
            this.safety.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.safety.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.safety.OnIdleState.IconLeftImage = null;
            this.safety.OnIdleState.IconRightImage = null;
            this.safety.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.safety.OnPressedState.BorderRadius = 25;
            this.safety.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.safety.OnPressedState.BorderThickness = 1;
            this.safety.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.safety.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.safety.OnPressedState.IconLeftImage = null;
            this.safety.OnPressedState.IconRightImage = null;
            this.safety.Size = new System.Drawing.Size(189, 39);
            this.safety.TabIndex = 14;
            this.safety.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.safety.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.safety.TextMarginLeft = 0;
            this.safety.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.safety, "");
            this.bunifuToolTip1.SetToolTipIcon(this.safety, null);
            this.bunifuToolTip1.SetToolTipTitle(this.safety, "");
            this.safety.UseDefaultRadiusAndThickness = true;
            this.safety.Click += new System.EventHandler(this.safety_Click);
            // 
            // unlock
            // 
            this.unlock.AllowAnimations = true;
            this.unlock.AllowMouseEffects = true;
            this.unlock.AllowToggling = false;
            this.unlock.AnimationSpeed = 200;
            this.unlock.AutoGenerateColors = false;
            this.unlock.AutoRoundBorders = false;
            this.unlock.AutoSizeLeftIcon = true;
            this.unlock.AutoSizeRightIcon = true;
            this.unlock.BackColor = System.Drawing.Color.Transparent;
            this.unlock.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.unlock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("unlock.BackgroundImage")));
            this.unlock.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.unlock.ButtonText = "Unlock Settings";
            this.unlock.ButtonTextMarginLeft = 0;
            this.unlock.ColorContrastOnClick = 45;
            this.unlock.ColorContrastOnHover = 45;
            this.unlock.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.unlock.CustomizableEdges = borderEdges2;
            this.unlock.DialogResult = System.Windows.Forms.DialogResult.None;
            this.unlock.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.unlock.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.unlock.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.unlock.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.unlock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.unlock.ForeColor = System.Drawing.Color.White;
            this.unlock.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.unlock.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.unlock.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.unlock.IconMarginLeft = 11;
            this.unlock.IconPadding = 10;
            this.unlock.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.unlock.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.unlock.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.unlock.IconSize = 25;
            this.unlock.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.unlock.IdleBorderRadius = 25;
            this.unlock.IdleBorderThickness = 1;
            this.unlock.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.unlock.IdleIconLeftImage = null;
            this.unlock.IdleIconRightImage = null;
            this.unlock.IndicateFocus = false;
            this.unlock.Location = new System.Drawing.Point(923, 580);
            this.unlock.Name = "unlock";
            this.unlock.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.unlock.OnDisabledState.BorderRadius = 25;
            this.unlock.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.unlock.OnDisabledState.BorderThickness = 1;
            this.unlock.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.unlock.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.unlock.OnDisabledState.IconLeftImage = null;
            this.unlock.OnDisabledState.IconRightImage = null;
            this.unlock.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.unlock.onHoverState.BorderRadius = 25;
            this.unlock.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.unlock.onHoverState.BorderThickness = 1;
            this.unlock.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.unlock.onHoverState.ForeColor = System.Drawing.Color.White;
            this.unlock.onHoverState.IconLeftImage = null;
            this.unlock.onHoverState.IconRightImage = null;
            this.unlock.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.unlock.OnIdleState.BorderRadius = 25;
            this.unlock.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.unlock.OnIdleState.BorderThickness = 1;
            this.unlock.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.unlock.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.unlock.OnIdleState.IconLeftImage = null;
            this.unlock.OnIdleState.IconRightImage = null;
            this.unlock.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.unlock.OnPressedState.BorderRadius = 25;
            this.unlock.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.unlock.OnPressedState.BorderThickness = 1;
            this.unlock.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.unlock.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.unlock.OnPressedState.IconLeftImage = null;
            this.unlock.OnPressedState.IconRightImage = null;
            this.unlock.Size = new System.Drawing.Size(189, 39);
            this.unlock.TabIndex = 15;
            this.unlock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.unlock.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.unlock.TextMarginLeft = 0;
            this.unlock.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuToolTip1.SetToolTip(this.unlock, "");
            this.bunifuToolTip1.SetToolTipIcon(this.unlock, null);
            this.bunifuToolTip1.SetToolTipTitle(this.unlock, "");
            this.unlock.UseDefaultRadiusAndThickness = true;
            this.unlock.Click += new System.EventHandler(this.unlock_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(427, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Off";
            this.bunifuToolTip1.SetToolTip(this.label6, "");
            this.bunifuToolTip1.SetToolTipIcon(this.label6, null);
            this.bunifuToolTip1.SetToolTipTitle(this.label6, "");
            // 
            // childsecure
            // 
            this.childsecure.AutoSize = true;
            this.childsecure.Location = new System.Drawing.Point(403, 550);
            this.childsecure.Name = "childsecure";
            this.childsecure.Size = new System.Drawing.Size(18, 17);
            this.childsecure.TabIndex = 18;
            this.bunifuToolTip1.SetToolTip(this.childsecure, "");
            this.bunifuToolTip1.SetToolTipIcon(this.childsecure, global::FireBrowser.Properties.Resources.secure_48px);
            this.bunifuToolTip1.SetToolTipTitle(this.childsecure, "Secure Child Browsing");
            this.childsecure.UseVisualStyleBackColor = true;
            // 
            // AeroPeek
            // 
            this.AeroPeek.AutoSize = true;
            this.AeroPeek.Checked = true;
            this.AeroPeek.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AeroPeek.Location = new System.Drawing.Point(12, 495);
            this.AeroPeek.Name = "AeroPeek";
            this.AeroPeek.Size = new System.Drawing.Size(132, 20);
            this.AeroPeek.TabIndex = 19;
            this.AeroPeek.Text = "AeroPeek - Tabs";
            this.bunifuToolTip1.SetToolTip(this.AeroPeek, "");
            this.bunifuToolTip1.SetToolTipIcon(this.AeroPeek, null);
            this.bunifuToolTip1.SetToolTipTitle(this.AeroPeek, "");
            this.AeroPeek.UseVisualStyleBackColor = true;
            this.AeroPeek.CheckedChanged += new System.EventHandler(this.AeroPeek_CheckedChanged);
            // 
            // cs
            // 
            this.cs.AutoSize = true;
            this.cs.Location = new System.Drawing.Point(217, 40);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(73, 20);
            this.cs.TabIndex = 20;
            this.cs.TabStop = true;
            this.cs.Text = "Costum";
            this.cs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuToolTip1.SetToolTip(this.cs, "");
            this.bunifuToolTip1.SetToolTipIcon(this.cs, null);
            this.bunifuToolTip1.SetToolTipTitle(this.cs, "");
            this.cs.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 34);
            this.textBox1.TabIndex = 21;
            this.bunifuToolTip1.SetToolTip(this.textBox1, "");
            this.bunifuToolTip1.SetToolTipIcon(this.textBox1, null);
            this.bunifuToolTip1.SetToolTipTitle(this.textBox1, "");
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(42, 126);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(271, 32);
            this.Save.TabIndex = 22;
            this.Save.Text = "Save-Engine";
            this.bunifuToolTip1.SetToolTip(this.Save, "");
            this.bunifuToolTip1.SetToolTipIcon(this.Save, null);
            this.bunifuToolTip1.SetToolTipTitle(this.Save, "");
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdGoogle);
            this.groupBox2.Controls.Add(this.Save);
            this.groupBox2.Controls.Add(this.cs);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 185);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search Engine";
            this.bunifuToolTip1.SetToolTip(this.groupBox2, "");
            this.bunifuToolTip1.SetToolTipIcon(this.groupBox2, null);
            this.bunifuToolTip1.SetToolTipTitle(this.groupBox2, "");
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // parent
            // 
            this.parent.Tick += new System.EventHandler(this.parent_Tick);
            // 
            // firstsync
            // 
            this.firstsync.Tick += new System.EventHandler(this.firstsync_Tick);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1124, 633);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.AeroPeek);
            this.Controls.Add(this.childsecure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.safety);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.unlock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings - Parent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Click += new System.EventHandler(this.Settings_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuToolTip bunifuToolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rdGoogle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox pass;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton safety;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton unlock;
        private System.Windows.Forms.Timer parent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox childsecure;
        private System.Windows.Forms.Timer firstsync;
        private System.Windows.Forms.CheckBox AeroPeek;
        private System.Windows.Forms.RadioButton cs;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}