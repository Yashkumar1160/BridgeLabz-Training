using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_2
{
    internal class SecondLargestAndLargest
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
                //if array size limit reaches then increase the size of digits array using temp array
                if (index == maxDigit)
                {   //increase maxDigit
                    maxDigit += 10;
                    //create new temp array of size maxDigits
                    int[] temp = new int[maxDigit];

                    //store elements of digits array in temp array
                    for (int i = 0; i < digits.Length; i++)
                    {
                        temp[i] = digits[i];
                    }
                    //assign digits array to temp
                    digits = temp;
                }
                //remove last digit and store it in array
                digits[index] = number % 10;
                number /= 10;//remove last digit
                index++;
            }
            //initialize largest and second largest variables
            int largest = 0;
            int secondLargest = 0;

            //find largest and second largest digit
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
