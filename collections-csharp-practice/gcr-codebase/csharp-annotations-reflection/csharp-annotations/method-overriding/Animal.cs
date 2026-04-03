using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.method_overriding
{
    //parent class
    internal class Animal
    {
        //method to make sound
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
}
