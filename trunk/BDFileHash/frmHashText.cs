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
    public partial class frmHashText : Form
    {
        public frmHashText()
        {
            InitializeComponent();
            ParentHashTypeSelected = HashType.NONE;
            CalculatedHash = string.Empty;
        }

        public HashType ParentHashTypeSelected { get; set; }
        public string CalculatedHash { get; set; }

        private void btnHashText_Click(object sender, EventArgs e)
        {
            if (ParentHashTypeSelected == HashType.NONE)
            {
                MessageBox.Show("Invalid Hash Type selected on main form");
                return;
            }
            HashTools ht = new HashTools();
            ht.CreateTextHash(this.tbxHashText.Text, ParentHashTypeSelected);
            if (ht.InError)
            {
                MessageBox.Show("Hashing Error: " + ht.ErrorMsg);
                return;
            }
            CalculatedHash = ht.Hash;
            this.Close();
        }
    }
}
