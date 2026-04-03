using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linear_binary_search
{
    internal class FirstAndLastOccurrence
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

            //take target element
            Console.Write("ENTER TARGET ELEMENT: ");
            int target = Convert.ToInt32(Console.ReadLine());

            //call FindFirstIndex method
            Console.WriteLine("FIRST INDEX: " + FindFirstIndex(numbers, target));

            //call FindLastIndex
            Console.WriteLine("LAST INDEX: " + FindLastIndex(numbers, target));
        }

        //method to find first index of element
        public static int FindFirstIndex(int[] numbers, int target)
        {
            //start index 
            int start = 0;

            //ending index
            int end = numbers.Length - 1;

            //stores first occurrence index
            int result = -1;

            //loop for binary search
            while (start <= end)
            {
                //calculate mid index
                int mid = (start + end) / 2;

                //if target element is found
                if (numbers[mid] == target)
                {
                    //store middle index
                    result = mid;
                    end = mid - 1;
                }
                //if target element is greater then search right part
                else if (numbers[mid] < target)
                {
                    start = mid + 1;
                }
                //if target element is smaller then search left part
                else
                {
                    end = mid - 1;
                }
            }
            return result;
        }

        //method to find last index of element
        public static int FindLastIndex(int[] numbers, int target)
        {
            //start index 
            int start = 0;

            //ending index
            int end = numbers.Length - 1;

            //store last occurrence index
            int result = -1;

            //loop for binary search
            while (start <= end)
            {
                //calculate mid index
                int mid = (start + end) / 2;

                //if target is found
                if (numbers[mid] == target)
                {
                    result = mid;
                    start = mid + 1;
                }
                //if target is greater then search right part
                else if (numbers[mid] < target)
                {
                    start = mid + 1;
                }
                //if target is smaller search left part
                else
                {
                    end = mid - 1;
                }
            }
            return result;
        }

    }
}