using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_1
{
    internal class SumOfNaturalNumbers
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            //create instance of class
            SumOfNaturalNumbers obj = new SumOfNaturalNumbers();

            //call the CalculateSum() method
            int sum = obj.CalculateSum(number);
            //display result
            Console.WriteLine("Sum of " + number + " natural numbers is " + sum);

        }
        //Method to find sum of natural numbers
        public int CalculateSum(int number)
        {
            //Calculate sum of natural numbers using loop
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            //return total sum of numbers
            return sum;
        }
    }
}
