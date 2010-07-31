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
            ActionLoadUserSettings();

        }

        private void ActionLoadUserSettings()
        {
            this.chkCheckLikeTextfileForHash.Checked = Properties.Settings.Default.CheckLikeTextfileForHash;
            this.chkHashFileOnLoad.Checked = Properties.Settings.Default.HashFileOnLoad;
            this.lblDefaultFolderValue.Text = Properties.Settings.Default.DefaultStartingFolder;
        }

        private void ActionWriteUserSettings()
        {
            Properties.Settings.Default.CheckLikeTextfileForHash = this.chkCheckLikeTextfileForHash.Checked;
            Properties.Settings.Default.HashFileOnLoad = this.chkHashFileOnLoad.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ActionWriteUserSettings();
            Properties.Settings.Default.Save();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            ActionLoadUserSettings();

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
