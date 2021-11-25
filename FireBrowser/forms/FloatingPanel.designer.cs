
namespace FireBrowser.forms
{
    partial class FloatingPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FloatingPanel));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.OpenSettings = new System.Windows.Forms.Button();
            this.TuneAudio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Build = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // OpenSettings
            // 
            this.OpenSettings.Image = global::FireBrowser.Properties.Resources.settings_24px;
            this.OpenSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OpenSettings.Location = new System.Drawing.Point(12, 77);
            this.OpenSettings.Name = "OpenSettings";
            this.OpenSettings.Size = new System.Drawing.Size(268, 41);
            this.OpenSettings.TabIndex = 0;
            this.OpenSettings.Text = "Settings";
            this.OpenSettings.UseVisualStyleBackColor = true;
            this.OpenSettings.Click += new System.EventHandler(this.OpenSettings_Click);
            // 
            // TuneAudio
            // 
            this.TuneAudio.Image = global::FireBrowser.Properties.Resources.icons8_sound_32;
            this.TuneAudio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TuneAudio.Location = new System.Drawing.Point(12, 124);
            this.TuneAudio.Name = "TuneAudio";
            this.TuneAudio.Size = new System.Drawing.Size(268, 41);
            this.TuneAudio.TabIndex = 2;
            this.TuneAudio.Text = "Audio";
            this.TuneAudio.UseVisualStyleBackColor = true;
            this.TuneAudio.Click += new System.EventHandler(this.TuneAudio_Click);
            // 
            // button1
            // 
            this.button1.Image = global::FireBrowser.Properties.Resources.icons8_tasklist_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(12, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "TaskMan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Help
            // 
            this.Help.Image = global::FireBrowser.Properties.Resources.icons8_help_32;
            this.Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Help.Location = new System.Drawing.Point(12, 218);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(268, 41);
            this.Help.TabIndex = 4;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Build
            // 
            this.Build.Image = global::FireBrowser.Properties.Resources.icons8_rest_api_32;
            this.Build.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Build.Location = new System.Drawing.Point(12, 266);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(268, 41);
            this.Build.TabIndex = 5;
            this.Build.Text = "Build";
            this.Build.UseVisualStyleBackColor = true;
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Owner:";
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::FireBrowser.Properties.Resources.close_window_48px;
            this.BtnClose.Location = new System.Drawing.Point(250, 9);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 28);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnClose.TabIndex = 7;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(12, 7);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(35, 35);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 8;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // FloatingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TuneAudio);
            this.Controls.Add(this.OpenSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FloatingPanel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FloatingPanel";
            this.Load += new System.EventHandler(this.FloatingPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button OpenSettings;
        private System.Windows.Forms.Button TuneAudio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Build;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnClose;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}