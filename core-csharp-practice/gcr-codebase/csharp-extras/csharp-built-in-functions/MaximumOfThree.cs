using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_built_in_functions
{
    internal class MaximumOfThree
    {
        public static void Main(string[] args)
        {
            //take first number input
            int firstNumber = TakeInput("Enter First Number");
            //take second number input
            int secondNumber = TakeInput("Enter Second Number");
            //take third number input
            int thirdNumber = TakeInput("Enter Third Number");


            int maxNumber = FindMaximum(firstNumber, secondNumber, thirdNumber);
            Console.WriteLine("Maximum number is: " + maxNumber);
        }
        //Method to take number inputs
        public static int TakeInput(string message)
        {   //display message
            Console.WriteLine(message);
            //return number input
            return Convert.ToInt32(Console.ReadLine());
        }
        //Method to find maximum of three numbers
        public static int FindMaximum(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {   //if first number is maximum
                return firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {   //if second number is maximum
                return secondNumber;
            }
            else
            {   //if third number is maximum
                return thirdNumber;
            }
        }
    }
}
