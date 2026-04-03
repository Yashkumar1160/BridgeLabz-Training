using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.custom_serialization_attribute
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //create user object
            User user = new User
            {
                Username = "Yash",
                Email = "yash@email.com",
                Age = 30
            };

            //convert object to JSON
            string json = JsonSerializer.ConvertToJson(user);

            //print JSON output
            Console.WriteLine(json);
        }
    }
}
