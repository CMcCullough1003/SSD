using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogCare
{
    class PaymentConstants
    {
        public const int PAYMENT_IN_FULL = 1;
        public const int PAYMENT_PER_CLASS = 2; 

        public string fetchPaymentMethod(int method)
        {
            switch (method)
            {
                case PAYMENT_IN_FULL: return "Payment in full";
                default: return "Payment per class";
            }
        }
    }
}
