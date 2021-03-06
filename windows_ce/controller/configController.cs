﻿using System;
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
    public class config
    {
        public static string Username { get; set; }
        public static string Barcode { get; set; }// "ASSYCOM-075A";
        public static string Type { get; set; }

        public static string format_currency(decimal amount)
        {
            return String.Format("{0:c}", amount).Replace("$", "");
        }

        public static string DefaultDateFormat(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd");
        }

        public static string DefaultDateTimeFormat(DateTime dt)
        {
            return dt.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static DataTable get(string xmlString)
        {
            StringReader sr = new StringReader(xmlString);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable("table");
            ds.ReadXml(sr);
            dt = ds.Tables[0];
            return dt;
        }
    }
}
