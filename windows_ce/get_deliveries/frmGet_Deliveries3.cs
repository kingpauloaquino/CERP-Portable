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
    public partial class frmGet_Deliveries3 : Form
    {
        public frmGet_Deliveries3()
        {
            InitializeComponent();

            dataGrid1.DataSource = Get_Deliveries.Delivery_Items();
            dataGrid1.TableStyles.Add(Get_Deliveries.DataTable_Style3());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Get_Deliveries.get_id[dataGrid1.CurrentCell.RowNumber]);
            //int id = Convert.ToInt32(Get_Deliveries.get_id[dataGrid1.CurrentCell.RowNumber]);
            //frmReceived_Deliveries received_deliveries = new frmReceived_Deliveries(id);
            //received_deliveries.Show();

            //this.Dispose();
            //this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                Get_Deliveries.update_received_deliveries(
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                Get_Deliveries.get_items_received()
                ));
        }
    }
}