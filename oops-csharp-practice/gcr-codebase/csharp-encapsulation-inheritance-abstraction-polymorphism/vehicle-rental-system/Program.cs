using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.vehicle_rental_system
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Start();
        }

        public static void Start()
        {

            VehicleManager manager = new VehicleManager();

            while (true)
            {
                Console.WriteLine("\n1. ADD CAR");
                Console.WriteLine("2. ADD BIKE");
                Console.WriteLine("3. ADD TRUCK");
                Console.WriteLine("4. VIEW VEHICLES");
                Console.WriteLine("5. EXIT");
                Console.Write("ENTER CHOICE: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        manager.AddVehicle(new CarImpl("CAR101", 2000));
                        Console.WriteLine("CAR ADDED");
                        break;

                    case 2:
                        manager.AddVehicle(new BikeImpl("BIKE201", 500));
                        Console.WriteLine("BIKE ADDED");
                        break;

                    case 3:
                        manager.AddVehicle(new TruckImpl("TRUCK301", 5000));
                        Console.WriteLine("TRUCK ADDED");
                        break;

                    case 4:
                        Console.Write("ENTER DAYS: ");
                        int days = Convert.ToInt32(Console.ReadLine());
                        manager.DisplayVehicles(days);
                        break;

                    case 5:
                        return;
                }
            }
        }
    }
}
