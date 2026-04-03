using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_instance_vs_class_variable
{
    internal class Vehicle
    {
        //instance variables
        string ownerName;

        string vehicleType;

        //class variable
        static int registrationFee = 100;

        //create parameterized constructor
        Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        public static void Main(string[] args)
        {
            //take owner name input
            Console.Write("ENTER OWNER NAME: ");
            string ownerName = Console.ReadLine();

            //take owner name input
            Console.Write("ENTER VEHICLE TYPE: ");
            string vehicleType = Console.ReadLine();

            //create object
            Vehicle vehicle = new Vehicle(ownerName, vehicleType);

            //call the DisplayVehicleDetails method
            vehicle.DisplayVehicleDetails();

            //call the UpdateRegistrationFee method
            UpdateRegistrationFee();


        }

        //---------------DISPLAY VEHICLE DETAILS-----------------
        //method to display vehicle details
        void DisplayVehicleDetails()
        {
            Console.WriteLine("\nVehicle Owner Name: " + ownerName);

            Console.WriteLine("Vehicle Type: " + vehicleType);
        }

        //----------------UPDATE REGISTRATION FEE-----------------
        //method to update vehicle registration fee
        static void UpdateRegistrationFee()
        {
            //take new fee input
            Console.Write("ENTER NEW FEE: ");
            int newFee = Convert.ToInt32(Console.ReadLine());

            //update registration fee
            registrationFee = newFee;

            Console.WriteLine("UPDATED");

            Console.WriteLine("NEW FEE: " + registrationFee);
        }
    }
}
