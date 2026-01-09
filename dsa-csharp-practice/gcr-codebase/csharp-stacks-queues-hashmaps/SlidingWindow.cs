using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_stacks_queues_hashmaps
{
    internal class SlidingWindow
    {
        public static void Main(string[] args)
        {
            //take size of array
            Console.WriteLine("ENTER ARRAY SIZE: ");
            int size = Convert.ToInt32(Console.ReadLine());

            //create array to store numbers
            int[] numbers = new int[size];

            //loop to take number input
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("ENTER NUMBER: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //take window size
            Console.WriteLine("ENTER WINDOW SIZE: ");
            int k = Convert.ToInt32(Console.ReadLine());

            //call FindSlidingWindowMax
            int[] maxNumbers = FindSlidingWindowMax(numbers, k);

            //display maximum elements
            for (int i = 0; i < maxNumbers.Length; i++)
            {
                Console.WriteLine(maxNumbers[i] + " ");
            }
        }

        public static int[] FindSlidingWindowMax(int[] numbers, int k)
        {
            //variable to store length of numbers array
            int n = numbers.Length;

            //array to store maximum numbers
            int[] maxNumbers = new int[n - k + 1];

            //loop through each window
            for (int i = 0; i <= n - k; i++)
            {
                //assume first element of window is maximum
                int max = numbers[i];

                //loop to find maximum element in current window
                for (int j = i; j < i + k; j++)
                {
                    max = Math.Max(max, numbers[j]);
                }

                //store maximum value in array
                maxNumbers[i] = max;
            }

            return maxNumbers;
        }

    }
}

