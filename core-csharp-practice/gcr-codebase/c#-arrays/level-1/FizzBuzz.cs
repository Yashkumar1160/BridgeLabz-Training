using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_1
{
    internal class FizzBuzz
    {
        public static void Main(string[] args)
        {
            //take user input
            Console.WriteLine("Enter Number:");
            int number = Convert.ToInt32(Console.ReadLine());
            //initialize string array with size number+1
            string[] result = new string[number + 1];

            //loop from 0 to number
            for (int i = 0; i <= number; i++)
            {
                if (i == 0)
                {   //if i is equal to 0
                    result[i] = "0";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {   //if i is divisible by both 3 and 5
                    result[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {   //if i is divisible by 3
                    result[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {   //if i is divisible by 5
                    result[i] = "Buzz";
                }
                else
                {   //if i is not divisible with either 3 or 5
                    result[i] = i.ToString();
                }
            }
            for (int i = 0; i <= number; i++)
            {   //Display elements of string array result
                Console.WriteLine("Position " + i + " = " + result[i]);
            }
        }
    }
}
