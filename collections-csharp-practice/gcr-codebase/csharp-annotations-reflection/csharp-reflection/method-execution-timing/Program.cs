using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.method_execution_timing
{
    internal class Program
    {
        public static void Main()
        {
            //create object
            Worker worker = new Worker();

            MethodTimer.Execute(worker, "DoWork");
        }
    }
}
