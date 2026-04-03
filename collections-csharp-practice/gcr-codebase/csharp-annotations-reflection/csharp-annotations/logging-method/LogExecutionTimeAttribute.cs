using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.logging_method
{
    //custom attribute to mark methods for logging execution time
    [AttributeUsage(AttributeTargets.Method)]
    internal class LogExecutionTimeAttribute : Attribute
    {
        //empty attribute 
    }
}
