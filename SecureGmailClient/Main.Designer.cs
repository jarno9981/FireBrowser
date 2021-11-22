namespace SecureGmailClient
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.newWeb = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.newWeb)).BeginInit();
            this.SuspendLayout();
            // 
            // newWeb
            // 
            this.newWeb.CreationProperties = null;
            this.newWeb.DefaultBackgroundColor = System.Drawing.Color.White;
            this.newWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newWeb.Location = new System.Drawing.Point(0, 0);
            this.newWeb.Name = "newWeb";
            this.newWeb.Size = new System.Drawing.Size(1295, 830);
            this.newWeb.Source = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            this.newWeb.TabIndex = 0;
            this.newWeb.ZoomFactor = 1D;
            this.newWeb.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.newWeb_CoreWebView2InitializationCompleted);
            this.newWeb.NavigationStarting += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationStartingEventArgs>(this.newWeb_NavigationStarting);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 830);
            this.Controls.Add(this.newWeb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure-Client";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newWeb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 newWeb;
    }
}

