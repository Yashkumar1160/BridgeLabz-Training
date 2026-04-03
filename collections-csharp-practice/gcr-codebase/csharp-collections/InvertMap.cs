using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_collections
{
    internal class InvertMap
    {
        public static void Main(string[] args)
        {
            //dictionary to store key value pair 
            Dictionary<string, int> inputMap = new Dictionary<string, int>();

            inputMap.Add("A", 1);
            inputMap.Add("B", 2);
            inputMap.Add("C", 1);

            //call InvertDictionary method
            InvertDictionary(inputMap);
        }

        //method to invert dictionary
        public static void InvertDictionary(Dictionary<string, int> inputMap)
        {
            //dictionary to store inverted result
            Dictionary<int, List<string>> invertedMap = new Dictionary<int, List<string>>();


            //loop through original dictionary
            foreach (var item in inputMap)
            {
                //check if value already exists
                if (!invertedMap.ContainsKey(item.Value))
                {
                    invertedMap[item.Value] = new List<string>();
                }

                //add original key to list
                invertedMap[item.Value].Add(item.Key);
            }

            //display inverted dictionary
            Console.WriteLine("Inverted Map:");
            foreach (var item in invertedMap)
            {
                Console.Write(item.Key + " = ");
                foreach (string key in item.Value)
                {
                    Console.Write(key + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
