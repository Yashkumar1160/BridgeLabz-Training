using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csharp_json_data
{
    internal class ValidateJson
    {
        public static void Main()
        {
            //json data
            string json = @"{ 'id':1, 'name':'Yash', 'email':'yash@gmail.com' }";

            //json schema
            string schemaText = @"{
              'type':'object',
              'properties':{
                'id':{'type':'integer'},
                'name':{'type':'string'},
                'email':{'type':'string'}
              },
              'required':['id','name','email']
            }";

            //parse schema
            JSchema schema = JSchema.Parse(schemaText);

            //parse json data
            JObject data = JObject.Parse(json);

            //validate json
            bool isValid = data.IsValid(schema);

            //display validation result
            Console.WriteLine(isValid ? "Valid JSON" : "Invalid JSON");
        }
    }
}
