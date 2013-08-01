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
    public partial class frmGet_Deliveries : Form
    {
        public frmGet_Deliveries()
        {
            InitializeComponent();
            dataGrid1.DataSource = Get_Deliveries.populate_deliveries();
            dataGrid1.TableStyles.Add(Get_Deliveries.DataTable_Style());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGrid1[dataGrid1.CurrentCell.RowNumber, 0]);
            frmGet_Deliveries2 get_deliveries2 = new frmGet_Deliveries2(id);
            get_deliveries2.Show();

            this.Dispose();
            this.Close();
        }
    }
}