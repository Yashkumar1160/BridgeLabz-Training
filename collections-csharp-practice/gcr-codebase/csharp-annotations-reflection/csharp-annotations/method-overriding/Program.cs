using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.method_overriding
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //create object of Dog class
            Dog dog = new Dog();

            //call overridden method
            dog.MakeSound();
        }
    }
}
