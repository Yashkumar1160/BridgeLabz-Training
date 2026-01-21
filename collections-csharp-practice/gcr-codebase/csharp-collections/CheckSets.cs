using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class CheckSets
    {
        public static void Main(string[] args)
        {
            //take number of elements
            Console.WriteLine("Enter Number of Elements: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            //hashsets
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();


            //take elements for set 1
            Console.WriteLine("Enter Elements For Set 1: ");
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Enter Element: ");
                set1.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //take elements for set 2
            Console.WriteLine("Enter Elements For Set 2: ");
            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine("Enter Element: ");
                set2.Add(Convert.ToInt32(Console.ReadLine()));
            }


            //call CheckTwoSets
            CheckTwoSets(set1, set2);
        }

        //method to check if two sets are same
        public static void CheckTwoSets(HashSet<int> set1, HashSet<int> set2)
        {
            //check using SetEquals
            bool result = set1.SetEquals(set2);

            Console.WriteLine("Are Sets Equal: " + result);
        }
    }
}
