using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.logging_method
{
    internal class CalculatorService
    {
        //method with execution time logging
        [LogExecutionTime]
        public void FastMethod()
        {
            //simulate fast work
            Thread.Sleep(500);
        }

        //method with execution time logging
        [LogExecutionTime]
        public void SlowMethod()
        {
            //simulate slow work
            Thread.Sleep(1500);
        }
    }
}
