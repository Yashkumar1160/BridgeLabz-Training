using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.aero_vigil
{
    internal class FlightUtilityImpl : IFlight
    {
        //store passenger capacity
        CapacityStore<int> passengerCapacity = new CapacityStore<int>();

        //store fuel capacity
        CapacityStore<double> fuelCapacity = new CapacityStore<double>();

        //constructor
        public FlightUtilityImpl()
        {
            //passenger capacity
            passengerCapacity.Add("SpiceJet", 396);
            passengerCapacity.Add("Vistara", 615);
            passengerCapacity.Add("IndiGo", 230);
            passengerCapacity.Add("Air Arabia", 130);

            //fuel capacity
            fuelCapacity.Add("SpiceJet", 200000);
            fuelCapacity.Add("Vistara", 300000);
            fuelCapacity.Add("IndiGo", 250000);
            fuelCapacity.Add("Air Arabia", 150000);
        }

        //method to validate flight number
        //method to validate flight number using regex
        public bool ValidateFlightNumber(string flightNumber)
        {
            //regex pattern: FL- followed by exactly 4 digits
            string pattern = @"^FL-\d{4}$";

            //check flight number using regex
            if (!Regex.IsMatch(flightNumber, pattern))
            {
                throw new InvalidFlightException("The flight number " + flightNumber + " is invalid");
            }

            return true;
        }



        //method to validate flight name
        public bool ValidateFlightName(string flightName)
        {
            //check if flight name is valid
            if (!passengerCapacity.Contains(flightName))
            {
                throw new InvalidFlightException("The flight name " + flightName + " is invalid");
            }

            return true;
        }

        //method to validate passenger count
        public bool ValidatePassengerCount(int passengerCount, string flightName)
        {
            //store max passenger count
            int max = passengerCapacity.Get(flightName);

            //check passenger count
            if (passengerCount <= 0 || passengerCount > max)
            {
                throw new InvalidFlightException("The passenger count " + passengerCount + " is invalid for " + flightName);
            }

            return true;
        }

        //method to calculate fuel
        public double CalculateFuelToFillTank(string flightName, double currentFuelLevel)
        {
            //store max fuel capacity
            double maxFuel = fuelCapacity.Get(flightName);

            //check current fuel
            if (currentFuelLevel < 0 || currentFuelLevel > maxFuel)
            {
                throw new InvalidFlightException("Invalid fuel level for " + flightName);
            }

            return maxFuel - currentFuelLevel;
        }
    }
}
