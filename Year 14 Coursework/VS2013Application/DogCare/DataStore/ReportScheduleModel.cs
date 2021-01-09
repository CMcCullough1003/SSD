using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStore
{
    class ReportScheduleModel
    {
        public int classId = 0;
        public DateTime classDate = DateTime.MinValue;
        public TimeSpan startTime = TimeSpan.MinValue;
        public TimeSpan endTime = TimeSpan.MinValue;
        public int programVarietyId = 0;
        public string programVarietyName = "";
        public int programId = 0;
        public string programName = "";
        public int staffId = 0;
        public string staffName = "";
    }
}
