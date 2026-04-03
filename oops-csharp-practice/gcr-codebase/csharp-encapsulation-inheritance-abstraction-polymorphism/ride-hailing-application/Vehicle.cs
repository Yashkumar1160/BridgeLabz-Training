using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ride_hailing_application
{
    internal abstract class Vehicle
    {
        //variable to store vehicle id
        protected int vehicleId;

        //variable to store driver name
        protected string driverName;
        
        //variable to store rate per km
        protected double ratePerKm;

        //variable to store current location
        private string currentLocation;

        //getter and setter for vehicle id
        public int VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }

        //getter and setter for driver name
        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }

        //getter and setter for rate per km
        public double RatePerKm
        {
            get { return ratePerKm; }
            set { ratePerKm = value; }
        }
        
        //getter and setter for location
        protected void SetLocation(string location)
        {
            currentLocation = location;
        }
        protected string GetLocation(){
            return currentLocation;
        }

        //parameterized constructor
        public Vehicle(int id, string driverName, double rate)
        {
            this.vehicleId = id;
            this.driverName = driverName;
            this.ratePerKm = rate;
            this.SetLocation("Unknown");
        }

        //abstract method to calculate fare
        public abstract double CalculateFare(double distance);

        //concrete method to display vehicle details
        public void GetVehicleDetails()
        {
            Console.WriteLine("\nVEHICLE ID: "+VehicleId);
            
            Console.WriteLine("DRIVER NAME: "+DriverName);
            
            Console.WriteLine("RATE PER KM: "+RatePerKm);

            Console.WriteLine("CURRENT LOCATION: "+GetLocation());
        }
    }
}
