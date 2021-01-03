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
            Application.Run(new frmTraining());
        }
        
        private static void populateDatabase() {

            //clear all the records in all the tables
            new DataStoreTableHelper().clearAllTables();

            //check the tables are empty
            consoleTableCounts();

            //Adding some records to it will be easier to create and update the screens

            //add Client records
            ClientTable clientTable = new ClientTable();

            ClientModel clientModelBob = new ClientModel();
            clientModelBob.name = "Bob";
            clientModelBob.phone = "1234567890";
            clientModelBob.email = "bob@gmail.com";
            int clientIdBob = clientTable.create(clientModelBob);

            ClientModel clientModelKate = new ClientModel();
            clientModelKate.name = "Kate";
            clientModelKate.phone = "1234567890";
            clientModelKate.email = "kate@gmail.com";
            int clientIdKate = clientTable.create(clientModelKate);

            //add Dog records
            DogTable dogTable = new DogTable();

            DogModel dogModelBoxer = new DogModel();
            dogModelBoxer.name = "Boxer";
            dogModelBoxer.clientID = clientIdBob;
            dogModelBoxer.age = 7;
            dogModelBoxer.breed = "Bulldog";
            int dogIdBoxer = dogTable.create(dogModelBoxer);

            DogModel dogModelTed = new DogModel();
            dogModelTed.name = "Ted";
            dogModelTed.clientID = clientIdKate;
            dogModelTed.age = 7;
            dogModelTed.breed = "Shi Tzu";
            int dogIdTed = dogTable.create(dogModelTed);

            //add Staff records
            StaffTable staffTable = new StaffTable();

            StaffModel staffModelBob = new StaffModel();
            staffModelBob.name = "Bob";
            int staffIdBob = staffTable.create(staffModelBob);

            StaffModel staffModelKate = new StaffModel();
            staffModelKate.name = "Kate";
            int staffIdKate = staffTable.create(staffModelKate);


            //add ProgramCost records
            ProgramVarietyTable programVarietyTable = new ProgramVarietyTable();

            ProgramVarietyModel programVarietyAdvanced = new ProgramVarietyModel();
            programVarietyAdvanced.name = "Advanced";
            programVarietyAdvanced.depositAmount = 30.0;
            programVarietyAdvanced.fullPaymentPercentageDiscount = 0.0;
            programVarietyAdvanced.sessionCost = 30.0;
            programVarietyAdvanced.noOfClasses = 8;
            programVarietyAdvanced.dogSpacesMaximum = 8;
            int programCostId1 = programVarietyTable.create(programVarietyAdvanced);


            ProgramVarietyModel programVarietyRegular = new ProgramVarietyModel();
            programVarietyRegular.name = "Regular";
            programVarietyRegular.depositAmount = 20.0;
            programVarietyRegular.fullPaymentPercentageDiscount = 10.0;
            programVarietyRegular.sessionCost = 25.0;
            programVarietyRegular.noOfClasses = 6;
            programVarietyRegular.dogSpacesMaximum = 10;
            int programCostId2 = programVarietyTable.create(programVarietyRegular);


            //add Program records
            ProgramTable programTable = new ProgramTable();

            ProgramModel programModel1 = new ProgramModel();
            programModel1.name = programVarietyAdvanced.name ;
            programModel1.programVarietyId = programCostId1;
            int programId1 = programTable.create(programModel1);

            ProgramModel programModel2 = new ProgramModel();
            programModel2.name = programVarietyRegular.name;
            programModel2.programVarietyId = programCostId2;
            int programId2 = programTable.create(programModel2);

            //add Enrollment records
            EnrollmentTable enrollmentTable = new EnrollmentTable();

            EnrollmentModel enrollmentModel1 = new EnrollmentModel();
            enrollmentModel1.name = dogModelBoxer.name + " (owned by " + clientModelBob.name + ") in " + programModel1.name;
            enrollmentModel1.clientId = clientIdBob;
            enrollmentModel1.dogId = dogIdBoxer;
            enrollmentModel1.programId = programId1;
            enrollmentModel1.paymentMethod = PaymentConstants.PAYMENT_IN_FULL;
            enrollmentModel1.joinDate = DateTime.Now;
            enrollmentModel1.inviteIssued = false;
            int enrollmentId1 = enrollmentTable.create(enrollmentModel1);


            EnrollmentModel enrollmentModel2 = new EnrollmentModel();
            enrollmentModel2.name = dogModelTed.name + " (owned by " + clientModelKate.name + ") in " + programModel2.name;
            enrollmentModel2.clientId = clientIdKate;
            enrollmentModel2.dogId = dogIdTed;
            enrollmentModel2.programId = programId2;
            enrollmentModel2.paymentMethod = PaymentConstants.PAYMENT_PER_CLASS;
            enrollmentModel2.joinDate = DateTime.Now;
            enrollmentModel2.inviteIssued = true;
            int enrollmentId2 = enrollmentTable.create(enrollmentModel2);


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

            Int32 programCostCount = new ProgramVarietyTable().count();
            Console.WriteLine("programCostCount = " + programCostCount);

            Int32 programCount = new ProgramTable().count();
            Console.WriteLine("programCount = " + programCount);

            Int32 staffCount = new StaffTable().count();
            Console.WriteLine("staffCount = " + staffCount);

            Console.WriteLine("==============================");

        }
    }
}
