using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.utilities
{
    public class InputValidator
    {
        //method to get valid string input 
        public static string GetValidString(string message)
        {
            string input;

            //loop until user enters valid input
            while (true)
            {
                Console.Write(message);
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }

                Console.WriteLine("Invalid input! Try again.");
            }
        }

        //method to get valid integer input 
        public static int GetValidPositiveInt(string message)
        {
            int value;

            //loop until user enters valid input
            while (true)
            {
                Console.Write(message);
                value=int.Parse(Console.ReadLine());
                if (value > 0)
                {
                    return value;   
                }

                Console.WriteLine("Invalid number! Enter positive integer.");
            }
        }

        //method to get valid double input 
        public static double GetValidPositiveDouble(string message)
        {
            double value;

            //loop until user enters valid input
            while (true)
            {
                Console.Write(message);
                value=double.Parse(Console.ReadLine());
                if (value > 0)
                {
                    return value;                    
                }

                Console.WriteLine("Invalid number! Enter positive number.");
            }
        }

        //method to get valid non negative input 
        public static int GetValidNonNegativeInt(string message)
        {
            int value;

            //loop until user enters valid input
            while (true)
            {
                Console.Write(message);
                int value=int.Parse(Console.ReadLine());
                if (value >= 0)
                {
                    return value;                    
                }

                Console.WriteLine("Invalid number! Enter 0 or positive integer.");
            }
        }
    }
}