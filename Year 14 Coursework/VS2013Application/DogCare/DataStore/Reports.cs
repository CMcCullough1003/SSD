using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataStore
{
    public class Reports
    {
        public List<ReportScheduleModel> readReportSchedule()
        {
            List<ReportScheduleModel> reportBillingList = new List<ReportScheduleModel>();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ScheduleReport");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                while (dataReader.Read()) //Expecting multiple records - Read moves to the next record - Get values from the columns
                {
                    //Create a new class model for every record in the data reader
                    ReportScheduleModel reportScheduleModel = new ReportScheduleModel();

                    reportScheduleModel.classId = dataReader.GetInt32(0);
                    reportScheduleModel.classDate = dataReader.GetDateTime(1);
                    reportScheduleModel.startTime = dataReader.GetTimeSpan(2);
                    reportScheduleModel.endTime = dataReader.GetTimeSpan(3);
                    reportScheduleModel.programVarietyId = dataReader.GetInt32(4);
                    reportScheduleModel.programVarietyName = dataReader.GetString(5);
                    reportScheduleModel.programId = dataReader.GetInt32(6);
                    reportScheduleModel.programName = dataReader.GetString(7);
                    reportScheduleModel.staffId = dataReader.GetInt32(8);
                    reportScheduleModel.staffName = dataReader.GetString(9);

                    //Copy the new model onto the end of the list
                    reportBillingList.Add(reportScheduleModel);
                }

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown ReportBillingList: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return reportBillingList;
        }

        public List<ReportAttendeesModel> readReportAttendees(Int32 programID)
        {
            List<ReportAttendeesModel> reportAttendeesList = new List<ReportAttendeesModel>();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("AttendeesReport");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;
                commandRead.Parameters.Add("@ProgramID", SqlDbType.Int).Value = programID;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                while (dataReader.Read()) //Expecting multiple records - Read moves to the next record - Get values from the columns
                {
                    //Create a new class model for every record in the data reader
                    ReportAttendeesModel reportAttendeesModel = new ReportAttendeesModel();

                    reportAttendeesModel.clientName = dataReader.GetString(0);
                    reportAttendeesModel.dogName = dataReader.GetString(1);

                    //Copy the new model onto the end of the list
                    reportAttendeesList.Add(reportAttendeesModel);
                }

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown ReportAttendeesList: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return reportAttendeesList;
        }

        public List<ReportBillingModel> readReportBilling()
        {
            List<ReportBillingModel> reportBillingList = new List<ReportBillingModel>();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("BillingReport");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                while (dataReader.Read()) //Expecting multiple records - Read moves to the next record - Get values from the columns
                {
                    //Create a new class model for every record in the data reader
                    ReportBillingModel reportBillingModel = new ReportBillingModel();

                    reportBillingModel.paymentId = dataReader.GetInt32(0);
                    reportBillingModel.clientName = dataReader.GetString(1);
                    reportBillingModel.paymentType = dataReader.GetString(2);
                    reportBillingModel.amountDue = dataReader.GetDouble(3);
                    reportBillingModel.dueDate = dataReader.GetDateTime(4);
                    reportBillingModel.daysOverdue = dataReader.GetInt32(5);
                    reportBillingModel.paymentRecieved = dataReader.GetBoolean(6);
                    reportBillingModel.programId = dataReader.GetInt32(7);
                    reportBillingModel.programName = dataReader.GetString(8);

                    //Copy the new model onto the end of the list
                    reportBillingList.Add(reportBillingModel);
                }

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown ReportBillingList: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return reportBillingList;
        }

        public List<ReportEnrollmentModel> readReportEnrollment()
        {
            List<ReportEnrollmentModel> reportEnrollmentList = new List<ReportEnrollmentModel>();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("EnrollmentReport");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                while (dataReader.Read()) //Expecting multiple records - Read moves to the next record - Get values from the columns
                {
                    //Create a new class model for every record in the data reader
                    ReportEnrollmentModel reportEnrollmentModel = new ReportEnrollmentModel();

                    reportEnrollmentModel.programName = dataReader.GetString(0);
                    reportEnrollmentModel.programVarietyName = dataReader.GetString(1);
                    reportEnrollmentModel.firstClassDate = dataReader.GetDateTime(2);
                    reportEnrollmentModel.numberEnrolled = dataReader.GetInt32(3);
                    reportEnrollmentModel.maxSpaces = dataReader.GetInt32(4);
                    reportEnrollmentModel.freeSpaces = dataReader.GetInt32(5);

                    //Copy the new model onto the end of the list
                    reportEnrollmentList.Add(reportEnrollmentModel);
                }

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown ReportEnrollmentList: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return reportEnrollmentList;
        }

        public List<ReportProgramModel> readReportProgram()
        {
            List<ReportProgramModel> reportProgramList = new List<ReportProgramModel>();

            try
            {
                DataStoreConnectionHelper dataStoreHelper = new DataStoreConnectionHelper();

                //Create connection to database
                SqlConnection connection = dataStoreHelper.createConnection();

                //Set up the stored procedure and the parameters
                SqlCommand commandRead = new SqlCommand("ProgramReport");
                commandRead.CommandType = System.Data.CommandType.StoredProcedure;

                //Which connection to execute the command against
                commandRead.Connection = connection;

                //Execute the command
                SqlDataReader dataReader = commandRead.ExecuteReader(); //Used for reading records

                //Handle return values
                while (dataReader.Read()) //Expecting multiple records - Read moves to the next record - Get values from the columns
                {
                    //Create a new class model for every record in the data reader
                    ReportProgramModel reportProgramModel = new ReportProgramModel();

                    reportProgramModel.programName = dataReader.GetString(0);
                    reportProgramModel.programVariety = dataReader.GetString(1);
                    reportProgramModel.NoOfClasses = dataReader.GetInt32(2);
                    reportProgramModel.NumberOfClassesArranged = dataReader.GetInt32(3);
                    reportProgramModel.missingClasses = dataReader.GetInt32(4);

                    //Copy the new model onto the end of the list
                    reportProgramList.Add(reportProgramModel);
                }

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown ReportProgramList: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return reportProgramList;
        }
    }
}
