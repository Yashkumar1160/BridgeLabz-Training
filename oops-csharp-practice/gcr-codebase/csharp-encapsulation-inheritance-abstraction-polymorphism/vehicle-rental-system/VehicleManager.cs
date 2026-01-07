using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.vehicle_rental_system
{
    internal class VehicleManager
    {
        Vehicle[] vehicles = new Vehicle[50];

        int count = 0;

        public void AddVehicle(Vehicle vehicle)
        {
            vehicles[count] = vehicle;
            count++;
        }

        public void DisplayVehicles(int days)
        {
            for (int i = 0; i < count; i++)
            {
                vehicles[i].DisplayDetails();

                double rent = vehicles[i].CalculateRentalCost(days);
                Console.WriteLine("RENTAL COST: " + rent);

                if (vehicles[i] is IInsurable insurable)
                {
                    Console.WriteLine(insurable.GetInsuranceDetails());
                }
            }
        }

    }
}
