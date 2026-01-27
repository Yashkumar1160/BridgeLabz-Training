using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.custom_attribute
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //create object of TaskManager
            TaskManager manager = new TaskManager();

            //get method info using reflection
            MethodInfo method = typeof(TaskManager).GetMethod("CompleteTask");

            //get custom attribute from method
            TaskInfo info = (TaskInfo)Attribute.GetCustomAttribute(method, typeof(TaskInfo));

            //print attribute details
            Console.WriteLine("Priority: " + info.Priority);
            Console.WriteLine("Assigned To: " + info.AssignedTo);

            //call method
            manager.CompleteTask();
        }
    }
}
