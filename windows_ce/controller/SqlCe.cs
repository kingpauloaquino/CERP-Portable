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
        private static string Connection
        {
            get {
                return "Data Source=" +
                    System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) +
                    "\\database\\temp_database.sdf;Password=";
            }
        }

        public SqlCeConnection Open()
        {
            return new SqlCeConnection(Connection);
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
            try
            {
                using (SqlCeConnection sqlCon = Open())
                {
                    using (SqlCeDataAdapter sqlDa = new SqlCeDataAdapter(sql, sqlCon))
                    {
                        sqlCon.Open();
                        dt = new DataTable("table");
                        sqlDa.Fill(dt);
                        dt = (dt.Rows.Count > 0) ? dt : null;
                        sqlCon.Close();
                    }
                }
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
            try
            {
                using (SqlCeConnection sqlCon = Open())
                {
                    using (SqlCeCommand sqlCom = new SqlCeCommand(query, sqlCon))
                    {
                        sqlCon.Open();
                        SqlCeDataReader sqlDr = sqlCom.ExecuteReader();
                        while (sqlDr.Read())
                        {
                            listFields l = new listFields();
                            for (int i = 0; i < index.Length; i++)
                            {
                                l.sqlDr[i] = sqlDr[i].ToString();
                            }
                            list.Add(l);
                        }
                        sqlCon.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public bool Execute(string query)
        {
            using (SqlCeConnection sqlCon = Open())
            {
                using (SqlCeCommand sqlcom = new SqlCeCommand(query, sqlCon))
                {
                    sqlCon.Open();
                    sqlcom.ExecuteNonQuery();
                    sqlCon.Close();
                    return true;
                }
            }
        }
    }
}
