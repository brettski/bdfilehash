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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFileHash));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCurrentHashAsDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbxFile = new System.Windows.Forms.TextBox();
            this.tbxFilesHash = new System.Windows.Forms.TextBox();
            this.tbxCompareHash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGetHashFile = new System.Windows.Forms.Button();
            this.grpBoxHashType = new System.Windows.Forms.GroupBox();
            this.rbtnSha256 = new System.Windows.Forms.RadioButton();
            this.rbtnSha1 = new System.Windows.Forms.RadioButton();
            this.rbtnMd5 = new System.Windows.Forms.RadioButton();
            this.btnGetCompareFile = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnCreateHash = new System.Windows.Forms.Button();
            this.btnSavetoCompare = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpBoxHashType.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCurrentHashAsDefaultToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Tools";
            // 
            // saveCurrentHashAsDefaultToolStripMenuItem
            // 
            this.saveCurrentHashAsDefaultToolStripMenuItem.Name = "saveCurrentHashAsDefaultToolStripMenuItem";
            this.saveCurrentHashAsDefaultToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.saveCurrentHashAsDefaultToolStripMenuItem.Text = "Save current hash as default";
            this.saveCurrentHashAsDefaultToolStripMenuItem.Click += new System.EventHandler(this.saveCurrentHashAsDefaultToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.settingsToolStripMenuItem.Text = "Settings...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // tbxFile
            // 
            this.tbxFile.Location = new System.Drawing.Point(15, 65);
            this.tbxFile.Name = "tbxFile";
            this.tbxFile.Size = new System.Drawing.Size(341, 20);
            this.tbxFile.TabIndex = 2;
            // 
            // tbxFilesHash
            // 
            this.tbxFilesHash.Location = new System.Drawing.Point(15, 109);
            this.tbxFilesHash.Name = "tbxFilesHash";
            this.tbxFilesHash.Size = new System.Drawing.Size(341, 20);
            this.tbxFilesHash.TabIndex = 3;
            // 
            // tbxCompareHash
            // 
            this.tbxCompareHash.Location = new System.Drawing.Point(15, 154);
            this.tbxCompareHash.Name = "tbxCompareHash";
            this.tbxCompareHash.Size = new System.Drawing.Size(341, 20);
            this.tbxCompareHash.TabIndex = 4;
            this.tbxCompareHash.TextChanged += new System.EventHandler(this.tbxCompareHash_TextChanged);
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
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "File\'s Hash";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Compare Hash";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGetHashFile
            // 
            this.btnGetHashFile.Location = new System.Drawing.Point(362, 65);
            this.btnGetHashFile.Name = "btnGetHashFile";
            this.btnGetHashFile.Size = new System.Drawing.Size(24, 20);
            this.btnGetHashFile.TabIndex = 8;
            this.btnGetHashFile.Text = "...";
            this.btnGetHashFile.UseVisualStyleBackColor = true;
            this.btnGetHashFile.Click += new System.EventHandler(this.btnGetHashFile_Click);
            // 
            // grpBoxHashType
            // 
            this.grpBoxHashType.Controls.Add(this.rbtnSha256);
            this.grpBoxHashType.Controls.Add(this.rbtnSha1);
            this.grpBoxHashType.Controls.Add(this.rbtnMd5);
            this.grpBoxHashType.Location = new System.Drawing.Point(223, 27);
            this.grpBoxHashType.Name = "grpBoxHashType";
            this.grpBoxHashType.Size = new System.Drawing.Size(228, 35);
            this.grpBoxHashType.TabIndex = 9;
            this.grpBoxHashType.TabStop = false;
            this.grpBoxHashType.Text = "Hash Type";
            // 
            // rbtnSha256
            // 
            this.rbtnSha256.AutoSize = true;
            this.rbtnSha256.Location = new System.Drawing.Point(122, 15);
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
            this.rbtnSha1.Location = new System.Drawing.Point(60, 15);
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
            this.btnGetCompareFile.Location = new System.Drawing.Point(362, 154);
            this.btnGetCompareFile.Name = "btnGetCompareFile";
            this.btnGetCompareFile.Size = new System.Drawing.Size(24, 20);
            this.btnGetCompareFile.TabIndex = 10;
            this.btnGetCompareFile.Text = "...";
            this.btnGetCompareFile.UseVisualStyleBackColor = true;
            this.btnGetCompareFile.Click += new System.EventHandler(this.btnGetCompareFile_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.Location = new System.Drawing.Point(393, 154);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 11;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // btnCreateHash
            // 
            this.btnCreateHash.Location = new System.Drawing.Point(393, 65);
            this.btnCreateHash.Name = "btnCreateHash";
            this.btnCreateHash.Size = new System.Drawing.Size(75, 23);
            this.btnCreateHash.TabIndex = 12;
            this.btnCreateHash.Text = "Create Hash";
            this.btnCreateHash.UseVisualStyleBackColor = true;
            this.btnCreateHash.Click += new System.EventHandler(this.btnCreateHash_Click);
            // 
            // btnSavetoCompare
            // 
            this.btnSavetoCompare.Location = new System.Drawing.Point(362, 109);
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
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 179);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 14;
            // 
            // frmFileHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 201);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSavetoCompare);
            this.Controls.Add(this.btnCreateHash);
            this.Controls.Add(this.btnCompare);
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
        private System.Windows.Forms.TextBox tbxFile;
        private System.Windows.Forms.TextBox tbxFilesHash;
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
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnCreateHash;
        private System.Windows.Forms.Button btnSavetoCompare;
        private System.Windows.Forms.RadioButton rbtnSha256;
        private System.Windows.Forms.ToolStripMenuItem saveCurrentHashAsDefaultToolStripMenuItem;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

