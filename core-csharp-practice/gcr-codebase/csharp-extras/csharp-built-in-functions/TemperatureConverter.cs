using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.csharp_extras.csharp_built_in_functions
{
    internal class TemperatureConverter
    {
        public static void Main(string[] args)
        {
            //take input for temperature variable
            Console.WriteLine("Enter temperature");
            double temperature = Convert.ToDouble(Console.ReadLine());
            //give choices to user
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            //take user choice
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {   //if choice is 1 then call CelsiusToFahrenheit method
                Console.WriteLine("Result: " + CelsiusToFahrenheit(temperature));
            }
            else
            {   //if choice is 2 then call FahrenheitToCelsius method
                Console.WriteLine("Result: " + FahrenheitToCelsius(temperature));
            }
        }
        //Method to convert Celsius to Fahrenheit
        public static double CelsiusToFahrenheit(double celsius)
        {   //convert celsius to fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }
        //Method to convert Fahrenheit to Celsius
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            //convert fahrenheit to celsius
            double celsius = (fahrenheit - 32) * 5 / 9;
            return celsius;
        }
    }
}
