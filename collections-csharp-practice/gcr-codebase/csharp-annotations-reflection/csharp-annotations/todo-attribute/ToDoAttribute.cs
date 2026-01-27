using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.todo_attribute
{
    //custom attribute to mark todo tasks
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    internal class TodoAttribute : Attribute
    {
        //store task 
        public string Task { get; }

        //store developer name
        public string AssignedTo { get; }

        //priority level
        public string Priority { get; }

        //constructor 
        public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
        {
            Task = task;
            AssignedTo = assignedTo;
            Priority = priority;
        }
    }
}
