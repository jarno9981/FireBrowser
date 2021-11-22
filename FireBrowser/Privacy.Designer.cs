namespace FireBrowser
{
    partial class Privacy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Privacy));
            this.nswict = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nswict
            // 
            this.nswict.BackColor = System.Drawing.Color.Transparent;
            this.nswict.Checked = false;
            this.nswict.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.nswict.CheckedSwitchColor = System.Drawing.Color.White;
            this.nswict.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.nswict.Location = new System.Drawing.Point(12, 27);
            this.nswict.Name = "nswict";
            this.nswict.OutlineThickness = 3;
            this.nswict.Size = new System.Drawing.Size(61, 26);
            this.nswict.TabIndex = 0;
            this.nswict.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.nswict.UncheckedSwitchColor = System.Drawing.Color.White;
            this.nswict.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Outline;
            this.nswict.CheckedChanged += new System.EventHandler(this.nswict_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "child-Safety";
            // 
            // Privacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 96);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nswict);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(429, 143);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(429, 143);
            this.Name = "Privacy";
            this.ShowInTaskbar = false;
            this.Text = "Privacy";
            this.Load += new System.EventHandler(this.Privacy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuToggleSwitch2 nswict;
        private System.Windows.Forms.Label label1;
    }
}