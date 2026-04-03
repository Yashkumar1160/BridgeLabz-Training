using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_2
{
    internal class BodyMassIndex
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter number of persons:");
            int number = Convert.ToInt32(Console.ReadLine());
            //define double array weight to store weights of persons
            double[] weight = new double[number];
            //define double array height to store heights of persons
            double[] height = new double[number];
            //define double array bmi to store BMIs of persons
            double[] bmi = new double[number];
            //define double array weight status to store weights status of persons
            string[] weightStatus = new string[number];

            //loop to take inputs and calculate bmi
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter details of person " + (i + 1));
                //take weight inputs
                Console.WriteLine("Weight: ");
                weight[i] = Convert.ToDouble(Console.ReadLine());
                //take height inputs in meters
                Console.WriteLine("Height (in meters) : ");
                height[i] = Convert.ToDouble(Console.ReadLine());
                //calculate bmi
                bmi[i] = weight[i] / (height[i] * height[i]);
                //store weight status according to bmi
                if (bmi[i] <= 18.4)
                {   //Underweight status
                    weightStatus[i] = "Underweight";
                }
                else if (bmi[i] >= 18.5 && bmi[i] <= 24.9)
                {   //Normal status
                    weightStatus[i] = "Normal";
                }
                else if (bmi[i] >= 25 && bmi[i] <= 39.9)
                {   //Overweight status
                    weightStatus[i] = "Overweight";
                }
                else
                {   //Obese status
                    weightStatus[i] = "Obese";
                }
            }
            //display details of each person 
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Details of person " + (i + 1));
                //display height
                Console.WriteLine("Height : " + height[i]);
                //display weight
                Console.WriteLine("Weight : " + weight[i]);
                //display BMI
                Console.WriteLine("BMI : " + bmi[i]);
                //display weight status
                Console.WriteLine("Weight Status : " + weightStatus[i]);
            }
        }
    }
}
