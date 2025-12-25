using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_2
{
    internal class UnitConverterThree
    {
        //Method to convert fahrenheit to celsius
        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            double fahrenheit2celsius = (fahrenheit - 32) * 5 / 9;
            return fahrenheit2celsius;
        }
        //Method to convert celsius to fahrenheit
        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double celsius2fahrenheit = (celsius * 9 / 5) + 32;
            return celsius2fahrenheit;
        }
        //Method to convert pounds to kilograms
        public static double ConvertPoundsToKilograms(double pounds)
        {
            double pounds2kilograms = 0.453592;
            return pounds * pounds2kilograms;
        }
        //Method to convert kilograms to pounds
        public static double ConvertKilogramsToPounds(double kilograms)
        {
            double kilograms2pounds = 2.20462;
            return kilograms * kilograms2pounds;
        }
        //Method to convert gallons to litres
        public static double ConvertGallonsToLitres(double gallons)
        {
            double gallons2litres = 3.78541;
            return gallons * gallons2litres;
        }
        //Method to convert litres to gallons
        public static double ConvertLitresToGallons(double litres)
        {
            double litres2gallons = 0.264172;
            return litres * litres2gallons;
        }
    }
}
