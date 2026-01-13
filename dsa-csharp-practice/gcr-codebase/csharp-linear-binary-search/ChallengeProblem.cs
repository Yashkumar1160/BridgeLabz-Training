using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linear_binary_search
{
    internal class ChallengeProblem
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
            Console.Write("ENTER TARGET: ");
            int target = Convert.ToInt32(Console.ReadLine());

            //call FindFirstMissingNumber method
            int missingNumber=FindFirstMissingPositive(numbers);
            Console.WriteLine("FIRST MISSING POSITIVE: " + missingNumber);

            //sort array
            Array.Sort(numbers);

            //call FindTargetElement method
            int targetIndex=FindTargetElement(numbers,target);
            Console.WriteLine("TARGET INDEX: " + targetIndex);
        }

        //find missing positive using linear search
        public static int FindFirstMissingPositive(int[] numbers)
        {
            //store array length
            int n = numbers.Length;

            //array to check if element is visited
            bool[] visited = new bool[n + 1];

            //mark visited positive numbers
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > 0 && numbers[i] <= n)
                {
                    visited[numbers[i]] = true;
                }
            }

            //find first missing positive
            for (int i = 1; i <= n; i++)
            {
                if (!visited[i])
                {
                    return i;
                }
            }

            return n + 1;
        }

        //method to find target element using binary search
        public static int FindTargetElement(int[] numbers, int target)
        {
            //starting index
            int start = 0;

            //ending index
            int end = numbers.Length - 1;

            //loop for binary search
            while (start <= end)
            {
                //calculate mid index
                int mid = (start + end) / 2;

                //if target is found
                if (numbers[mid] == target)
                {
                    return mid;
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

            return -1;
        }
    }
}
