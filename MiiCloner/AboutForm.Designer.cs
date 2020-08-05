namespace MiiCloner
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblMiiInstaller = new System.Windows.Forms.LinkLabel();
            this.lblMiiExtractor = new System.Windows.Forms.LinkLabel();
            this.lblGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(13, 13);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(437, 273);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            // 
            // lblMiiInstaller
            // 
            this.lblMiiInstaller.AutoSize = true;
            this.lblMiiInstaller.Location = new System.Drawing.Point(12, 182);
            this.lblMiiInstaller.Name = "lblMiiInstaller";
            this.lblMiiInstaller.Size = new System.Drawing.Size(62, 13);
            this.lblMiiInstaller.TabIndex = 2;
            this.lblMiiInstaller.TabStop = true;
            this.lblMiiInstaller.Text = "Mii Installer.";
            this.lblMiiInstaller.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMiiInstaller_LinkClicked);
            // 
            // lblMiiExtractor
            // 
            this.lblMiiExtractor.AutoSize = true;
            this.lblMiiExtractor.Location = new System.Drawing.Point(59, 221);
            this.lblMiiExtractor.Name = "lblMiiExtractor";
            this.lblMiiExtractor.Size = new System.Drawing.Size(68, 13);
            this.lblMiiExtractor.TabIndex = 3;
            this.lblMiiExtractor.TabStop = true;
            this.lblMiiExtractor.Text = "Mii Extractor.";
            this.lblMiiExtractor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMiiExtractor_LinkClicked);
            // 
            // lblGitHub
            // 
            this.lblGitHub.AutoSize = true;
            this.lblGitHub.Location = new System.Drawing.Point(13, 287);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(40, 13);
            this.lblGitHub.TabIndex = 4;
            this.lblGitHub.TabStop = true;
            this.lblGitHub.Text = "GitHub";
            this.lblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGitHub_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 315);
            this.Controls.Add(this.lblGitHub);
            this.Controls.Add(this.lblMiiExtractor);
            this.Controls.Add(this.lblMiiInstaller);
            this.Controls.Add(this.lblAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowInTaskbar = false;
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.LinkLabel lblMiiInstaller;
        private System.Windows.Forms.LinkLabel lblMiiExtractor;
        private System.Windows.Forms.LinkLabel lblGitHub;
    }
}