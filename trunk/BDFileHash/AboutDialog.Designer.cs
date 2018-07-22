namespace BDFileHash
{
    partial class AboutDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutDialog));
            this.label1 = new System.Windows.Forms.Label();
            this.grpbxVersionInfo = new System.Windows.Forms.GroupBox();
            this.lblVersionInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.llProductWebsite = new System.Windows.Forms.LinkLabel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.grpbxDescription = new System.Windows.Forms.GroupBox();
            this.grpbxVersionInfo.SuspendLayout();
            this.grpbxDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BD File Hash";
            // 
            // grpbxVersionInfo
            // 
            this.grpbxVersionInfo.BackColor = System.Drawing.Color.Transparent;
            this.grpbxVersionInfo.Controls.Add(this.lblVersionInfo);
            this.grpbxVersionInfo.Location = new System.Drawing.Point(16, 173);
            this.grpbxVersionInfo.Name = "grpbxVersionInfo";
            this.grpbxVersionInfo.Size = new System.Drawing.Size(247, 65);
            this.grpbxVersionInfo.TabIndex = 1;
            this.grpbxVersionInfo.TabStop = false;
            this.grpbxVersionInfo.Text = "Version Information";
            // 
            // lblVersionInfo
            // 
            this.lblVersionInfo.AutoSize = true;
            this.lblVersionInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblVersionInfo.Location = new System.Drawing.Point(6, 16);
            this.lblVersionInfo.Name = "lblVersionInfo";
            this.lblVersionInfo.Size = new System.Drawing.Size(60, 13);
            this.lblVersionInfo.TabIndex = 1;
            this.lblVersionInfo.Text = "VersionInfo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copyright © 2010--2018, Brettski";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Author: Brett Slaski";
            // 
            // llProductWebsite
            // 
            this.llProductWebsite.AutoSize = true;
            this.llProductWebsite.BackColor = System.Drawing.Color.Transparent;
            this.llProductWebsite.Location = new System.Drawing.Point(13, 63);
            this.llProductWebsite.Name = "llProductWebsite";
            this.llProductWebsite.Size = new System.Drawing.Size(86, 13);
            this.llProductWebsite.TabIndex = 4;
            this.llProductWebsite.TabStop = true;
            this.llProductWebsite.Text = "Product Website";
            this.llProductWebsite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llProductWebsite_LinkClicked);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Location = new System.Drawing.Point(6, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(239, 39);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "BD File Hash is a convenient file hash and \r\nhash compare tool for Windows.  Curr" +
    "ently \r\nworks with MD5, SHA-1, SHA-256, and SHA-512";
            // 
            // grpbxDescription
            // 
            this.grpbxDescription.BackColor = System.Drawing.Color.Transparent;
            this.grpbxDescription.Controls.Add(this.lblDescription);
            this.grpbxDescription.Location = new System.Drawing.Point(16, 85);
            this.grpbxDescription.Name = "grpbxDescription";
            this.grpbxDescription.Size = new System.Drawing.Size(247, 82);
            this.grpbxDescription.TabIndex = 6;
            this.grpbxDescription.TabStop = false;
            this.grpbxDescription.Text = "Description";
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(181)))), ((int)(((byte)(9)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.grpbxDescription);
            this.Controls.Add(this.llProductWebsite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpbxVersionInfo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutDialog";
            this.Text = "About";
            this.grpbxVersionInfo.ResumeLayout(false);
            this.grpbxVersionInfo.PerformLayout();
            this.grpbxDescription.ResumeLayout(false);
            this.grpbxDescription.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbxVersionInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llProductWebsite;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox grpbxDescription;
        private System.Windows.Forms.Label lblVersionInfo;
    }
}