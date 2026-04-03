using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.json_representation
{
    internal class Program
    {
        public static void Main()
        {
            //create person
            Person person = new Person { Age = 25, Name = "Yash" };

            Console.WriteLine(JsonConverter.ToJson(person));
        }
    }
}
