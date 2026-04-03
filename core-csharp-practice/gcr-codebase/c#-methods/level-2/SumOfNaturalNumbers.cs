using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_2
{
    internal class SumOfNaturalNumbers
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());

            //check if the number is  a natural number
            if (number <= 0)
            {
                Console.WriteLine("Not a natural number:");
                return;
            }
            //calculate sum of natural numbers
            int recursiveSum = RecursiveSum(number);
            int formulaSum = FormulaSum(number);
            //display result
            Console.WriteLine("Recursive Sum: " + recursiveSum);
            Console.WriteLine("Formula Sum: " + formulaSum);
            Console.WriteLine("Same answer ? " + (recursiveSum == formulaSum));

        }
        //Method to calculate natural numbers sum using recursion
        public static int RecursiveSum(int number)
        {
            if (number == 1)
            {   //if number is equal to 1 then return 1
                return 1;
            }
            //recursive call
            return number + RecursiveSum(number - 1);
        }
        //Method to calculate natural numbers sum using formula
        public static int FormulaSum(int number)
        {
            //return sum using formula
            return number * (number + 1) / 2;
        }



    }
}
