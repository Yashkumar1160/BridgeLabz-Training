using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_1
{
    internal class QuotientAndRemainder
    {
        public static void Main(string[] args)
        {
            //take user number inputs
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            //call the FindRemainderAndQuotient() method and store it in result array
            int[] result = FindRemainderAndQuotient(firstNumber, secondNumber);
            //display result
            Console.WriteLine("Quotient : " + result[0]);
            Console.WriteLine("Remainder : " + result[1]);



        }
        //Method to find the quotient and remainder of the two numbers
        public static int[] FindRemainderAndQuotient(int firstNumber, int secondNumber)
        {
            //create result array to store quotient and remainder
            int[] result = new int[2];

            //find quotient and store it in result array
            result[0] = firstNumber / secondNumber;
            //find remainder and store it in result array
            result[1] = firstNumber % secondNumber;

            //return result array
            return result;
        }
    }
}
