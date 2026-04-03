using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.custom_attribute
{
    internal class TaskManager
    {
        //method marked with custom attribute
        [TaskInfo("High", "Yash")]
        public void CompleteTask()
        {
            Console.WriteLine("Task completed");
        }
    }
}
