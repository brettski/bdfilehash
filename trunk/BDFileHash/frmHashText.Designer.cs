namespace BDFileHash
{
    partial class frmHashText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHashText));
            this.label1 = new System.Windows.Forms.Label();
            this.tbxHashText = new System.Windows.Forms.TextBox();
            this.btnHashText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter text to hash below:";
            // 
            // tbxHashText
            // 
            this.tbxHashText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxHashText.Location = new System.Drawing.Point(2, 25);
            this.tbxHashText.Multiline = true;
            this.tbxHashText.Name = "tbxHashText";
            this.tbxHashText.Size = new System.Drawing.Size(401, 240);
            this.tbxHashText.TabIndex = 1;
            // 
            // btnHashText
            // 
            this.btnHashText.Location = new System.Drawing.Point(317, 2);
            this.btnHashText.Name = "btnHashText";
            this.btnHashText.Size = new System.Drawing.Size(75, 20);
            this.btnHashText.TabIndex = 2;
            this.btnHashText.Text = "Hash Text";
            this.btnHashText.UseVisualStyleBackColor = true;
            this.btnHashText.Click += new System.EventHandler(this.btnHashText_Click);
            // 
            // frmHashText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(404, 266);
            this.Controls.Add(this.btnHashText);
            this.Controls.Add(this.tbxHashText);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHashText";
            this.Text = "frmHashText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxHashText;
        private System.Windows.Forms.Button btnHashText;
    }
}