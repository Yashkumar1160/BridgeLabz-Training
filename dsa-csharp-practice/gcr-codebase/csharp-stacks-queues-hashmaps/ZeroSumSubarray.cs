using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_stacks_queues_hashmaps
{
    internal class ZeroSumSubarray
    {
        public static void Main()
        {
            //take array size
            Console.WriteLine("ENTER ARRAY SIZE:");
            int size = Convert.ToInt32(Console.ReadLine());

            //create numbers array
            int[] numbers = new int[size];

            //loop to take numbers input
            for (int i = 0; i < size; i++)
            {
                Console.Write("ENTER NUMBER: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            //call FindZeroSumSubarrays method
            FindZeroSumSubarrays(numbers);
        }

        //method to find zero sum subarrays
        public static void FindZeroSumSubarrays(int[] numbers)
        {
            //dictionary to store cumulative sum and its index
            Dictionary<int, int> map = new Dictionary<int, int>();

            //variable to store sum
            int sum = 0;

            //handle subarray starting from index 0
            map[0] = -1;

            //loop through numbers array
            for (int i = 0; i < numbers.Length; i++)
            {
                //update sum
                sum = sum + numbers[i];

                //if same sum found again
                if (map.ContainsKey(sum))
                {
                    int startIndex = map[sum] + 1;
                    int endIndex = i;

                    Console.WriteLine("ZERO SUM SUBARRAY FROM INDEX " + startIndex + " TO " + endIndex);
                }
                else
                {
                    //store first occurrence of sum
                    map[sum] = i;
                }
            }
        }
    }
}
