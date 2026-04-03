using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.repeatable_attribute
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //get method info
            MethodInfo method = typeof(IssueTracker).GetMethod("ProcessData");

            //get all BugReport attributes
            object[] bugs = method.GetCustomAttributes(typeof(BugReport), false);

            //print all bug reports
            foreach (BugReport bug in bugs)
            {
                Console.WriteLine("Bug: " + bug.Description);
            }
        }
    }
}
