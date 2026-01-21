using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class ConvertSetToSortedList
    {
        public static void Main(string[] args)
        {
            //take number of elements
            Console.WriteLine("Enter Number of Elements: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            //hashset to store numbers
            HashSet<int> numbers = new HashSet<int>();

            //tale elements
            Console.WriteLine("Enter Elements:");
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.Write("Enter Element: ");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //call ConvertToSortedListmethod
            ConvertToSortedList(numbers);
        }

        //method to convert set to sorted list
        public static void ConvertToSortedList(HashSet<int> numbers)
        {
            //sorted list
            List<int> sortedList = new List<int>(numbers);
            sortedList.Sort();

            //display result    
            Console.WriteLine("Sorted List:");
            foreach (int num in sortedList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
