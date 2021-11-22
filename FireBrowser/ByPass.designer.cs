namespace FireBrowser
{
    partial class ByPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ByPass));
            this.rnd = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rnd
            // 
            this.rnd.ElipseRadius = 25;
            this.rnd.TargetControl = this;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(601, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.UseSystemPasswordChar = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(620, 12);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(152, 34);
            this.pass.TabIndex = 1;
            this.pass.Text = "bypass";
            this.pass.UseVisualStyleBackColor = true;
            this.pass.Click += new System.EventHandler(this.pass_Click);
            // 
            // ByPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 59);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ByPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ByPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse rnd;
        private System.Windows.Forms.Button pass;
        private System.Windows.Forms.TextBox textBox1;
    }
}