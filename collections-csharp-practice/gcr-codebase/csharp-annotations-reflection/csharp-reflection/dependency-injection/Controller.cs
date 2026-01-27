 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.dependency_injection.InjectionAttribute;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_reflection.dependency_injection
{
    internal class Controller
    {
        //dependency to be injected
        [Inject]
        public Service service;

        public void Run()
        {
            service.Execute();
        }
    }
}
