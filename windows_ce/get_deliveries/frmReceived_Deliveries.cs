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
    public partial class frmReceived_Deliveries : Form
    {
        public int new_id;
        public Int64 rqty = 0;
        public frmReceived_Deliveries(int id)
        {
            InitializeComponent();
            this.Location = new Point(0, 70);
            new_id = id;

            //DataRow[] result = config.DataTable.Select("item_id = " + id);
            //foreach (DataRow r in result)
            //{
            //    lblCode.Text = r["code"].ToString();
            //    rqty = Convert.ToInt64(r["po_qty_int"]);
            //    textBox1.Text = r["po_qty_int"].ToString();
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmGet_Deliveries3 get_deliveries3 = new frmGet_Deliveries3();
            get_deliveries3.Show();

            this.Dispose();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int status = 22;
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "")
                {
                    if (Convert.ToInt64(textBox1.Text) > rqty)
                    {
                        MessageBox.Show("Oop, invalid qty input");
                        return;
                    }

                    if (Convert.ToInt64(textBox1.Text) == rqty)
                    {
                        status = 21;
                    }

                    if (Get_Deliveries.update_qty(new_id, Convert.ToInt64(textBox1.Text), status, textBox2.Text))
                    {
                        MessageBox.Show("Successfully Updated");

                        frmGet_Deliveries3 get_deliveries3 = new frmGet_Deliveries3();
                        get_deliveries3.Show();

                        this.Dispose();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Enter remarks");
                }
            }
            else
            {
                MessageBox.Show("Enter received qty");
            }
        }
    }
}