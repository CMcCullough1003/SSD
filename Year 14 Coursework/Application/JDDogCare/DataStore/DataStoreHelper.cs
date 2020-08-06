using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataStore
{
    public class DataStoreHelper
    {
        public SqlConnection createConnection()
        {
            string connectionDetails = @"Data Source=.\SQLEXPRESS;Initial Catalog=Dogs;Integrated Security=True";

            //Create an object that can make a connection to the database server running on your computer. 
            //Think of this as the bit of string
            var connection = new SqlConnection(connectionDetails);

            connection.Open();

            return connection;
        }

        public void closeConnection(SqlConnection connection)
        {
            connection.Close();
        }

        public void clearAllTables()
        {
            new ClientTable().deleteAll();
        }
    }
}
