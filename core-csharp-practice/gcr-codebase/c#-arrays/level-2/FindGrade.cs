using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_2
{
    internal class FindGrade
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter number of students:");
            int students = Convert.ToInt32(Console.ReadLine());
            //create double array to store physics marks
            double[] physics = new double[students];
            //create double array to store chemistry marks
            double[] chemistry = new double[students];
            //create double array to store maths marks
            double[] maths = new double[students];
            //create array to store percentages
            double[] percentage = new double[students];
            //create array to store grades of student
            string[] grade = new string[students];

            //take inputs using loop
            for (int i = 0; i < students; i++)
            {
                Console.WriteLine("Enter Marks of student " + (i + 1));
                //marks in physics
                Console.WriteLine("Physics : ");
                physics[i] = Convert.ToDouble(Console.ReadLine());
                //marks in chemistry
                Console.WriteLine("Chemistry : ");
                chemistry[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Maths : ");
                //marks in maths
                maths[i] = Convert.ToDouble(Console.ReadLine());

                //check for valid inputs
                if (physics[i] < 0 || chemistry[i] < 0 || maths[i] < 0)
                {
                    Console.WriteLine("Enter positive value");
                    i = i - 1;
                    continue;
                }

                //calculate percentage and store it in percentage array
                percentage[i] = (physics[i] + chemistry[i] + maths[i]) / 3;

                //finding grades according to percentages
                if (percentage[i] >= 80)
                {
                    grade[i] = "A";
                }
                else if (percentage[i] >= 70 && percentage[i] <= 79)
                {
                    grade[i] = "B";
                }
                else if (percentage[i] >= 60 && percentage[i] <= 69)
                {
                    grade[i] = "C";
                }
                else if (percentage[i] >= 50 && percentage[i] <= 59)
                {
                    grade[i] = "D";
                }
                else if (percentage[i] >= 40 && percentage[i] <= 49)
                {
                    grade[i] = "E";
                }
                else
                {
                    grade[i] = "R";
                }
            }
            //display details
            for (int i = 0; i < students; i++)
            {
                Console.WriteLine("Details of student " + (i + 1));
                //display marks in physics
                Console.WriteLine("Marks in Physics : " + physics[i]);
                //display marks in chemistry
                Console.WriteLine("Marks in Chemistry : " + chemistry[i]);
                //display marks in maths
                Console.WriteLine("Marks in Maths : " + maths[i]);
                //display percentage
                Console.WriteLine("Percentage : " + percentage[i]);
                //display grade
                Console.WriteLine("Grade : " + grade[i]);
                Console.WriteLine();


            }
        }
    }
}
