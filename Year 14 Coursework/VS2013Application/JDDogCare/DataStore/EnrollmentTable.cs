using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataStore
{
    public class EnrollmentTable
    {
        /*
            Purpose: 
            Creates a new record in the enrollment table

            Parameters: 
            EnrollmentModel will be populated, although enrollmentID will have a defualt value of 0

            Return:
            enrollmentID of the record created

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public int create(EnrollmentModel enrollmentModel)
        {
            int enrollmentID = 0;
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("CreateEnrollment");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@EnrollmentID", SqlDbType.Int).Direction = ParameterDirection.Output; //Output parameter that will be returned from this function
                commandCreate.Parameters.Add("@ClientID", SqlDbType.Int).Value = enrollmentModel.clientId;
                commandCreate.Parameters.Add("@DogID", SqlDbType.Int).Value = enrollmentModel.dogId;
                commandCreate.Parameters.Add("@ProgramID", SqlDbType.Int).Value = enrollmentModel.programId;

                //Which connection to execute the command against
                commandCreate.Connection = connection;

                //Execute the command
                commandCreate.ExecuteNonQuery(); //Used for creating new records

                //Handle return values
                enrollmentID = Convert.ToInt32(commandCreate.Parameters["@EnrollmentID"].Value); //Convert the output value from the SP into an int

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown create: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return enrollmentID;
        }

        /*
            Purpose: 
            Reads a record from the enrollment table

            Parameters: 
            enrollmentID allows the user to select a specific record

            Return:
            All information from the selected record

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public EnrollmentModel read(int enrollmentID)
        {
            EnrollmentModel enrollmentModel = new EnrollmentModel();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ReadEnrollmentByID");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;
                commandRead.Parameters.Add("@EnrollmentID", SqlDbType.Int).Value = enrollmentID;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                dataReader.Read(); //Only expecting one record - Read moves to the first record - Get values from the columns
                enrollmentModel = convertCursorRecordToModel(dataReader);

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown read: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return enrollmentModel;
        }

        /*
            Purpose: 
            Reads all records from the enrollment table

            Parameters: 
            No parameters

            Return:
            All information from every record

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public List<EnrollmentModel> readAll()
        {
            List<EnrollmentModel> enrollments = new List<EnrollmentModel>();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ReadEnrollment");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                while (dataReader.Read()) //Expecting multiple records - Read moves to the next record - Get values from the columns
                {
                    //Create a new enrollment model for every record in the data reader
                    EnrollmentModel enrollmentModel = new EnrollmentModel();

                    //Copy information from the data reader into the new data model
                    enrollmentModel = convertCursorRecordToModel(dataReader);

                    //Copy the new model onto the end of the list
                    enrollments.Add(enrollmentModel);
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

            return enrollments;
        }

        /*
            Purpose: 
            Counts the number of records in the enrollment table

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
                SqlCommand commandRead = new SqlCommand("CountEnrollment");
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
            Updates a record from the enrollment table

            Parameters: 
            enrollmentID to select a specific record

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public void update(EnrollmentModel enrollmentModel)
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("UpdateEnrollmentByID");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@EnrollmentID", SqlDbType.Int).Value = enrollmentModel.id;
                commandCreate.Parameters.Add("@ClientID", SqlDbType.Int).Value = enrollmentModel.clientId;
                commandCreate.Parameters.Add("@DogID", SqlDbType.Int).Value = enrollmentModel.dogId;
                commandCreate.Parameters.Add("@ProgramID", SqlDbType.Int).Value = enrollmentModel.programId;

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
            Deletes a record from the enrollment table

            Parameters: 
            enrollmentID to select a specific record

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public void delete(int enrollmentID)
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("DeleteEnrollmentByID");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@EnrollmentID", SqlDbType.Int).Value = enrollmentID;

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

                SqlCommand commandCreate = new SqlCommand("DeleteEnrollmentAll");
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
        private EnrollmentModel convertCursorRecordToModel(SqlDataReader dataReader)
        {
            EnrollmentModel enrollmentModel = new EnrollmentModel();

            enrollmentModel.id = dataReader.GetInt32(0);
            enrollmentModel.clientId = dataReader.GetInt32(1);
            enrollmentModel.dogId = dataReader.GetInt32(2);
            enrollmentModel.programId = dataReader.GetInt32(3);

            return enrollmentModel;
        }
    }
}
