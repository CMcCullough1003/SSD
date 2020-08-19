using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataStore
{
    public class DataStoreConnectionHelper
    {
        /*
            Purpose: 
            Create a connection to an SQL server database

            Parameters: 
            No parameters

            Return:
            Returns a connection to an SQL server database

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public SqlConnection createConnection()
        {
            //These are the details for connecting your app to the database server running on your computer
            //"Data Source=.\SQLEXPRESS". SQLEXPRESS indicates the type of database server. The ".\" means the database server is running on the same computer as the app
            //"Initial Catalog=SchoolBuilders". This is the name of the database we want to use 
            string connectionDetails = @"Data Source=.\SQLEXPRESS;Initial Catalog=Dogs;Integrated Security=True";

            //Create an object that can make a connection to the database server running on your computer. 
            //Think of this as the bit of string
            var connection = new SqlConnection(connectionDetails);

            connection.Open();

            return connection;
        }

        /*
            Purpose: 
            Close a connection to an SQL server database

            Parameters: 
            The connection to the database

            Return:
            No return

            Exceptions:
            None expected
        */
        public void closeConnection(SqlConnection connection)
        {
            connection.Close();
        }
    }
}
