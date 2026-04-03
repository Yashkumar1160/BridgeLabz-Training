using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.obsolete_attribute
{
    internal class LegacyAPI
    {
        //old method 
        [Obsolete("OldFeature is obsolete.")]
        public void OldFeature()
        {
            Console.WriteLine("Old feature");
        }

        //new method
        public void NewFeature()
        {
            Console.WriteLine("New feature");
        }
    }
}
