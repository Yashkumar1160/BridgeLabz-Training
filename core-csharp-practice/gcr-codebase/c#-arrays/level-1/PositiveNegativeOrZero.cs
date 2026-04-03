using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_1
{
    internal class PositiveNegativeOrZero
    {
        public static void Main(string[] args)
        {
            //create an array of size 5
            int[] numbers = new int[5];

            //take user input numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //check if the number is positive, negative or zero
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    //check if the number is even or odd
                    if (numbers[i] % 2 == 0)
                    {   //if number is even
                        Console.WriteLine("Positive Even Number");
                    }
                    else
                        //{   if number is odd
                        Console.WriteLine("Positive Odd Number");
                }
                else if (numbers[i] < 0)
                {
                    //if number is negative
                    Console.WriteLine("Negative Number");
                }
                else
                {
                    //if number is zero
                    Console.WriteLine("Zero");
                }
            }
            //comparing first and last numbers of array
            if (numbers[0] > numbers[numbers.Length - 1])
            {   //if first number is greater
                Console.WriteLine("First number is greater than last");
            }
            else if (numbers[0] < numbers[numbers.Length - 1])
            {   //if first number is lesser
                Console.WriteLine("First number is lesser than last");
            }
            else
            {   //if both are equal
                Console.WriteLine("Both are equal");
            }
        }
    }
}
