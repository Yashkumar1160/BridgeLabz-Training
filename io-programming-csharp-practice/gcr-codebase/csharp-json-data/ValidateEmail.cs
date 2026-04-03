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
    internal class ValidateEmail
    {
        public static void Main()
        {
            //json data
            string json = @"{ 'email':'yash@gmail.com' }";

            //json schema
            string schemaText = @"{
              'type':'object',
              'properties':{
                'email':{ 'type':'string', 'format':'email' }
              },
              'required':['email']
            }";

            //parse schema
            JSchema schema = JSchema.Parse(schemaText);

            //parse json
            JObject data = JObject.Parse(json);

            //validate email
            bool isValid = data.IsValid(schema);

            //display result
            Console.WriteLine(isValid ? "Valid Email" : "Invalid Email");
        }
    }
}
