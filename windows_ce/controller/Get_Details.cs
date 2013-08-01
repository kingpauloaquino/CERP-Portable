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

namespace windows_ce
{
    class Get_Details
    {
        static CERPService api = new CERPService();
        static DataTable dt;

        public static listCollection Now()
        {
            listCollection list = new listCollection();
            try
            {
                DataRow[] result = config.get(api.GetDetails(config.Barcode, config.Type)).Select();
                foreach (DataRow l in result)
                {
                    fieldCollections f = new fieldCollections();
                    f.Mid = l["mid"].ToString();
                    f.Code = l["code"].ToString();
                    f.Type = l["type"].ToString();
                    f.Classification = l["classification"].ToString();
                    f.Description = l["description"].ToString();
                    f.Model = l["model"].ToString();
                    f.Pic = l["pic"].ToString();
                    f.Unit = l["unit"].ToString();
                    f.Defect_rate = l["defect_rate"].ToString();
                    f.Sorting_percentage = l["sorting_percentage"].ToString();
                    decimal MSqty = Convert.ToDecimal(l["msq"].ToString());
                    f.Msq = config.format_currency(MSqty);
                    f.Status = l["status"].ToString();
                    f.Total_qty = Totl_Qty();
                    list.Add(f);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        static string Totl_Qty()
        {
            DataRow[] result = config.get(api.GetStock(config.Barcode, config.Type)).Select();
            foreach (DataRow l in result)
            {
                decimal qty = Convert.ToDecimal(l["total_stock"].ToString());
                return config.format_currency(qty);
            }
            return "0.00";
        }

        public static DataTable Item_list()
        {
            dt = new DataTable("table");
            dt = config.get(api.GetStockItems(config.Barcode, config.Type));
            return dt;
        }

        public static listCollection Item(string id)
        {
            listCollection list = new listCollection();
            try
            {
                DataRow[] result = dt.Select("id = " + id);
                foreach (DataRow l in result)
                {
                    fieldCollections f = new fieldCollections();
                    f.Lid = l["id"].ToString();
                    f.Litem_id = l["item_id"].ToString();
                    f.Linvoice_no = l["invoice_no"].ToString();
                    f.Llotno = l["lot_no"].ToString();
                    f.Lqty = l["qty"].ToString();
                    f.Lremarks = l["remarks"].ToString();
                    f.Lunit = l["unit"].ToString();
                    list.Add(f);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
    }
}
