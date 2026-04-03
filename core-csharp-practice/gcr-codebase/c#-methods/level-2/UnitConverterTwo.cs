using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_2
{
    internal class UnitConverterTwo
    {
        //Method to convert feet to yards
        public static double ConvertFeetToYards(double feet)
        {
            double feet2yards = 0.333333;
            return feet * feet2yards;
        }
        //Method to convert meters to inches
        public static double ConvertMetersToInches(double meters)
        {
            double meters2inches = 39.3701;
            return meters * meters2inches;
        }//Method to convert inches to meters
        public static double ConvertInchesToMeters(double inches)
        {
            double inches2meters = 0.0254;
            return inches * inches2meters;
        }//Method to convert inches to centimeters
        public static double ConvertInchesToCm(double inches)
        {
            double inches2cm = 2.54;
            return inches * inches2cm;
        }
    }
}
