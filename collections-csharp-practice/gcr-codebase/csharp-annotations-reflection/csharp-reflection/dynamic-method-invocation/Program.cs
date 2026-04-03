using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.dynamic_method_invocation
{
    internal class Program
    {
        public static void Main()
        {
            //create object of MathOperations
            MathOperations math = new MathOperations();

            //take method name
            Console.WriteLine("Enter method name (Add, Subtract, Multiply):");
            string methodName = Console.ReadLine();

            //get type information
            Type type = typeof(MathOperations);

            //get method info based on user input
            MethodInfo method = type.GetMethod(methodName);

            //check if method exists
            if (method != null)
            {
                //invoke method dynamically
                object result = method.Invoke(math, new object[] { 10, 5 });

                //print result
                Console.WriteLine("Result: " + result);
            }
            else
            {
                //method not found
                Console.WriteLine("Invalid method name");
            }
        }
    }
}
