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
    public partial class frmGetMaterialIssuance2 : Form
    {
       
        public frmGetMaterialIssuance2()
        {
            InitializeComponent();

            try
            {
                dataGrid1.DataSource = Get_MaterialIssuance.getMaterialItemsByBarCode(config.Barcode);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmGetMaterialIssuance2_Load(object sender, EventArgs e)
        {

        }
    }
}