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
            new ClientDogTable().deleteAll();
            new WaitingListTable().deleteAll();
            new PaymentTable().deleteAll();
            new EnrollmentTable().deleteAll();
            new ClassTable().deleteAll();
            new ProgramTable().deleteAll();
            new ProgramCostTable().deleteAll();
            new ProgramTypeTable().deleteAll();
            new StaffTable().deleteAll();
            new DogTable().deleteAll();
            new ClientTable().deleteAll();
        }
    }
}
