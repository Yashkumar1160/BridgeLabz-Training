using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_this_sealed_static_keywords
{
    internal class Student
    {
        //static variables
        public static string universityName = "GLA UNIVERSITY";

        private static int totalStudents;

        //instance variables
        public readonly int rollNumber;

        private string studentName;

        private char grade;

        //create parameterized constructor
        public Student(int rollNumber, string studentName, char grade)
        {
            this.rollNumber = rollNumber;
            this.studentName = studentName;
            this.grade = grade;
            totalStudents++;
        }

        public static void Main(string[] args)
        {
            //call TakeInputs method
            TakeInputs();
        }

        //------------TAKE INPUTS-----------------
        //method to take user inputs
        public static void TakeInputs()
        {
            //take roll number input
            Console.Write("ENTER ROLL NUMBER:");
            int rollNumber = Convert.ToInt32(Console.ReadLine());

            //take student name input
            Console.Write("ENTER STUDENT NAME: ");
            string studentName = Console.ReadLine();

            //take grade input
            Console.Write("ENTER GRADE: ");
            char grade = Console.ReadLine()[0];

            //create object
            Student student = new Student(rollNumber, studentName, grade);


            //check if object is of class type
            if (student is Student)
            {
                //call DisplayDetails method
                student.DisplayDetails();

                //call DisplayTotalStudents method
                DisplayTotalStudents();

            }
        }

        //--------------DISPLAY DETAILS----------------
        //method to display all Student details
        public void DisplayDetails()
        {
            Console.WriteLine("\nSTUDENT DETAILS: ");

            Console.WriteLine("STUDENT NAME: " + studentName);

            Console.WriteLine("STUDENT  ROLL NUMBER: " + rollNumber);

            Console.WriteLine("STUDENT GRADE: " + grade);

        }

        //----------DISPLAY TOTAL STUDENTS---------------
        //method to display total Students
        public static void DisplayTotalStudents()
        {
            Console.WriteLine("\nTOTAL STUDENTS: " + totalStudents);
        }

    }
}
