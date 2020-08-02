namespace MiiCloner
{
    partial class MiiEditorForm
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
            this.lblMiiName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMiiName
            // 
            this.lblMiiName.AutoSize = true;
            this.lblMiiName.Font = new System.Drawing.Font("CTMKF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiiName.Location = new System.Drawing.Point(178, 103);
            this.lblMiiName.Name = "lblMiiName";
            this.lblMiiName.Size = new System.Drawing.Size(0, 16);
            this.lblMiiName.TabIndex = 0;
            // 
            // MiiEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMiiName);
            this.Name = "MiiEditorForm";
            this.Text = "Mii Cloner";
            this.Load += new System.EventHandler(this.MiiClonerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiiName;
    }
}

