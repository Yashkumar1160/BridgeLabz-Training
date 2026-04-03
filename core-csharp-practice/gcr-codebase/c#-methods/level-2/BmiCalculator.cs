using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_2
{
    internal class BmiCalculator
    {
        public static void Main(string[] args)
        {
            //create array to store height, weight and bmi
            double[,] data = new double[10, 3];
            //take user inputs
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter weight(kg)");
                data[i, 0] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter height(cm)");
                data[i, 1] = Convert.ToDouble(Console.ReadLine());

                data[i, 2] = CalculateBMI(data[i, 0], data[i, 1]);

            }
            //display result
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("BMI : " + data[i, 2] + " Status : " + GetStatus(data[i, 2]));
            }
        }
        //Method to calculate bmi
        public static double CalculateBMI(double weight, double height)
        {
            double heightInMeters = height / 100;
            double bmi = weight / (heightInMeters * heightInMeters);
            return bmi;
        }
        //Method to find bmi status
        public static string GetStatus(double bmi)
        {
            if (bmi <= 18.4)
            {   //Underweight status
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {   //Normal status
                return "Normal";
            }
            else if (bmi >= 25 && bmi <= 39.9)
            {   //Overweight status
                return "Overweight";
            }
            else
            {   //Obese status
                return "Obese";
            }
        }
    }
}
