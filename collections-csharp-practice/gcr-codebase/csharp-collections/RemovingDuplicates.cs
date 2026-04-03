using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class RemovingDuplicates
    {
        public static void Main(string[] args)
        {
            //take number of elements
            Console.Write("Enter Number Of Elements: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            //list to store numbers
            List<int> numbers = new List<int>();

            //loop to take number inputs
            for (int i = 0; i < numberOfElements; i++)
            {
                //take number
                Console.Write("Enter Number: ");
                int value = Convert.ToInt32(Console.ReadLine());
                numbers.Add(value);
            }

            //call RemoveDuplicates method
            RemoveDuplicates(numbers);
        }

        //method to remove duplicates
        public static void RemoveDuplicates(List<int> numbers)
        {
            //list to store elements after removing duplicates
            List<int> result = new List<int>();

            //hashset to track duplicates
            HashSet<int> visited = new HashSet<int>();

            //loop through list
            foreach (int num in numbers)
            {
                //check if visited or not
                if (!visited.Contains(num))
                {
                    visited.Add(num);
                    result.Add(num);
                }
            }

            Console.WriteLine("List After Removing Duplicates:");
            foreach (int num in result)
            {
                Console.Write(num + " ");
            }
        }
    }
}
