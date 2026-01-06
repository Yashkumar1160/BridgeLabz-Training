using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.bird_sanctuary_system
{
    internal class DuckImpl : Bird,ISwimmable
    {
        //constructor
        public DuckImpl(string species,string color):base(species,color) { }

        //implementation of CanSwim method
        public bool CanSwim()
        {
            return true;
        }

        //override DisplayDetails method
        public override void DisplayDetails()
        {

            Console.WriteLine("\nSPECIES: " + species);

            Console.WriteLine("COLOR: " + color);

        }

    }
}
