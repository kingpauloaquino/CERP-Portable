using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using windows_ce.local_api;

namespace windows_ce
{
    public partial class frmItems : Form
    {
        public frmItems(string id)
        {
            InitializeComponent();
            populate(id);
        }

        void populate(string id)
        {
            try
            {
                var list = Get_Details.Item(id);
                if (list != null)
                {
                    foreach (var l in list)
                    {
                        lblCode.Text = config.Barcode;
                        lblInvoice.Text = l.Linvoice_no;
                        lblLot.Text = l.Llotno;
                        lblRemarks.Text = l.Lremarks;
                        lblQty.Text = l.Lqty;
                    }
                }
                else
                {
                    MessageBox.Show("Oop, Item did not found");
                    this.Dispose();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Dispose();
                this.Close();
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}