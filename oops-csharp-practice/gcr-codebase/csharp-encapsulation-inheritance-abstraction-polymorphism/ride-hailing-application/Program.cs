using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ride_hailing_application
{
    internal class Program
    {
        public static void Main()
        {
            Start();
        }

        //method to start program
        public static void Start()
        {
            //create object of class RideManager
            RideManager manager = new RideManager();

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\n--- RIDE HAILING APPLICATION ---");
                Console.WriteLine("1. ADD CAR");
                Console.WriteLine("2. ADD BIKE");
                Console.WriteLine("3. ADD AUTO");
                Console.WriteLine("4. VIEW ALL VEHICLES");
                Console.WriteLine("5. CALCULATE FARE");
                Console.WriteLine("6. UPDATE LOCATION");
                Console.WriteLine("7. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        AddCar(manager);
                        break;

                    case 2:
                        AddBike(manager);
                        break;

                    case 3:
                        AddAuto(manager);
                        break;

                    case 4:
                        Console.WriteLine("\nVEHICLE DETAILS");
                        manager.DisplayAllVehicles();
                        break;

                    case 5:
                        CalculateFare(manager);
                        break;

                    case 6:
                        UpdateLocation(manager);
                        break;

                    case 7:
                        Console.WriteLine("Exiting... Thank you!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        //method to add car
        static void AddCar(RideManager manager)
        {
            //take vehicle id
            Console.Write("VEHICLE ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //take driver name
            Console.Write("DRIVER NAME: ");
            string driver = Console.ReadLine();

            //take rate per km
            Console.Write("RAKE PER KM: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            //create object of class CarImpl
            CarImpl car = new CarImpl(id, driver, rate);

            //add car
            manager.AddVehicle(car);

            Console.WriteLine("CAR ADDED");
        }

        static void AddBike(RideManager manager)
        {
            //take vehicle id
            Console.Write("VEHICLE ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //take driver name
            Console.Write("DRIVER NAME: ");
            string driver = Console.ReadLine();

            //take rate per km
            Console.Write("RAKE PER KM: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            //create object of class BikeImpl
            BikeImpl bike = new BikeImpl(id, driver, rate);

            //add bike
            manager.AddVehicle(bike);

            Console.WriteLine("BIKE ADDED");
        }

        static void AddAuto(RideManager manager)
        {
            //take vehicle id
            Console.Write("VEHICLE ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //take driver name
            Console.Write("DRIVER NAME: ");
            string driver = Console.ReadLine();

            //take rate per km
            Console.Write("RAKE PER KM: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            //create object of class AutoImpl
            AutoImpl auto = new AutoImpl(id, driver, rate);

            //add auto
            manager.AddVehicle(auto);

            Console.WriteLine("AUTO ADDED");
        }

        //method to calculate fare 
        static void CalculateFare(RideManager manager)
        {
            //take vehicle id
            Console.Write("Enter Vehicle ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //call FindVehicle method
            Vehicle vehicle = manager.FindVehicle(id);

            //check if vehicle is null
            if (vehicle == null)
            {
                Console.WriteLine("\nVEHICLE NOT FOUND");
                return;
            }

            //take distance
            Console.Write("ENTER DISTANCE (km): ");
            double distance = Convert.ToDouble(Console.ReadLine());

            //take fare
            double fare = vehicle.CalculateFare(distance);
            Console.WriteLine($"FARE FOR {distance} km: {fare}");
        }

        //method to update location
        static void UpdateLocation(RideManager manager)
        {
            //take vehicle id
            Console.Write("ENTER VEHICLE ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //call FindVehicle method
            Vehicle vehicle = manager.FindVehicle(id);

            //check if vehicle is null
            if (vehicle == null)
            {
                Console.WriteLine("Vehicle not found!");
                return;
            }

            if (vehicle is IGPS gpsVehicle)
            {
                //take new location
                Console.Write("ENTER NEW LOCATION: ");
                string location = Console.ReadLine();

                //update location 
                gpsVehicle.UpdateLocation(location);

                Console.WriteLine("LOCATION UPDATED");
            }
        }
    }
}