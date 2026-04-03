using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.repeatable_attribute
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    internal class BugReport : Attribute 
    {
        //property to store bug description
        public string Description { get; }

        //constructor 
        public BugReport(string description)
        {
            Description = description;
        }
    }
}
