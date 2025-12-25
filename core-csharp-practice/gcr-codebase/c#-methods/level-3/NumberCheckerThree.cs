using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class NumberCheckerThree
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
        //Method to reverse digits
        public static int[] ReverseDigits(int[] digits)
        {
            int[] reverse = new int[digits.Length];
            for (int i = 0; i < digits.Length; i++)
            {
                reverse[i] = digits[digits.Length - 1 - i];
            }
            return reverse;
        }
        //Method to compare array
        public static bool AreArraysEqual(int[] a, int[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }
            return true;
        }
        //Method to check palindrome
        public static bool CheckPalindrome(int number)
        {
            int[] digits = StoreDigits(number);
            int[] reverse = ReverseDigits(digits);

            return AreArraysEqual(digits, reverse);
        }
        //Method to check duck number
        public static bool CheckDuckNumber(int[] digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != 0)
                {
                    return true;
                }
            }
            return false;
        }
        public static void Main(string[] args)
        {
            //take number input
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] digits = StoreDigits(number);
            //calling all methods
            Console.WriteLine("Count of digits: " + CountDigits(number));
            Console.WriteLine("Reversed digits: " + string.Join("", ReverseDigits(digits)));
            Console.WriteLine("Is Palindrome? " + CheckPalindrome(number));
            Console.WriteLine("Is Duck Number? " + CheckDuckNumber(digits));

        }

    }
}
