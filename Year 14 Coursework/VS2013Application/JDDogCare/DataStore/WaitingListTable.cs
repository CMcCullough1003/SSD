using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataStore
{
    public class WaitingListTable
    {
        /*
           Purpose: 
           Creates a new record in the waitingList table

           Parameters: 
           WaitingListModel will be populated, although waitingListID will have a defualt value of 0

           Return:
           waitingListID of the record created

           Exceptions:
           Logs any exception thrown within the stored procedure and rethrows
       */
        public int create(WaitingListModel waitingListModel)
        {
            int waitingListID = 0;
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("CreateWaitingList");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@WaitingListID", SqlDbType.Int).Direction = ParameterDirection.Output; //Output parameter that will be returned from this function
                commandCreate.Parameters.Add("@ClientID", SqlDbType.Int).Value = waitingListModel.clientId;
                commandCreate.Parameters.Add("@DogID", SqlDbType.Int).Value = waitingListModel.dogId;
                commandCreate.Parameters.Add("@ProgramTypeID", SqlDbType.Int).Value = waitingListModel.programTypeId;
                commandCreate.Parameters.Add("@JoinDate", SqlDbType.DateTime).Value = waitingListModel.joinDate;
                commandCreate.Parameters.Add("@InviteIssued", SqlDbType.Bit).Value = waitingListModel.inviteIssued;

                //Which connection to execute the command against
                commandCreate.Connection = connection;

                //Execute the command
                commandCreate.ExecuteNonQuery(); //Used for creating new records

                //Handle return values
                waitingListID = Convert.ToInt32(commandCreate.Parameters["@WaitingListID"].Value); //Convert the output value from the SP into an int

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown create: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return waitingListID;
        }

        /*
            Purpose: 
            Reads a record from the waitingList table

            Parameters: 
            waitingListID allows the user to select a specific record

            Return:
            All information from the selected record

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public WaitingListModel read(int waitingListID)
        {
            WaitingListModel waitingListModel = new WaitingListModel();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ReadWaitingListByID");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;
                commandRead.Parameters.Add("@WaitingListID", SqlDbType.Int).Value = waitingListID;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                dataReader.Read(); //Only expecting one record - Read moves to the first record - Get values from the columns
                waitingListModel = convertCursorRecordToModel(dataReader);

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown read: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return waitingListModel;
        }

        /*
            Purpose: 
            Reads all records from the waitingList table

            Parameters: 
            No parameters

            Return:
            All information from every record

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public List<WaitingListModel> readAll()
        {
            List<WaitingListModel> waitingLists = new List<WaitingListModel>();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ReadWaitingList");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                while (dataReader.Read()) //Expecting multiple records - Read moves to the next record - Get values from the columns
                {
                    //Create a new waitingList model for every record in the data reader
                    WaitingListModel waitingListModel = new WaitingListModel();

                    //Copy information from the data reader into the new data model
                    waitingListModel = convertCursorRecordToModel(dataReader);

                    //Copy the new model onto the end of the list
                    waitingLists.Add(waitingListModel);
                }

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown readAll: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return waitingLists;
        }

        /*
            Purpose: 
            Counts the number of records in the waitingList table

            Parameters: 
            No parameters

            Return:
            The number of records

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */

        public int count()
        {
            int count = 0;

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("CountWaitingList");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for counting records

                //Only overwrite defualt when record is returned
                if (dataReader.HasRows == true)
                {
                    //Handle return values
                    dataReader.Read(); //Expecting one record with one column
                    count = dataReader.GetInt32(0);
                }

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown count: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return count;
        }

        /*
            Purpose: 
            Updates a record from the waitingList table

            Parameters: 
            waitingListID to select a specific record

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public void update(WaitingListModel waitingListModel)
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("UpdateWaitingListByID");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@WaitingListID", SqlDbType.Int).Value = waitingListModel.id;
                commandCreate.Parameters.Add("@ClientID", SqlDbType.Int).Value = waitingListModel.clientId;
                commandCreate.Parameters.Add("@DogID", SqlDbType.Int).Value = waitingListModel.dogId;
                commandCreate.Parameters.Add("@ProgramTypeID", SqlDbType.Int).Value = waitingListModel.programTypeId;
                commandCreate.Parameters.Add("@JoinDate", SqlDbType.DateTime).Value = waitingListModel.joinDate;
                commandCreate.Parameters.Add("@InviteIssued", SqlDbType.Bit).Value = waitingListModel.inviteIssued;

                //Which connection to execute the command against
                commandCreate.Connection = connection;

                //Execute the command
                commandCreate.ExecuteNonQuery(); //Used for updating new records

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown update: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }
        }

        /*
            Purpose: 
            Deletes a record from the waitingList table

            Parameters: 
            waitingListID to select a specific record

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public void delete(int waitingListID)
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("DeleteWaitingListByID");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@WaitingListID", SqlDbType.Int).Value = waitingListID;

                //Which connection to execute the command against
                commandCreate.Connection = connection;

                //Execute the command
                commandCreate.ExecuteNonQuery(); //Used for deleting new records

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown delete: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }
        }

        /*
            Purpose: 
            Deletes all record from the class table

            Parameters: 
            No parameters

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */

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
        private WaitingListModel convertCursorRecordToModel(SqlDataReader dataReader)
        {
            WaitingListModel waitingListModel = new WaitingListModel();

            waitingListModel.id = dataReader.GetInt32(0);
            waitingListModel.clientId = dataReader.GetInt32(1);
            waitingListModel.dogId = dataReader.GetInt32(2);
            waitingListModel.programTypeId = dataReader.GetInt32(3);
            waitingListModel.joinDate = dataReader.GetDateTime(4);
            waitingListModel.inviteIssued = dataReader.GetBoolean(5);

            return waitingListModel;
        }
    }
}
