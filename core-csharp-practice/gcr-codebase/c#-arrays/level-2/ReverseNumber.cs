using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_2
{
    internal class ReverseNumber
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            //store number in temp variable
            int temp = number;
            //initialize count variable to 0
            int count = 0;

            //loop to find number of digits
            while (temp != 0)
            {
                count++;
                temp = temp / 10;
            }
            //define integer array to store digits of number
            int[] digits = new int[count];

            //initialize index variable to store array index
            int index = 0;

            //extract digits from the number and store them in array
            while (number != 0)
            {
                digits[index] = number % 10;
                number = number / 10;
                index++;
            }
            //define integer array  to store digits in reverse
            int[] reverse = new int[count];
            //loop to reverse digits array
            for (int i = 0; i < count; i++)
            {
                reverse[i] = digits[i];
            }
            //display number in reverse
            Console.WriteLine("Reversed Number: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(reverse[i]);
            }
        }
    }
}
