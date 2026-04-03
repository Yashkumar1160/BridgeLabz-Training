using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_1
{
    internal class TrigonometricFunctions
    {
        public static void Main(string[] args)
        {
            //take input angle
            Console.WriteLine("Enter angle in degrees:");
            double angle = Convert.ToDouble(Console.ReadLine());

            //create instance of class
            TrigonometricFunctions trigonometricFunctions = new TrigonometricFunctions();

            //call the CalculateTrigonometricFinctions() method and store  result in array
            double[] result = trigonometricFunctions.CalculateTrigonometricFunctions(angle);
            //display result
            Console.WriteLine("Sine value : " + result[0]);
            Console.WriteLine("Cosine value : " + result[1]);
            Console.WriteLine("Tangent value : " + result[2]);
        }
        //Method to calculate trigonometric functions
        public double[] CalculateTrigonometricFunctions(double angle)
        {
            //convert degrees to radians
            double radians = angle * Math.PI / 180;

            //create array to store trigonometric function values
            double[] result = new double[3];
            //sine value
            result[0] = Math.Sin(radians);
            //cosine value
            result[1] = Math.Cos(radians);
            //tangent value
            result[2] = Math.Tan(radians);
            //return result array
            return result;
        }
    }
}
