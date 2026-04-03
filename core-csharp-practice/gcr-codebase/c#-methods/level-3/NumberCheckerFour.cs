using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class NumberCheckerFour
    {
        //Method to check prime number
        public static bool CheckPrimeNumber(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        //Method to check neon number
        public static bool CheckNeonNumber(int number)
        {
            int square = number * number;
            int sum = 0;
            while (square != 0)
            {
                sum += square % 10;
                square /= 10;
            }
            return sum == number;
        }
        //Method to check spy number
        public static bool CheckSpyNumber(int number)
        {
            int sum = 0;
            int product = 1;
            while (number != 0)
            {
                int digit = number % 10;
                sum += digit;
                product *= digit;
                number /= 10;
            }
            return sum == product;
        }
        //Method to check automorphic number
        public static bool CheckAutomorphicNumber(int number)
        {
            int square = number * number;
            return square.ToString().EndsWith(number.ToString());
        }
        //Method to check buzz number
        public static bool CheckBuzzNumber(int number)
        {
            return number % 7 == 0 || number % 10 == 7;
        }
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //calling all methods
            Console.WriteLine("Is Prime? " + CheckPrimeNumber(number));
            Console.WriteLine("Is Neon? " + CheckNeonNumber(number));
            Console.WriteLine("Is Spy? " + CheckSpyNumber(number));
            Console.WriteLine("Is Automorphic? " + CheckAutomorphicNumber(number));
            Console.WriteLine("Is Buzz? " + CheckBuzzNumber(number));
        }

    }
}
