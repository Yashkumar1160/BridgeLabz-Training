using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csharp_json_data
{
    internal class JsonReport
    {
        public static void Main()
        {
            //mock database records
            var records = new List<object>
            {
                new { id = 1, name = "Yash", score = 85 },
                new { id = 2, name = "Varun", score = 90 }
            };

            //convert records to json report
            string json = JsonConvert.SerializeObject(records, Formatting.Indented);

            //display report
            Console.WriteLine(json);
        }
    }
}
