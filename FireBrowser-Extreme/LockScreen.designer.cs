
namespace FireBrowser_Extreme
{
    partial class LockScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockScreen));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.unlockbtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.psscode = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.account = new System.Windows.Forms.Label();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.Silver;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.account);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.unlockbtn);
            this.bunifuCards1.Controls.Add(this.psscode);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1600, 1102);
            this.bunifuCards1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(822, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "use passcode to unlock";
            // 
            // unlockbtn
            // 
            this.unlockbtn.ActiveImage = null;
            this.unlockbtn.AllowAnimations = true;
            this.unlockbtn.AllowBuffering = false;
            this.unlockbtn.AllowToggling = false;
            this.unlockbtn.AllowZooming = false;
            this.unlockbtn.AllowZoomingOnFocus = false;
            this.unlockbtn.BackColor = System.Drawing.Color.Transparent;
            this.unlockbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.unlockbtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("unlockbtn.ErrorImage")));
            this.unlockbtn.FadeWhenInactive = false;
            this.unlockbtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.unlockbtn.Image = global::FireBrowser_Extreme.Properties.Resources.icons8_key_2_32;
            this.unlockbtn.ActiveImage = null;
            this.unlockbtn.ImageLocation = null;
            this.unlockbtn.ImageMargin = 20;
            this.unlockbtn.ImageSize = new System.Drawing.Size(40, 38);
            this.unlockbtn.ImageZoomSize = new System.Drawing.Size(60, 58);
            this.unlockbtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("unlockbtn.InitialImage")));
            this.unlockbtn.Location = new System.Drawing.Point(1282, 426);
            this.unlockbtn.Name = "unlockbtn";
            this.unlockbtn.Rotation = 0;
            this.unlockbtn.ShowActiveImage = true;
            this.unlockbtn.ShowCursorChanges = true;
            this.unlockbtn.ShowImageBorders = false;
            this.unlockbtn.ShowSizeMarkers = false;
            this.unlockbtn.Size = new System.Drawing.Size(60, 58);
            this.unlockbtn.TabIndex = 2;
            this.unlockbtn.ToolTipText = "";
            this.unlockbtn.WaitOnLoad = false;
            this.unlockbtn.ImageMargin = 20;
            this.unlockbtn.ZoomSpeed = 10;
            this.unlockbtn.Click += new System.EventHandler(this.unlockbtn_Click);
            // 
            // psscode
            // 
            this.psscode.AcceptsReturn = false;
            this.psscode.AcceptsTab = false;
            this.psscode.AnimationSpeed = 200;
            this.psscode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.psscode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.psscode.BackColor = System.Drawing.Color.Transparent;
            this.psscode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("psscode.BackgroundImage")));
            this.psscode.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.psscode.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.psscode.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.psscode.BorderColorIdle = System.Drawing.Color.Silver;
            this.psscode.BorderRadius = 25;
            this.psscode.BorderThickness = 1;
            this.psscode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.psscode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.psscode.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.psscode.DefaultText = "";
            this.psscode.FillColor = System.Drawing.Color.White;
            this.psscode.HideSelection = true;
            this.psscode.IconLeft = null;
            this.psscode.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.psscode.IconPadding = 10;
            this.psscode.IconRight = null;
            this.psscode.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.psscode.Lines = new string[0];
            this.psscode.Location = new System.Drawing.Point(563, 426);
            this.psscode.MaxLength = 32767;
            this.psscode.MinimumSize = new System.Drawing.Size(1, 1);
            this.psscode.Modified = false;
            this.psscode.Multiline = false;
            this.psscode.Name = "psscode";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.psscode.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.psscode.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.psscode.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.psscode.OnIdleState = stateProperties16;
            this.psscode.Padding = new System.Windows.Forms.Padding(3);
            this.psscode.PasswordChar = '\0';
            this.psscode.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.psscode.PlaceholderText = "Enter Passcode";
            this.psscode.ReadOnly = false;
            this.psscode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.psscode.SelectedText = "";
            this.psscode.SelectionLength = 0;
            this.psscode.SelectionStart = 0;
            this.psscode.ShortcutsEnabled = true;
            this.psscode.Size = new System.Drawing.Size(684, 58);
            this.psscode.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.psscode.TabIndex = 1;
            this.psscode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.psscode.TextMarginBottom = 0;
            this.psscode.TextMarginLeft = 3;
            this.psscode.TextMarginTop = 0;
            this.psscode.TextPlaceholder = "Enter Passcode";
            this.psscode.UseSystemPasswordChar = false;
            this.psscode.WordWrap = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCards1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(6, 10);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(136, 29);
            this.account.TabIndex = 4;
            this.account.Text = "Welcome, ";
            // 
            // LockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1102);
            this.ControlBox = false;
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LockScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LockScreen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LockScreen_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.UI.WinForms.BunifuImageButton unlockbtn;
        private Bunifu.UI.WinForms.BunifuTextBox psscode;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label account;
    }
}