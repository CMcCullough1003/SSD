using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataStore
{
    public class DataStoreTableHelper
    {

        /*
          Purpose: 
          Delete all records from the database

          Parameters: 
          No parameters

          Return:
          No return

          Exceptions:
          None expected
      */
        public void clearAllTables()
        {
            new WaitingListTable().deleteAll();
            new PaymentTable().deleteAll();
            new EnrollmentTable().deleteAll();
            new ClassTable().deleteAll();
            new ProgramTable().deleteAll();
            new ProgramVarietyTable().deleteAll();
            new StaffTable().deleteAll();
            new DogTable().deleteAll();
            new ClientTable().deleteAll();
        }
    }
}
