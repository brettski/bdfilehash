namespace BDFileHash
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.chkCheckLikeTextfileForHash = new System.Windows.Forms.CheckBox();
            this.chkHashFileOnLoad = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDefaultFolder = new System.Windows.Forms.Label();
            this.lblDefaultFolderValue = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.chkCopyHashToClipboard = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkCheckLikeTextfileForHash
            // 
            this.chkCheckLikeTextfileForHash.AutoSize = true;
            this.chkCheckLikeTextfileForHash.BackColor = System.Drawing.Color.Transparent;
            this.chkCheckLikeTextfileForHash.Location = new System.Drawing.Point(36, 49);
            this.chkCheckLikeTextfileForHash.Name = "chkCheckLikeTextfileForHash";
            this.chkCheckLikeTextfileForHash.Size = new System.Drawing.Size(191, 17);
            this.chkCheckLikeTextfileForHash.TabIndex = 0;
            this.chkCheckLikeTextfileForHash.Text = "Check like file name for hash value";
            this.chkCheckLikeTextfileForHash.UseVisualStyleBackColor = false;
            // 
            // chkHashFileOnLoad
            // 
            this.chkHashFileOnLoad.AutoSize = true;
            this.chkHashFileOnLoad.BackColor = System.Drawing.Color.Transparent;
            this.chkHashFileOnLoad.Location = new System.Drawing.Point(36, 72);
            this.chkHashFileOnLoad.Name = "chkHashFileOnLoad";
            this.chkHashFileOnLoad.Size = new System.Drawing.Size(174, 17);
            this.chkHashFileOnLoad.TabIndex = 1;
            this.chkHashFileOnLoad.Text = "Hash file on \'Send To\' app start";
            this.chkHashFileOnLoad.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(36, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(152, 202);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "BD File Hash User Settings";
            // 
            // lblDefaultFolder
            // 
            this.lblDefaultFolder.AutoSize = true;
            this.lblDefaultFolder.BackColor = System.Drawing.Color.Transparent;
            this.lblDefaultFolder.Location = new System.Drawing.Point(12, 130);
            this.lblDefaultFolder.Name = "lblDefaultFolder";
            this.lblDefaultFolder.Size = new System.Drawing.Size(115, 13);
            this.lblDefaultFolder.TabIndex = 5;
            this.lblDefaultFolder.Text = "Default Starting Folder:";
            // 
            // lblDefaultFolderValue
            // 
            this.lblDefaultFolderValue.AutoSize = true;
            this.lblDefaultFolderValue.BackColor = System.Drawing.Color.Transparent;
            this.lblDefaultFolderValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDefaultFolderValue.Location = new System.Drawing.Point(12, 146);
            this.lblDefaultFolderValue.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDefaultFolderValue.MinimumSize = new System.Drawing.Size(250, 0);
            this.lblDefaultFolderValue.Name = "lblDefaultFolderValue";
            this.lblDefaultFolderValue.Size = new System.Drawing.Size(250, 15);
            this.lblDefaultFolderValue.TabIndex = 6;
            this.lblDefaultFolderValue.Click += new System.EventHandler(this.lblDefaultFolderValue_Click);
            // 
            // chkCopyHashToClipboard
            // 
            this.chkCopyHashToClipboard.AutoSize = true;
            this.chkCopyHashToClipboard.BackColor = System.Drawing.Color.Transparent;
            this.chkCopyHashToClipboard.Location = new System.Drawing.Point(36, 95);
            this.chkCopyHashToClipboard.Name = "chkCopyHashToClipboard";
            this.chkCopyHashToClipboard.Size = new System.Drawing.Size(186, 17);
            this.chkCopyHashToClipboard.TabIndex = 7;
            this.chkCopyHashToClipboard.Text = "Copy calculated hash to clipboard";
            this.chkCopyHashToClipboard.UseVisualStyleBackColor = false;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.chkCopyHashToClipboard);
            this.Controls.Add(this.lblDefaultFolderValue);
            this.Controls.Add(this.lblDefaultFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkHashFileOnLoad);
            this.Controls.Add(this.chkCheckLikeTextfileForHash);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkCheckLikeTextfileForHash;
        private System.Windows.Forms.CheckBox chkHashFileOnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDefaultFolder;
        private System.Windows.Forms.Label lblDefaultFolderValue;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.CheckBox chkCopyHashToClipboard;
    }
}