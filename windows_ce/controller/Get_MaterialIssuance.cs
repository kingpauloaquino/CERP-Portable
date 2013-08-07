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
        
        public static DataTable populate()
        {
            sqlCe = new CE();
            api = new CERPService();
            dt = new DataTable("table");
            dt = sqlCe.dt(api.GetMaterialIssuance());
            return dt;
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
                    using (SqlCeConnection sqlcon1 = new SqlCeConnection(CE.Connection))
                    {
                        using (SqlCeCommand sqlCom1 = new SqlCeCommand("", sqlcon1))
                        {
                            sqlcon1.Open();
                            sqlCom1.CommandText = "INSERT INTO GetMaterialIssuance" + 
                            "(id, request_no, batch_no, requested_date, expected_date, remarks, completion_status) " +
                            "VALUES (@id, @request_no, @batch_no, @requested_date, @expected_date, @remarks, @completion_status);";
                            sqlCom1.Parameters.AddWithValue("@id",i);
                            sqlCom1.Parameters.AddWithValue("@request_no", m["request_no"].ToString());
                            sqlCom1.Parameters.AddWithValue("@batch_no", m["batch_no"].ToString());
                            sqlCom1.Parameters.AddWithValue("@requested_date", config.DefaultDateTimeFormat(Convert.ToDateTime(m["requested_date"])));
                            sqlCom1.Parameters.AddWithValue("@expected_date", config.DefaultDateTimeFormat(Convert.ToDateTime(m["expected_date"])));
                            sqlCom1.Parameters.AddWithValue("@remarks", m["remarks"].ToString());
                            sqlCom1.Parameters.AddWithValue("@completion_status", m["completion_status"].ToString());
                            sqlCom1.ExecuteNonQuery();
                            sqlcon1.Close();
                        }
                    }

                    //SqlCeParameter sqlParam = new SqlCeParameter(
                    //sqlParam .Value =
                    string query = "";
                    //sqlCe.Execute(query);
                    System.Threading.Thread.Sleep(100);

                    dt = new DataTable("table");
                    dt = sqlCe.dt(api.GetMaterialIssuanceItems(i));
                    DataRow[] result2 = dt.Select();

                    foreach (DataRow l in result1)
                    {
                        query = "INSERT INTO GetMaterialIssuanceItems" +
                        "(id, issue_id, code, lot_no, qty, status, address) " +
                        "VALUES " +
                        "( '" + i + "', " +
                        "'" + m["issue_id"].ToString() + "', " +
                        "'" + m["code"].ToString() + "', " +
                        "'" + m["lot_no"].ToString() + "', " +
                        "'" + m["qty"].ToString() + "', " +
                        "'" + m["status"].ToString() + "', " +
                        "'" + m["address"].ToString() + "' " +
                        ");";
                        //sqlCe.Execute(query);
                    }
                } 
            }
        }

        public static DataTable getMaterialIssuanceItems(int id)
        {
            sqlCe = new CE();
            api = new CERPService();
            dt = new DataTable("table");
            dt = sqlCe.dt(api.GetMaterialIssuanceItems(id));
            return dt;
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
            supplier_name.Width = 108;
            dtStyle.GridColumnStyles.Add(supplier_name);
            return dtStyle;
        }

    }
}
