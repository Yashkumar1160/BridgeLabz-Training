using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.car_rental_application
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //create object of RentalService class
            RentalService service = new RentalService();

            Console.WriteLine("VEHICLE RENTAL APPLICATION");

            while (true)
            {
                //display choices
                Console.WriteLine("\n1. ADD BIKE");
                Console.WriteLine("2. ADD CAR");
                Console.WriteLine("3. ADD TRUCK");
                Console.WriteLine("4. VIEW VEHICLES");
                Console.WriteLine("5. RENT VEHICLE");
                Console.WriteLine("6. RETURN VEHICLE");
                Console.WriteLine("7. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                if (choice == 1)
                {
                    Console.Write("\nBIKE ID: ");
                    int id= Convert.ToInt32(Console.ReadLine());
                    Console.Write("BRAND: ");
                    string brand= Console.ReadLine();
                    service.AddVehicle(new BikeImpl(id,brand));
                }
                else if (choice == 2)
                {
                    Console.Write("\nCAR ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("BRAND: ");
                    string brand = Console.ReadLine();
                    service.AddVehicle(new CarImpl(id,brand));
                }
                else if (choice == 3)
                {
                    Console.Write("\nTRUCK ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.Write("BRAND: ");
                    string brand = Console.ReadLine();
                    service.AddVehicle(new TruckImpl(id,brand));
                }
                else if (choice == 4)
                {
                    service.ViewAllVehicles();
                }
                else if (choice == 5)
                {
                    Console.Write("\nVEHICLE ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Vehicle v = service.FindVehicle(id);

                    if (v is IRentable rentable) 
                    {
                        Console.Write("DAYS: ");
                        int days = Convert.ToInt32(Console.ReadLine());

                        if (!UtilityClass.CheckDays(days))
                        {
                            Console.WriteLine("INVALID DAYS");
                            continue;
                        }

                        Console.WriteLine("RENT: " + rentable.CalculateRent(days));
                        v.MarkRented();
                    }
                    else
                    {
                        Console.WriteLine("\nVEHICLE NOT RENTABLE");
                    }
                }
                else if (choice == 6)
                {
                    Console.Write("\nVEHICLE ID: ");
                    Vehicle v = service.FindVehicle(Convert.ToInt32(Console.ReadLine()));
                    if (v != null)
                    {
                        v.MarkReturned();
                        Console.WriteLine("VEHICLE RETURNED");
                    }
                }
                else if (choice == 7)
                {
                    Console.WriteLine("\nTHANKYOU");
                    break;
                }
            }
        }
    }

}
