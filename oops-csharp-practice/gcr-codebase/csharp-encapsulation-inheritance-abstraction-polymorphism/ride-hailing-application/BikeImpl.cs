using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ride_hailing_application
{
    internal class BikeImpl : Vehicle, IGPS 
    {
        //constructor
        public BikeImpl(int id, string driverName, double rate) : base(id, driverName, rate) { }

        //override CalculateFare method 
        public override double CalculateFare(double distance)
        {
            return distance * ratePerKm * 0.9; // 10% discount for bikes
        }

        //methods to get location and update location
        public string GetCurrentLocation()
        {
            return "Current Location: " + base.GetLocation();
        }

        public void UpdateLocation(string newLocation)
        {
            base.SetLocation(newLocation);
        }

    }
}
