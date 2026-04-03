using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.leet_code_codebase.csharp_stacks_queues_hashmaps
{
    internal class TwoSum
    {
        public static void Main()
        {
            //take array size from user
            Console.Write("ENTER ARRAY SIZE: ");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[size];

            //take array elements from user
            for (int i = 0; i < size; i++)
            {
                Console.Write("ENTER NUMBER: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //take target sum from user
            Console.Write("ENTER TARGET SUM: ");
            int target = Convert.ToInt32(Console.ReadLine());

            //check for pair
            if (FindTwoSum(numbers, target))
            {
                Console.WriteLine("PAIR EXISTS WITH THE GIVEN SUM");
            }
            else
            {
                Console.WriteLine("NO PAIR FOUND WITH THE GIVEN SUM");
            }
        }

        //method to check if two numbers sum to target using dictionary
        public static bool FindTwoSum(int[] numbers, int target)
        {
            //dictionary to store visited numbers
            Dictionary<int, bool> map = new Dictionary<int, bool>();

            //traverse the array
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                int required = target - current;

                //check if the required number is already in the dictionary
                if (map.ContainsKey(required))
                    return true;

                //add current number to dictionary
                if (!map.ContainsKey(current))
                    map[current] = true;
            }

            //no pair found
            return false;
        }


    }
}
