using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_annotations_reflection.csharp_annotations.obsolete_attribute
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //create object of LegacyAPI
            LegacyAPI api = new LegacyAPI();

            //calling old method
            api.OldFeature();

            //calling new method
            api.NewFeature();
        }
    }
}
