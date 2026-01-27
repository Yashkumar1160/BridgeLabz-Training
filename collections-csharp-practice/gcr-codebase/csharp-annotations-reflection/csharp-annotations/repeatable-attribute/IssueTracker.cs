using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.repeatable_attribute
{
    internal class IssueTracker
    {
        //method with multiple bug reports
        [BugReport("Null reference exception occurs")]
        [BugReport("Performance issue on large input")]
        public void ProcessData()
        {
            Console.WriteLine("Processing data");
        }
    }
}
