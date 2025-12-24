using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_2
{
    internal class FrequencyOfDigits
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            //store number in temp variable
            int temp = number;
            //initialize count variable to 0
            int count = 0;
            //loop to count number of digits
            while (temp != 0)
            {
                count++;
                temp /= 10;
            }
            //create integer  array to store digits
            int[] digits = new int[count];
            //initialize index variable to 0
            int index = 0;
            //loop to store digits in array
            while (number != 0)
            {
                digits[index++] = number % 10;
                number /= 10;
            }
            //create integer array to store frequency of each digit
            int[] frequency = new int[10];

            //loop to calculate frequency of each digit
            for (int i = 0; i < frequency.Length; i++)
            {
                int digitFrequency = 0;
                for (int j = 0; j < digits.Length; j++)
                {
                    if (i == digits[j])
                    {
                        digitFrequency++;
                    }
                }
                frequency[i] = digitFrequency;
            }

            //loop to display frequency
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine("Digit " + i + " occurs " + frequency[i] + " times ");
                }
            }


        }
    }
}
