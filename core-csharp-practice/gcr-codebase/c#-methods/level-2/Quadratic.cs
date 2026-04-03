using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace BridgeLabzTraining.c__methods.level_2
{
    internal class Quadratic
    {
        public static void Main(string[] args)
        {
            //take input values for variables a, b and c
            Console.WriteLine("Enter a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c:");
            double c = Convert.ToDouble(Console.ReadLine());

            //create array to store roots
            double[] roots = FindRoots(a, b, c);

            //check roots
            if (roots.Length == 0)
            {
                Console.WriteLine("No real roots");
            }
            else
            {
                for (int i = 0; i < roots.Length; i++)
                {
                    Console.WriteLine("Root :" + roots[i]);
                }
            }

        }
        //Method to find roots
        public static double[] FindRoots(double a, double b, double c)
        {
            //calculate delta 
            double delta = b * b - 4 * a * c;
            //if delta is positive
            if (delta > 0)
            {
                double[] roots = new double[2];
                roots[0] = (-b + delta) / (2 * a);
                roots[1] = (-b - delta) / (2 * a);
                return roots;

            }
            //if delta is zero
            if (delta == 0)
            {
                double[] roots = new double[1];
                roots[0] = -b / (2 * a);
            }
            //if delta is negative
            return new double[0];

        }
    }
}
