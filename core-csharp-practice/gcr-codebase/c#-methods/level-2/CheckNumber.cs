using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_2
{
    internal class CheckNumber
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[5];
            //take inputs
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter number " + (i + 1));
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                if (CheckPositive(numbers[i]))
                {
                    Console.WriteLine(CheckEven(numbers[i]) ? "Even" : "Odd");
                }
                else
                {
                    Console.WriteLine("Negative Number");
                }
            }
            //compare first and last
            int result = CompareNumbers(numbers[0], numbers[4]);
            if (result == 0)
            {
                Console.WriteLine("Numbers are equal");
            }
            else if (result == 1)
            {
                Console.WriteLine("First number is greater");
            }
            else
            {
                Console.WriteLine("Second number is greater");
            }
        }
        //Method to check if the number is positive
        public static bool CheckPositive(int number)
        {
            return number >= 0;
        }
        //Method to check if number is Even
        public static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }
        //Method to compare two numbers
        public static int CompareNumbers(int number1, int number2)
        {
            if (number1 > number2)
            {
                return 1;
            }
            else if (number1 == number2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
