using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.vehicle_rental_system
{
    internal abstract class Vehicle
    {
        // protected fields
        protected string vehicleNumber;
        protected string type;
        protected double rentalRate;

        // Getter & Setter properties
        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double RentalRate
        {
            get { return rentalRate; }
            set { rentalRate = value; }
        }

        // Constructor
        public Vehicle(string number, string type, double rate)
        {
            vehicleNumber = number;
            this.type = type;
            rentalRate = rate;
        }

        // Abstract method
        public abstract double CalculateRentalCost(int days);

        // Concrete method
        public void DisplayDetails()
        {
            Console.WriteLine("\nVEHICLE NUMBER: " + VehicleNumber);
            Console.WriteLine("TYPE: " + Type);
            Console.WriteLine("RATE PER DAY: " + RentalRate);
        }
    }
}

