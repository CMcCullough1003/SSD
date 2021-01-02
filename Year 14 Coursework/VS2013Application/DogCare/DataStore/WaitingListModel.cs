using System;
using System.Collections.Generic;
using System.Text;

namespace DataStore
{
    public class WaitingListModel
    {
        public int id = 0;
        public int clientId = 0;
        public int dogId = 0;
        public int programVarietyId = 0;
        public DateTime joinDate = DateTime.MinValue;
        public Boolean inviteIssued = false;
    }
}
