using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.level_1
{
    internal class Circle
    {
        //attributes to store data

        double radius;

        //create default constructor
        public Circle() : this(10)
        {

        }

        //create parameterized constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public static void Main(string[] args)
        {
            //create object using default constructor
            Circle circle1 = new Circle();

            //take radius input
            Console.Write("ENTER RADIUS: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            //create object using parameterized constructor
            Circle circle2 = new Circle(radius);

            //call CalculateArea Method
            circle1.CalculateArea();

            circle2.CalculateArea();

        }

        //---------------CALCULATE AREA-----------------
        //method to calculate area of circle
        public void CalculateArea()
        {
            //calculate area of circle
            double area = Math.PI * radius * radius;

            Console.WriteLine("AREA OF CIRCLE: " + area);
        }

    }
}
