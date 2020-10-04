using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataStore
{
    public class ProgramTypeTable
    {
        /*
           Purpose: 
           Creates a new record in the programType table

           Parameters: 
           ProgramTypeModel will be populated, although programTypeID will have a defualt value of 0

           Return:
           programTypeID of the record created

           Exceptions:
           Logs any exception thrown within the stored procedure and rethrows
       */
        public int create(ProgramTypeModel programTypeModel)
        {
            int programTypeID = 0;
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("CreateProgramType");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@ProgramTypeID", SqlDbType.Int).Direction = ParameterDirection.Output; //Output parameter that will be returned from this function
                commandCreate.Parameters.Add("@Description", SqlDbType.VarChar).Value = programTypeModel.description;

                //Which connection to execute the command against
                commandCreate.Connection = connection;

                //Execute the command
                commandCreate.ExecuteNonQuery(); //Used for creating new records

                //Handle return values
                programTypeID = Convert.ToInt32(commandCreate.Parameters["@ProgramTypeID"].Value); //Convert the output value from the SP into an int

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown create: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return programTypeID;
        }

        /*
            Purpose: 
            Reads a record from the programType table

            Parameters: 
            programTypeID allows the user to select a specific record

            Return:
            All information from the selected record

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public ProgramTypeModel read(int programTypeID)
        {
            ProgramTypeModel programTypeModel = new ProgramTypeModel();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ReadProgramTypeByID");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;
                commandRead.Parameters.Add("@ProgramTypeID", SqlDbType.Int).Value = programTypeID;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                dataReader.Read(); //Only expecting one record - Read moves to the first record - Get values from the columns
                programTypeModel = convertCursorRecordToModel(dataReader);

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown read: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return programTypeModel;
        }

        /*
            Purpose: 
            Reads all records from the programType table

            Parameters: 
            No parameters

            Return:
            All information from every record

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public List<ProgramTypeModel> readAll()
        {
            List<ProgramTypeModel> programTypes = new List<ProgramTypeModel>();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ReadProgramType");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                while (dataReader.Read()) //Expecting multiple records - Read moves to the next record - Get values from the columns
                {
                    //Create a new programType model for every record in the data reader
                    ProgramTypeModel programTypeModel = new ProgramTypeModel();

                    //Copy information from the data reader into the new data model
                    programTypeModel = convertCursorRecordToModel(dataReader);

                    //Copy the new model onto the end of the list
                    programTypes.Add(programTypeModel);
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

            return programTypes;
        }

        /*
            Purpose: 
            Counts the number of records in the programType table

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
                SqlCommand commandRead = new SqlCommand("CountProgramType");
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
            Updates a record from the programType table

            Parameters: 
            programTypeID to select a specific record

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public void update(ProgramTypeModel programTypeModel)
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("UpdateProgramTypeByID");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@ProgramTypeID", SqlDbType.Int).Value = programTypeModel.id;
                commandCreate.Parameters.Add("@Description", SqlDbType.VarChar).Value = programTypeModel.description;

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
            Deletes a record from the programType table

            Parameters: 
            programTypeID to select a specific record

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public void delete(int programTypeID)
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("DeleteProgramTypeByID");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@ProgramTypeID", SqlDbType.Int).Value = programTypeID;

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
            Deletes all record from the programType table

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

                SqlCommand commandCreate = new SqlCommand("DeleteProgramTypeAll");
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

        private ProgramTypeModel convertCursorRecordToModel(SqlDataReader dataReader)
        {
            ProgramTypeModel programTypeModel = new ProgramTypeModel();

            programTypeModel.id = dataReader.GetInt32(0);
            programTypeModel.description = dataReader.GetString(1);


            return programTypeModel;
        }
    }
}
