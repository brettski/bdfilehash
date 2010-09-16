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
    public partial class frmFileHash : Form
    {
        // class variables
        private bool isSendTo = false;
        private string currentFolder = string.Empty;

        public frmFileHash()
        {
            InitializeComponent();
            // get command line args and see if filename was passed in
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                tbxFile.Text = args[1];
                isSendTo = true;
            }
            lblStatus.Text = string.Empty;

        }

        private void btnGetHashFile_Click(object sender, EventArgs e)
        {
            string s = PickAFile();
            if (string.Empty != s)
                this.tbxFile.Text = s;
            // We don't want to disturb the text box if nothing was selected
        }

        private string PickAFile()
        {
            return PickAFile("All Files (*.*)|*.*");
        }

        private string PickAFile(string filter)
        {
            this.openFileDialog1.InitialDirectory = currentFolder;
            this.openFileDialog1.Filter = filter;
            this.openFileDialog1.RestoreDirectory = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                return openFileDialog1.FileName;
            else
                return string.Empty;
        }

        private void btnCreateHash_Click(object sender, EventArgs e)
        {
            ActionCreateHash();
        }

        private void ActionCreateHash()
        {
            // Verify there is a file value and the file exists, then calculate the hash
            if (!(tbxFile.Text.Length > 0 && System.IO.File.Exists(tbxFile.Text)))
            {
                MessageBox.Show(String.Format("File textbox empty or file doesn't exist. ({0})", tbxFile.Text));
                return;
            }
            HashTools ht = new HashTools();
            HashType htype;
            if (rbtnMd5.Checked)
            {
                htype = HashType.MD5;
            }
            else if (rbtnSha1.Checked)
            {
                htype = HashType.SHA1;
            }
            else if (rbtnSha256.Checked)
            {
                htype = HashType.SHA256;
            }
            else
            {
                MessageBox.Show("Invalid Hash Type");
                return;
            }

            ht.CreateFileHash(tbxFile.Text, htype);
            if (ht.InError)
            {
                // Throw Error
                MessageBox.Show("ERROR: " + ht.ErrorMsg);
                return;
            }
            this.tbxFilesHash.Text = ht.Hash;
            currentFolder = ht.PathToFileToHash;
            if (Properties.Settings.Default.CheckLikeTextfileForHash) //TODO:Check how setting works when removed from config file
            {
                if (ht.FindTextHashFile(htype))
                {
                    tbxCompareHash.Text = ht.TextFileHashFound;
                    lblStatus.Text = string.Format("Hash found in file {0}", ht.TextFileFound);

                }
            }
        }

        private void btnGetCompareFile_Click(object sender, EventArgs e)
        {
            // Open hash file and grab a value
            string filter = string.Empty;
            string hashCFile = string.Empty;
            if (rbtnMd5.Checked)
            {
                filter = "MD5 (*.MD5)|*.MD5|All Files (*.*)|*.*";
                hashCFile = PickAFile(filter);
                if (string.IsNullOrEmpty(hashCFile))
                    return;
                tbxCompareHash.Text = FileTools.FindHashInFile(hashCFile, HashType.MD5);
            }
            else if (rbtnSha1.Checked || rbtnSha256.Checked)
            {
                filter = "SHA* (*.SHA*)|*.SHA*|All Files (*.*)|*.*";
                hashCFile = PickAFile(filter);
                if (string.IsNullOrEmpty(hashCFile))
                    return;
                if (rbtnSha1.Checked)
                    tbxCompareHash.Text = FileTools.FindHashInFile(hashCFile, HashType.SHA1);
                else
                    tbxCompareHash.Text = FileTools.FindHashInFile(hashCFile, HashType.SHA256);
            }
        }

        private void btnSavetoCompare_Click(object sender, EventArgs e)
        {
            // Write hash value from file hash text box to compare text box
            tbxCompareHash.Text = tbxFilesHash.Text;
            tbxFilesHash.Text = string.Empty;
        }

        private void frmFileHash_Load(object sender, EventArgs e)
        {
            // ** To hide our testing item on the menu strip **
            testToolStripMenuItem.Visible = true;
            // Creates user config file with defaults if there isn't one.
            Properties.Settings.Default.Save();
            // Set some parameters on load
            // Default to MD5 Hash if not user defined.
            string v = Properties.Settings.Default.DefaultHashType;
            if (HashType.MD5.ToString() == v)
                rbtnMd5.Checked = true;
            else if (HashType.SHA1.ToString() == v)
                rbtnSha1.Checked = true;
            else if (HashType.SHA256.ToString() == v)
                rbtnSha256.Checked = true;
            else
                rbtnMd5.Checked = true;
            currentFolder = Properties.Settings.Default.DefaultStartingFolder;
            if (isSendTo && Properties.Settings.Default.HashFileOnLoad)
            {
                ActionCreateHash();
            }

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            ActionCompareHashes();
        }

        private void ActionCompareHashes()
        {
            // Compare the textboxes, simple
            string msg = string.Empty;
            tbxFilesHash.Text = tbxFilesHash.Text.ToLower().Trim();
            tbxCompareHash.Text = tbxCompareHash.Text.ToLower().Trim();
            if (tbxFilesHash.Text == tbxCompareHash.Text)
            {
                msg = @"Hashes are the same!";
                if (true) //TODO: Add setting for this feature
                    SetCompareStatus(CompareStatus.same); 
            }
            else
            {
                msg = @"Hashes are different!";
                if (true)
                    SetCompareStatus(CompareStatus.different);
            }
            //MessageBox.Show(msg, "Compare Hashes", MessageBoxButtons.OK);
        }


        /// <summary>
        /// Simple method to clear form statuses for next action
        /// </summary>
        private void ClearStatus()
        {
            lblStatus.Text = string.Empty;
        }

        private void tbxCompareHash_TextChanged(object sender, EventArgs e)
        {
            // Need this event for when the text changes the status is cleared.
            // Help says this will fire programmatically or with physical change
            ClearStatus();
            if (this.tbxCompareHash.Text.Length > 0 && this.tbxFilesHash.Text.Length > 0)
                ActionCompareHashes();
            else
                SetCompareStatus(CompareStatus.clear);
        }

        private void tbxFilesHash_TextChanged(object sender, EventArgs e)
        {
            if (this.tbxCompareHash.Text.Length > 0 && this.tbxFilesHash.Text.Length > 0)
                ActionCompareHashes();
            else
                SetCompareStatus(CompareStatus.clear);

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutDialog ad = new AboutDialog();
            ad.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings frmSet = new frmSettings();
            frmSet.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveCurrentHashAsDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string v = string.Empty;

            if (rbtnMd5.Checked)
                v = HashType.MD5.ToString();
            if (rbtnSha1.Checked)
                v = HashType.SHA1.ToString();
            if (rbtnSha256.Checked)
                v = HashType.SHA256.ToString();
            Properties.Settings.Default.DefaultHashType = v;
            Properties.Settings.Default.Save();
            MessageBox.Show(string.Format("Your default hash type is saved as {0}", v), "Save Default Hash Type", MessageBoxButtons.OK);

        }

        private void SetCompareStatus(CompareStatus cstat)
        {
            switch (cstat)
            {
                case CompareStatus.clear:
                    this.tbxFilesHash.BackColor = Color.White;
                    this.tbxCompareHash.BackColor = Color.White;
                    break;

                case CompareStatus.different:
                    this.tbxFilesHash.BackColor = Color.Tomato;
                    this.tbxCompareHash.BackColor = Color.Tomato;
                    break;

                case CompareStatus.same:
                    this.tbxFilesHash.BackColor = Color.LightGreen;
                    this.tbxCompareHash.BackColor = Color.LightGreen;
                    break;
    
            }
        }

        enum CompareStatus
        {
            clear,
            different,
            same
        }
// **** Testing methods        
        private void getColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetCompareStatus(CompareStatus.different);
            //MessageBox.Show(this, "Hello there");
        }

    }
}
