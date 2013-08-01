using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlServerCe;

namespace kpa.Data.SqlServerCe
{
    public class CE
    {
        string connection_string = string.Empty;
        public string Connection
        {
            get { return connection_string; }
            set { connection_string = value; }
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
                    indexCollections f = new indexCollections();
                    if (index.Length == 1)
                    {
                        f.Index0 = sqldr[index[0]].ToString();
                    }
                    else if (index.Length == 2)
                    {
                        f.Index0 = sqldr[index[0]].ToString();
                        f.Index1 = sqldr[index[1]].ToString();
                    }
                    else if (index.Length == 3)
                    {
                        f.Index0 = sqldr[index[0]].ToString();
                        f.Index1 = sqldr[index[1]].ToString();
                        f.Index2 = sqldr[index[2]].ToString();
                    }
                    else if (index.Length == 4)
                    {
                        f.Index0 = sqldr[index[0]].ToString();
                        f.Index1 = sqldr[index[1]].ToString();
                        f.Index2 = sqldr[index[2]].ToString();
                        f.Index3 = sqldr[index[3]].ToString();
                    }
                    else if (index.Length == 5)
                    {
                        f.Index0 = sqldr[index[0]].ToString();
                        f.Index1 = sqldr[index[1]].ToString();
                        f.Index2 = sqldr[index[2]].ToString();
                        f.Index3 = sqldr[index[3]].ToString();
                        f.Index4 = sqldr[index[4]].ToString(); 
                    }
                    else if (index.Length == 6)
                    {
                        f.Index0 = sqldr[index[0]].ToString();
                        f.Index1 = sqldr[index[1]].ToString();
                        f.Index2 = sqldr[index[2]].ToString();
                        f.Index3 = sqldr[index[3]].ToString();
                        f.Index4 = sqldr[index[4]].ToString();
                        f.Index5 = sqldr[index[5]].ToString(); 
                    }
                    else if (index.Length == 7)
                    {
                        f.Index0 = sqldr[index[0]].ToString();
                        f.Index1 = sqldr[index[1]].ToString();
                        f.Index2 = sqldr[index[2]].ToString();
                        f.Index3 = sqldr[index[3]].ToString();
                        f.Index4 = sqldr[index[4]].ToString();
                        f.Index5 = sqldr[index[5]].ToString();
                        f.Index6 = sqldr[index[6]].ToString(); 
                    }
                    else if (index.Length == 8)
                    {
                        f.Index0 = sqldr[index[0]].ToString();
                        f.Index1 = sqldr[index[1]].ToString();
                        f.Index2 = sqldr[index[2]].ToString();
                        f.Index3 = sqldr[index[3]].ToString();
                        f.Index4 = sqldr[index[4]].ToString();
                        f.Index5 = sqldr[index[5]].ToString();
                        f.Index6 = sqldr[index[6]].ToString();
                        f.Index7 = sqldr[index[7]].ToString();
                    }
                    else if (index.Length == 9)
                    {
                        f.Index0 = sqldr[index[0]].ToString();
                        f.Index1 = sqldr[index[1]].ToString();
                        f.Index2 = sqldr[index[2]].ToString();
                        f.Index3 = sqldr[index[3]].ToString();
                        f.Index4 = sqldr[index[4]].ToString();
                        f.Index5 = sqldr[index[5]].ToString();
                        f.Index6 = sqldr[index[6]].ToString();
                        f.Index7 = sqldr[index[7]].ToString();
                        f.Index8 = sqldr[index[8]].ToString();
                    }
                    else if (index.Length == 10)
                    {
                        f.Index0 = sqldr[index[0]].ToString();
                        f.Index1 = sqldr[index[1]].ToString();
                        f.Index2 = sqldr[index[2]].ToString();
                        f.Index3 = sqldr[index[3]].ToString();
                        f.Index4 = sqldr[index[4]].ToString();
                        f.Index5 = sqldr[index[5]].ToString();
                        f.Index6 = sqldr[index[6]].ToString();
                        f.Index7 = sqldr[index[7]].ToString();
                        f.Index8 = sqldr[index[8]].ToString();
                        f.Index9 = sqldr[index[9]].ToString();
                    }
                    list.Add(f);
                }
                return list;
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
            try
            {
                sqlcon.Open();
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return false;
        }
    }
}
