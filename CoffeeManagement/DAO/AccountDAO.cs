using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeManagement.DAO
{
    internal class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance { 
            get { 
                if (instance == null) instance = new AccountDAO();
                return instance; 
            } 
        }

        public bool Login(string username, string password)
        {
            string query = "select * from dbo.Account where username = N'"+username+"' and password = N'"+password+"'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return dataTable.Rows.Count > 0;
        }

    }
}
