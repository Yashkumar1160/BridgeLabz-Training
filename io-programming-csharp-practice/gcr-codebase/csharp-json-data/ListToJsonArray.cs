using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csharp_json_data
{
    internal class ListToJsonArray
    {
        public static void Main()
        {
            //create list of users
            var users = new List<object>
            {
                new { name = "Yash", age = 20 },
                new { name = "Varun", age = 28 }
            };

            //convert list to json array
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);

            //display json array
            Console.WriteLine(json);
        }
    }
}
