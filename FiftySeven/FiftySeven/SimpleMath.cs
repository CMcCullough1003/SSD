using System;
using System.Collections.Generic;
using System.Text;

namespace FiftySeven
{
    public class SimpleMath
    {

        public SimpleMath()
        {
        }

        public void maths()
        {
            Console.WriteLine("What is the first number?");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the second number?");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int addition = additionValue(firstNumber, secondNumber);
            int subtraction = subtractionValue(firstNumber, secondNumber);
            int multiplication = multiplicationValue(firstNumber, secondNumber);
            int division = divisionValue(firstNumber, secondNumber);

            Console.WriteLine(equation(firstNumber, secondNumber, addition, subtraction, multiplication, division));
        }

        public int additionValue (int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public int subtractionValue(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int multiplicationValue(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int divisionValue(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }

        public string equation (int firstNumber, int secondnumber, int additionValue, int subtractionValue, int multiplicationValue, int divisionValue)
        {
            return firstNumber + " + " + secondnumber + " = " + additionValue + "\n" + firstNumber + " - " + secondnumber + " = " + subtractionValue + "\n" + firstNumber + " * " + secondnumber + " = " + multiplicationValue + "\n" + firstNumber + " / " + secondnumber + " = " + divisionValue + "\n";
        }
    }
}
