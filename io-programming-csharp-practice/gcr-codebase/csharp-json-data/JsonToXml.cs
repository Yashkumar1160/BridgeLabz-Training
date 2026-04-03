using System;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csharp_json_data
{
    internal class JsonToXml
    {
        public static void Main()
        {
            //json data
            string json = @"{ 'name':'Yash', 'age':20 }";

            //convert json to xml
            XNode xml = JsonConvert.DeserializeXNode(json, "User");

            //display xml
            Console.WriteLine(xml);
        }
    }
}
