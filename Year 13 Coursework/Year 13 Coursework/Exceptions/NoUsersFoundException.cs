using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year_13_Coursework.Exceptions
{
    class NoUsersFoundException : Exception
    {
        public NoUsersFoundException()
            : base()
        {

        }

        public NoUsersFoundException(string message)
    : base(message)
        {

        }
    }
}
