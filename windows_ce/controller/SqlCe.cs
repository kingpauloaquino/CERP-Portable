using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Data.SqlServerCe;
using windows_ce;

namespace kpa.Data.SqlServerCe
{
    public class CE
    {
        static string dbPath = "Data Source=" +
                System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) +
                "\\database\\temp_database.sdf;Password=";
        public static string Connection
        {
            get { return dbPath; }
            set { dbPath = value; }
        }

        public DataTable dt(string xmlString)
        {
            DataTable dt;
            try
            {
                StringReader sr = new StringReader(xmlString);
                DataSet ds = new DataSet();
                dt = new DataTable("table");
                ds.ReadXml(sr);
                dt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                dt = null;
            }
            return dt;
        }

        public DataTable DataTable(string sql)
        {
            DataTable dt;
            SqlCeConnection sqlcon = new SqlCeConnection(Connection);
            SqlCeDataAdapter sqlda = new SqlCeDataAdapter(sql, sqlcon);
            try
            {
                sqlcon.Open();
                dt = new DataTable("table");
                sqlda.Fill(dt);
                dt = (dt.Rows.Count > 0) ? dt : null;
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dt;
        }

        public listCollection Select(string query, int[] index)
        {
            listCollection list = new listCollection();
            SqlCeConnection sqlcon = new SqlCeConnection(Connection);
            SqlCeCommand sqlcom = new SqlCeCommand(query, sqlcon);
            SqlCeDataReader sqldr;
            try
            {
                sqlcon.Open();
                sqldr = sqlcom.ExecuteReader();
                while (sqldr.Read())
                {
                    listFields l = new listFields();
                    for (int i = 0; i < index.Length; i++)
                    {
                       l.sqlDr[i] = sqldr[i].ToString();
                    }
                    list.Add(l);
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public bool Execute(string query)
        {
            SqlCeConnection sqlcon = new SqlCeConnection(Connection);
            SqlCeCommand sqlcom = new SqlCeCommand(query, sqlcon);
            if (sqlcon.State != ConnectionState.Closed)
            {
                sqlcon.Close();
            }
            sqlcon.Open();
            sqlcom.ExecuteNonQuery();
            sqlcon.Close();
            return true;
        }
    }
}
