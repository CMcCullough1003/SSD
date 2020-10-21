using System;
using System.Collections.Generic;
using System.Text;

namespace DataStore
{
    public class ClassModel
    {
        public int id = 0;
        public int programId = 0;
        public int staffId = 0;
        public DateTime classDate = DateTime.MinValue;
        public TimeSpan startTime = TimeSpan.MinValue;
        public TimeSpan endTime = TimeSpan.MinValue;
    }
}
