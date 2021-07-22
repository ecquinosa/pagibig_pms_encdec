using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pagibig_pms_encdec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtb2.Clear();

            if (chkEncrypt.Checked)
                rtb2.AppendText(EncryptionUtility.EncryptText(rtb1.Text));
            else
                rtb2.AppendText(EncryptionUtility.DecryptText(rtb1.Text));
        }
    }
}
