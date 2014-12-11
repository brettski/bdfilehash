namespace BDFileHash
{
    partial class frmFileHash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileHash));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentHashAsDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToVirusTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchHashingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxFile = new System.Windows.Forms.TextBox();
            this.tbxFilesHash = new System.Windows.Forms.TextBox();
            this.tbxCompareHash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGetHashFile = new System.Windows.Forms.Button();
            this.grpBoxHashType = new System.Windows.Forms.GroupBox();
            this.rbtnSha512 = new System.Windows.Forms.RadioButton();
            this.rbtnSha256 = new System.Windows.Forms.RadioButton();
            this.rbtnSha1 = new System.Windows.Forms.RadioButton();
            this.rbtnMd5 = new System.Windows.Forms.RadioButton();
            this.btnGetCompareFile = new System.Windows.Forms.Button();
            this.btnCreateHash = new System.Windows.Forms.Button();
            this.btnSavetoCompare = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClearAll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpBoxHashType.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hashTextToolStripMenuItem,
            this.saveCurrentHashAsDefaultToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.sendToVirusTotalToolStripMenuItem,
            this.batchHashingToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "Tools";
            // 
            // hashTextToolStripMenuItem
            // 
            this.hashTextToolStripMenuItem.Name = "hashTextToolStripMenuItem";
            this.hashTextToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.hashTextToolStripMenuItem.Text = "Hash &Text...";
            this.hashTextToolStripMenuItem.Click += new System.EventHandler(this.hashTextToolStripMenuItem_Click);
            // 
            // saveCurrentHashAsDefaultToolStripMenuItem
            // 
            this.saveCurrentHashAsDefaultToolStripMenuItem.Name = "saveCurrentHashAsDefaultToolStripMenuItem";
            this.saveCurrentHashAsDefaultToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.saveCurrentHashAsDefaultToolStripMenuItem.Text = "Save current hash as default";
            this.saveCurrentHashAsDefaultToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentHashAsDefaultToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // sendToVirusTotalToolStripMenuItem
            // 
            this.sendToVirusTotalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendToVirusTotalToolStripMenuItem.Image")));
            this.sendToVirusTotalToolStripMenuItem.Name = "sendToVirusTotalToolStripMenuItem";
            this.sendToVirusTotalToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.sendToVirusTotalToolStripMenuItem.Text = "Send to Virus Total";
            this.sendToVirusTotalToolStripMenuItem.ToolTipText = "Check hash value at VirusTotal.com";
            this.sendToVirusTotalToolStripMenuItem.Click += new System.EventHandler(this.sendToVirusTotalToolStripMenuItem_Click);
            // 
            // batchHashingToolStripMenuItem
            // 
            this.batchHashingToolStripMenuItem.Name = "batchHashingToolStripMenuItem";
            this.batchHashingToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.batchHashingToolStripMenuItem.Text = "Batch Hashing";
            this.batchHashingToolStripMenuItem.Click += new System.EventHandler(this.batchHashingToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getColorToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Visible = false;
            // 
            // getColorToolStripMenuItem
            // 
            this.getColorToolStripMenuItem.Name = "getColorToolStripMenuItem";
            this.getColorToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.getColorToolStripMenuItem.Text = "GetColor";
            this.getColorToolStripMenuItem.Click += new System.EventHandler(this.getColorToolStripMenuItem_Click);
            // 
            // tbxFile
            // 
            this.tbxFile.AllowDrop = true;
            this.tbxFile.Location = new System.Drawing.Point(15, 65);
            this.tbxFile.Name = "tbxFile";
            this.tbxFile.Size = new System.Drawing.Size(346, 20);
            this.tbxFile.TabIndex = 2;
            this.tbxFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbxFile_DragDrop);
            this.tbxFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbxFile_DragEnter);
            this.tbxFile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFile_KeyPress);
            // 
            // tbxFilesHash
            // 
            this.tbxFilesHash.AllowDrop = true;
            this.tbxFilesHash.Location = new System.Drawing.Point(15, 109);
            this.tbxFilesHash.Name = "tbxFilesHash";
            this.tbxFilesHash.Size = new System.Drawing.Size(346, 20);
            this.tbxFilesHash.TabIndex = 3;
            this.tbxFilesHash.TextChanged += new System.EventHandler(this.tbxFilesHash_TextChanged);
            this.tbxFilesHash.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbxFilesHash_DragDrop);
            this.tbxFilesHash.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbxFilesHash_DragEnter);
            this.tbxFilesHash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxFilesHash_KeyPress);
            // 
            // tbxCompareHash
            // 
            this.tbxCompareHash.Location = new System.Drawing.Point(15, 154);
            this.tbxCompareHash.Name = "tbxCompareHash";
            this.tbxCompareHash.Size = new System.Drawing.Size(346, 20);
            this.tbxCompareHash.TabIndex = 4;
            this.tbxCompareHash.TextChanged += new System.EventHandler(this.tbxCompareHash_TextChanged);
            this.tbxCompareHash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCompareHash_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "File to hash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File\'s hash";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Compare hash";
            // 
            // btnGetHashFile
            // 
            this.btnGetHashFile.Location = new System.Drawing.Point(374, 65);
            this.btnGetHashFile.Name = "btnGetHashFile";
            this.btnGetHashFile.Size = new System.Drawing.Size(24, 20);
            this.btnGetHashFile.TabIndex = 8;
            this.btnGetHashFile.Text = "...";
            this.btnGetHashFile.UseVisualStyleBackColor = true;
            this.btnGetHashFile.Click += new System.EventHandler(this.btnGetHashFile_Click);
            // 
            // grpBoxHashType
            // 
            this.grpBoxHashType.Controls.Add(this.rbtnSha512);
            this.grpBoxHashType.Controls.Add(this.rbtnSha256);
            this.grpBoxHashType.Controls.Add(this.rbtnSha1);
            this.grpBoxHashType.Controls.Add(this.rbtnMd5);
            this.grpBoxHashType.Location = new System.Drawing.Point(205, 27);
            this.grpBoxHashType.Name = "grpBoxHashType";
            this.grpBoxHashType.Size = new System.Drawing.Size(275, 35);
            this.grpBoxHashType.TabIndex = 9;
            this.grpBoxHashType.TabStop = false;
            this.grpBoxHashType.Text = "Hash Type";
            // 
            // rbtnSha512
            // 
            this.rbtnSha512.AutoSize = true;
            this.rbtnSha512.Location = new System.Drawing.Point(205, 15);
            this.rbtnSha512.Name = "rbtnSha512";
            this.rbtnSha512.Size = new System.Drawing.Size(68, 17);
            this.rbtnSha512.TabIndex = 3;
            this.rbtnSha512.TabStop = true;
            this.rbtnSha512.Text = "SHA-512";
            this.rbtnSha512.UseVisualStyleBackColor = true;
            // 
            // rbtnSha256
            // 
            this.rbtnSha256.AutoSize = true;
            this.rbtnSha256.Location = new System.Drawing.Point(131, 15);
            this.rbtnSha256.Name = "rbtnSha256";
            this.rbtnSha256.Size = new System.Drawing.Size(68, 17);
            this.rbtnSha256.TabIndex = 2;
            this.rbtnSha256.TabStop = true;
            this.rbtnSha256.Text = "SHA-256";
            this.rbtnSha256.UseVisualStyleBackColor = true;
            // 
            // rbtnSha1
            // 
            this.rbtnSha1.AutoSize = true;
            this.rbtnSha1.Location = new System.Drawing.Point(69, 15);
            this.rbtnSha1.Name = "rbtnSha1";
            this.rbtnSha1.Size = new System.Drawing.Size(56, 17);
            this.rbtnSha1.TabIndex = 1;
            this.rbtnSha1.TabStop = true;
            this.rbtnSha1.Text = "SHA-1";
            this.rbtnSha1.UseVisualStyleBackColor = true;
            // 
            // rbtnMd5
            // 
            this.rbtnMd5.AutoSize = true;
            this.rbtnMd5.Location = new System.Drawing.Point(6, 15);
            this.rbtnMd5.Name = "rbtnMd5";
            this.rbtnMd5.Size = new System.Drawing.Size(48, 17);
            this.rbtnMd5.TabIndex = 0;
            this.rbtnMd5.TabStop = true;
            this.rbtnMd5.Text = "MD5";
            this.rbtnMd5.UseVisualStyleBackColor = true;
            // 
            // btnGetCompareFile
            // 
            this.btnGetCompareFile.Location = new System.Drawing.Point(374, 154);
            this.btnGetCompareFile.Name = "btnGetCompareFile";
            this.btnGetCompareFile.Size = new System.Drawing.Size(24, 20);
            this.btnGetCompareFile.TabIndex = 10;
            this.btnGetCompareFile.Text = "...";
            this.btnGetCompareFile.UseVisualStyleBackColor = true;
            this.btnGetCompareFile.Click += new System.EventHandler(this.btnGetCompareFile_Click);
            // 
            // btnCreateHash
            // 
            this.btnCreateHash.Location = new System.Drawing.Point(405, 65);
            this.btnCreateHash.Name = "btnCreateHash";
            this.btnCreateHash.Size = new System.Drawing.Size(75, 23);
            this.btnCreateHash.TabIndex = 12;
            this.btnCreateHash.Text = "Create Hash";
            this.btnCreateHash.UseVisualStyleBackColor = true;
            this.btnCreateHash.Click += new System.EventHandler(this.btnCreateHash_Click);
            // 
            // btnSavetoCompare
            // 
            this.btnSavetoCompare.Location = new System.Drawing.Point(374, 109);
            this.btnSavetoCompare.Name = "btnSavetoCompare";
            this.btnSavetoCompare.Size = new System.Drawing.Size(106, 23);
            this.btnSavetoCompare.TabIndex = 13;
            this.btnSavetoCompare.Text = "Move to Compare";
            this.btnSavetoCompare.UseVisualStyleBackColor = true;
            this.btnSavetoCompare.Click += new System.EventHandler(this.btnSavetoCompare_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 179);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 14;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(405, 152);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 15;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // frmFileHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 201);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSavetoCompare);
            this.Controls.Add(this.btnCreateHash);
            this.Controls.Add(this.btnGetCompareFile);
            this.Controls.Add(this.grpBoxHashType);
            this.Controls.Add(this.btnGetHashFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxCompareHash);
            this.Controls.Add(this.tbxFilesHash);
            this.Controls.Add(this.tbxFile);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFileHash";
            this.Text = "BDFileHash - Main";
            this.Load += new System.EventHandler(this.frmFileHash_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBoxHashType.ResumeLayout(false);
            this.grpBoxHashType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.TextBox tbxCompareHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGetHashFile;
        private System.Windows.Forms.GroupBox grpBoxHashType;
        private System.Windows.Forms.RadioButton rbtnMd5;
        private System.Windows.Forms.RadioButton rbtnSha1;
        private System.Windows.Forms.Button btnGetCompareFile;
        private System.Windows.Forms.Button btnCreateHash;
        private System.Windows.Forms.Button btnSavetoCompare;
        private System.Windows.Forms.RadioButton rbtnSha256;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentHashAsDefaultToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getColorToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.ToolStripMenuItem batchHashingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashTextToolStripMenuItem;
        protected System.Windows.Forms.TextBox tbxFile;
        protected System.Windows.Forms.TextBox tbxFilesHash;
        private System.Windows.Forms.RadioButton rbtnSha512;
        private System.Windows.Forms.ToolStripMenuItem sendToVirusTotalToolStripMenuItem;
    }
}

