
namespace FireBrowser
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.account = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.unlockbtn = new Bunifu.UI.WinForms.BunifuImageButton();
            this.psscode = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.account.AutoSize = true;
            this.account.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.account.Location = new System.Drawing.Point(8, 516);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(136, 29);
            this.account.TabIndex = 4;
            this.account.Text = "Welcome, ";
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(892, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
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
            this.unlockbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.unlockbtn.BackColor = System.Drawing.Color.Transparent;
            this.unlockbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.unlockbtn.ErrorImage = ((System.Drawing.Image)(resources.GetObject("unlockbtn.ErrorImage")));
            this.unlockbtn.FadeWhenInactive = false;
            this.unlockbtn.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.unlockbtn.Image = global::FireBrowser.Properties.Resources.icons8_key_2_32;
            this.unlockbtn.ImageActive = null;
            this.unlockbtn.ImageLocation = null;
            this.unlockbtn.ImageMargin = 20;
            this.unlockbtn.ImageSize = new System.Drawing.Size(40, 38);
            this.unlockbtn.ImageZoomSize = new System.Drawing.Size(60, 58);
            this.unlockbtn.InitialImage = ((System.Drawing.Image)(resources.GetObject("unlockbtn.InitialImage")));
            this.unlockbtn.Location = new System.Drawing.Point(1094, 7);
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
            this.unlockbtn.Zoom = 20;
            this.unlockbtn.ZoomSpeed = 10;
            this.unlockbtn.Click += new System.EventHandler(this.unlockbtn_Click);
            // 
            // psscode
            // 
            this.psscode.AcceptsReturn = false;
            this.psscode.AcceptsTab = false;
            this.psscode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.psscode.AnimationSpeed = 200;
            this.psscode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.psscode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.psscode.AutoSizeHeight = true;
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
            this.psscode.Location = new System.Drawing.Point(186, 12);
            this.psscode.MaxLength = 32767;
            this.psscode.MinimumSize = new System.Drawing.Size(1, 1);
            this.psscode.Modified = false;
            this.psscode.Multiline = false;
            this.psscode.Name = "psscode";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.psscode.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.psscode.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.psscode.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.psscode.OnIdleState = stateProperties4;
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
            this.psscode.Size = new System.Drawing.Size(863, 46);
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
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FireBrowser.Properties.Resources.icons8_lock_32;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Locked";
            // 
            // LockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1166, 564);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.account);
            this.Controls.Add(this.psscode);
            this.Controls.Add(this.unlockbtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LockScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LockScreen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LockScreen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LockScreen_FormClosed);
            this.Load += new System.EventHandler(this.LockScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton unlockbtn;
        private Bunifu.UI.WinForms.BunifuTextBox psscode;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label account;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}