using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using windows_ce.local_api;
using System.Threading;

namespace windows_ce
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
            //populate();
        }

        public void populate()
        {
            //foreach (var x in api.get_barcode(config.Barcode))
            //{
            //    label1.Text = "Item Code: " + x.Item_code;
            //    label2.Text = "Barcode: " + config.Barcode;
            //    label3.Text = "Brand: " + x.Item_brand_name;
            //    label4.Text = "Name: " + x.Item_name;
            //    label5.Text = "Desc: " + x.Item_description;
            //    label6.Text = "Net: " + x.Item_net_wt;
            //    label7.Text = "Qty: " + x.Item_qty.ToString();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != string.Empty)
            //{
            //    int qty = Convert.ToInt32(textBox1.Text);
            //    if (api.update(config.Barcode, qty))
            //    {
            //        MessageBox.Show("Update was successful", "Notification");
            //        populate();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Update wasn't successful", "Notification");
            //    }
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void frmView_Load(object sender, EventArgs e)
        {

        }

        private void frmView_Closing(object sender, CancelEventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}