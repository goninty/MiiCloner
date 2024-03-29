﻿namespace MiiCloner
{
    partial class OpenMiiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpenMiiForm));
            this.btnOpenMii = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenMii
            // 
            this.btnOpenMii.AllowDrop = true;
            this.btnOpenMii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenMii.Location = new System.Drawing.Point(0, 0);
            this.btnOpenMii.Name = "btnOpenMii";
            this.btnOpenMii.Size = new System.Drawing.Size(208, 65);
            this.btnOpenMii.TabIndex = 0;
            this.btnOpenMii.Text = "Click here or drag and drop to load .mii, .miigx and .mae files";
            this.btnOpenMii.UseVisualStyleBackColor = true;
            this.btnOpenMii.Click += new System.EventHandler(this.btnOpenMii_Click);
            this.btnOpenMii.DragDrop += new System.Windows.Forms.DragEventHandler(this.btnOpenMii_DragDrop);
            this.btnOpenMii.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnOpenMii_DragEnter);
            // 
            // OpenMiiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 65);
            this.Controls.Add(this.btnOpenMii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OpenMiiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mii Cloner";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.OpenMiiForm_HelpButtonClicked);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenMii;
    }
}