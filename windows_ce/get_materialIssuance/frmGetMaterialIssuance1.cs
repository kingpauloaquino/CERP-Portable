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
    public partial class frmGetMaterialIssuance1 : Form
    {
        public frmGetMaterialIssuance1()
        {
            InitializeComponent();

            Get_MaterialIssuance.process();
            dataGrid1.DataSource = Get_MaterialIssuance.populate;
            dataGrid1.TableStyles.Add(Get_MaterialIssuance.DataTable_Style());
        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGrid1[dataGrid1.CurrentCell.RowNumber, 0]);
            Get_MaterialIssuance.miid = id;

            frmScanner scan = new frmScanner("MateialIssuance");
            scan.Show();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}