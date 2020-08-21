using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataStore
{
    class WaitingListTable
    {
        public void deleteAll()
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();
                SqlConnection connection = dataStoreHelper.createConnection();

                SqlCommand commandCreate = new SqlCommand("DeleteWaitingListAll");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;

                commandCreate.Connection = connection;

                commandCreate.ExecuteNonQuery();

                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception thrown: " + ex.Message);
            }
        }
    }
}
