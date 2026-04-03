using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_1
{
    internal class OddEven
    {
        public static void Main(string[] args)
        {
            //take integer input 
            Console.WriteLine("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            //check if number is a natural number or not
            if (number > 0)
            {
                //if number is a natural number create
                //create integer array for odd numbers
                int[] oddNumbers = new int[number / 2 + 1];
                //create integer array for even numbers
                int[] evenNumbers = new int[number / 2 + 1];

                //create index variable for odd and even array and initialize them to 0
                int oddIndex = 0;
                int evenIndex = 0;
                //for loop to iterate from 1 to number
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {   //if i is even number
                        evenNumbers[evenIndex++] = i;
                    }
                    else
                    {   //if i is odd number
                        oddNumbers[oddIndex++] = i;
                    }
                }
                //display even numbers
                Console.WriteLine("Even Numbers are:");
                for (int i = 0; i < evenIndex; i++)
                {
                    Console.WriteLine(evenNumbers[i] + " ");
                }
                //display odd numbers
                Console.WriteLine("Odd Numbers are:");
                for (int i = 0; i < oddIndex; i++)
                {
                    Console.WriteLine(oddNumbers[i] + " ");
                }
            }
            else
            {
                Console.Error.WriteLine("Not a Natural Number");
                Environment.Exit(0);
            }
        }
    }
}
