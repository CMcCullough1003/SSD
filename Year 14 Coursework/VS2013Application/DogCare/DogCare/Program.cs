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
            consoleTableCounts();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
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
