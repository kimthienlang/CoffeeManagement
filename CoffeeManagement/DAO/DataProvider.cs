using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAO
{
    public class DataProvider
    {
        private static DataProvider instance = null;
        public static DataProvider Instance { 
            get { 
                if (instance == null) instance = new DataProvider(); 
                return instance; 
            } 
        }
        string strConnection = @"Data Source=.\sqlexpress;Initial Catalog=ManageCoffeeShop;Integrated Security=True";
        
        public DataTable ExecuteQuery(string query, object[] para = null)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConnection)) { 
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                
                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dataTable);
                connection.Close();
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string query, object[] para = null)
        {
            int data;

            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] para = null)
        {
            object data;

            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                if (para != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, para[i]);
                            i++;
                        }
                    }
                }

                data = cmd.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
