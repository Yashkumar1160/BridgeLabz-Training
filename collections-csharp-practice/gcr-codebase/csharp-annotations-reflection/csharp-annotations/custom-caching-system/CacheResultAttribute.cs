using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.custom_caching_system
{
    //attribute to mark methods whose result should be cached
    [AttributeUsage(AttributeTargets.Method)]
    internal class CacheResultAttribute : Attribute
    {
    }
}
