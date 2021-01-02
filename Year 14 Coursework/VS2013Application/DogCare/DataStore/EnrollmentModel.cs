using System;
using System.Collections.Generic;
using System.Text;

namespace DataStore
{
    public class EnrollmentModel
    {
        public int id = 0;
        public string name = "";
        public int clientId = 0;
        public int dogId = 0;
        public int programId = 0;
        public int paymentMethod = 0;
        public DateTime joinDate = DateTime.MinValue;
        public Boolean inviteIssued = false;
    }
}
