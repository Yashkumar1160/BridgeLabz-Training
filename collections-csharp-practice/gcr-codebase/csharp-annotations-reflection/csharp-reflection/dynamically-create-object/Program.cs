using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.dynamically_create_object
{
    internal class Program
    {
        public static void Main()
        {
            //get type information
            Type type = typeof(Student);

            //create object dynamically
            object obj = Activator.CreateInstance(type);

            //call method
            MethodInfo method = type.GetMethod("Display");
            method.Invoke(obj, null);
        }
    }
}
