﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStore
{
    public class PaymentModel
    {
        public int id = 0;
        public int enrollmentId = 0;
        public double paymentAmountDue = 0.0;
        public string paymentAmountDueDate = "";
        public bool paymentRecieved = false;
        public string paymentRecievedDate = "";
        public bool recieptIssed = false;
    }
}
