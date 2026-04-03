using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.mark_important_methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //get type information
            Type type = typeof(Service);

            //loop through all methods
            foreach (MethodInfo method in type.GetMethods())
            {
                //check if method has ImportantMethod attribute
                ImportantMethodAttribute attr =
                    method.GetCustomAttribute<ImportantMethodAttribute>();

                //if attribute exists
                if (attr != null)
                {
                    Console.WriteLine("Method: " + method.Name);
                    Console.WriteLine("Level: " + attr.Level);
                    Console.WriteLine();
                }
            }
        }
    }
}
