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
using System.Data.SqlServerCe;

using kpa.Data.SqlServerCe;

namespace windows_ce
{
    public class Get_MaterialIssuance
    {
        internal static CE sqlCe;
        internal static DataTable dt;
        internal static CERPService api;

        public static int miid { get; set; }
        
        public static DataTable populate
        {
            get { return dt; }
        }

        public static DataTable getMaterialIssuanceItems(int id)
        {
            sqlCe = new CE();
            api = new CERPService();
            return sqlCe.dt(api.GetMaterialIssuanceItems(id));
        }

        internal static bool id(int id)
        {
            sqlCe = new CE();
            var result = sqlCe.Select("SELECT id FROM GetMaterialIssuance WHERE id = " + id, new int[] { 0 });
            foreach (var i in result)
            {
                return true;
            }
            return false;
        }

        public static void process()
        {
            sqlCe = new CE();
            api = new CERPService();
            dt = new DataTable("table");
            dt = sqlCe.dt(api.GetMaterialIssuance());
            DataRow[] result1 = dt.Select();

            foreach (DataRow m in result1)
            {
                int i = Convert .ToInt32(m["id"]);
                if (!id(i))
                {
                    // save material issuance into local database
                    SaveMaterialIssuance(i,
                    m["request_no"].ToString(),
                    m["batch_no"].ToString(),
                    m["requested_date"].ToString(),
                    m["expected_date"].ToString(),
                    m["remarks"].ToString(),
                    m["completion_status"].ToString());

                    System.Threading.Thread.Sleep(100);

                    // get material issuance items 
                    DataRow[] result2 = sqlCe.dt(api.GetMaterialIssuanceItems(i)).Select();
                    foreach (DataRow l in result2)
                    {
                        // save material issuance items into local database
                        SaveMaterialIssuanceItems(i,
                        l["issue_id"].ToString(),
                        l["code"].ToString(),
                        l["lot_no"].ToString(),
                        l["qty"].ToString(),
                        l["status"].ToString(),
                        l["address"].ToString());
                    }
                } 
            }
        }

        internal static bool SaveMaterialIssuance(int id, string r_no, string b_no, string r_date, string e_date, string remarks, string c_status)
        {
            bool returns = false;
            sqlCe = new CE();
            using (SqlCeConnection sqlCon = sqlCe.Open())
            {
                string query = "INSERT INTO GetMaterialIssuance" +
                "(id, request_no, batch_no, requested_date, expected_date, remarks, completion_status) " +
                "VALUES (@id, @request_no, @batch_no, @requested_date, @expected_date, @remarks, @completion_status);";
                using (SqlCeCommand sqlCom = new SqlCeCommand(query, sqlCon))
                {
                    sqlCon.Open();
                    sqlCom.Parameters.AddWithValue("@id", id);
                    sqlCom.Parameters.AddWithValue("@request_no", r_no);
                    sqlCom.Parameters.AddWithValue("@batch_no", b_no);
                    sqlCom.Parameters.AddWithValue("@requested_date", config.DefaultDateTimeFormat(Convert.ToDateTime(r_date)));
                    sqlCom.Parameters.AddWithValue("@expected_date", config.DefaultDateTimeFormat(Convert.ToDateTime(e_date)));
                    sqlCom.Parameters.AddWithValue("@remarks", remarks);
                    sqlCom.Parameters.AddWithValue("@completion_status", c_status);
                    sqlCom.ExecuteNonQuery();
                    sqlCon.Close();
                    returns = true;
                }
            }
            return returns;
        }

        internal static bool SaveMaterialIssuanceItems(int id, string issue_id, string code, string l_no, string qty, string status, string address)
        {
            bool returns = false;
            sqlCe = new CE();
            using (SqlCeConnection sqlCon = sqlCe.Open())
            {
                string query = "INSERT INTO GetMaterialIssuanceItems" +
                "(id, issue_id, code, lot_no, qty, status, address) " +
                "VALUES (@id, @issue_id, @code, @l_no, @qty, @status, @address);";
                using (SqlCeCommand sqlCom = new SqlCeCommand(query, sqlCon))
                {
                    sqlCon.Open();
                    sqlCom.Parameters.AddWithValue("@id", id);
                    sqlCom.Parameters.AddWithValue("@issue_id", issue_id);
                    sqlCom.Parameters.AddWithValue("@code", code);
                    sqlCom.Parameters.AddWithValue("@l_no", l_no);
                    sqlCom.Parameters.AddWithValue("@qty", qty);
                    sqlCom.Parameters.AddWithValue("@status", status);
                    sqlCom.Parameters.AddWithValue("@address", address);
                    sqlCom.ExecuteNonQuery();
                    sqlCon.Close();
                    returns =  true;
                }
            }
            return returns;
        }

        public static DataTable getMaterialItemsByBarCode(string b_code)
        {
            sqlCe = new CE();
            return sqlCe.DataTable("SELECT * FROM GetMaterialIssuanceItems WHERE id '" + miid + "' AND code = '" + b_code + "'");
        }

        public static DataGridTableStyle DataTable_Style()
        {
            DataGridTableStyle dtStyle = new DataGridTableStyle();
            dtStyle.MappingName = "table";

            DataGridTextBoxColumn id = new DataGridTextBoxColumn();
            id.MappingName = "id";
            id.HeaderText = "-";
            id.Width = 5;
            dtStyle.GridColumnStyles.Add(id);

            DataGridTextBoxColumn po_number = new DataGridTextBoxColumn();
            po_number.MappingName = "request_no";
            po_number.HeaderText = "Request #";
            po_number.Width = 100;
            dtStyle.GridColumnStyles.Add(po_number);

            DataGridTextBoxColumn supplier_name = new DataGridTextBoxColumn();
            supplier_name.MappingName = "completion_status";
            supplier_name.HeaderText = "Status";
            supplier_name.Width = 107;
            dtStyle.GridColumnStyles.Add(supplier_name);
            return dtStyle;
        }

    }
}
