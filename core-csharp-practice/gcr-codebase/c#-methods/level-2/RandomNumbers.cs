using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_2
{
    internal class RandomNumbers
    {
        public static void Main(string[] args)
        {
            //create array to store random numbers
            int[] numbers = Generate4DigitRandomArray(5);
            //create double array to store average, minimum and maximum
            double[] result = FindAverageMinMax(numbers);
            //display result
            Console.WriteLine("Average: " + result[0]);
            Console.WriteLine("Min: " + result[1]);
            Console.WriteLine("Max: " + result[2]);
        }
        //Method to generate random numbers
        public static int[] Generate4DigitRandomArray(int size)
        {
            //create instance of Random class
            Random r = new Random();
            //create array to store numbers
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                //generate numbers between 1-100
                numbers[i] = r.Next(1, 100);
            }
            return numbers;
        }
        //Method to find average, min and max
        public static double[] FindAverageMinMax(int[] numbers)
        {
            //initialize min , sum and max variables
            int min = numbers[0];
            int max = numbers[0];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                //find min
                min = Math.Min(min, numbers[i]);
                //find max
                max = Math.Max(max, numbers[i]);
            }
            double average = (double)sum / numbers.Length;

            return new double[] { average, min, max };
        }
    }
}
