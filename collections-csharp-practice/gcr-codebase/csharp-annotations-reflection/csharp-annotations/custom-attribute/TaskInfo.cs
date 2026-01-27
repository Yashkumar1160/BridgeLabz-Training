using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.custom_attribute
{
    //custom attribute to store task info
    [AttributeUsage(AttributeTargets.Method)]
    internal class TaskInfo : Attribute 
    {
        //store priority
        public string Priority { get; }

        //store assigned person
        public string AssignedTo { get; }

        //constructor 
        public TaskInfo(string priority, string assignedTo)
        {
            Priority = priority;
            AssignedTo = assignedTo;
        }
    }
}
