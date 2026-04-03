using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.arrays.level_2
{
    internal class FindGradeTwoD
    {
        public static void Main(string[] args)
        {
            //take number input
            Console.WriteLine("Enter number of students:");
            int students = Convert.ToInt32(Console.ReadLine());
            //create double array to store marks
            double[,] marks = new double[students, 3];
            //create array to store percentage
            double[] percentage = new double[students];
            //create array to store grades of student
            string[] grade = new string[students];

            //take inputs using loop
            for (int i = 0; i < students; i++)
            {
                Console.WriteLine("Enter Marks of student " + (i + 1));
                //marks in physics
                Console.WriteLine("Physics : ");
                double physics = Convert.ToDouble(Console.ReadLine());
                //marks in chemistry
                Console.WriteLine("Chemistry : ");
                double chemistry = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Maths : ");
                //marks is maths
                double maths = Convert.ToDouble(Console.ReadLine());

                //check for valid inputs
                if (physics < 0 || chemistry < 0 || maths < 0)
                {
                    Console.WriteLine("Enter positive value");
                    i = i - 1;
                    continue;
                }
                //store marks in array
                marks[i, 0] = physics;
                marks[i, 1] = chemistry;
                marks[i, 2] = maths;
                //calculate percentage and store it in percentage array
                percentage[i] = (physics + chemistry + maths) / 3;

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
                Console.WriteLine("Marks in Physics : " + marks[i, 0]);
                //display marks in chemistry
                Console.WriteLine("Marks in Chemistry : " + marks[i, 1]);
                //display marks in maths
                Console.WriteLine("Marks in Maths : " + marks[i, 2]);
                //display percentage
                Console.WriteLine("Percentage : " + percentage[i]);
                //display grade
                Console.WriteLine("Grade : " + grade[i]);
                Console.WriteLine();


            }
        }
    }
}
