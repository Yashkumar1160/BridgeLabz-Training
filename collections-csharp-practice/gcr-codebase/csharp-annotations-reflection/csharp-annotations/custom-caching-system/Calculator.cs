using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.custom_caching_system
{
    internal class Calculator
    {
        //this method is expensive and should be cached
        [CacheResult]
        public int Square(int number)
        {
            Console.WriteLine("Performing expensive calculation");

            //simulate heavy processing
            Thread.Sleep(2000);

            return number * number;
        }

        //method to handle caching logic
        public int ExecuteWithCache(string methodName, int input)
        {
            //create cache key
            string key = methodName + "_" + input;

            //check if value already cached
            if (CacheManager.Contains(key))
            {
                Console.WriteLine("Returning cached result");
                return (int)CacheManager.Get(key);
            }

            //call actual method if not cached
            int result = Square(input);

            //store result in cache
            CacheManager.Add(key, result);

            return result;
        }
    }
}
