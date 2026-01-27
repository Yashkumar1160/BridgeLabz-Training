using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.method_execution_timing
{
    internal class MethodTimer
    {
        public static void Execute(object obj, string methodName)
        {
            //get type info
            Type type = obj.GetType();

            //get method info
            MethodInfo method = type.GetMethod(methodName);

            //start stopwatch
            Stopwatch sw = Stopwatch.StartNew();

            //invoke method
            method.Invoke(obj, null);

            //stop stopwatch
            sw.Stop();

            //print time taken
            Console.WriteLine("Execution Time: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}
