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
    public partial class frmStock_Items : Form
    {
        public frmStock_Items()
        {
            InitializeComponent();
            lblCode.Text = config.Barcode;
            dataGrid1.DataSource = Get_Details.Item_list();
            dataGrid1.TableStyles.Add(DataGrid_TableStyle.frmStock_Items());
        }

        private void dataGrid1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                frmItems item = new frmItems(dataGrid1[dataGrid1.CurrentCell.RowNumber, 0].ToString());
                item.Show();
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