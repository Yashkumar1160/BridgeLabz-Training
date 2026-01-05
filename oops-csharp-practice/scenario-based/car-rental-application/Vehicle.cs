using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.car_rental_application
{
    abstract class Vehicle
    {
        //variable to store vehicleId
        public int vehicleId;

        //variable to store vehicle brand
        public string brand;

        //variable to store vehicle availability
        public bool available = true;

        //parameterized constructor
        public Vehicle(int vehicleId, string brand)
        {
            this.vehicleId = vehicleId;
            this.brand = brand;
        }

        //method to mark that the vehicle is rented
        public void MarkRented()
        {
            available = false;
        }

        //method to mark that the vehicle is returned
        public void MarkReturned()
        {
            available=true;
        }

        //abstract method to display vehicle details
        public abstract void DisplayInfo();

    }
}
