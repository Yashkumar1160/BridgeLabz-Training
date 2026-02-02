using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csharp_json_data
{

    internal class Car
    {
        public static void Main()
        {
            //create a Car object
            var car = new
            {
                brand = "Tesla",
                year = 2024,
                color = "Red"
            };

            //convert object to JSON string
            string json = JsonConvert.SerializeObject(car, Formatting.Indented);

            //display json
            Console.WriteLine(json);
        }
    }
}
