using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.aero_vigil
{
    internal class UserInterface
    {
        public static void DisplayMenu()
        {
            //create object of FlightUtil class
            FlightUtilityImpl util = new FlightUtilityImpl();

            while (true)
            {
                //display menu
                Console.WriteLine("\n-------Welcome To AeroVigil-------");
                Console.WriteLine("1. Enter Flight Details");
                Console.WriteLine("2. Exit");
                Console.Write("Enter choice: ");

                //take user's choice
                int choice = int.Parse(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //enter flight details
                    case 1:
                        //try block
                        try
                        {
                            Console.WriteLine("\nEnter flight details");
                            Console.WriteLine("Format: FL-XXXX:FlightName:PassengerCount:FuelLevel");

                            //take flight details
                            string input = Console.ReadLine();

                            //regex pattern for complete input
                            string pattern = @"^FL-\d{4}:[A-Za-z ]+:\d+:\d+(\.\d+)?$";

                            //validate input format using regex
                            if (!Regex.IsMatch(input, pattern))
                            {
                                Console.WriteLine("Invalid input format");
                                break;
                            }

                            //split input after validation
                            string[] data = input.Split(':');


                            //store flight number
                            string flightNumber = data[0];

                            //store flight name
                            string flightName = data[1];

                            //store passenger count
                            int passengerCount = int.Parse(data[2]);

                            //store fuel level
                            double fuelLevel = double.Parse(data[3]);

                            //validate flight number
                            util.ValidateFlightNumber(flightNumber);

                            //validate flight name
                            util.ValidateFlightName(flightName);

                            //validate passenger count
                            util.ValidatePassengerCount(passengerCount, flightName);

                            //calculate fuel
                            double fuel = util.CalculateFuelToFillTank(flightName, fuelLevel);

                            Console.WriteLine("Fuel required to fill the tank: " + fuel + " liters");
                        }
                        //catch block to handle InvalidFlightException
                        catch (InvalidFlightException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        //catch block to catch other exception
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid input format");
                        }
                        break;

                    //exit
                    case 2:
                        Console.WriteLine("Exit Successful");
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
