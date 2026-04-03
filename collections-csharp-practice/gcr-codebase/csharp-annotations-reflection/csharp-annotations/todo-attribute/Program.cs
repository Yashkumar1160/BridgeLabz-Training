using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.todo_attribute
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //get type info
            Type type = typeof(Project);

            //loop through methods
            foreach (MethodInfo method in type.GetMethods())
            {
                //get all Todo attributes
                object[] todos =
                    method.GetCustomAttributes(typeof(TodoAttribute), false);

                //print todo details
                foreach (TodoAttribute todo in todos)
                {
                    Console.WriteLine("Method: " + method.Name);
                    Console.WriteLine("Task: " + todo.Task);
                    Console.WriteLine("Assigned To: " + todo.AssignedTo);
                    Console.WriteLine("Priority: " + todo.Priority);
                    Console.WriteLine();
                }
            }
        }
    }
}
