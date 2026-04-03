using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.aero_vigil
{
    internal class InvalidFlightException : Exception 
    {
        //constructor
        public InvalidFlightException(string message) : base(message)
        {
        }
    }
}
