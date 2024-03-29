﻿namespace MiiCloner
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
            this.lblSaveGameMngr = new System.Windows.Forms.LinkLabel();
            this.lblCustomMKWiiki = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(13, 13);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(437, 468);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = resources.GetString("lblAbout.Text");
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // lblMiiInstaller
            // 
            this.lblMiiInstaller.AutoSize = true;
            this.lblMiiInstaller.Location = new System.Drawing.Point(12, 338);
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
            this.lblMiiExtractor.Location = new System.Drawing.Point(59, 378);
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
            this.lblGitHub.Location = new System.Drawing.Point(13, 482);
            this.lblGitHub.Name = "lblGitHub";
            this.lblGitHub.Size = new System.Drawing.Size(40, 13);
            this.lblGitHub.TabIndex = 4;
            this.lblGitHub.TabStop = true;
            this.lblGitHub.Text = "GitHub";
            this.lblGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGitHub_LinkClicked);
            // 
            // lblSaveGameMngr
            // 
            this.lblSaveGameMngr.AutoSize = true;
            this.lblSaveGameMngr.Location = new System.Drawing.Point(265, 403);
            this.lblSaveGameMngr.Name = "lblSaveGameMngr";
            this.lblSaveGameMngr.Size = new System.Drawing.Size(126, 13);
            this.lblSaveGameMngr.TabIndex = 5;
            this.lblSaveGameMngr.TabStop = true;
            this.lblSaveGameMngr.Text = "SaveGame Manager GX.";
            this.lblSaveGameMngr.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSaveGameMngr_LinkClicked);
            // 
            // lblCustomMKWiiki
            // 
            this.lblCustomMKWiiki.AutoSize = true;
            this.lblCustomMKWiiki.Location = new System.Drawing.Point(86, 298);
            this.lblCustomMKWiiki.Name = "lblCustomMKWiiki";
            this.lblCustomMKWiiki.Size = new System.Drawing.Size(122, 13);
            this.lblCustomMKWiiki.TabIndex = 6;
            this.lblCustomMKWiiki.TabStop = true;
            this.lblCustomMKWiiki.Text = "Custom Mario Kart Wiiki.";
            this.lblCustomMKWiiki.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCustomMKWiiki_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 506);
            this.Controls.Add(this.lblCustomMKWiiki);
            this.Controls.Add(this.lblSaveGameMngr);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.LinkLabel lblSaveGameMngr;
        private System.Windows.Forms.LinkLabel lblCustomMKWiiki;
    }
}