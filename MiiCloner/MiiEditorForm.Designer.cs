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
            this.gbMiiName = new System.Windows.Forms.GroupBox();
            this.txtMiiName = new System.Windows.Forms.TextBox();
            this.gbCreatorName = new System.Windows.Forms.GroupBox();
            this.txtCreatorName = new System.Windows.Forms.TextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.gbFavorite = new System.Windows.Forms.GroupBox();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.gbMonth = new System.Windows.Forms.GroupBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.gbDay = new System.Windows.Forms.GroupBox();
            this.gbBirthday = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnMogi = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.pnColorFill = new System.Windows.Forms.Panel();
            this.pbGender = new System.Windows.Forms.PictureBox();
            this.pbFavorite = new System.Windows.Forms.PictureBox();
            this.gbMiiName.SuspendLayout();
            this.gbCreatorName.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.gbFavorite.SuspendLayout();
            this.gbColor.SuspendLayout();
            this.gbMonth.SuspendLayout();
            this.gbDay.SuspendLayout();
            this.gbBirthday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavorite)).BeginInit();
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
            // gbMiiName
            // 
            this.gbMiiName.Controls.Add(this.txtMiiName);
            this.gbMiiName.Location = new System.Drawing.Point(12, 12);
            this.gbMiiName.Name = "gbMiiName";
            this.gbMiiName.Size = new System.Drawing.Size(255, 55);
            this.gbMiiName.TabIndex = 1;
            this.gbMiiName.TabStop = false;
            this.gbMiiName.Text = "Mii Name";
            // 
            // txtMiiName
            // 
            this.txtMiiName.Enabled = false;
            this.txtMiiName.Location = new System.Drawing.Point(6, 21);
            this.txtMiiName.Name = "txtMiiName";
            this.txtMiiName.Size = new System.Drawing.Size(242, 20);
            this.txtMiiName.TabIndex = 0;
            this.txtMiiName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbCreatorName
            // 
            this.gbCreatorName.Controls.Add(this.txtCreatorName);
            this.gbCreatorName.Location = new System.Drawing.Point(12, 73);
            this.gbCreatorName.Name = "gbCreatorName";
            this.gbCreatorName.Size = new System.Drawing.Size(255, 55);
            this.gbCreatorName.TabIndex = 2;
            this.gbCreatorName.TabStop = false;
            this.gbCreatorName.Text = "Creator Name";
            // 
            // txtCreatorName
            // 
            this.txtCreatorName.Enabled = false;
            this.txtCreatorName.Location = new System.Drawing.Point(6, 21);
            this.txtCreatorName.Name = "txtCreatorName";
            this.txtCreatorName.Size = new System.Drawing.Size(242, 20);
            this.txtCreatorName.TabIndex = 0;
            this.txtCreatorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbGender
            // 
            this.gbGender.Controls.Add(this.pbGender);
            this.gbGender.Location = new System.Drawing.Point(12, 134);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(81, 81);
            this.gbGender.TabIndex = 5;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // gbFavorite
            // 
            this.gbFavorite.Controls.Add(this.pbFavorite);
            this.gbFavorite.Location = new System.Drawing.Point(186, 134);
            this.gbFavorite.Name = "gbFavorite";
            this.gbFavorite.Size = new System.Drawing.Size(81, 81);
            this.gbFavorite.TabIndex = 6;
            this.gbFavorite.TabStop = false;
            this.gbFavorite.Text = "Favorite";
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.pnColorFill);
            this.gbColor.Location = new System.Drawing.Point(99, 134);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(81, 81);
            this.gbColor.TabIndex = 7;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color";
            // 
            // gbMonth
            // 
            this.gbMonth.Controls.Add(this.txtMonth);
            this.gbMonth.Location = new System.Drawing.Point(6, 19);
            this.gbMonth.Name = "gbMonth";
            this.gbMonth.Size = new System.Drawing.Size(118, 55);
            this.gbMonth.TabIndex = 3;
            this.gbMonth.TabStop = false;
            this.gbMonth.Text = "Month";
            // 
            // txtMonth
            // 
            this.txtMonth.Enabled = false;
            this.txtMonth.Location = new System.Drawing.Point(6, 21);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(106, 20);
            this.txtMonth.TabIndex = 0;
            this.txtMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDay
            // 
            this.txtDay.Enabled = false;
            this.txtDay.Location = new System.Drawing.Point(6, 21);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(106, 20);
            this.txtDay.TabIndex = 0;
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbDay
            // 
            this.gbDay.Controls.Add(this.txtDay);
            this.gbDay.Location = new System.Drawing.Point(131, 19);
            this.gbDay.Name = "gbDay";
            this.gbDay.Size = new System.Drawing.Size(118, 55);
            this.gbDay.TabIndex = 4;
            this.gbDay.TabStop = false;
            this.gbDay.Text = "Day";
            // 
            // gbBirthday
            // 
            this.gbBirthday.Controls.Add(this.gbMonth);
            this.gbBirthday.Controls.Add(this.gbDay);
            this.gbBirthday.Location = new System.Drawing.Point(12, 221);
            this.gbBirthday.Name = "gbBirthday";
            this.gbBirthday.Size = new System.Drawing.Size(255, 88);
            this.gbBirthday.TabIndex = 8;
            this.gbBirthday.TabStop = false;
            this.gbBirthday.Text = "Birthday";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 315);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 29);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnMogi
            // 
            this.btnMogi.Location = new System.Drawing.Point(12, 350);
            this.btnMogi.Name = "btnMogi";
            this.btnMogi.Size = new System.Drawing.Size(255, 48);
            this.btnMogi.TabIndex = 11;
            this.btnMogi.Text = "Generate 26 alphabetically lettered miis for Mogi Lounge";
            this.btnMogi.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(143, 315);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(124, 29);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export Clone";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // pnColorFill
            // 
            this.pnColorFill.Location = new System.Drawing.Point(15, 19);
            this.pnColorFill.Name = "pnColorFill";
            this.pnColorFill.Size = new System.Drawing.Size(51, 51);
            this.pnColorFill.TabIndex = 0;
            // 
            // pbGender
            // 
            this.pbGender.Location = new System.Drawing.Point(15, 19);
            this.pbGender.Name = "pbGender";
            this.pbGender.Size = new System.Drawing.Size(51, 51);
            this.pbGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGender.TabIndex = 0;
            this.pbGender.TabStop = false;
            // 
            // pbFavorite
            // 
            this.pbFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFavorite.Location = new System.Drawing.Point(16, 25);
            this.pbFavorite.Name = "pbFavorite";
            this.pbFavorite.Size = new System.Drawing.Size(48, 39);
            this.pbFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFavorite.TabIndex = 1;
            this.pbFavorite.TabStop = false;
            // 
            // MiiEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 412);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnMogi);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbBirthday);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.gbFavorite);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.gbCreatorName);
            this.Controls.Add(this.gbMiiName);
            this.Controls.Add(this.lblMiiName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiiEditorForm";
            this.Text = "Mii Cloner";
            this.Load += new System.EventHandler(this.MiiClonerForm_Load);
            this.gbMiiName.ResumeLayout(false);
            this.gbMiiName.PerformLayout();
            this.gbCreatorName.ResumeLayout(false);
            this.gbCreatorName.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbFavorite.ResumeLayout(false);
            this.gbFavorite.PerformLayout();
            this.gbColor.ResumeLayout(false);
            this.gbMonth.ResumeLayout(false);
            this.gbMonth.PerformLayout();
            this.gbDay.ResumeLayout(false);
            this.gbDay.PerformLayout();
            this.gbBirthday.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavorite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMiiName;
        private System.Windows.Forms.GroupBox gbMiiName;
        private System.Windows.Forms.TextBox txtMiiName;
        private System.Windows.Forms.GroupBox gbCreatorName;
        private System.Windows.Forms.TextBox txtCreatorName;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.GroupBox gbFavorite;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.GroupBox gbMonth;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.GroupBox gbDay;
        private System.Windows.Forms.GroupBox gbBirthday;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnMogi;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pnColorFill;
        private System.Windows.Forms.PictureBox pbGender;
        private System.Windows.Forms.PictureBox pbFavorite;
    }
}

