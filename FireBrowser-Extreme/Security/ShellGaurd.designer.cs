
namespace FireBrowser_Extreme.Security
{
    partial class ShellGaurd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShellGaurd));
            this.IconShell = new System.Windows.Forms.NotifyIcon(this.components);
            this.Menu1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.security = new System.Windows.Forms.ToolStripMenuItem();
            this.settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IconShell
            // 
            this.IconShell.ContextMenuStrip = this.Menu1;
            this.IconShell.Icon = ((System.Drawing.Icon)(resources.GetObject("IconShell.Icon")));
            this.IconShell.Text = "ShellGaurd-FireBrowser";
            this.IconShell.Visible = true;
            // 
            // Menu1
            // 
            this.Menu1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.security,
            this.settings});
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(215, 84);
            // 
            // security
            // 
            this.security.Image = global::FireBrowser_Extreme.Properties.Resources.microsoft_admin_48px;
            this.security.Name = "security";
            this.security.Size = new System.Drawing.Size(214, 26);
            this.security.Text = "Security Centrum";
            this.security.Click += new System.EventHandler(this.security_Click);
            // 
            // settings
            // 
            this.settings.Image = global::FireBrowser_Extreme.Properties.Resources.settings_24px;
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(214, 26);
            this.settings.Text = "Settings";
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // ShellGaurd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 154);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShellGaurd";
            this.ShowInTaskbar = false;
            this.Text = "ShellGaurd";
            this.Load += new System.EventHandler(this.ShellGaurd_Load);
            this.Menu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon IconShell;
        private System.Windows.Forms.ContextMenuStrip Menu1;
        private System.Windows.Forms.ToolStripMenuItem security;
        private System.Windows.Forms.ToolStripMenuItem settings;
    }
}