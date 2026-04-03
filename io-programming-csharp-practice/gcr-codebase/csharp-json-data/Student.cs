using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csharp_json_data
{

    internal class Student
    {
        public static void Main()
        {
            //create a Student object 
            var student = new
            {
                name = "Yash",
                age = 20,
                subjects = new string[] { "Maths", "Physics", "Computer Science" }
            };

            //convert object to JSON string
            string json = JsonConvert.SerializeObject(student, Formatting.Indented);

            //display json
            Console.WriteLine(json);
        }
    }
}