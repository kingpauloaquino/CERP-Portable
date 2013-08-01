using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using BCD.net; 

namespace windows_ce
{
    public partial class frmLogin : Form
    {
        BCD.net.CBScanner BScanner = new BCD.net.CBScanner();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != null)
            //{
            //    config.Username = textBox1.Text;
            //    this.Close();
            //}
            //else
            //{
            //    MessageBox.Show("Oops, Please enter a valid username.");
            //}
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.BScanner.StartBarcodeScan();
        }
    }
}