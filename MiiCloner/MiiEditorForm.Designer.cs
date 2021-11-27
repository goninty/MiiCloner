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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiiEditorForm));
            this.lblMiiName = new System.Windows.Forms.Label();
            this.gbMiiName = new System.Windows.Forms.GroupBox();
            this.txtMiiName = new System.Windows.Forms.TextBox();
            this.gbCreatorName = new System.Windows.Forms.GroupBox();
            this.txtCreatorName = new System.Windows.Forms.TextBox();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.pbGender = new System.Windows.Forms.PictureBox();
            this.gbFavorite = new System.Windows.Forms.GroupBox();
            this.pbFavorite = new System.Windows.Forms.PictureBox();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.pnColorFill = new System.Windows.Forms.Panel();
            this.gbMonth = new System.Windows.Forms.GroupBox();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.gbDay = new System.Windows.Forms.GroupBox();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.gbBirthday = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnMogi = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.gbMogiTagStyle = new System.Windows.Forms.GroupBox();
            this.chbCustomiseTag = new System.Windows.Forms.CheckBox();
            this.cbMogiTag = new System.Windows.Forms.ComboBox();
            this.gbMiiName.SuspendLayout();
            this.gbCreatorName.SuspendLayout();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGender)).BeginInit();
            this.gbFavorite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavorite)).BeginInit();
            this.gbColor.SuspendLayout();
            this.gbMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            this.gbDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            this.gbBirthday.SuspendLayout();
            this.gbMogiTagStyle.SuspendLayout();
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
            this.txtMiiName.Font = new System.Drawing.Font("CTMKF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiiName.Location = new System.Drawing.Point(6, 19);
            this.txtMiiName.MaxLength = 10;
            this.txtMiiName.Name = "txtMiiName";
            this.txtMiiName.Size = new System.Drawing.Size(242, 25);
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
            this.txtCreatorName.Font = new System.Drawing.Font("CTMKF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreatorName.Location = new System.Drawing.Point(6, 19);
            this.txtCreatorName.MaxLength = 10;
            this.txtCreatorName.Name = "txtCreatorName";
            this.txtCreatorName.Size = new System.Drawing.Size(242, 25);
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
            // pbGender
            // 
            this.pbGender.Enabled = false;
            this.pbGender.Location = new System.Drawing.Point(15, 19);
            this.pbGender.Name = "pbGender";
            this.pbGender.Size = new System.Drawing.Size(51, 51);
            this.pbGender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGender.TabIndex = 0;
            this.pbGender.TabStop = false;
            this.pbGender.Click += new System.EventHandler(this.pbGender_Click);
            this.pbGender.DoubleClick += new System.EventHandler(this.pbGender_DoubleClick);
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
            // pbFavorite
            // 
            this.pbFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFavorite.Enabled = false;
            this.pbFavorite.Location = new System.Drawing.Point(16, 25);
            this.pbFavorite.Name = "pbFavorite";
            this.pbFavorite.Size = new System.Drawing.Size(48, 39);
            this.pbFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFavorite.TabIndex = 1;
            this.pbFavorite.TabStop = false;
            this.pbFavorite.Click += new System.EventHandler(this.pbFavorite_Click);
            this.pbFavorite.DoubleClick += new System.EventHandler(this.pbFavorite_DoubleClick);
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
            // pnColorFill
            // 
            this.pnColorFill.Enabled = false;
            this.pnColorFill.Location = new System.Drawing.Point(15, 19);
            this.pnColorFill.Name = "pnColorFill";
            this.pnColorFill.Size = new System.Drawing.Size(51, 51);
            this.pnColorFill.TabIndex = 0;
            this.pnColorFill.Click += new System.EventHandler(this.pnColorFill_Click);
            this.pnColorFill.DoubleClick += new System.EventHandler(this.pnColorFill_DoubleClick);
            // 
            // gbMonth
            // 
            this.gbMonth.Controls.Add(this.nudMonth);
            this.gbMonth.Location = new System.Drawing.Point(6, 19);
            this.gbMonth.Name = "gbMonth";
            this.gbMonth.Size = new System.Drawing.Size(118, 55);
            this.gbMonth.TabIndex = 3;
            this.gbMonth.TabStop = false;
            this.gbMonth.Text = "Month";
            // 
            // nudMonth
            // 
            this.nudMonth.Enabled = false;
            this.nudMonth.Location = new System.Drawing.Point(6, 22);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(106, 20);
            this.nudMonth.TabIndex = 1;
            this.nudMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.ValueChanged += new System.EventHandler(this.nudMonth_ValueChanged);
            // 
            // gbDay
            // 
            this.gbDay.Controls.Add(this.nudDay);
            this.gbDay.Location = new System.Drawing.Point(131, 19);
            this.gbDay.Name = "gbDay";
            this.gbDay.Size = new System.Drawing.Size(118, 55);
            this.gbDay.TabIndex = 4;
            this.gbDay.TabStop = false;
            this.gbDay.Text = "Day";
            // 
            // nudDay
            // 
            this.nudDay.Enabled = false;
            this.nudDay.Location = new System.Drawing.Point(6, 22);
            this.nudDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(106, 20);
            this.nudDay.TabIndex = 2;
            this.nudDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnMogi
            // 
            this.btnMogi.Location = new System.Drawing.Point(12, 412);
            this.btnMogi.Name = "btnMogi";
            this.btnMogi.Size = new System.Drawing.Size(255, 48);
            this.btnMogi.TabIndex = 11;
            this.btnMogi.Text = "Generate 26 Miis with A-Z tags for Mogi Lounge";
            this.btnMogi.UseVisualStyleBackColor = true;
            this.btnMogi.Click += new System.EventHandler(this.btnMogi_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(143, 315);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(124, 29);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Export Clone";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // gbMogiTagStyle
            // 
            this.gbMogiTagStyle.Controls.Add(this.chbCustomiseTag);
            this.gbMogiTagStyle.Controls.Add(this.cbMogiTag);
            this.gbMogiTagStyle.Location = new System.Drawing.Point(12, 350);
            this.gbMogiTagStyle.Name = "gbMogiTagStyle";
            this.gbMogiTagStyle.Size = new System.Drawing.Size(255, 54);
            this.gbMogiTagStyle.TabIndex = 13;
            this.gbMogiTagStyle.TabStop = false;
            this.gbMogiTagStyle.Text = "Mogi Tag Style";
            // 
            // chbCustomiseTag
            // 
            this.chbCustomiseTag.AutoSize = true;
            this.chbCustomiseTag.Location = new System.Drawing.Point(137, 23);
            this.chbCustomiseTag.Name = "chbCustomiseTag";
            this.chbCustomiseTag.Size = new System.Drawing.Size(96, 17);
            this.chbCustomiseTag.TabIndex = 1;
            this.chbCustomiseTag.Text = "Customise Tag";
            this.chbCustomiseTag.UseVisualStyleBackColor = true;
            this.chbCustomiseTag.CheckedChanged += new System.EventHandler(this.chbCustomiseTag_CheckedChanged);
            // 
            // cbMogiTag
            // 
            this.cbMogiTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMogiTag.Font = new System.Drawing.Font("CTMKF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMogiTag.FormattingEnabled = true;
            this.cbMogiTag.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbMogiTag.ItemHeight = 16;
            this.cbMogiTag.Items.AddRange(new object[] {
            "A",
            "[A]",
            "『A』",
            "A♪",
            "A☆",
            "A★",
            "A◇",
            "A◆"});
            this.cbMogiTag.Location = new System.Drawing.Point(12, 19);
            this.cbMogiTag.MaxLength = 9;
            this.cbMogiTag.Name = "cbMogiTag";
            this.cbMogiTag.Size = new System.Drawing.Size(106, 24);
            this.cbMogiTag.TabIndex = 0;
            // 
            // MiiEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 471);
            this.Controls.Add(this.gbMogiTagStyle);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MiiEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mii Cloner";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MiiEditorForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.MiiClonerForm_Load);
            this.gbMiiName.ResumeLayout(false);
            this.gbMiiName.PerformLayout();
            this.gbCreatorName.ResumeLayout(false);
            this.gbCreatorName.PerformLayout();
            this.gbGender.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGender)).EndInit();
            this.gbFavorite.ResumeLayout(false);
            this.gbFavorite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavorite)).EndInit();
            this.gbColor.ResumeLayout(false);
            this.gbMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            this.gbDay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            this.gbBirthday.ResumeLayout(false);
            this.gbMogiTagStyle.ResumeLayout(false);
            this.gbMogiTagStyle.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbDay;
        private System.Windows.Forms.GroupBox gbBirthday;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnMogi;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel pnColorFill;
        private System.Windows.Forms.PictureBox pbGender;
        private System.Windows.Forms.PictureBox pbFavorite;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.GroupBox gbMogiTagStyle;
        private System.Windows.Forms.ComboBox cbMogiTag;
        private System.Windows.Forms.CheckBox chbCustomiseTag;
    }
}

