using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_linear_binary_search
{
    internal class FirstNegative
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
            FindFirstNegative(numbers);
        }

        //method to display first negative number in array
        public static void FindFirstNegative(int[] numbers)
        {
            //loop through numbers array
            for (int i = 0; i < numbers.Length; i++)
            {
                //check if number is negative
                if (numbers[i] < 0)
                {
                    Console.WriteLine("FIRST NEGATIVE NUMBER: " + numbers[i]);
                    return;
                }
            }

            Console.WriteLine("NO NEGATIVE NUMBER");
        }
    }
}
