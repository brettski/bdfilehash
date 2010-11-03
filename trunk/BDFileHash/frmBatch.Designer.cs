namespace BDFileHash
{
    partial class frmBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBatch));
            this.tbxBatchFolder = new System.Windows.Forms.TextBox();
            this.tbxFilePattern = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxOutputFile = new System.Windows.Forms.TextBox();
            this.grpBxOutput = new System.Windows.Forms.GroupBox();
            this.rbCsv = new System.Windows.Forms.RadioButton();
            this.rbHtml = new System.Windows.Forms.RadioButton();
            this.grpBxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxBatchFolder
            // 
            this.tbxBatchFolder.Location = new System.Drawing.Point(15, 22);
            this.tbxBatchFolder.Name = "tbxBatchFolder";
            this.tbxBatchFolder.Size = new System.Drawing.Size(380, 20);
            this.tbxBatchFolder.TabIndex = 0;
            // 
            // tbxFilePattern
            // 
            this.tbxFilePattern.Location = new System.Drawing.Point(15, 72);
            this.tbxFilePattern.Name = "tbxFilePattern";
            this.tbxFilePattern.Size = new System.Drawing.Size(156, 20);
            this.tbxFilePattern.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder to Batch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "File Pattern";
            // 
            // tbxOutputFile
            // 
            this.tbxOutputFile.Location = new System.Drawing.Point(6, 42);
            this.tbxOutputFile.Name = "tbxOutputFile";
            this.tbxOutputFile.Size = new System.Drawing.Size(365, 20);
            this.tbxOutputFile.TabIndex = 4;
            // 
            // grpBxOutput
            // 
            this.grpBxOutput.Controls.Add(this.rbHtml);
            this.grpBxOutput.Controls.Add(this.tbxOutputFile);
            this.grpBxOutput.Controls.Add(this.rbCsv);
            this.grpBxOutput.Location = new System.Drawing.Point(15, 107);
            this.grpBxOutput.Name = "grpBxOutput";
            this.grpBxOutput.Size = new System.Drawing.Size(377, 73);
            this.grpBxOutput.TabIndex = 5;
            this.grpBxOutput.TabStop = false;
            this.grpBxOutput.Text = "Output Results";
            // 
            // rbCsv
            // 
            this.rbCsv.AutoSize = true;
            this.rbCsv.Location = new System.Drawing.Point(6, 19);
            this.rbCsv.Name = "rbCsv";
            this.rbCsv.Size = new System.Drawing.Size(46, 17);
            this.rbCsv.TabIndex = 0;
            this.rbCsv.TabStop = true;
            this.rbCsv.Text = "CSV";
            this.rbCsv.UseVisualStyleBackColor = true;
            // 
            // rbHtml
            // 
            this.rbHtml.AutoSize = true;
            this.rbHtml.Location = new System.Drawing.Point(58, 19);
            this.rbHtml.Name = "rbHtml";
            this.rbHtml.Size = new System.Drawing.Size(55, 17);
            this.rbHtml.TabIndex = 1;
            this.rbHtml.TabStop = true;
            this.rbHtml.Text = "HTML";
            this.rbHtml.UseVisualStyleBackColor = true;
            // 
            // frmBatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 212);
            this.Controls.Add(this.grpBxOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxFilePattern);
            this.Controls.Add(this.tbxBatchFolder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBatch";
            this.Text = "BD File Hash - Batch";
            this.grpBxOutput.ResumeLayout(false);
            this.grpBxOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBatchFolder;
        private System.Windows.Forms.TextBox tbxFilePattern;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxOutputFile;
        private System.Windows.Forms.GroupBox grpBxOutput;
        private System.Windows.Forms.RadioButton rbHtml;
        private System.Windows.Forms.RadioButton rbCsv;

    }
}