﻿
namespace FireBrowser.forms
{ 

    partial class BrowserTaskMan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserTaskMan));
            this.lsbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lsbox
            // 
            this.lsbox.FormattingEnabled = true;
            this.lsbox.ItemHeight = 16;
            this.lsbox.Items.AddRange(new object[] {
            "Browser",
            "WebView",
            "Gpu-Cache"});
            this.lsbox.Location = new System.Drawing.Point(12, 12);
            this.lsbox.Name = "lsbox";
            this.lsbox.Size = new System.Drawing.Size(776, 420);
            this.lsbox.TabIndex = 0;
            // 
            // BrowserTaskMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrowserTaskMan";
            this.Text = "BrowserTaskMan-Alpha.Test";
            this.Load += new System.EventHandler(this.BrowserTaskMan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lsbox;
    }
}