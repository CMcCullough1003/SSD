using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataStore
{
    public class DogTable
    {
        /*
             Purpose: 
             Creates a new record in the dog table

             Parameters: 
             DogModel will be populated, although dogID will have a defualt value of 0

             Return:
             dogID of the record created

             Exceptions:
             Logs any exception thrown within the stored procedure and rethrows
         */
        public int create(DogModel dogModel)
        {
            int dogID = 0;
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("CreateDog");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@DogID", SqlDbType.Int).Direction = ParameterDirection.Output; //Output parameter that will be returned from this function
                commandCreate.Parameters.Add("@ClientID", SqlDbType.Int).Value = dogModel.clientID;
                commandCreate.Parameters.Add("@Name", SqlDbType.VarChar).Value = dogModel.name;
                commandCreate.Parameters.Add("@Age", SqlDbType.Int).Value = dogModel.age;
                commandCreate.Parameters.Add("@Breed", SqlDbType.VarChar).Value = dogModel.breed;
                commandCreate.Parameters.Add("@ExperienceOrQualification", SqlDbType.Bit).Value = dogModel.experienceOrQualification;

                //Which connection to execute the command against
                commandCreate.Connection = connection;

                //Execute the command
                commandCreate.ExecuteNonQuery(); //Used for creating new records

                //Handle return values
                dogID = Convert.ToInt32(commandCreate.Parameters["@DogID"].Value); //Convert the output value from the SP into an int

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown create: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return dogID;
        }

        /*
            Purpose: 
            Reads a record from the dog table

            Parameters: 
            dogID allows the user to select a specific record

            Return:
            All information from the selected record

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public DogModel read(int dogID)
        {
            DogModel dogModel = new DogModel();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ReadDogByID");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;
                commandRead.Parameters.Add("@DogID", SqlDbType.Int).Value = dogID;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                dataReader.Read(); //Only expecting one record - Read moves to the first record - Get values from the columns
                dogModel = convertCursorRecordToModel(dataReader);

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown read: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return dogModel;
        }

        /*
            Purpose: 
            Reads all records from the dog table

            Parameters: 
            No parameters

            Return:
            All information from every record

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public List<DogModel> readAll()
        {
            List<DogModel> dogs = new List<DogModel>();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ReadDogs");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                while (dataReader.Read()) //Expecting multiple records - Read moves to the next record - Get values from the columns
                {
                    //Create a new dog model for every record in the data reader
                    DogModel dogModel = new DogModel();

                    //Copy information from the data reader into the new data model
                    dogModel = convertCursorRecordToModel(dataReader);

                    //Copy the new model onto the end of the list
                    dogs.Add(dogModel);
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

            return dogs;
        }

        /*
            Purpose: 
            Counts the number of records in the dog table

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
                SqlCommand commandRead = new SqlCommand("CountDog");
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
            Updates a record from the dog table

            Parameters: 
            dogID to select a specific record

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public void update(DogModel dogModel)
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("UpdateDogByID");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@DogID", SqlDbType.Int).Value = dogModel.id;
                commandCreate.Parameters.Add("@ClientID", SqlDbType.Int).Value = dogModel.clientID;
                commandCreate.Parameters.Add("@Name", SqlDbType.VarChar).Value = dogModel.name;
                commandCreate.Parameters.Add("@Age", SqlDbType.Int).Value = dogModel.age;
                commandCreate.Parameters.Add("@Breed", SqlDbType.VarChar).Value = dogModel.breed;
                commandCreate.Parameters.Add("@ExperienceOrQualification", SqlDbType.Bit).Value = dogModel.experienceOrQualification;

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
            Deletes a record from the dog table

            Parameters: 
            dogID to select a specific record

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public void delete(int dogID)
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("DeleteDogByID");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@DogID", SqlDbType.Int).Value = dogID;

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

                SqlCommand commandCreate = new SqlCommand("DeleteDogAll");
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
        private DogModel convertCursorRecordToModel(SqlDataReader dataReader)
        {
            DogModel dogModel = new DogModel();

            dogModel.id = dataReader.GetInt32(0);
            dogModel.clientID = dataReader.GetInt32(1);
            dogModel.name = dataReader.GetString(2);
            dogModel.age = dataReader.GetInt32(3);
            dogModel.breed = dataReader.GetString(4);
            dogModel.experienceOrQualification = dataReader.GetBoolean(5);

            return dogModel;
        }
    }
}
