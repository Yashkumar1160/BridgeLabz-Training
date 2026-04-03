using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_2
{
    internal class UnitConverter
    {
        //Method to convert kilometers to miles
        public static double ConvertKmToMiles(double km)
        {
            double km2miles = 0.621371;
            return km * km2miles;
        }
        //Method to convert miles to kilometers
        public static double ConvertMilesToKm(double miles)
        {
            double miles2km = 1.60934;
            return miles * miles2km;
        }//Method to convert meters to feet
        public static double ConvertMetersToFeet(double meters)
        {
            double meteres2feet = 3.28084;
            return meters * meteres2feet;
        }//Method to convert feet to meters
        public static double ConvertFeetToMeters(double feet)
        {
            double feet2meters = 0.3048;
            return feet * feet2meters;
        }
    }
}
