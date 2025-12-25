using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_2
{
    internal class FactorsOfNumber
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            //call the GetFactors() method
            int[] factors = FindFactors(number);

            //display factors of number
            Console.WriteLine("Factors are: ");
            for (int i = 0; i < factors.Length; i++)
            {
                Console.Write(factors[i] + " ");
            }
            Console.WriteLine();
            //display sum of factors
            Console.WriteLine("Sum of factors : " + FindSum(factors));
            //display product of factors

            Console.WriteLine("Product of factors : " + FindProduct(factors));
            //display sum of squares of factors

            Console.WriteLine("Sum of squares of factors : " + FindSumOfSquares(factors));



        }
        //Method to find factors of number
        public static int[] FindFactors(int number)
        {
            int count = 0;

            //count factors
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            //create integer array to store factors
            int[] factors = new int[count];
            int index = 0;
            //loop to find and store factors
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index++] = i;
                }
            }
            //returns factors array
            return factors;
        }
        //Method to find sum of the factors
        public static int FindSum(int[] factors)
        {
            //initialize sum variable to 0
            int sum = 0;
            //loop to calculate sum
            for (int i = 0; i < factors.Length; i++)
            {
                sum += factors[i];
            }
            return sum;
        }
        //Method to find product of the factors
        public static int FindProduct(int[] factors)
        {
            //initialize product variable to 1
            int product = 1;
            //loop to find product
            for (int i = 0; i < factors.Length; i++)
            {
                product *= factors[i];
            }
            return product;
        }
        //Method to find sum of square of the factors
        public static double FindSumOfSquares(int[] factors)
        {
            //initialize sum variable to 0
            double sum = 0;
            //loop to find sum of square using Math.Pow() function
            for (int i = 0; i < factors.Length; i++)
            {
                sum += Math.Pow(factors[i], 2);
            }
            return sum;
        }

    }
}
