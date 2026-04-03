using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class NumberCheckerFive
    {
        //Method to find factors
        public static int[] FindFactors(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            int[] factors = new int[count];
            int index = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index++] = i;
                }
            }
            return factors;
        }
        //Method to find greatest factor
        public static int FindGreatestFactor(int[] factors)
        {
            int max = factors[0];
            for (int i = 1; i < factors.Length; i++)
            {
                if (factors[i] > max)
                {
                    max = factors[i];
                }
            }
            return max;
        }
        //Method to find sum of factors
        public static int SumOfFactors(int[] factors)
        {
            int sum = 0;
            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }
            return sum;
        }
        //Method to find product of factors
        public static long ProductOfFactors(int[] factors)
        {
            long product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product *= factors[i];
            }
            return product;
        }
        //Method to find product of cube of factors
        public static double ProductOfCubeOfFactors(int[] factors)
        {
            double product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product *= Math.Pow(factors[i], 3);
            }
            return product;
        }
        //Method to check perfect number 
        public static bool CheckPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }
        //Method to check abundant number 
        public static bool CheckAbundantNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum > number;
        }
        //Method to check deficient number 
        public static bool CheckDeficientNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum < number;
        }
        //Method to check strong number 
        public static bool CheckStrongNumber(int number)
        {
            int temp = number;
            int sum = 0;
            while (temp != 0)
            {
                int digit = temp % 10;
                int fact = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fact *= i;
                }
                sum += fact;
                temp /= 10;
            }
            return sum == number;
        }
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] factors = FindFactors(number);
            //calling all methods
            Console.WriteLine("Factors: ");
            for (int i = 0; i < factors.Length; i++)
            {
                Console.Write(factors[i]+" ");
            }
            Console.WriteLine("Greatest Factor: " + FindGreatestFactor(factors));
            Console.WriteLine("Sum of Factors: " + SumOfFactors(factors));
            Console.WriteLine("Product of Factors: " + ProductOfFactors(factors));
            Console.WriteLine("Product of Cube of Factors: " + ProductOfCubeOfFactors(factors));
            Console.WriteLine("Is Perfect? " + CheckPerfectNumber(number));
            Console.WriteLine("Is Abundant? " + CheckAbundantNumber(number));
            Console.WriteLine("Is Deficient? " + CheckDeficientNumber(number));
            Console.WriteLine("Is Strong? " + CheckStrongNumber(number));
        }
    }
}
