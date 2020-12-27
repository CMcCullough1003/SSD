using System;
using System.Collections.Generic;
using System.Text;

namespace DataStore
{
    public class ExceptionMessageGenerator
    {
        public string generateMessage(string exceptionMessage)
        {
            if (exceptionMessage.Contains("CK__Client__Name"))
            {
                return "Name must be at least 3 characters";
            }

            if (exceptionMessage.Contains("CK__Client__Phone"))
            {
                return "Phone must be at least 10 characters";
            }

            if (exceptionMessage.Contains("CK__Client__Email"))
            {
                return "Email must be at least 7 characters";
            }

            if (exceptionMessage.Contains("CK__Staff__Name"))
            {
                return "Name must be at least 3 characters";
            }

            if (exceptionMessage.Contains("CK__ProgramType__Description"))
            {
                return "Description must be either regular or advanced";
            }

            if (exceptionMessage.Contains("CK__ProgramCo__Depos"))
            {
                return "Deposit must be between £20 and £100";
            }

            if (exceptionMessage.Contains("CK__ProgramCo__Sessi"))
            {
                return "Session cost must be between £20 and £100";
            }

            if (exceptionMessage.Contains("CK__ProgramCo__FullP"))
            {
                return "Percentage discount must be between 0% and 100%";
            }

            if (exceptionMessage.Contains("CK__DogSpaceMax__FullP"))
            {
                return "Percentage discount must be between 0% and 100%";
            }

            if (exceptionMessage.Contains("CK__Class__Times"))
            {
                return "End time must be later than start time";
            }

            if (exceptionMessage.Contains("CK__Class__ClassDate"))
            {
                return "Date must not be in the past";
            }

            return "Oops! Something has gone wrong. Please contact the system administrator\n\n" + exceptionMessage;
        }
    }
}
