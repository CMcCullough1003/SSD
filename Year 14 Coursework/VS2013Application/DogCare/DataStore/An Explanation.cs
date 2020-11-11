using System;
using System.Collections.Generic;
using System.Text;

namespace DataStore
{
    class An_Explanation
    {
        /*
        //Think of your application and the datbase server as using plastic cups and string to communicate.
        //Your app has a cup that you talk into.
        //The database has a cup that it uses to listen with.
        //You need to create the string that connects the two.

        //These are the details for connecting your app to the database server running on your computer
        //"Data Source=.\SQLEXPRESS". SQLEXPRESS indicates the type of database server. The ".\" means the database server is running on the same computer as the app
        //"Initial Catalog=SchoolBuilders". This is the name of the database we want to use 
        string connectionDetails = @"Data Source=.\SQLEXPRESS;Initial Catalog=Dogs;Integrated Security=True";

        //Create an object that can make a connection to the database server running on your computer. 
        //Think of this as the bit of string
        var connection = new SqlConnection(connectionDetails);

        try
        {
            //Try to open a connection to the database server
            //Think of this as trying to join the cups with the bit of string
            connection.Open();

            //Create a command object that can run an sql statement against the database 
            //Think of this as what you are going to say into the app cup
            //SqlCommand command = new SqlCommand("Select * from address");
            SqlCommand command = new SqlCommand("SelectAddress");
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.Add("@Postcode", SqlDbType.VarChar).Value = "CCC";

            //It's possible for your app to attempt to connect with many database servers
            //Think of this as making sure we are sending the right request down the right bit of string
            command.Connection = connection;

            //Execute the select request
            //Think of this as sending the request from the app cup down the string. When the response comes back put it into the DataReader 
            SqlDataReader dataReader = command.ExecuteReader();

            //The response will (hopefully) contain a list of information. Loop down this list until we get to the end
            while (dataReader.Read())
            {

                //GetValue(0) gets the contents of the first column. GetValue(1) gets the contents of the second column. etc
                Console.WriteLine("<" + dataReader.GetValue(0) + "> <" + dataReader.GetValue(1) + ">");
            }

            //Always close the connection to the database when you have finished
            //The database server has many cups to listen for requests from different computers and users but if they are all busy the next user can't connect.
            //Think of this as cutting the string and freeing up one of the database servers cups.
            connection.Close();
        }
        catch (Exception ex)
        {
            //Uh-oh.
            //Something went wrong.
            Console.WriteLine("Exception thrown: " + ex.Message);
        }
    */
    }
}
