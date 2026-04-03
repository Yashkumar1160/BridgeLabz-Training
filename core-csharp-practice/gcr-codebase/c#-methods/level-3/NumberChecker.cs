using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class NumberChecker
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
        //Method to check armstrong number
        public static bool CheckArmstrongNumber(int number)
        {
            int[] digits = StoreDigits(number);
            int power = digits.Length;
            int sum = 0;

            for (int i = 0; i < digits.Length; i++)
            {
                sum += (int)Math.Pow(digits[i], power);
            }
            return sum == number;
        }
        //Method to find largest and second largest element
        public static void FindLargest(int[] digits)
        {
            int largest = digits[0];
            int secondLargest = digits[0];

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] > largest)
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)
                {
                    secondLargest = digits[i];
                }
            }
            Console.WriteLine("Largest: " + largest);
            Console.WriteLine("Second Largest: " + secondLargest);
        }
        //Method to find smallest and second smallest
        public static void FindSmallest(int[] digits)
        {
            int smallest = digits[0];
            int secondSmallest = digits[0];

            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digits[i];
                }
                else if (digits[i] < secondSmallest && digits[i] != smallest)
                {
                    secondSmallest = digits[i];
                }
            }
            Console.WriteLine("Smallest: " + smallest);
            Console.WriteLine("Second Smallest: " + secondSmallest);
        }
        public static void Main(string[] args)
        {
            //take number input
            int number = Convert.ToInt32(Console.ReadLine());

            //calling different methods
            Console.WriteLine("Digits : "+CountDigits(number));

            int[]digits=StoreDigits(number);

            Console.WriteLine("Duck Number :"+CheckDuckNumber(digits));

            Console.WriteLine("Armstrong Number : " + CheckArmstrongNumber(number));

            FindLargest(digits);
            FindSmallest(digits);

        }
    }
}
