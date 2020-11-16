using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataStore;

namespace DogCare
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //add all the records
            populateDatabase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStaff());
        }
        
        private static void populateDatabase() {

            //clear all the records in all the tables
            new DataStoreTableHelper().clearAllTables();

            //check the tables are empty
            consoleTableCounts();

            //Adding some records to it will be easier to create and update the screens

            //add Staff records
            StaffTable staffTable = new StaffTable();

            StaffModel staffModelBob = new StaffModel();
            staffModelBob.name = "Bob";
            int staffIdBob = staffTable.create(staffModelBob);

            StaffModel staffModelKate = new StaffModel();
            staffModelKate.name = "Kate";
            int staffIdKate = staffTable.create(staffModelKate);


            //add ProgramType records
            ProgramTypeTable programTypeTable = new ProgramTypeTable();

            ProgramTypeModel programTypeModelRegular = new ProgramTypeModel();
            programTypeModelRegular.description = "Regular";
            int programTypeIdRegular = programTypeTable.create(programTypeModelRegular);

            ProgramTypeModel programTypeModelAdvanced = new ProgramTypeModel();
            programTypeModelAdvanced.description = "Advanced";
            int programTypeIdAdvanced = programTypeTable.create(programTypeModelAdvanced);


            //add ProgramCost records
            ProgramCostTable programCostTable = new ProgramCostTable();

            ProgramCostModel programCostModel1 = new ProgramCostModel();
            programCostModel1.depositAmount = 50.0;
            programCostModel1.fullPaymentPercentageDiscount = 25.0;
            programCostModel1.sessionCost = 35.0;
            int programCostId1 = programCostTable.create(programCostModel1);

            ProgramCostModel programCostModel2 = new ProgramCostModel();
            programCostModel2.depositAmount = 40.0;
            programCostModel2.fullPaymentPercentageDiscount = 15.0;
            programCostModel2.sessionCost = 20.0;
            int programCostId2 = programCostTable.create(programCostModel2);


            //add Program records
            ProgramTable programTable = new ProgramTable();

            ProgramModel programModel1 = new ProgramModel();
            programModel1.programTypeId = programTypeIdAdvanced;
            programModel1.programCostId = programCostId1;
            programModel1.noOfClasses = 10;
            programModel1.dogSpacesMaximum = 5;
            int programId1 = programTable.create(programModel1);

            ProgramModel programModel2 = new ProgramModel();
            programModel2.programTypeId = programTypeIdRegular;
            programModel2.programCostId = programCostId2;
            programModel2.noOfClasses = 7;
            programModel2.dogSpacesMaximum = 15;
            int programId2 = programTable.create(programModel2);




            //check the tables have records
            consoleTableCounts();
        }

        private static void consoleTableCounts() {

            Console.WriteLine("How many records in the tables");
            Console.WriteLine("==============================");

            Int32 classCount = new ClassTable().count();
            Console.WriteLine("classCount = " + classCount);

            Int32 clientCount = new ClientTable().count();
            Console.WriteLine("clientCount = " + clientCount);

            Int32 dogCount = new DogTable().count();
            Console.WriteLine("dogCount = " + dogCount);

            Int32 enrollmentCount = new EnrollmentTable().count();
            Console.WriteLine("enrollmentCount = " + enrollmentCount);

            Int32 paymentCount = new PaymentTable().count();
            Console.WriteLine("paymentCount = " + paymentCount);

            Int32 programCostCount = new ProgramCostTable().count();
            Console.WriteLine("programCostCount = " + programCostCount);

            Int32 programCount = new ProgramTable().count();
            Console.WriteLine("programCount = " + programCount);

            Int32 programTypeCount = new ProgramTypeTable().count();
            Console.WriteLine("programTypeCount = " + programTypeCount);

            Int32 staffCount = new StaffTable().count();
            Console.WriteLine("staffCount = " + staffCount);

            Int32 waitingListCount = new WaitingListTable().count();
            Console.WriteLine("waitingListCount = " + waitingListCount);

            Console.WriteLine("==============================");

        }
    }
}
