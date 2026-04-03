using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ride_hailing_application
{
    internal class RideManager
    {
        //array to store vehicles
        private Vehicle[] vehicles = new Vehicle[100];

        //variable to store total vehicles count
        private int totalVehicles = 0;

        //method to add vehicle
        public void AddVehicle(Vehicle vehicle)
        {
            vehicles[totalVehicles++] = vehicle;
        }

        //method to display all vehicles
        public void DisplayAllVehicles()
        {
            if (totalVehicles == 0)
            {
                Console.WriteLine("No vehicles available.");
                return;
            }

            for (int i = 0; i < totalVehicles; i++)
            {
                vehicles[i].GetVehicleDetails();
            }
        }

        //method to find a vehicle with id
        public Vehicle FindVehicle(int id)
        {
            for (int i = 0; i < totalVehicles; i++)
            {
                if (vehicles[i].VehicleId == id)
                    return vehicles[i];
            }
            return null;
        }
    }
}
