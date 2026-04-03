using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class DistanceAndLineEquation
    {
        public static void Main(string[] args)
        {
            //take first point input
            Console.Write("Enter x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            //take second point input
            Console.Write("Enter x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            //call the distance method
            double distance = FindDistance(x1, y1, x2, y2);

            //call the line equation method
            double[] line = FindLineEquation(x1, y1, x2, y2);

            //display distance
            Console.WriteLine("Euclidean Distance : " + distance);
            Console.WriteLine("Line Equation : y = " + line[0] + "x + " + line[1]);
        }
        //Method to find euclidean distance
        public static double FindDistance(double x1, double y1, double x2, double y2)
        {
            //calculate (x2-x1)^2
            double partX = Math.Pow(x2 - x1, 2);

            //calculate (y2-y1)^2
            double partY = Math.Pow(y2 - y1, 2);

            //calculate square root of sum
            double distance = Math.Sqrt(partX + partY);

            return distance;
        }
        //Method to find line equation
        public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
        {
            //calculate slope 
            double m = (y2 - y1) / (x2 - x1);
            //calculate y-intercept
            double b = y1 - (m * x1);

            return new double[] { m, b };
        }
    }
}
