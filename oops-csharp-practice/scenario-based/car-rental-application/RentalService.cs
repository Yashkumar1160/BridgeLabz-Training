using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.car_rental_application
{
    internal class RentalService
    {
        //variable to store company name
        public static string companyName = "VEHICLE RENTAL";

        //array to store vehicles
        private Vehicle[]vehicles=new Vehicle[100];

        //variable to store total vehicle count
        private int totalVehicle = 0;

        //method to add vehicle
        public void AddVehicle(Vehicle v)
        {
            vehicles[totalVehicle] = v;
            totalVehicle++;
        }

        //method to find vehicle
        public Vehicle FindVehicle(int vehicleId)
        {
            for(int i = 0; i < totalVehicle; i++)
            {
                if (vehicles[i].vehicleId == vehicleId)
                {
                    return vehicles[i];
                }
            }

            return null;
        }

        //method to display all vehicles
        public void ViewAllVehicles()
        {
            for(int i = 0; i < totalVehicle; i++)
            {
                vehicles[i].DisplayInfo();
            }
        }
    }
}
