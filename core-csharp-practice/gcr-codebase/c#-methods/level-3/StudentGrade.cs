using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.c__methods.level_3
{
    internal class StudentGrade
    {
        //Method to generate random marks
        public static int[,] GenerateMarks(int n)
        {
            //create array to store marks of 3 subjects
            int[,] marks = new int[n, 3];
            //create object of Random class
            Random random = new Random();
            //generate random marks and store
            for (int i = 0; i < n; i++)
            {
                //physics marks
                marks[i, 0] = random.Next(1, 100);
                //chemistry marks
                marks[i, 1] = random.Next(1, 100);
                //maths marks
                marks[i, 2] = random.Next(1, 100);

            }
            return marks;
        }
        //Method to calculate total, average and percentage
        public static double[,] CalculateResults(int[,] marks)
        {
            int students = marks.GetLength(0);
            //create array to store results
            double[,] result = new double[students, 3];

            for (int i = 0; i < students; i++)
            {
                double total = marks[i, 0] + marks[i, 1] + marks[i, 2];
                double average = total / 3;
                double percentage = (total / 300) * 100;

                result[i, 0] = Math.Round(total, 2);
                result[i, 1] = Math.Round(average, 2);
                result[i, 2] = Math.Round(percentage, 2);

            }
            return result;
        }
        //Method to display scorecard
        public static void DisplayScoreCard(int[,] marks, double[,] result)
        {
            Console.WriteLine("\nStudent\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
            Console.WriteLine("------------------------------------------------------------------------------");

            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.WriteLine(
                    (i + 1) + "\t" +
                    marks[i, 0] + "\t" +
                    marks[i, 1] + "\t" +
                    marks[i, 2] + "\t" +
                    result[i, 0] + "\t" +
                    result[i, 1] + "\t" +
                    result[i, 2]
                    );
            }
        }
        //Main Method
        public static void Main(string[] args)
        {
            //take input for number of students
            Console.WriteLine("Enter number of students");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            //generate random marks for 3 subjects
            int[,] marks = GenerateMarks(numberOfStudents);
            //call the CalculateResults() method 
            double[,] result = CalculateResults(marks);
            //display result
            DisplayScoreCard(marks, result);
        }

    }
}
