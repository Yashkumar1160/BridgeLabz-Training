using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.access_private_fields
{
    internal class Program
    {
        public static void Main()
        {
            //create object
            Person person = new Person();

            //get type information
            Type type = typeof(Person);

            //get private field using BindingFlags
            FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            //set new value
            field.SetValue(person, 30);

            //get value
            int value = (int)field.GetValue(person);

            Console.WriteLine("Age value: " + value);
        }
    }
}
