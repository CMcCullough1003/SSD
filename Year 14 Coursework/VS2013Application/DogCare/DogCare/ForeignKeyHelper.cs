using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStore;

namespace DogCare
{
    class ForeignKeyHelper
    {
        public int findIndexOfClientID(List<ClientModel> clients, int clientID)
        {
            for (int i = 0; i < clients.Count; i++)
            {
                if (clientID == clients[i].id)
                {
                    return i;
                }
            }
            return -1;
        }

        public int findIndexOfDogID(List<DogModel> dogs, int dogID)
        {
            for (int i = 0; i < dogs.Count; i++)
            {
                if (dogID == dogs[i].id)
                {
                    return i;
                }
            }
            return -1;
        }

        internal int findIndexOfProgramVarietyID(List<ProgramVarietyModel> programCosts, int programCostId)
        {
            for (int i = 0; i < programCosts.Count; i++)
            {
                if (programCostId == programCosts[i].id)
                {
                    return i;
                }
            }
            return -1;
        }

        internal int findIndexOfProgramID(List<ProgramModel> programs, int programId)
        {
            for (int i = 0; i < programs.Count; i++)
            {
                if (programId == programs[i].id)
                {
                    return i;
                }
            }
            return -1;
        }

        internal int findIndexOfStaffID(List<StaffModel> staff, int staffId)
        {
            for (int i = 0; i < staff.Count; i++)
            {
                if (staffId == staff[i].id)
                {
                    return i;
                }
            }
            return -1;
        }

        internal int findIndexOfEnrollmentID(List<EnrollmentModel> enrollment, int enrollmentId)
        {
            for (int i = 0; i < enrollment.Count; i++)
            {
                if (enrollmentId == enrollment[i].id)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
