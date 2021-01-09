using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataStore
{
    class Reports
    {
        public List<ReportScheduleModel> readReportSchedule()
        {
            List<ReportScheduleModel> reportScheduleList = new List<ReportScheduleModel>();

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
                    reportScheduleList.Add(reportScheduleModel);
                }

                //Close connection to database
                dataStoreHelper.closeConnection(connection);

            }
            catch (Exception ex)
            {
                //Log the exception and rethrow
                Console.WriteLine("Exception thrown ReportScheduleList: " + this.GetType().Name + ". <" + ex.Message + ">");
                throw ex;
            }

            return reportScheduleList;
        }
    }
}
