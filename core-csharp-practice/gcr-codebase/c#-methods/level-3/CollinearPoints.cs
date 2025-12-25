using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class CollinearPoints
    {
        //Method to check collinear points using slope formula
        public static bool IsCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            //calculate slope AB
            double slopeAB = (y2 - y1) / (x2 - x1);
            //calculate slope BC
            double slopeBC = (y3 - y2) / (x3 - x2);
            //calculate slope AC
            double slopeAC = (y3 - y1) / (x3 - x1);

            //check if all slopes are equal
            if (slopeAB == slopeBC && slopeBC == slopeAC)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Method using area of triangle
        public static bool IsCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            //calculate area using formula
            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));

            //if area is zero, points are collinear
            if (area == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Main(string[] args)
        {
            //take user inputs
            Console.WriteLine("Enter x1 and y1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x2 and y2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter x3 and y3");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());

            //check collinear points using slope method
            bool slopeResult = IsCollinearUsingSlope(x1, y1, x2, y2, x3, y3);

            //check collinear points using area method
            bool areaResult = IsCollinearUsingArea(x1, y1, x2, y2, x3, y3);

            //display results
            Console.WriteLine("Using slope method: " + slopeResult);
            Console.WriteLine("Using area method: " + areaResult);

            if (slopeResult && areaResult)
            {
                Console.WriteLine("Points are collinear");
            }
            else
            {
                Console.WriteLine("Points are not collinear");
            }




        }

    }
}
