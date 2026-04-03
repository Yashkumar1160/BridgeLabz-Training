using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_1
{
    internal class SmallestAndLargest
    {
        public static void Main(string[] args)
        {
            //take three number inputs
            Console.WriteLine("Enter first number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            //call the FindSmallestAndLargest() method and store the result in the array
            int[] result = FindSmallestAndLargest(firstNumber, secondNumber, thirdNumber);
            //display results
            Console.WriteLine("Smallest : " + result[0]);
            Console.WriteLine("Largest : " + result[1]);

        }
        //Method to find the smallest and largest numbers
        public static int[] FindSmallestAndLargest(int firstNumber, int secondNumber, int thirdNumber)
        {
            //create array to store the smallest and largest number
            int[] result = new int[2];

            //find which number is largest
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                result[1] = firstNumber;
            }
            else if (secondNumber > thirdNumber && secondNumber > firstNumber)
            {
                result[1] = secondNumber;
            }
            else
            {
                result[1] = thirdNumber;
            }
            //find which number is  smallest 
            if (firstNumber < secondNumber && firstNumber < thirdNumber)
            {
                result[0] = firstNumber;
            }
            else if (secondNumber < thirdNumber && secondNumber < firstNumber)
            {
                result[0] = secondNumber;
            }
            else
            {
                result[0] = thirdNumber;
            }
            //returns the result array
            return result;
        }
    }
}
