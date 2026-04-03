using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    internal class BusRouteDistance
    {
        //variable to store total distance
        double totalDistance = 0;

        //variable to store total bus stops
        int totalStops=0;
        public static void Main(string[] args)
        {
            Start();
        }

        //---------------DISPLAY MENU------------------
        //method to display the menu
        public static void Start()
        {
            Console.WriteLine("WELCOME TO BUS DISTANCE TRACKER");

            //create object
            BusRouteDistance busRouteDistance = new BusRouteDistance();

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\n1. ADD DISTANCE TO TRAVEL");
                Console.WriteLine("\n2. CHECK TOTAL DISTANCE TRAVELLED");
                Console.WriteLine("\n3. GET OFF FROM BUS");
                Console.WriteLine("\n4. DISPLAY TOTAL STOPS");
                Console.Write("\nENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        busRouteDistance.AddDistance();
                        break;

                    case 2:
                        busRouteDistance.CheckTotalDistance();
                        break;

                    case 3:
                        if (busRouteDistance.GetOffFromBus())
                        {
                            return;
                        }
                        break;

                    case 4:
                        busRouteDistance.DisplayTotalStops();
                        break;

                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }

            }

        }
        //----------------CHECK DISTANCE------------------
        //method to validate distance value
        public bool CheckDistance(double distance)
        {
            return distance > 0;
        }

        //----------------ADD DISTANCE-------------------
        //method to add distance
        public void AddDistance()
        {
            //take user input distance
            Console.Write("\nENTER DISTANCE TO TRAVEL: ");

            double distance = Convert.ToDouble(Console.ReadLine());

            if (CheckDistance(distance))
            {
                totalDistance += distance;

                Console.WriteLine("DISTANCE ADDED");
            }
            else
            {
                Console.WriteLine("ENTER VALID DISTANCE");
                return;
            }
        }

        //-----------------CHECK TOTAL DISTANCE---------------
        //method to check total distance travelled
        public void CheckTotalDistance()
        {
            Console.WriteLine("TOTAL DISTANCE: " + totalDistance);
        }

        //-------------------GET OFF FROM BUS-----------------
        //method to get off from bus
        public bool GetOffFromBus()
        {
            //take user input
            Console.Write("DO YOU WANT TO EXIT BUS (YES/NO): ");

            string choice = Console.ReadLine();
            
            //check user's input 
            if (choice == "YES")
            {
                Console.WriteLine("THANKYOU FOR TRAVELLING");
                return true;
            }

            return false;

        }

        //-------------DISPLAY TOTAL STOPS---------------
        //method to display total bus stops
        public void DisplayTotalStops()
        {
            Console.WriteLine("TOTAL STOPS COVERED: "+totalStops);
        }
    }

}

