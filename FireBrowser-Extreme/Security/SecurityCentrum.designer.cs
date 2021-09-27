
namespace FireBrowser_Extreme.Security
{
    partial class SecurityCentrum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityCentrum));
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuGradientPanel2 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lv1 = new System.Windows.Forms.RichTextBox();
            this.lv2 = new System.Windows.Forms.RichTextBox();
            this.sep1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.sep2 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.check = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 20;
            this.bunifuGradientPanel1.Controls.Add(this.check);
            this.bunifuGradientPanel1.Controls.Add(this.lv1);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(68, 47);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(362, 492);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.BorderRadius = 20;
            this.bunifuGradientPanel2.Controls.Add(this.check2);
            this.bunifuGradientPanel2.Controls.Add(this.lv2);
            this.bunifuGradientPanel2.Controls.Add(this.label2);
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(92)))), ((int)(((byte)(188)))));
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.Color.DeepPink;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(60)))), ((int)(((byte)(212)))));
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(529, 47);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(362, 492);
            this.bunifuGradientPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fast / Secure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Slower / Higher Secure";
            // 
            // lv1
            // 
            this.lv1.Location = new System.Drawing.Point(28, 94);
            this.lv1.Name = "lv1";
            this.lv1.ReadOnly = true;
            this.lv1.ShortcutsEnabled = false;
            this.lv1.Size = new System.Drawing.Size(302, 294);
            this.lv1.TabIndex = 1;
            this.lv1.TabStop = false;
            this.lv1.Text = "Normal - security\n\n*few things blocked\n*anti track only ask\n*basis data blocking";
            // 
            // lv2
            // 
            this.lv2.Location = new System.Drawing.Point(33, 94);
            this.lv2.Name = "lv2";
            this.lv2.ReadOnly = true;
            this.lv2.ShortcutsEnabled = false;
            this.lv2.Size = new System.Drawing.Size(302, 294);
            this.lv2.TabIndex = 2;
            this.lv2.TabStop = false;
            this.lv2.Text = "High - security * note may brake websites\n\n*all blocking\n*anti tracking force\n*on" +
    "ly neaserry cookies\n*advenced data blocking\n*no autofill web-id";
            // 
            // sep1
            // 
            this.sep1.BackColor = System.Drawing.Color.Transparent;
            this.sep1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sep1.BackgroundImage")));
            this.sep1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sep1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.sep1.LineColor = System.Drawing.Color.Maroon;
            this.sep1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.sep1.LineThickness = 2;
            this.sep1.Location = new System.Drawing.Point(68, 546);
            this.sep1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sep1.Name = "sep1";
            this.sep1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.sep1.Size = new System.Drawing.Size(362, 30);
            this.sep1.TabIndex = 2;
            // 
            // sep2
            // 
            this.sep2.BackColor = System.Drawing.Color.Transparent;
            this.sep2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sep2.BackgroundImage")));
            this.sep2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sep2.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.sep2.LineColor = System.Drawing.Color.Silver;
            this.sep2.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.sep2.LineThickness = 2;
            this.sep2.Location = new System.Drawing.Point(529, 546);
            this.sep2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sep2.Name = "sep2";
            this.sep2.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.sep2.Size = new System.Drawing.Size(362, 30);
            this.sep2.TabIndex = 3;
            // 
            // check
            // 
            this.check.AutoSize = true;
            this.check.Checked = true;
            this.check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.check.Location = new System.Drawing.Point(160, 454);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(49, 21);
            this.check.TabIndex = 2;
            this.check.Text = "On";
            this.check.UseVisualStyleBackColor = true;
            this.check.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(149, 454);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(49, 21);
            this.check2.TabIndex = 3;
            this.check2.Text = "Off";
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.check2_CheckedChanged);
            // 
            // update
            // 
            this.update.Interval = 250;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // SecurityCentrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 624);
            this.Controls.Add(this.sep2);
            this.Controls.Add(this.sep1);
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(997, 671);
            this.MinimumSize = new System.Drawing.Size(997, 671);
            this.Name = "SecurityCentrum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SecurityCentrum";
            this.Load += new System.EventHandler(this.SecurityCentrum_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuGradientPanel2.ResumeLayout(false);
            this.bunifuGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.CheckBox check;
        private System.Windows.Forms.RichTextBox lv1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel2;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.RichTextBox lv2;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuSeparator sep1;
        private Bunifu.UI.WinForms.BunifuSeparator sep2;
        private System.Windows.Forms.Timer update;
    }
}