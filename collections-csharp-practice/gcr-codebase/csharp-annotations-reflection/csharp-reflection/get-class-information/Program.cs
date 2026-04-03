using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.get_class_information
{
    internal class Program
    {
        static void Main()
        {
            //get type information of SampleClass
            Type type = typeof(SampleClass);

            Console.WriteLine("Class Name: " + type.Name);

            //get all methods
            Console.WriteLine("\nMethods:");
            foreach (MethodInfo method in type.GetMethods())
            {
                Console.WriteLine(method.Name);
            }

            //get all fields
            Console.WriteLine("\nFields:");
            foreach (FieldInfo field in type.GetFields(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine(field.Name);
            }

            //get constructors
            Console.WriteLine("\nConstructors:");
            foreach (ConstructorInfo constructorInfo in type.GetConstructors())
            {
                Console.WriteLine(constructorInfo.Name);
            }
        }
    }
}
