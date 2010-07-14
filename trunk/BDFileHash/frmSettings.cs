using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BDFileHash
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            this.chkCheckLikeTextfileForHash.Checked = Properties.Settings.Default.CheckLikeTextfileForHash;
            this.lblDefaultFolderValue.Text = Properties.Settings.Default.DefaultStartingFolder;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CheckLikeTextfileForHash = this.chkCheckLikeTextfileForHash.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            this.chkCheckLikeTextfileForHash.Checked = Properties.Settings.Default.CheckLikeTextfileForHash;
            this.lblDefaultFolderValue.Text = Properties.Settings.Default.DefaultStartingFolder;

        }

        private void lblDefaultFolderValue_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = Properties.Settings.Default.DefaultStartingFolder;
            folderBrowserDialog1.Description = @"Select default folder";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblDefaultFolderValue.Text = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.DefaultStartingFolder = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
