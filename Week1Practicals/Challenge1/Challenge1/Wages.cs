using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge1
{
    public class Wages
    {
        public const int HOURS_IN_WORKING_WEEK = 40;
        
        public Wages()
        {
        }

        public double grossWeeklyWage(double hourlyRate)
        {
            double weeklyWage = hourlyRate * HOURS_IN_WORKING_WEEK;
            return weeklyWage;
        }

        public double netWeeklyWage(double grossWeeklyWage)
        {
            double netWage = grossWeeklyWage + ((grossWeeklyWage / 100) * 20);
            return netWage;
        }

        public string details(string firstName, string surname, int age)
        {
            return"Your first name is " + firstName + ".\nYour second name is " + surname + ".\nYour age is " + age + ".";
        }

        public string details(string firstName, string surname, int age, double hourlyRates)
        {
            return "Your first name is " + firstName + ".\nYour second name is " + surname + ".\nYour age is " + age + ".\nYour hourly rate is £" + hourlyRates + ".";
        }
    }
}
