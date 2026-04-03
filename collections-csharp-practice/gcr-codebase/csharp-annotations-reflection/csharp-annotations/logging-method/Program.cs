using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.logging_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create service object
            CalculatorService service = new CalculatorService();

            //get type info
            Type type = typeof(CalculatorService);

            //loop through methods
            foreach (MethodInfo method in type.GetMethods())
            {
                //check if method has LogExecutionTime attribute
                if (method.GetCustomAttribute<LogExecutionTimeAttribute>() != null)
                {
                    //start stopwatch
                    Stopwatch sw = Stopwatch.StartNew();

                    //call method
                    method.Invoke(service, null);

                    //stop stopwatch
                    sw.Stop();

                    //print execution time
                    Console.WriteLine(
                        method.Name + " executed in " +
                        sw.ElapsedMilliseconds + " ms");
                }
            }
        }
    }
}
