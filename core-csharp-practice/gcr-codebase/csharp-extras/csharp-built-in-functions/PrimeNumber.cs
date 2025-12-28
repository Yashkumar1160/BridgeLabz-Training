using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_built_in_functions
{
    internal class PrimeNumber
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            //Call the Check Prime method
            Console.WriteLine(CheckPrime(number) ? "Prime Number" : "Not Prime");
        }
        //Method to check prime number
        public static bool CheckPrime(int number)
        {
            //number less than or equal to 1 are not prime
            if (number <= 1)
            {
                return false;
            }
            //loop from 2 to number-1 
            for (int i = 2; i < number; i++)
            {   //if number is divisible by i then it is not prime
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
