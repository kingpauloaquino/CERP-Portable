using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Data;
using System.Drawing;
using System.Xml;
using System.IO;
using System.Net;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace windows_ce
{
    public class DataGrid_TableStyle
    {
        public static DataGridTableStyle frmStock_Items()
        {
            DataGridTableStyle dtStyle = new DataGridTableStyle();
            dtStyle.MappingName = "table";

            DataGridTextBoxColumn id = new DataGridTextBoxColumn();
            id.MappingName = "id";
            id.HeaderText = "ID";
            id.Width = 30;
            dtStyle.GridColumnStyles.Add(id);

            DataGridTextBoxColumn lotno = new DataGridTextBoxColumn();
            lotno.MappingName = "lot_no";
            lotno.HeaderText = "Lot#";
            lotno.Width = 80;
            dtStyle.GridColumnStyles.Add(lotno);

            DataGridTextBoxColumn qty = new DataGridTextBoxColumn();
            qty.MappingName = "qty";
            qty.HeaderText = "Qty";
            qty.Width = 96;
            dtStyle.GridColumnStyles.Add(qty);

            return dtStyle;
        }
    }
}
