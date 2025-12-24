using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_2
{
    internal class LargestAndSecondLargest
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter Number");
            int number = Convert.ToInt32(Console.ReadLine());
            //initialize variable maxDigit
            int maxDigit = 10;
            //define integer array to store digits
            int[] digits = new int[maxDigit];
            //initialize integer index variable to 0
            int index = 0;

            //use loop to iterate until number is not equal to 0 and store digits
            while (number != 0)
            {
                //if array size limit reaches then break the loop
                if (index == maxDigit)
                {
                    break;
                }
                //remove last digit and store it in array
                digits[index] = number % 10;
                number /= 10;//remove last digit
                index++;
            }
            //initialize index of largest and second largest variable
            int largest = -1;
            int secondLargest = -1;

            //find largest and second largest digits
            for (int i = 0; i < index; i++)
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
            Console.WriteLine("Largest Digit: " + largest);
            Console.WriteLine("Second Largest Digit: " + secondLargest);
        }
    }
}
