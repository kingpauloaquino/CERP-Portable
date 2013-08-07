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
using windows_ce.local_api;

using kpa.Data.SqlServerCe;

namespace windows_ce
{
    class Get_Deliveries
    {
        static CERPService api = new CERPService();
        public static List<string> get_id;
        static int delivery_id;
        static DataTable dt;

        public static DataTable populate_deliveries()
        {
            dt = new DataTable("table");
            dt = config.get(api.GetDeliveries());
            return dt;
        }

        public static listCollection Item(int id)
        {
            listCollection list = new listCollection();
            try
            {
                DataRow[] result = dt.Select("delivery_id = '" + id + "'");
                foreach (DataRow l in result)
                {
                  fieldCollections f = new fieldCollections();
                  delivery_id = Convert.ToInt32(l["delivery_id"].ToString());
                  f.PO_No =  l["po_number"].ToString();
                  f.Delivery_Date =  l["delivery_date"].ToString();
                  f.Supplier_Name = l["supplier_name"].ToString();
                  list.Add(f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return list;
        }

        static bool Is_Exist(Int64 id)
        {
            CE sqlCe = new CE();
            foreach (var l in sqlCe.Select(
                "SELECT did FROM tbl_delivery_items_received WHERE did = " + id, // - select query
                new int[] { 0 } // - index columns
                ))
            {
                if (l != null)
                {
                    return true;
                }
            }
            return false;
        }

        public static void save_to_localdb()
        {
            try
            {
                CE sqlCe = new CE();
                dt = new DataTable("table");
                dt = config.get(api.GetDeliveryItems(delivery_id));
                DataRow[] result = dt.Select();
                string query = string.Empty;
                foreach (DataRow l in result)
                {
                    if (!Is_Exist(Convert.ToInt64(l["id"])))
                    {
                        query = "INSERT INTO tbl_delivery_items_received (delivery_id, did, mid, code, po_qty, received_qty, status) " +
                                "VALUES " +
                                "('" + delivery_id + "', " +
                                "'" + l["id"].ToString() + "', " +
                                "'" + l["mid"].ToString() + "', " +
                                "'" + l["code"].ToString() + "', " +
                                "'" + l["po_qty"].ToString() + "', " +
                                "'" + l["received"].ToString() + "', " +
                                "'22');";
                        sqlCe.Execute(query);
                    }
                }

                query = "SELECT delivery_id, did, mid, code, po_qty, received_qty " +
                        "FROM tbl_delivery_items_received WHERE delivery_id = " + delivery_id;
                dt = new DataTable("table");
                dt = sqlCe.DataTable(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static DataTable Delivery_Items()
        {
            return dt;
        }

        public static bool update_qty(int id, Int64 received_qty, int status, string remarks)
        {
            CE sqlCe = new CE();
            string query = "UPDATE tbl_delivery_items_received SET " +
                           "received_qty = '" + received_qty + "', " +
                           "status = '" + status + "', " +
                           "remarks = '" + remarks + "' " +
                           "WHERE did = " + id;
            return sqlCe.Execute(query);
        }

        public static string get_items_received()
        {
            string result = string.Empty;
            CE sqlCe = new CE();
            dt = new DataTable("table");
            dt = sqlCe.DataTable("SELECT " +
                                 "did, " +
                                 "mid, " +
                                 "received_qty, " +
                                 "status, " +
                                 "remarks " +
                                 "FROM tbl_delivery_items_received " +
                                 "WHERE delivery_id = " + delivery_id);
            if (dt != null)
            {
                StringWriter sw = new StringWriter();
                dt.WriteXml(sw);
                result = sw.ToString().Trim().Replace("\r\n", "");
            }
            return result;
        }

        public static bool check_received(int id)
        {
            CE sqlCe = new CE();
            string query = "SELECT * FROM cerpdb.delivery_items WHERE did = '" + id + "' AND delivery_id > 0";
            foreach (var l in sqlCe.Select(query, new int[] { 0 }))
            {
                if (l != null)
                {
                    return true;
                }
            }
            return false;
        }

        public static string update_received_deliveries(string invoice, string receipt, string lot_no, string receiving_remarks, string items)
        {
            return api.ReceiveDelivery(delivery_id, invoice, receipt, lot_no, receiving_remarks, items);
        }

        public static DataGridTableStyle DataTable_Style()
        {
            DataGridTableStyle dtStyle = new DataGridTableStyle();
            dtStyle.MappingName = "table";

            DataGridTextBoxColumn id = new DataGridTextBoxColumn();
            id.MappingName = "delivery_id";
            id.HeaderText = "-";
            id.Width = 5;
            dtStyle.GridColumnStyles.Add(id);

            DataGridTextBoxColumn po_number = new DataGridTextBoxColumn();
            po_number.MappingName = "po_number";
            po_number.HeaderText = "PO #";
            po_number.Width = 100;
            dtStyle.GridColumnStyles.Add(po_number);

            DataGridTextBoxColumn supplier_name = new DataGridTextBoxColumn();
            supplier_name.MappingName = "supplier_name";
            supplier_name.HeaderText = "Supplier Name";
            supplier_name.Width = 108;
            dtStyle.GridColumnStyles.Add(supplier_name);
            return dtStyle;
        }

        public static DataGridTableStyle DataTable_Style2()
        {
            DataGridTableStyle dtStyle = new DataGridTableStyle();
            dtStyle.MappingName = "table";

            DataGridTextBoxColumn code = new DataGridTextBoxColumn();
            code.MappingName = "code";
            code.HeaderText = "MAT Code";
            code.Width = 100;
            dtStyle.GridColumnStyles.Add(code);

            DataGridTextBoxColumn po_qty = new DataGridTextBoxColumn();
            po_qty.MappingName = "po_qty";
            po_qty.HeaderText = "Qty";
            po_qty.Width = 108;
            dtStyle.GridColumnStyles.Add(po_qty);

            return dtStyle;
        }

        public static DataGridTableStyle DataTable_Style3()
        {
            DataGridTableStyle dtStyle = new DataGridTableStyle();
            dtStyle.MappingName = "table";

            DataGridTextBoxColumn code = new DataGridTextBoxColumn();
            code.MappingName = "code";
            code.HeaderText = "MAT Code";
            code.Width = 108;
            dtStyle.GridColumnStyles.Add(code);

            DataGridTextBoxColumn po_qty = new DataGridTextBoxColumn();
            po_qty.MappingName = "po_qty";
            po_qty.HeaderText = "Qty";
            po_qty.Width = 50;
            dtStyle.GridColumnStyles.Add(po_qty);

            DataGridTextBoxColumn received_qty = new DataGridTextBoxColumn();
            received_qty.MappingName = "received_qty";
            received_qty.HeaderText = "Rcd";
            received_qty.Width = 50;
            dtStyle.GridColumnStyles.Add(received_qty);

            return dtStyle;
        }
    }
}
