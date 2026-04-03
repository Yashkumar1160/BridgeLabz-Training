using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.aero_vigil
{
    internal class CapacityStore<T>
    {
        private Dictionary<string, T> data = new Dictionary<string, T>();

        //method to add value to dictionary
        public void Add(string key, T value)
        {
            data[key] = value;
        }

        //method to get value using key
        public T Get(string key)
        {
            return data[key];
        }

        //method to check if key exists
        public bool Contains(string key)
        {
            return data.ContainsKey(key);
        }
    }
}
