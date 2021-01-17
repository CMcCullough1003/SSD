using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore
{
    public class ReportEnrollmentModel
    {
        public string programName = "";
        public string programVarietyName = "";
        public DateTime firstClassDate = DateTime.MinValue;
        public int numberEnrolled = 0;
        public int maxSpaces = 0;
        public int freeSpaces = 0;
    }
}
