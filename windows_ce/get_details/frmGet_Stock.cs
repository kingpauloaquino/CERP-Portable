using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Xml;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using windows_ce.local_api;

namespace windows_ce
{
    public partial class frmGet_Stock : Form
    {
        CERPService api = new CERPService();
        public frmGet_Stock()
        {
            InitializeComponent();
            populate_details();
        }

        void populate_details()
        {
            try
            {
                var list = Get_Details.Now();
                if (list != null)
                {
                    foreach (var l in list)
                    {
                        lblCode.Text = config.Barcode;
                        lblClass.Text = "Class.: " + l.Classification;
                        lblUnit.Text = "Unit: " + l.Unit;
                        lblMinStock.Text = "Min. Stk.Qty: " + l.Msq;
                        lblDesc.Text = "Desc: " + l.Description;
                        lblTotalQty.Text = "Total Qty: " + l.Total_qty;
                    }
                }
                else
                {
                    MessageBox.Show("Barcode isn't exist!");
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            frmStock_Items get_stock_items = new frmStock_Items();
            get_stock_items.Show();
        }
    }
}