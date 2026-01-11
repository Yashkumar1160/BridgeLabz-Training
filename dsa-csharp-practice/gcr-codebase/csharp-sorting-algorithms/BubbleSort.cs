using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.gcr_codebase.csharp_sorting_algorithms
{
    internal class BubbleSort
    {
        public static void Main(string[] args)
        {
            //take input for number of students 
            Console.Write("ENTER NUMBER OF STUDENTS: ");
            int numberOfStudents = Convert.ToInt32(Console.ReadLine());

            //create array to store marks
            int[] marks = new int[numberOfStudents];

            //loop to take students marks
            for (int i = 0; i < numberOfStudents; i++)
            {
                Console.Write("ENTER MARKS OF STUDENT " + (i + 1) + " : ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            //call SortMarks method 
            SortMarks(marks);

            //display sorted marks array
            Console.WriteLine("SORTED MARKS:");
            foreach (int mark in marks)
                Console.Write(mark + " ");
        }

        //method to sort array
        public static void SortMarks(int[] marks)
        {
            //variable to store array length
            int n = marks.Length;

            //loop runs till n-1
            for (int i = 0; i < n - 1; i++)
            {
                //loop to compare adjacent elements
                for (int j = 0; j < n - 1 - i; j++)
                {
                    //if current element is greater than the next element then swap them
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                    }
                }
            }
        }
    }
}
