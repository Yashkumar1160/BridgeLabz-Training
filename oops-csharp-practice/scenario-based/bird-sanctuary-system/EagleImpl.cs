using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary_system
{
    internal class EagleImpl : Bird, IFlyable 
    {
        //constructor
        public EagleImpl(string species,string color):base(species, color) { }

        //implementation of CanFly method
        public bool CanFly()
        {
            return true;
        }

        //override DisplayDetails method
        public override void DisplayDetails()
        {

            Console.WriteLine("\nBIRD SPECIES: "+species);

            Console.WriteLine("BIRD COLOR: " + color);
        }
    }
}
