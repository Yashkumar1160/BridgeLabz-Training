using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csharp_json_data
{

    internal class ReadJson
    {
        public static void Main()
        {
            //read json file
            string json = File.ReadAllText("C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csharp-json-data\\User.json");

            //parse json data
            JObject obj = JObject.Parse(json);

            //display name field
            Console.WriteLine("Name: " + obj["name"]);

            //display email field
            Console.WriteLine("Email: " + obj["email"]);
        }
    }
}
