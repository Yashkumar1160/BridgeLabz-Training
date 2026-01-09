using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.leet_code_codebase.csharp_stacks_queues_hashmaps
{
    internal class LongestConsecutiveSequence
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

            //call method to find longest consecutive sequence
            FindLongestConsecutiveSequence(numbers);
        }

        //method to find length of longest consecutive sequence
        public static void FindLongestConsecutiveSequence(int[] numbers)
        {
            //dictionary to store elements (value as key)
            Dictionary<int, bool> map = new Dictionary<int, bool>();

            //store all numbers in dictionary
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!map.ContainsKey(numbers[i]))
                {
                    map[numbers[i]] = true;
                }
            }

            int longest = 0;

            //traverse array again
            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];

                //check if current number is the start of a sequence
                if (!map.ContainsKey(current - 1))
                {
                    int length = 1;

                    //count consecutive numbers
                    while (map.ContainsKey(current + length))
                    {
                        length++;
                    }

                    //update longest sequence length
                    if (length > longest)
                    {
                        longest = length;
                    }
                }
            }

            //display result
            Console.WriteLine("LONGEST CONSECUTIVE SEQUENCE LENGTH: " + longest);
        }
    }
}
