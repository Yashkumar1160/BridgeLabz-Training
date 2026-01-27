using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.dependency_injection
{
    internal class Program
    {
        public static void Main()
        {
            //create object 
            Controller controller = new Controller();

            DIContainer.InjectDependencies(controller);

            controller.Run();
        }
    }
}
