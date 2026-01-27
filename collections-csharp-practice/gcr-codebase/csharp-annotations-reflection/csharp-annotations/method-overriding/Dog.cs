using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.method_overriding
{
    //child class
    internal class Dog : Animal 
    {
        //override parent method
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
}
