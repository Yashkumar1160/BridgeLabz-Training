using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.invoke_private_method
{
    internal class Program
    {
        public static void Main()
        {
            //create object
            Calculator calculator = new Calculator();

            //get type info
            Type type = typeof(Calculator);

            //get private method
            MethodInfo method = type.GetMethod("Multiply",
                BindingFlags.NonPublic | BindingFlags.Instance);

            //invoke private method
            object result = method.Invoke(calculator, new object[] { 5, 4 });

            Console.WriteLine("Result: " + result);
        }
    }
}
