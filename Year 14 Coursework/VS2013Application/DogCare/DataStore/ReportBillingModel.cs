using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore
{
    public class ReportBillingModel
    {
        public int paymentId = 0;
        public string clientName = "";
        public string paymentType = "";
        public double amountDue = 0.0;
        public DateTime dueDate = DateTime.MinValue;
        public int daysOverdue = 0;
        public Boolean paymentRecieved = false;
        public int programId = 0;
        public string programName = "";
    }
}
