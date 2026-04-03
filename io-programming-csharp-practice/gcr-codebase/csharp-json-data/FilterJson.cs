using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csharp_json_data
{
    internal class FilterJson
    {
        public static void Main()
        {
            //json array data
            string json = @"[
              { 'name':'Yash', 'age':22 },
              { 'name':'Varun', 'age':28 }
            ]";

            //parse json array
            JArray arr = JArray.Parse(json);

            //filter records where age > 25
            foreach (JObject obj in arr)
            {
                if ((int)obj["age"] > 25)
                {
                    //display name
                    Console.WriteLine(obj["name"]);
                }
            }
        }
    }
}
