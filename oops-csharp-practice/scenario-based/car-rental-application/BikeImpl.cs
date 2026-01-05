using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.car_rental_application
{
    internal class BikeImpl:Vehicle,IRentable
    {
        //constructor
        public BikeImpl(int id,string brand) : base(id, brand) { }

        //implementation of CalculateRent method
        public double CalculateRent(int days)
        {
            return days * 500;
        }

        //override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine("\nBIKE ID: " + vehicleId);

            Console.WriteLine("BIKE BRAND: " + brand);

            Console.WriteLine("AVAILABLE: "+available);

        }
    }
}
