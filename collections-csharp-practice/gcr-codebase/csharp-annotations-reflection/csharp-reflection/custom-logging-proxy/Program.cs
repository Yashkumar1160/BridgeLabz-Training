using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.custom_logging_proxy
{
    internal class Program
    {
        static void Main()
        {
            IGreeting greeting = new GreetingImpl();

            LoggingProxy.Invoke(greeting, "SayHello");
        }
    }
}
