
namespace FireBrowser_Extreme.forms
{
    partial class AudioTuner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioTuner));
            this.label1 = new System.Windows.Forms.Label();
            this.drivers = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nothing To See Here Only Adapts Sound For Beter Kwalitie";
            // 
            // drivers
            // 
            this.drivers.DetectUrls = false;
            this.drivers.Enabled = false;
            this.drivers.Location = new System.Drawing.Point(16, 61);
            this.drivers.Name = "drivers";
            this.drivers.Size = new System.Drawing.Size(379, 81);
            this.drivers.TabIndex = 1;
            this.drivers.Text = "Chromium Web Driver 93.xx.xx\nwebview2 audio driver 93.1x.xx";
            // 
            // AudioTuner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 160);
            this.Controls.Add(this.drivers);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AudioTuner";
            this.ShowInTaskbar = false;
            this.Text = "Audio-Checker";
            this.Load += new System.EventHandler(this.AudioTuner_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AudioTuner_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox drivers;
    }
}