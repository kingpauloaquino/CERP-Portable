using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.WindowsCE.Forms;
using BCD.net;

using System.Xml;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using windows_ce.local_api;

namespace windows_ce
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            frmScanner prd = new frmScanner("Stock");
            prd.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmGet_Deliveries get_deliveries = new frmGet_Deliveries();
            get_deliveries.Show();
        }
    }
}