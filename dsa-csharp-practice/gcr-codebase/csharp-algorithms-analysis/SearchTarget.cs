using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_algorithms_analysis
{
    internal class SearchTarget
    {
        public static void Main(string[] args)
        {
            //take array size
            Console.Write("ENTER SIZE OF ARRAY: ");
            int size = Convert.ToInt32(Console.ReadLine());

            //create array to store numbers
            int[] numbers = new int[size];

            //loop to take number inputs
            for (int i = 0; i < size; i++)
            {
                Console.Write("ENTER NUMBER: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("ENTER TARGET ELEMENT: ");
            int target = Convert.ToInt32(Console.ReadLine());

            //linear search start time
            DateTime linearStart = DateTime.Now;

            //linear search
            LinearSearch(numbers, target);

            //linear search end time
            DateTime linearEnd = DateTime.Now;

            Console.WriteLine("LINEAR SEARCH TIME: " + (linearEnd - linearStart).TotalMilliseconds + " ms");

            //binary search start time
            DateTime binaryStart = DateTime.Now;

            //binary search
            BinarySearch(numbers, target);

            //binary search end time
            DateTime binaryEnd = DateTime.Now;

            Console.WriteLine("BINARY SEARCH TIME: " + (binaryEnd - binaryStart).TotalMilliseconds + " ms");

        }

        //method to search for target element using linear search
        public static void LinearSearch(int[] numbers, int target)
        {

            //loop through numbers array
            for (int i = 0; i < numbers.Length; i++)
            {
                //if target is fount
                if (numbers[i] == target)
                {
                    Console.WriteLine("\nELEMENT FOUND AT INDEX: " + i);
                    return;
                }
            }

            Console.WriteLine("TARGET ELEMENT NOT FOUND");
        }

        //method to search for target element using binary search
        public static void BinarySearch(int[] numbers, int target)
        {
            //starting index
            int low = 0;

            //ending index
            int high = numbers.Length - 1;

            //binary search loop
            while (low <= high)
            {
                //calculate mid index
                int mid = (low + high) / 2;


                //if target is found
                if (numbers[mid] == target)
                {
                    Console.WriteLine("\nTARGET FOUND AT INDEX: " + mid);
                    return;
                }
                //if target is greater then search right half
                else if (numbers[mid] < target)
                {
                    low = mid + 1;
                }
                //if target is smaller then search left half
                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine("TARGET NOT FOUND");
        }
    }
}
