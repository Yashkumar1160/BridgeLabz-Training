using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.car_rental_application
{
    internal class CarImpl : Vehicle, IRentable 
    {
        public CarImpl(int vehicleId, string brand) : base(vehicleId, brand) { }

        //implementation of CalculateRent method
        public double CalculateRent(int days)
        {
            return days * 1000;
        }

        //override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine("\nCAR ID: "+vehicleId);

            Console.WriteLine("CAR BRAND: " + brand);

            Console.WriteLine("AVAILABLE: " + available);
        }
    }
}
