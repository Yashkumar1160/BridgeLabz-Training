using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_2
{
    internal class MultiDimensionalBMI
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter Number of Persons:");
            int number = Convert.ToInt32(Console.ReadLine());
            //define double array to store the details of person
            double[,] personData = new double[number, 3];
            //define string array to store weight status 
            string[] weightStatus = new string[number];

            //take inputs
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter details of person " + (i + 1));
                //take weight input
                Console.WriteLine("Weight:");
                double weight = Convert.ToDouble(Console.ReadLine());
                //take height input
                Console.WriteLine("Height:");
                double height = Convert.ToDouble(Console.ReadLine());

                //check if the inputs are valid
                if (weight <= 0 || height <= 0)
                {
                    Console.WriteLine("Enter positive values");
                    i--;
                    continue;
                }
                //store weight in person data array
                personData[i, 0] = weight;
                //store height in person data array
                personData[i, 1] = height;
                //calculate bmi and store it in person data array
                personData[i, 2] = weight / (height * height);

                //check weight status
                if (personData[i, 2] <= 18.4)
                {   //Underweight status
                    weightStatus[i] = "Underweight";
                }
                else if (personData[i, 2] >= 18.5 && personData[i, 2] <= 24.9)
                {
                    //Normal status
                    weightStatus[i] = "Normal";
                }
                else if (personData[i, 2] >= 25 && personData[i, 2] <= 39.9)
                {
                    //Overweight status
                    weightStatus[i] = "Overweight";

                }
                else
                {   //Obese status
                    weightStatus[i] = "Obese";
                }
            }
            //display details
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Details of person " + (i + 1));
                //display weight
                Console.WriteLine("Weight : " + personData[i, 0]);
                //display height
                Console.WriteLine("Height : " + personData[i, 1]);
                //display BMI
                Console.WriteLine("BMI : " + personData[i, 2]);
                //display weight status
                Console.WriteLine("Weight Status : " + weightStatus[i]);
            }

        }
    }
}
