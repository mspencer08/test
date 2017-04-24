﻿namespace MtEnhancedTradosPlugin
{
    partial class MtProviderConfDialog
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboProvider = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxMT = new System.Windows.Forms.GroupBox();
            this.btnDeleteSavedMicrosoftCreds = new System.Windows.Forms.Button();
            this.chkCatId = new System.Windows.Forms.CheckBox();
            this.txtCatId = new System.Windows.Forms.TextBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.lblClientSecret = new System.Windows.Forms.Label();
            this.chkSaveCred = new System.Windows.Forms.CheckBox();
            this.txtClientSecret = new System.Windows.Forms.TextBox();
            this.groupBoxGT = new System.Windows.Forms.GroupBox();
            this.btnDeleteSavedGoogleKey = new System.Windows.Forms.Button();
            this.chkSaveKey = new System.Windows.Forms.CheckBox();
            this.textApiKey = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBoxPostedit = new System.Windows.Forms.GroupBox();
            this.txtPostEditFileName = new System.Windows.Forms.TextBox();
            this.btnBrowsePostEditFile = new System.Windows.Forms.Button();
            this.groupBoxPreedit = new System.Windows.Forms.GroupBox();
            this.txtPreEditFileName = new System.Windows.Forms.TextBox();
            this.btnBrowsePreEdit = new System.Windows.Forms.Button();
            this.chkResendDrafts = new System.Windows.Forms.CheckBox();
            this.chkUsePostEdit = new System.Windows.Forms.CheckBox();
            this.chkUsePreEdit = new System.Windows.Forms.CheckBox();
            this.chkPlainTextOnly = new System.Windows.Forms.CheckBox();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxMT.SuspendLayout();
            this.groupBoxGT.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBoxPostedit.SuspendLayout();
            this.groupBoxPreedit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(275, 378);
            this.btn_OK.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(100, 28);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "&OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(381, 378);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(100, 28);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "&Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboProvider);
            this.groupBox3.Location = new System.Drawing.Point(3, 5);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(443, 68);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose MT provider";
            // 
            // comboProvider
            // 
            this.comboProvider.BackColor = System.Drawing.SystemColors.Window;
            this.comboProvider.FormattingEnabled = true;
            this.comboProvider.Items.AddRange(new object[] {
            "Google Translate",
            "Microsoft Translator"});
            this.comboProvider.Location = new System.Drawing.Point(6, 20);
            this.comboProvider.Name = "comboProvider";
            this.comboProvider.Size = new System.Drawing.Size(431, 24);
            this.comboProvider.TabIndex = 0;
            this.comboProvider.SelectedIndexChanged += new System.EventHandler(this.comboProvider_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(469, 352);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage1.Controls.Add(this.groupBoxMT);
            this.tabPage1.Controls.Add(this.groupBoxGT);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(461, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Choose provider";
            // 
            // groupBoxMT
            // 
            this.groupBoxMT.Controls.Add(this.btnDeleteSavedMicrosoftCreds);
            this.groupBoxMT.Controls.Add(this.chkCatId);
            this.groupBoxMT.Controls.Add(this.txtCatId);
            this.groupBoxMT.Controls.Add(this.lblClientID);
            this.groupBoxMT.Controls.Add(this.txtClientId);
            this.groupBoxMT.Controls.Add(this.lblClientSecret);
            this.groupBoxMT.Controls.Add(this.chkSaveCred);
            this.groupBoxMT.Controls.Add(this.txtClientSecret);
            this.groupBoxMT.Location = new System.Drawing.Point(4, 79);
            this.groupBoxMT.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMT.Name = "groupBoxMT";
            this.groupBoxMT.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMT.Size = new System.Drawing.Size(439, 243);
            this.groupBoxMT.TabIndex = 5;
            this.groupBoxMT.TabStop = false;
            this.groupBoxMT.Text = "Microsoft Translator credentials";
            this.groupBoxMT.Visible = false;
            // 
            // btnDeleteSavedMicrosoftCreds
            // 
            this.btnDeleteSavedMicrosoftCreds.AutoSize = true;
            this.btnDeleteSavedMicrosoftCreds.Location = new System.Drawing.Point(7, 147);
            this.btnDeleteSavedMicrosoftCreds.Name = "btnDeleteSavedMicrosoftCreds";
            this.btnDeleteSavedMicrosoftCreds.Size = new System.Drawing.Size(174, 27);
            this.btnDeleteSavedMicrosoftCreds.TabIndex = 16;
            this.btnDeleteSavedMicrosoftCreds.Text = "Delete saved credentials";
            this.btnDeleteSavedMicrosoftCreds.UseVisualStyleBackColor = true;
            this.btnDeleteSavedMicrosoftCreds.Click += new System.EventHandler(this.btnDeleteSavedMicrosoftCreds_Click);
            // 
            // chkCatId
            // 
            this.chkCatId.AutoSize = true;
            this.chkCatId.Location = new System.Drawing.Point(7, 183);
            this.chkCatId.Name = "chkCatId";
            this.chkCatId.Size = new System.Drawing.Size(135, 21);
            this.chkCatId.TabIndex = 9;
            this.chkCatId.Text = "Use category ID:";
            this.chkCatId.UseVisualStyleBackColor = true;
            this.chkCatId.CheckedChanged += new System.EventHandler(this.chkCatId_CheckedChanged);
            // 
            // txtCatId
            // 
            this.txtCatId.Enabled = false;
            this.txtCatId.Location = new System.Drawing.Point(7, 210);
            this.txtCatId.Name = "txtCatId";
            this.txtCatId.Size = new System.Drawing.Size(402, 22);
            this.txtCatId.TabIndex = 10;
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(3, 27);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(64, 17);
            this.lblClientID.TabIndex = 15;
            this.lblClientID.Text = "Client ID:";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(6, 47);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(246, 22);
            this.txtClientId.TabIndex = 3;
            // 
            // lblClientSecret
            // 
            this.lblClientSecret.AutoSize = true;
            this.lblClientSecret.Location = new System.Drawing.Point(4, 72);
            this.lblClientSecret.Name = "lblClientSecret";
            this.lblClientSecret.Size = new System.Drawing.Size(92, 17);
            this.lblClientSecret.TabIndex = 13;
            this.lblClientSecret.Text = "Client Secret:";
            // 
            // chkSaveCred
            // 
            this.chkSaveCred.AutoSize = true;
            this.chkSaveCred.Location = new System.Drawing.Point(7, 120);
            this.chkSaveCred.Name = "chkSaveCred";
            this.chkSaveCred.Size = new System.Drawing.Size(256, 21);
            this.chkSaveCred.TabIndex = 6;
            this.chkSaveCred.Text = "Save credentials for future sessions";
            this.chkSaveCred.UseVisualStyleBackColor = true;
            // 
            // txtClientSecret
            // 
            this.txtClientSecret.Location = new System.Drawing.Point(6, 92);
            this.txtClientSecret.Name = "txtClientSecret";
            this.txtClientSecret.PasswordChar = '*';
            this.txtClientSecret.Size = new System.Drawing.Size(399, 22);
            this.txtClientSecret.TabIndex = 4;
            // 
            // groupBoxGT
            // 
            this.groupBoxGT.Controls.Add(this.btnDeleteSavedGoogleKey);
            this.groupBoxGT.Controls.Add(this.chkSaveKey);
            this.groupBoxGT.Controls.Add(this.textApiKey);
            this.groupBoxGT.Location = new System.Drawing.Point(4, 330);
            this.groupBoxGT.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxGT.Name = "groupBoxGT";
            this.groupBoxGT.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxGT.Size = new System.Drawing.Size(439, 112);
            this.groupBoxGT.TabIndex = 5;
            this.groupBoxGT.TabStop = false;
            this.groupBoxGT.Text = "Google Translate API key";
            this.groupBoxGT.Visible = false;
            // 
            // btnDeleteSavedGoogleKey
            // 
            this.btnDeleteSavedGoogleKey.AutoSize = true;
            this.btnDeleteSavedGoogleKey.Location = new System.Drawing.Point(7, 74);
            this.btnDeleteSavedGoogleKey.Name = "btnDeleteSavedGoogleKey";
            this.btnDeleteSavedGoogleKey.Size = new System.Drawing.Size(127, 27);
            this.btnDeleteSavedGoogleKey.TabIndex = 13;
            this.btnDeleteSavedGoogleKey.Text = "Delete saved key";
            this.btnDeleteSavedGoogleKey.UseVisualStyleBackColor = true;
            this.btnDeleteSavedGoogleKey.Click += new System.EventHandler(this.btnDeleteSavedGoogleKey_Click);
            // 
            // chkSaveKey
            // 
            this.chkSaveKey.AutoSize = true;
            this.chkSaveKey.Location = new System.Drawing.Point(7, 48);
            this.chkSaveKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSaveKey.Name = "chkSaveKey";
            this.chkSaveKey.Size = new System.Drawing.Size(209, 21);
            this.chkSaveKey.TabIndex = 12;
            this.chkSaveKey.Text = "Save key for future sessions";
            this.chkSaveKey.UseVisualStyleBackColor = true;
            // 
            // textApiKey
            // 
            this.textApiKey.Location = new System.Drawing.Point(7, 22);
            this.textApiKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textApiKey.Name = "textApiKey";
            this.textApiKey.PasswordChar = '*';
            this.textApiKey.Size = new System.Drawing.Size(407, 22);
            this.textApiKey.TabIndex = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(461, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Provider options";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBoxPostedit);
            this.groupBox4.Controls.Add(this.groupBoxPreedit);
            this.groupBox4.Controls.Add(this.chkResendDrafts);
            this.groupBox4.Controls.Add(this.chkUsePostEdit);
            this.groupBox4.Controls.Add(this.chkUsePreEdit);
            this.groupBox4.Controls.Add(this.chkPlainTextOnly);
            this.groupBox4.Location = new System.Drawing.Point(3, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(444, 286);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Provider Options";
            // 
            // groupBoxPostedit
            // 
            this.groupBoxPostedit.Controls.Add(this.txtPostEditFileName);
            this.groupBoxPostedit.Controls.Add(this.btnBrowsePostEditFile);
            this.groupBoxPostedit.Location = new System.Drawing.Point(0, 204);
            this.groupBoxPostedit.Name = "groupBoxPostedit";
            this.groupBoxPostedit.Size = new System.Drawing.Size(435, 56);
            this.groupBoxPostedit.TabIndex = 22;
            this.groupBoxPostedit.TabStop = false;
            this.groupBoxPostedit.Text = "Post-lookup find/replace filename:";
            // 
            // txtPostEditFileName
            // 
            this.txtPostEditFileName.Enabled = false;
            this.txtPostEditFileName.Location = new System.Drawing.Point(3, 21);
            this.txtPostEditFileName.MaxLength = 30;
            this.txtPostEditFileName.Name = "txtPostEditFileName";
            this.txtPostEditFileName.ReadOnly = true;
            this.txtPostEditFileName.Size = new System.Drawing.Size(350, 22);
            this.txtPostEditFileName.TabIndex = 8;
            // 
            // btnBrowsePostEditFile
            // 
            this.btnBrowsePostEditFile.Location = new System.Drawing.Point(359, 18);
            this.btnBrowsePostEditFile.Name = "btnBrowsePostEditFile";
            this.btnBrowsePostEditFile.Size = new System.Drawing.Size(73, 28);
            this.btnBrowsePostEditFile.TabIndex = 10;
            this.btnBrowsePostEditFile.Text = "Browse...";
            this.btnBrowsePostEditFile.UseVisualStyleBackColor = true;
            this.btnBrowsePostEditFile.Click += new System.EventHandler(this.btnBrowsePostEditFile_Click);
            // 
            // groupBoxPreedit
            // 
            this.groupBoxPreedit.Controls.Add(this.txtPreEditFileName);
            this.groupBoxPreedit.Controls.Add(this.btnBrowsePreEdit);
            this.groupBoxPreedit.Location = new System.Drawing.Point(3, 107);
            this.groupBoxPreedit.Name = "groupBoxPreedit";
            this.groupBoxPreedit.Size = new System.Drawing.Size(435, 64);
            this.groupBoxPreedit.TabIndex = 21;
            this.groupBoxPreedit.TabStop = false;
            this.groupBoxPreedit.Text = "Pre-lookup find/replace filename:";
            // 
            // txtPreEditFileName
            // 
            this.txtPreEditFileName.Enabled = false;
            this.txtPreEditFileName.Location = new System.Drawing.Point(6, 24);
            this.txtPreEditFileName.MaxLength = 30;
            this.txtPreEditFileName.Name = "txtPreEditFileName";
            this.txtPreEditFileName.ReadOnly = true;
            this.txtPreEditFileName.Size = new System.Drawing.Size(344, 22);
            this.txtPreEditFileName.TabIndex = 20;
            this.txtPreEditFileName.TabStop = false;
            // 
            // btnBrowsePreEdit
            // 
            this.btnBrowsePreEdit.Location = new System.Drawing.Point(356, 21);
            this.btnBrowsePreEdit.Name = "btnBrowsePreEdit";
            this.btnBrowsePreEdit.Size = new System.Drawing.Size(73, 28);
            this.btnBrowsePreEdit.TabIndex = 14;
            this.btnBrowsePreEdit.Text = "Browse...";
            this.btnBrowsePreEdit.UseVisualStyleBackColor = true;
            this.btnBrowsePreEdit.Click += new System.EventHandler(this.btnBrowsePreEdit_Click);
            // 
            // chkResendDrafts
            // 
            this.chkResendDrafts.AutoSize = true;
            this.chkResendDrafts.Location = new System.Drawing.Point(6, 26);
            this.chkResendDrafts.Name = "chkResendDrafts";
            this.chkResendDrafts.Size = new System.Drawing.Size(277, 21);
            this.chkResendDrafts.TabIndex = 11;
            this.chkResendDrafts.Text = "Re-send draft and translated segments";
            this.chkResendDrafts.UseVisualStyleBackColor = true;
            // 
            // chkUsePostEdit
            // 
            this.chkUsePostEdit.AutoSize = true;
            this.chkUsePostEdit.Location = new System.Drawing.Point(3, 177);
            this.chkUsePostEdit.Name = "chkUsePostEdit";
            this.chkUsePostEdit.Size = new System.Drawing.Size(204, 21);
            this.chkUsePostEdit.TabIndex = 7;
            this.chkUsePostEdit.Text = "Do post-lookup find/replace";
            this.chkUsePostEdit.UseVisualStyleBackColor = true;
            this.chkUsePostEdit.CheckedChanged += new System.EventHandler(this.chkUsePostEdit_CheckedChanged);
            // 
            // chkUsePreEdit
            // 
            this.chkUsePreEdit.AutoSize = true;
            this.chkUsePreEdit.Location = new System.Drawing.Point(6, 80);
            this.chkUsePreEdit.Name = "chkUsePreEdit";
            this.chkUsePreEdit.Size = new System.Drawing.Size(198, 21);
            this.chkUsePreEdit.TabIndex = 13;
            this.chkUsePreEdit.Text = "Do pre-lookup find/replace";
            this.chkUsePreEdit.UseVisualStyleBackColor = true;
            this.chkUsePreEdit.CheckedChanged += new System.EventHandler(this.chkUsePreEdit_CheckedChanged);
            // 
            // chkPlainTextOnly
            // 
            this.chkPlainTextOnly.AutoSize = true;
            this.chkPlainTextOnly.Location = new System.Drawing.Point(6, 53);
            this.chkPlainTextOnly.Name = "chkPlainTextOnly";
            this.chkPlainTextOnly.Size = new System.Drawing.Size(214, 21);
            this.chkPlainTextOnly.TabIndex = 12;
            this.chkPlainTextOnly.Text = "Send plain text only (no tags)";
            this.chkPlainTextOnly.UseVisualStyleBackColor = true;
            // 
            // MtProviderConfDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 420);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MtProviderConfDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxMT.ResumeLayout(false);
            this.groupBoxMT.PerformLayout();
            this.groupBoxGT.ResumeLayout(false);
            this.groupBoxGT.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBoxPostedit.ResumeLayout(false);
            this.groupBoxPostedit.PerformLayout();
            this.groupBoxPreedit.ResumeLayout(false);
            this.groupBoxPreedit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chkCatId;
        private System.Windows.Forms.TextBox txtCatId;
        private System.Windows.Forms.GroupBox groupBoxMT;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Label lblClientSecret;
        private System.Windows.Forms.CheckBox chkSaveCred;
        private System.Windows.Forms.TextBox txtClientSecret;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPreEditFileName;
        private System.Windows.Forms.Button btnBrowsePreEdit;
        private System.Windows.Forms.CheckBox chkResendDrafts;
        private System.Windows.Forms.Button btnBrowsePostEditFile;
        private System.Windows.Forms.TextBox txtPostEditFileName;
        private System.Windows.Forms.CheckBox chkUsePostEdit;
        private System.Windows.Forms.CheckBox chkUsePreEdit;
        private System.Windows.Forms.CheckBox chkPlainTextOnly;
        private System.Windows.Forms.ComboBox comboProvider;
        private System.Windows.Forms.GroupBox groupBoxGT;
        private System.Windows.Forms.CheckBox chkSaveKey;
        private System.Windows.Forms.TextBox textApiKey;
        private System.Windows.Forms.GroupBox groupBoxPreedit;
        private System.Windows.Forms.GroupBox groupBoxPostedit;
        private System.Windows.Forms.Button btnDeleteSavedGoogleKey;
        private System.Windows.Forms.Button btnDeleteSavedMicrosoftCreds;
    }
}