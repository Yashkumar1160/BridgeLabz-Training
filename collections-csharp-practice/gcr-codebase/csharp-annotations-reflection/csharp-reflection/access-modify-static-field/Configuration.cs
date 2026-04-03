using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.access_modify_static_field
{
    internal class Configuration
    {
        //private static field
        private static string API_KEY = "OLD_KEY";

        //method to print api key
        public static void PrintKey()
        {
            Console.WriteLine("API Key: " + API_KEY);
        }
    }
}
