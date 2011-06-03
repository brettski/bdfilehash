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
            // Tool tip values
            toolTip1.AutoPopDelay = 10000;  // 10 sec.
            //TODO:Option to disable tool tips
            // Setup tool tips
            string ttmsg = string.Empty;
            ttmsg = "Clear all text boxes";
            toolTip1.SetToolTip(this.btnClearAll, ttmsg);
            ttmsg = "Pick a text file to parse a hash value out of";
            toolTip1.SetToolTip(this.btnGetCompareFile, ttmsg);
            ttmsg = "Pick a file to hash";
            toolTip1.SetToolTip(this.btnGetHashFile, ttmsg);
            ttmsg = "Calculates hash for file in file to hash text box";
            toolTip1.SetToolTip(this.btnCreateHash, ttmsg);
            ttmsg = "Move the file's hash value to the compare hash field\nso you may hash another file and compare them";
            toolTip1.SetToolTip(this.btnSavetoCompare, ttmsg);
            ttmsg = "Don't see the hash type you need?\nSend us a note and we'll do what we can to add it!";
            toolTip1.SetToolTip(this.grpBoxHashType, ttmsg);
        }

        private void frmFileHash_Load(object sender, EventArgs e)
        {
            // ** To hide our testing item on the menu strip **
            testToolStripMenuItem.Visible = false;
            batchHashingToolStripMenuItem.Visible = false;
            // --------------------------------------------- **
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
            else if (HashType.SHA512.ToString() == v)
                rbtnSha512.Checked = true;
            else
                rbtnMd5.Checked = true;
            currentFolder = Properties.Settings.Default.DefaultStartingFolder;
            if (isSendTo && Properties.Settings.Default.HashFileOnLoad)
            {
                ActionCreateHash();
            }

        }

        private void btnGetHashFile_Click(object sender, EventArgs e)
        {
            string s = PickAFile();
            if (!string.IsNullOrEmpty(s))
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
            HashType htype = GetSelectedHashType();
            if (HashType.NONE == htype)
            {
                MessageBox.Show("Invalid Hash Type");
                return;
            }
            Cursor.Current = Cursors.WaitCursor;
            ht.CreateFileHash(tbxFile.Text, htype);
            if (ht.InError)
            {
                // Throw Error
                MessageBox.Show("ERROR: " + ht.ErrorMsg);
                Cursor.Current = Cursors.Default;
                return;
            }
            Cursor.Current = Cursors.Default;
            this.tbxFilesHash.Text = ht.Hash;
            if(Properties.Settings.Default.CopyHashToClipboard && !string.IsNullOrEmpty(ht.Hash))
                Clipboard.SetText(ht.Hash);
            currentFolder = ht.PathToFileToHash;
            if (Properties.Settings.Default.CheckLikeTextfileForHash) //TODO:Check how setting works when removed from config file
            {
                if (ht.FindTextHashFile(htype))
                {
                    tbxCompareHash.Text = ht.TextFileHashFound;
                    lblStatus.Text = string.Format("Hash value found in file {0}", ht.TextFileFound);

                }
            }
        }

        protected HashType GetSelectedHashType()
        {
            HashType htype = HashType.MD5;
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
            else if (rbtnSha512.Checked)
            {
                htype = HashType.SHA512;
            }
            else
            {
                //MessageBox.Show("Invalid Hash Type");
                htype = HashType.NONE;
            }
            return htype;
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
            else if (rbtnSha1.Checked || rbtnSha256.Checked || rbtnSha512.Checked)
            {
                filter = "SHA* (*.SHA*)|*.SHA*|All Files (*.*)|*.*";
                hashCFile = PickAFile(filter);
                if (string.IsNullOrEmpty(hashCFile))
                    return;
                tbxCompareHash.Text = FileTools.FindHashInFile(hashCFile, GetSelectedHashType());
            }
        }

        private void btnSavetoCompare_Click(object sender, EventArgs e)
        {
            // Write hash value from file hash text box to compare text box
            tbxCompareHash.Text = tbxFilesHash.Text;
            tbxFilesHash.Text = string.Empty;
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
                SetCompareStatus(CompareStatus.same);
            }
            else
            {
                msg = @"Hashes are different!";
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
                    Color cd = Color.FromArgb(255, 0, 0);
                    this.tbxFilesHash.BackColor = cd;
                    this.tbxCompareHash.BackColor = cd;
                    break;

                case CompareStatus.same:
                    Color cs = Color.FromArgb(0, 255, 0);
                    this.tbxFilesHash.BackColor = cs;
                    this.tbxCompareHash.BackColor = cs;
                    break;

            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.tbxFile.Text = string.Empty;
            this.tbxFilesHash.Text = string.Empty;
            this.tbxCompareHash.Text = string.Empty;
        }

        private void tbxFile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if('\x1' == e.KeyChar)
                tbxFile.SelectAll();
        }

        private void tbxFilesHash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ('\x1' == e.KeyChar)
                tbxFilesHash.SelectAll();
        }

        private void tbxCompareHash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ('\x1' == e.KeyChar)
                tbxCompareHash.SelectAll();
        }

        // **** Testing methods        
        private void getColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SetCompareStatus(CompareStatus.different);
            string smsg;
            smsg = string.Format("init {0}; reshow {1}; pop {2}", toolTip1.InitialDelay, toolTip1.ReshowDelay, toolTip1.AutoPopDelay);
            MessageBox.Show(this, smsg);
            this.tbxCompareHash.SelectAll();
        }

        private void batchHashingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open batch hashing form
            frmBatch fbtch = new frmBatch();
            fbtch.Show();
        }

        private void tbxFilesHash_DragEnter(object sender, DragEventArgs e)
        {
            tbxFile_DragEnter(sender, e);
        }

        private void tbxFilesHash_DragDrop(object sender, DragEventArgs e)
        {
            tbxFile_DragDrop(sender, e);
        }

        private void tbxFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void tbxFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 1)
            {
                MessageBox.Show(@"You may only drop one file at a time!");
                return;
            }
            this.tbxFile.Text = files[0];
            ActionCreateHash();
        }

        private void hashTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Opens form to enter text in to be hashed;
            frmHashText hashtext = new frmHashText();
            hashtext.ParentHashTypeSelected = GetSelectedHashType();
            hashtext.ShowDialog();
            if (string.IsNullOrEmpty(hashtext.CalculatedHash))
                return;
            this.tbxFile.Text = "~From Text~";
            this.tbxFilesHash.Text = hashtext.CalculatedHash;
            if (Properties.Settings.Default.CopyHashToClipboard && !string.IsNullOrEmpty(hashtext.CalculatedHash))
                Clipboard.SetText(hashtext.CalculatedHash);
            // Hashes compaired on update value event on text boxes
        }
    }
}
