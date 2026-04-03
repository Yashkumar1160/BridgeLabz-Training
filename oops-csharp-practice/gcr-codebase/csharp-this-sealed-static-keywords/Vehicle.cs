using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_this_sealed_static_keywords
{
    internal class Vehicle
    {
        //static variables
        public static double registrationFee = 1000;

        //instance variables
        public readonly string registrationNumber;

        private string ownerName;

        private string vehicleType;

        //create parameterized constructor
        public Vehicle(string registrationNumber, string ownerName, string vehicleType)
        {
            this.registrationNumber = registrationNumber;
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        public static void Main(string[] args)
        {
            //call TakeInputs method
            TakeInputs();
        }

        //------------TAKE INPUTS-----------------
        //method to take user inputs
        public static void TakeInputs()
        {
            //take registration number input
            Console.Write("ENTER REGISTRATION NUMBER:");
            string registrationNumber = Console.ReadLine();

            //take owner name input
            Console.Write("ENTER OWNER NAME: ");
            string ownerName = Console.ReadLine();

            //take vehicle type input
            Console.Write("ENTER VEHICLE TYPE: ");
            string vehicleType = Console.ReadLine();

            //create object
            Vehicle vehicle = new Vehicle(registrationNumber, ownerName, vehicleType);


            //check if object is of class type
            if (vehicle is Vehicle)
            {
                //call DisplayDetails method
                vehicle.DisplayDetails();

                //call UpdateRegistrationFee method
                UpdateRegistrationFee();

            }
        }

        //--------------DISPLAY DETAILS----------------
        //method to display all Vehicle details
        public void DisplayDetails()
        {
            Console.WriteLine("\nVEHICLE DETAILS: ");

            Console.WriteLine("OWNER NAME: " + ownerName);

            Console.WriteLine("VEHICLE  REGISTRATION NUMBER: " + registrationNumber);

            Console.WriteLine("VEHICLE TYPE: " + vehicleType);

        }

        //----------UPDATE REGISTRATION FEE---------------
        //method to update registration fee
        public static void UpdateRegistrationFee()
        {
            Console.WriteLine("\nOLD REGISTRATION FEE: " + registrationFee);

            //take new registration fee input
            Console.Write("ENTER NEW REGISTRATION FEE: ");
            double newRegistrationFee = Convert.ToDouble(Console.ReadLine());

            //update registration fee
            registrationFee = newRegistrationFee;

            Console.WriteLine("REGISTRATION FEE UPDATED");

            Console.WriteLine("NEW REGISTRATION FEE: " + registrationFee);

        }

    }
}
