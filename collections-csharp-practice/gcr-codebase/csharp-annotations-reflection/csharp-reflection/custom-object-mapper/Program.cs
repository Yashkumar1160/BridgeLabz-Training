using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.custom_object_mapper
{
    internal class Program
    {
        public static void Main()
        {
            //create dictionary
            Dictionary<string, object> data = new Dictionary<string, object>();
            data["Id"] = 1;
            data["Name"] = "Yash";

            //map dictionary to object
            User user = ObjectMapper.ToObject<User>(data);

            Console.WriteLine("UserId: " + user.Id);
            Console.WriteLine("User Name: " + user.Name);
        }
    }
}
