using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace windows_ce
{
    public partial class frmGet_Deliveries2 : Form
    {
        public frmGet_Deliveries2(int delivery_id)
        {
            InitializeComponent();

            foreach (var l in Get_Deliveries.Item(delivery_id))
            {
                lblPo.Text = l.PO_No;
                lblDevDate.Text = l.Delivery_Date;
                lblSupplier.Text = l.Supplier_Name;
            }

            Get_Deliveries.save_to_localdb();
            dataGrid1.DataSource = Get_Deliveries.Delivery_Items();
            dataGrid1.TableStyles.Add(Get_Deliveries.DataTable_Style2());
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            frmGet_Deliveries back = new frmGet_Deliveries();
            back.Show();

            this.Dispose();
            this.Close();
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            frmGet_Deliveries3 frmGet_Deliveries3 = new frmGet_Deliveries3();
            frmGet_Deliveries3.Show();
        }
    }
}