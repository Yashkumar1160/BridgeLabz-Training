using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ride_hailing_application
{
    internal interface IGPS
    {
        //method to get current location
        string GetCurrentLocation();

        //method to update location
        void UpdateLocation(string newLocation);
    }
}
