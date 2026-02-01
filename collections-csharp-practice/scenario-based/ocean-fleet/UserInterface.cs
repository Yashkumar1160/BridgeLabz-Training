using System;
using System.Collections.Generic;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.ocean_fleet
{
    public class UserInterface
    {
        public static void DisplayMenu()
        {
             //interface reference
            IVesselUtil util = new VesselUtilImpl();

            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n1. Add Vessel");
                Console.WriteLine("2. Get Vessel By Id");
                Console.WriteLine("3. Show High Performance Vessels");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your choice:");

                //take user's choice
                int choice = int.Parse(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //add vessel
                    case 1:
                        Console.WriteLine("Enter vessel details");
                        string input = Console.ReadLine();

                        //split input
                        string[] data = input.Split(':');

                        Vessel vessel = new Vessel(
                            data[0],
                            data[1],
                            double.Parse(data[2]),
                            data[3]
                        );

                        util.AddVesselPerformance(vessel);
                        Console.WriteLine("Vessel added successfully");
                        break;

                    //get vessel by id
                    case 2:
                        Console.WriteLine("Enter the Vessel Id to check speed");
                        string id = Console.ReadLine();

                        Vessel found = util.GetVesselById(id);

                        if (found != null)
                        {
                            Console.WriteLine(
                                found.VesselId + " | " +
                                found.VesselName + " | " +
                                found.VesselType + " | " +
                                found.AverageSpeed + " knots"
                            );
                        }
                        else
                        {
                            Console.WriteLine("Vessel Id " + id + " not found");
                        }
                        break;

                    //show high performance vessels
                    case 3:
                        Console.WriteLine("High performance vessels are");

                        List<Vessel> topVessels = util.GetHighPerformanceVessels();

                        foreach (Vessel v in topVessels)
                        {
                            Console.WriteLine(
                                v.VesselId + " | " +
                                v.VesselName + " | " +
                                v.VesselType + " | " +
                                v.AverageSpeed + " knots"
                            );
                        }
                        break;

                    //exit
                    case 4:
                        Console.WriteLine("Exiting OceanFleet Analytics");
                        return;

                    //invalid choice
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
