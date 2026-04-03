using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_stacks_queues_hashmaps
{
    internal class CheckPairSum
    {
       public static void Main()
        {
            //take array size
            Console.WriteLine("ENTER ARRAY SIZE:");
            int size = Convert.ToInt32(Console.ReadLine());

            //create array to store numbers
            int[] numbers = new int[size];

            //take array elements
            for (int i = 0; i < size; i++)
            {
                Console.Write("ENTER NUMBER: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //take target sum
            Console.WriteLine("ENTER TARGET SUM:");
            int target = Convert.ToInt32(Console.ReadLine());

            //check for pair
            CheckPair(numbers, target);
        }

        //method to check if pair with given sum exists
        public static void CheckPair(int[] numbers, int target)
        {
            //dictionary to store visited numbers
            Dictionary<int, bool> map = new Dictionary<int, bool>();

            //traverse the array
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];

                //find required number to form the target sum
                int required = target - current;

                //if required number is already visited
                if (map.ContainsKey(required))
                {
                    Console.WriteLine("PAIR FOUND: " + current + " + " + required + " = " + target);
                    return;
                }

                //mark current number as visited
                if (!map.ContainsKey(current))
                {
                    map[current] = true;
                }
            }

            //if no pair is found
            Console.WriteLine("NO PAIR FOUND");
        }
    }
}

