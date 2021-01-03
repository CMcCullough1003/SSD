using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataStore
{
    public class ProgramVarietyTable
    {
        /*
           Purpose: 
           Creates a new record in the programCost table

           Parameters: 
           ProgramVarietyModel will be populated, although programCostID will have a defualt value of 0

           Return:
           programCostID of the record created

           Exceptions:
           Logs any exception thrown within the stored procedure and rethrows
       */
        public int create(ProgramVarietyModel programVarietyModel)
        {
            int programCostID = 0;
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("CreateProgramVariety");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@ProgramVarietyID", SqlDbType.Int).Direction = ParameterDirection.Output; //Output parameter that will be returned from this function
                commandCreate.Parameters.Add("@Name", SqlDbType.Text).Value = programVarietyModel.name;
                commandCreate.Parameters.Add("@DepositAmount", SqlDbType.Float).Value = programVarietyModel.depositAmount;
                commandCreate.Parameters.Add("@SessionCost", SqlDbType.Float).Value = programVarietyModel.sessionCost;
                commandCreate.Parameters.Add("@FullPaymentPercentageDiscount", SqlDbType.Float).Value = programVarietyModel.fullPaymentPercentageDiscount;
                commandCreate.Parameters.Add("@DogSpacesMaximum", SqlDbType.Int).Value = programVarietyModel.dogSpacesMaximum;
                commandCreate.Parameters.Add("@NoOfClasses", SqlDbType.Int).Value = programVarietyModel.noOfClasses;

                //Which connection to execute the command against
                commandCreate.Connection = connection;

                //Execute the command
                commandCreate.ExecuteNonQuery(); //Used for creating new records

                //Handle return values
                programCostID = Convert.ToInt32(commandCreate.Parameters["@ProgramVarietyID"].Value); //Convert the output value from the SP into an int

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown create: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return programCostID;
        }

        /*
            Purpose: 
            Reads a record from the programCost table

            Parameters: 
            programCostID allows the user to select a specific record

            Return:
            All information from the selected record

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public ProgramVarietyModel read(int programCostID)
        {
            ProgramVarietyModel programCostModel = new ProgramVarietyModel();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ReadProgramVarietyByID");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;
                commandRead.Parameters.Add("@ProgramVarietyID", SqlDbType.Int).Value = programCostID;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                dataReader.Read(); //Only expecting one record - Read moves to the first record - Get values from the columns
                programCostModel = convertCursorRecordToModel(dataReader);

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown read: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return programCostModel;
        }

        /*
            Purpose: 
            Reads all records from the programCost table

            Parameters: 
            No parameters

            Return:
            All information from every record

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public List<ProgramVarietyModel> readAll()
        {
            List<ProgramVarietyModel> programCosts = new List<ProgramVarietyModel>();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ReadProgramVariety");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                while (dataReader.Read()) //Expecting multiple records - Read moves to the next record - Get values from the columns
                {
                    //Create a new programCost model for every record in the data reader
                    ProgramVarietyModel programCostModel = new ProgramVarietyModel();

                    //Copy information from the data reader into the new data model
                    programCostModel = convertCursorRecordToModel(dataReader);

                    //Copy the new model onto the end of the list
                    programCosts.Add(programCostModel);
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

            return programCosts;
        }

        /*
            Purpose: 
            Counts the number of records in the programCost table

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
                SqlCommand commandRead = new SqlCommand("CountProgramVariety");
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
            Updates a record from the programCost table

            Parameters: 
            programCostID to select a specific record

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public void update(ProgramVarietyModel programVarietyModel)
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("UpdateProgramVarietyByID");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@ProgramVarietyID", SqlDbType.Int).Value = programVarietyModel.id;
                commandCreate.Parameters.Add("@Name", SqlDbType.Text).Value = programVarietyModel.name;
                commandCreate.Parameters.Add("@DepositAmount", SqlDbType.Float).Value = programVarietyModel.depositAmount;
                commandCreate.Parameters.Add("@SessionCost", SqlDbType.Float).Value = programVarietyModel.sessionCost;
                commandCreate.Parameters.Add("@FullPaymentPercentageDiscount", SqlDbType.Float).Value = programVarietyModel.fullPaymentPercentageDiscount;
                commandCreate.Parameters.Add("@DogSpacesMaximum", SqlDbType.Int).Value = programVarietyModel.dogSpacesMaximum;
                commandCreate.Parameters.Add("@NoOfClasses", SqlDbType.Int).Value = programVarietyModel.noOfClasses;

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
            Deletes a record from the programCost table

            Parameters: 
            programCostID to select a specific record

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public void delete(int programCostID)
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("DeleteProgramVarietyByID");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@ProgramVarietyID", SqlDbType.Int).Value = programCostID;

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
            Deletes all record from the programCost table

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

                SqlCommand commandCreate = new SqlCommand("DeleteProgramVarietyAll");
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

        private ProgramVarietyModel convertCursorRecordToModel(SqlDataReader dataReader)
        {
            ProgramVarietyModel programVarietyModel = new ProgramVarietyModel();

            programVarietyModel.id = dataReader.GetInt32(0);
            programVarietyModel.name = dataReader.GetString(1);
            programVarietyModel.depositAmount = dataReader.GetDouble(2);
            programVarietyModel.sessionCost = dataReader.GetDouble(3);
            programVarietyModel.fullPaymentPercentageDiscount = dataReader.GetDouble(4);
            programVarietyModel.dogSpacesMaximum = dataReader.GetInt32(5);
            programVarietyModel.noOfClasses = dataReader.GetInt32(6);


            return programVarietyModel;
        }
    }
}
