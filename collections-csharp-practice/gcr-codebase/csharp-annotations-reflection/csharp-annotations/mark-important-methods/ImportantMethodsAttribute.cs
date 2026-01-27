using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.mark_important_methods
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class ImportantMethodAttribute : Attribute
    {
        //property to store importance level
        public string Level { get; }

        //constructor 
        public ImportantMethodAttribute(string level = "HIGH")
        {
            Level = level;
        }
    }
}
