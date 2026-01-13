using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linear_binary_search
{
    internal class RotationPoint
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

            //call FindFirstNegative method
            FindRotatedPoint(numbers);
        }


        //method to find rotated point 
        public static void FindRotatedPoint(int[] numbers)
        {
            //initialize low and high index
            int low = 0;
            int high = numbers.Length - 1;

            //loop until low is less than high
            while (low < high)
            {
                //find mid 
                int mid = (low + high) / 2;

                if (numbers[mid] > numbers[high])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            Console.WriteLine("ROTATED POINT INDEX: " + low);
        }
    }
}
