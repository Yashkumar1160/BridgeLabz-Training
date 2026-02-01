using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.aero_vigil
{
    internal interface IFlight
    {
        //method to validate flight number
        public bool ValidateFlightNumber(string flightNumber);
        //method to validate flight name
        public bool ValidateFlightName(string flightName);
        //method to validate passenger count
        public bool ValidatePassengerCount(int passengerCount, string flightName);

        //method to calculate fuel
        public double CalculateFuelToFillTank(string flightName, double currentFuelLevel);

    }
}
