using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_1
{
    internal class WindChill
    {
        public static void Main(string[] args)
        {
            //take user inputs for variables temperature and windSpeed
            Console.WriteLine("Enter Temperature:");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter wind speed:");
            double windSpeed = Convert.ToDouble(Console.ReadLine());

            //create instance of class
            WindChill wc = new WindChill();

            //call the CalculateWindChill() method
            double windChill = wc.CalculateWindChill(temperature, windSpeed);
            //display result
            Console.WriteLine("Wind chill temperature : " + windChill);

        }
        //Method to calculate wind chill
        public double CalculateWindChill(double temperature, double windSpeed)
        {
            //calculate wind chill temperature
            double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
            //return windchill
            return windChill;
        }
    }
}
