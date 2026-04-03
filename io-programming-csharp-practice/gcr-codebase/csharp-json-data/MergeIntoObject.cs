using System;
using System.IO;
using Newtonsoft.Json.Linq;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csharp_json_data
{
    internal class MergeIntoObject
    {
        public static void Main()
        {
            //read first json file
            JObject obj1 = JObject.Parse(File.ReadAllText("C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csharp-json-data\\UserInfo.json"));

            //read second json file
            JObject obj2 = JObject.Parse(File.ReadAllText("C:\\Users\\yk444\\Videos\\BTECH\\.NET\\BridgeLabzTraining\\BridgeLabzTraining\\io-programming-csharp-practice\\gcr-codebase\\csharp-json-data\\UserInfo2.json"));

            //merge json objects
            obj1.Merge(obj2);

            //display merged json
            Console.WriteLine(obj1.ToString());
        }
    }
}
