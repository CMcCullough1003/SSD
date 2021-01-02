using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataStore
{
    public class PaymentTable
    {
        /*
           Purpose: 
           Creates a new record in the payment table

           Parameters: 
           PaymentModel will be populated, although paymentID will have a defualt value of 0

           Return:
           paymentID of the record created

           Exceptions:
           Logs any exception thrown within the stored procedure and rethrows
       */
        public int create(PaymentModel paymentModel)
        {
            int paymentID = 0;
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("CreatePayment");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@PaymentID", SqlDbType.Int).Direction = ParameterDirection.Output; //Output parameter that will be returned from this function
                commandCreate.Parameters.Add("@EnrollmentID", SqlDbType.Int).Value = paymentModel.enrollmentId;
                commandCreate.Parameters.Add("@PaymentType", SqlDbType.Text).Value = paymentModel.paymentType;
                commandCreate.Parameters.Add("@PaymentAmountDue", SqlDbType.Float).Value = paymentModel.paymentAmountDue;
                commandCreate.Parameters.Add("@PaymentAmountDueDate", SqlDbType.Date).Value = paymentModel.paymentAmountDueDate;
                commandCreate.Parameters.Add("@PaymentRecieved", SqlDbType.Int).Value = paymentModel.paymentRecieved;
                commandCreate.Parameters.Add("@PaymentRecievedDate", SqlDbType.Date).Value = paymentModel.paymentRecievedDate;
                commandCreate.Parameters.Add("@RecieptIssued", SqlDbType.Int).Value = paymentModel.recieptIssued;

                //Which connection to execute the command against
                commandCreate.Connection = connection;

                //Execute the command
                commandCreate.ExecuteNonQuery(); //Used for creating new records

                //Handle return values
                paymentID = Convert.ToInt32(commandCreate.Parameters["@PaymentID"].Value); //Convert the output value from the SP into an int

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown create: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return paymentID;
        }

        /*
            Purpose: 
            Reads a record from the payment table

            Parameters: 
            paymentID allows the user to select a specific record

            Return:
            All information from the selected record

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public PaymentModel read(int paymentID)
        {
            PaymentModel paymentModel = new PaymentModel();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ReadPaymentByID");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;
                commandRead.Parameters.Add("@PaymentID", SqlDbType.Int).Value = paymentID;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                dataReader.Read(); //Only expecting one record - Read moves to the first record - Get values from the columns
                paymentModel = convertCursorRecordToModel(dataReader);

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown read: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return paymentModel;
        }

        /*
            Purpose: 
            Reads all records from the payment table

            Parameters: 
            No parameters

            Return:
            All information from every record

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public List<PaymentModel> readAll()
        {
            List<PaymentModel> payments = new List<PaymentModel>();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ReadPayment");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                while (dataReader.Read()) //Expecting multiple records - Read moves to the next record - Get values from the columns
                {
                    //Create a new payment model for every record in the data reader
                    PaymentModel paymentModel = new PaymentModel();

                    //Copy information from the data reader into the new data model
                    paymentModel = convertCursorRecordToModel(dataReader);

                    //Copy the new model onto the end of the list
                    payments.Add(paymentModel);
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

            return payments;
        }

        /*
            Purpose: 
            Counts the number of records in the payment table

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
                SqlCommand commandRead = new SqlCommand("CountPayment");
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
            Updates a record from the payment table

            Parameters: 
            paymentID to select a specific record

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public void update(PaymentModel paymentModel)
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("UpdatePaymentByID");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@PaymentID", SqlDbType.Int).Value = paymentModel.id;
                commandCreate.Parameters.Add("@EnrollmentID", SqlDbType.Int).Value = paymentModel.enrollmentId;
                commandCreate.Parameters.Add("@PaymentType", SqlDbType.Text).Value = paymentModel.paymentType;
                commandCreate.Parameters.Add("@PaymentAmountDue", SqlDbType.Float).Value = paymentModel.paymentAmountDue;
                commandCreate.Parameters.Add("@PaymentAmountDueDate", SqlDbType.Date).Value = paymentModel.paymentAmountDueDate;
                commandCreate.Parameters.Add("@PaymentRecieved", SqlDbType.Bit).Value = paymentModel.paymentRecieved;
                commandCreate.Parameters.Add("@PaymentRecievedDate", SqlDbType.Date).Value = paymentModel.paymentRecievedDate;
                commandCreate.Parameters.Add("@RecieptIssued", SqlDbType.Bit).Value = paymentModel.recieptIssued;

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
            Deletes a record from the payment table

            Parameters: 
            paymentID to select a specific record

            Return:
            No return

            Exceptions:
            Logs any exception thrown within the stored procedure and rethrows
        */
        public void delete(int paymentID)
        {
            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandCreate = new SqlCommand("DeletePaymentByID");
                commandCreate.CommandType = System.Data.CommandType.StoredProcedure;
                commandCreate.Parameters.Add("@PaymentID", SqlDbType.Int).Value = paymentID;

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

                SqlCommand commandCreate = new SqlCommand("DeletePaymentAll");
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
        private PaymentModel convertCursorRecordToModel(SqlDataReader dataReader)
        {
            PaymentModel paymentModel = new PaymentModel();

            paymentModel.id = dataReader.GetInt32(0);
            paymentModel.enrollmentId = dataReader.GetInt32(1);
            paymentModel.paymentType = dataReader.GetString(2);
            paymentModel.paymentAmountDue = dataReader.GetDouble(3);
            paymentModel.paymentAmountDueDate = dataReader.GetDateTime(4);
            paymentModel.paymentRecieved = dataReader.GetBoolean(5);
            paymentModel.paymentRecievedDate = dataReader.GetDateTime(6);
            paymentModel.recieptIssued = dataReader.GetBoolean(7);

            return paymentModel;
        }
    }
}
