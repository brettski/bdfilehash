using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace BDFileHash
{
    public partial class AboutDialog : Form
    {
        public AboutDialog()
        {
            InitializeComponent();
            this.lblVersionInfo.Text = string.Format("{0},  {1}", FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion, System.IO.File.GetCreationTime(Assembly.GetExecutingAssembly().Location).ToString("MMMM dd, yyyy"));
        }

        private void llProductWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "http://bdfilehash.codeplex.com");
        }
    }
}
