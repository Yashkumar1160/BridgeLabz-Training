using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_access_modifiers
{
    internal class Student
    {
        //attributes
        public int rollNumber;

        protected string name;

        private float cgpa;

        //set cgpa method
        public void setCgpa(float cgpa)
        {
            this.cgpa = cgpa;
        }

        //get cgpa method
        public float getCgpa()
        {
            return cgpa;
        }


        //subclass
        class PostgraduateStudent : Student
        {
            public static void Main(string[] args)
            {
                //call the take input method
                TakeInput();
            }

            private static void TakeInput()
            {
                //create object of class
                PostgraduateStudent postgraduateStudent = new PostgraduateStudent();

                //take name input
                Console.Write("ENTER NAME: ");
                postgraduateStudent.name = Console.ReadLine();

                //take roll number input
                Console.Write("ENTER ROLL NUMBER: ");
                postgraduateStudent.rollNumber = Convert.ToInt32(Console.ReadLine());

                //take cgpa input
                Console.Write("ENTER CGPA: ");
                postgraduateStudent.setCgpa(float.Parse(Console.ReadLine()));

                //call DisplayDetails method 
                postgraduateStudent.DisplayDetails();
            }

            //method to display details of student
            private void DisplayDetails()
            {
                Console.WriteLine("\nNAME: " + name);
               
                Console.WriteLine("ROLL NUMBER: " + rollNumber);

                Console.WriteLine("CGPA: " + getCgpa());
            }
        }
    }
}
