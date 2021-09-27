
namespace FireBrowser_Extreme.forms
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
            this.ClosePnl = new System.Windows.Forms.Button();
            this.TuneAudio = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Build = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.OpenSettings.Location = new System.Drawing.Point(21, 61);
            this.OpenSettings.Name = "OpenSettings";
            this.OpenSettings.Size = new System.Drawing.Size(129, 41);
            this.OpenSettings.TabIndex = 0;
            this.OpenSettings.Text = "Settings";
            this.OpenSettings.UseVisualStyleBackColor = true;
            this.OpenSettings.Click += new System.EventHandler(this.OpenSettings_Click);
            // 
            // ClosePnl
            // 
            this.ClosePnl.Location = new System.Drawing.Point(55, 9);
            this.ClosePnl.Name = "ClosePnl";
            this.ClosePnl.Size = new System.Drawing.Size(55, 29);
            this.ClosePnl.TabIndex = 1;
            this.ClosePnl.Text = "Close";
            this.ClosePnl.UseVisualStyleBackColor = true;
            this.ClosePnl.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // TuneAudio
            // 
            this.TuneAudio.Location = new System.Drawing.Point(21, 108);
            this.TuneAudio.Name = "TuneAudio";
            this.TuneAudio.Size = new System.Drawing.Size(129, 41);
            this.TuneAudio.TabIndex = 2;
            this.TuneAudio.Text = "Audio";
            this.TuneAudio.UseVisualStyleBackColor = true;
            this.TuneAudio.Click += new System.EventHandler(this.TuneAudio_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "TaskMan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(21, 202);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(129, 41);
            this.Help.TabIndex = 4;
            this.Help.Text = "Help";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Build
            // 
            this.Build.Location = new System.Drawing.Point(21, 250);
            this.Build.Name = "Build";
            this.Build.Size = new System.Drawing.Size(129, 41);
            this.Build.TabIndex = 5;
            this.Build.Text = "Build";
            this.Build.UseVisualStyleBackColor = true;
            this.Build.Click += new System.EventHandler(this.Build_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Owner:";
            // 
            // FloatingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Build);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TuneAudio);
            this.Controls.Add(this.ClosePnl);
            this.Controls.Add(this.OpenSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FloatingPanel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FloatingPanel";
            this.Load += new System.EventHandler(this.FloatingPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button ClosePnl;
        private System.Windows.Forms.Button OpenSettings;
        private System.Windows.Forms.Button TuneAudio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Build;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Label label1;
    }
}