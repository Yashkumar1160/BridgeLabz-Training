using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.custom_caching_system
{
    public static class CacheManager
    {
        //dictionary to store cached results
        static Dictionary<string, object> cache =new Dictionary<string, object>();

        //method to check if result exists in cache
        public static bool Contains(string key)
        {
            return cache.ContainsKey(key);
        }

        //method to get cached result
        public static object Get(string key)
        {
            return cache[key];
        }

        //method to store result in cache
        public static void Add(string key, object value)
        {
            cache[key] = value;
        }
    }
}
