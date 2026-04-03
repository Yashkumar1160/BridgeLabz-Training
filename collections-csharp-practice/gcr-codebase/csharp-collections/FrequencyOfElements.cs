using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class FrequencyOfElements
    {
        public static void Main(string[] args)
        {
            //take number of elements
            Console.Write("Enter Number Of Elements: ");
            int numberOfElements = Convert.ToInt32(Console.ReadLine());

            //list to store items
            List<string> items = new List<string>();

            //loop to take elements
            for (int i = 0; i < numberOfElements; i++)
            {
                //take element
                Console.Write("Enter Element: ");
                string value = Console.ReadLine();
                items.Add(value);
            }

            //call FindFrequency method
            FindFrequency(items);
        }

        //method to find frequency of elements
        public static void FindFrequency(List<string> items)
        {
            //dictionary to store frequency 
            Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

            //loop to add frequency
            foreach (string item in items)
            {
                if (frequencyMap.ContainsKey(item))
                {
                    frequencyMap[item]++;
                }
                else
                {
                    frequencyMap.Add(item, 1);
                }
            }

            //display frequency
            Console.WriteLine("Element Frequency:");
            foreach (var data in frequencyMap)
            {
                Console.WriteLine(data.Key + " : " + data.Value);
            }
        }
    }
}
