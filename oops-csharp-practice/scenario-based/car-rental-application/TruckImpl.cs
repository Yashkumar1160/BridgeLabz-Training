using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.car_rental_application
{
    internal class TruckImpl : Vehicle, IRentable 
    {
        public TruckImpl(int vehicleId, string brand):base(vehicleId,brand) { }

        //implementation of CalculateRent method
        public double CalculateRent(int days)
        {
            return days * 1500;
        }

        //override DisplayInfo method
        public override void DisplayInfo()
        {
            Console.WriteLine("\nTRUCK ID: "+vehicleId);

            Console.WriteLine("TRUCK BRAND: " + brand);
            
            Console.WriteLine("AVAILABLE: " + available);

        }
    }
}
