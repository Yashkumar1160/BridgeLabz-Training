using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_class_and_object.level_1
{
    internal class Circle
    {
        //attribute to store data
        double radius;

        public static void Main(string[] args)
        {
            //create object of class
            Circle circle = new Circle();

            //take radius input
            Console.Write("ENTER RADIUS: ");

            circle.radius = Convert.ToDouble(Console.ReadLine());

            //call the CalculateArea method
            circle.CalculateArea();

            //call the CalculateCircumference method
            circle.CalculateCircumference();

        }

        //-----------------CALCULATE AREA-----------------
        //method to calculate area of circle
        public void CalculateArea()
        {
            //calculate area
            double area = Math.PI * radius * radius;

            Console.WriteLine("Area of circle: " + area);

        }

        //----------------CALCULATE CIRCUMFERENCE-------------
        //method to calculate circumference of circle
        public void CalculateCircumference()
        {
            //calculate circumference
            double circumference = 2 * Math.PI * radius;

            Console.WriteLine("Circumference of circle: " + circumference);
        }

    }
}
