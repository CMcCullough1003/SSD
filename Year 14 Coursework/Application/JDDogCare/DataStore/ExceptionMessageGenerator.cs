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

            return "Oops! Something has gone wrong. Please contact the system administrator";

        }
    }
}
