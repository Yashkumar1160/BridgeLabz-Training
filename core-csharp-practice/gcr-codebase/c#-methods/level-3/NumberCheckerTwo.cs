using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class NumberCheckerTwo
    {
        //Method to count digits
        public static int CountDigits(int number)
        {
            int count = 0;
            while (number != 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }
        //Method to Store digits in array
        public static int[] StoreDigits(int number)
        {
            int count = CountDigits(number);
            int[] digits = new int[count];
            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            return digits;
        }
        //Method to find sum of digits
        public static int SumOfDigits(int[] digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += digits[i];
            }
            return sum;
        }
        //Method to find sum of squares
        public static int SumOfSquares(int[] digits)
        {
            int sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += (int)Math.Pow(digits[i], 2);
            }
            return sum;
        }
        //Method to check harshad number
        public static bool CheckHarshadNumber(int number)
        {
            int sum = SumOfDigits(StoreDigits(number));

            return number % sum == 0;
        }
        //Method to find digit frequency
        public static int[,] DigitFrequency(int[] digits)
        {
            int[,] freq = new int[10, 2];

            for (int i = 0; i < 10; i++)
            {
                freq[i, 0] = i;
            }
            for (int i = 0; i < digits.Length; i++)
            {
                freq[digits[i], 1]++;
            }
            return freq;
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] digits = StoreDigits(num);
            //calling different methods
            Console.WriteLine("Count of digits: " + CountDigits(num));
            Console.WriteLine("Sum of digits: " + SumOfDigits(digits));
            Console.WriteLine("Sum of squares: " + SumOfSquares(digits));
            Console.WriteLine("Is Harshad Number? " + CheckHarshadNumber(num));

            Console.WriteLine("\nDigit Frequency:");
            int[,] freq = DigitFrequency(digits);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{freq[i, 0]} : {freq[i, 1]}");
            }


        }
    }
}