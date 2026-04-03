using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.traffic_manager
{
    internal class TrafficManagerMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("------TRAFFIC MANAGEMENT SYSTEM------");

            //create roundabout and queue objects
            RoundaboutUtilityImpl roundabout = new RoundaboutUtilityImpl();
            VehicleQueue queue = new VehicleQueue(5);

            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n1. ADD VEHICLE");
                Console.WriteLine("2. REMOVE VEHICLE");
                Console.WriteLine("3. DISPLAY ROUNDABOUT");
                Console.WriteLine("4. DISPLAY WAITING QUEUE");
                Console.WriteLine("5. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //add vehicle
                    case 1:
                        //take vehicle number
                        Console.Write("\nENTER VEHICLE NUMBER: ");
                        int vehicle = Convert.ToInt32(Console.ReadLine());

                        //if roundabout empty then add directly
                        if (roundabout.IsEmpty())
                        {
                            roundabout.AddVehicle(vehicle);
                        }
                        else
                        {
                            //otherwise add to queue
                            queue.Enqueue(vehicle);
                        }
                        break;

                    //remove vehicle
                    case 2:
                        //remove vehicle from roundabout
                        roundabout.RemoveVehicle();

                        //move vehicle from queue to roundabout
                        int nextVehicle = queue.Dequeue();
                        if (nextVehicle != -1)
                        {
                            roundabout.AddVehicle(nextVehicle);
                        }
                        break;

                    //display roundabout
                    case 3:
                        roundabout.DisplayRoundabout();
                        break;

                    //display waiting queue
                    case 4:
                        queue.DisplayQueue();
                        break;

                    //exit
                    case 5:
                        Console.WriteLine("\nEXIT SUCCESSFUL");
                        return;

                    default:
                        Console.WriteLine("\nINVALID CHOICE");
                        break;
                }
            }
        }
    }
}
