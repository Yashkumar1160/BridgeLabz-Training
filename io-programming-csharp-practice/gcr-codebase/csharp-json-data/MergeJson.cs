using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csharp_json_data
{
    internal class MergeJson
    {
        public static void Main()
        {
            //create first json object
            JObject obj1 = JObject.Parse(@"{ 'name':'Yash' }");

            //create second json object
            JObject obj2 = JObject.Parse(@"{ 'age':20 }");

            //merge second object into first
            obj1.Merge(obj2);

            //display merged json
            Console.WriteLine(obj1.ToString());
        }
    }
}
