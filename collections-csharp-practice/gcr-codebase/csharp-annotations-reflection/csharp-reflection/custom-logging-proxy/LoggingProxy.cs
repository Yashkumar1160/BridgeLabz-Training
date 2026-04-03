using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.custom_logging_proxy
{
    internal class LoggingProxy
    {
        public static void Invoke(object obj, string methodName)
        {
            //get type info
            Type type = obj.GetType();

            //get method info
            MethodInfo method = type.GetMethod(methodName);

            //log method name
            Console.WriteLine("Calling method: " + methodName);

            //invoke method
            method.Invoke(obj, null);
        }
    }
}
