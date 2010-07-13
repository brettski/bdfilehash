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

        }
    }
}
