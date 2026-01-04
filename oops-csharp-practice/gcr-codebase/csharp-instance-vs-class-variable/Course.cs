using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_instance_vs_class_variable
{
    internal class Course
    {
        //attributes

        //instance variable
        string courseName;

        double duration;

        int fee;

        //class variable
        static string instituteName;

        //create parameterized constructor
        Course(string courseName, double duration, int fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }
        public static void Main(string[] args)
        {
            //take input for instituteName
            Console.Write("ENTER INSTITUTE NAME: ");
            instituteName = Console.ReadLine();


            //take input for Course name
            Console.Write("ENTER COURSE NAME: ");
            string courseName = Console.ReadLine();

            //take input for duration
            Console.Write("ENTER COURSE DURATION: ");
            double duration = Convert.ToDouble(Console.ReadLine());

            //take input for fee
            Console.Write("ENTER COURSE FEE: ");
            int fee = Convert.ToInt32(Console.ReadLine());

            //create object
            Course course = new Course(courseName, duration, fee);


            //call DisplayCourseDetails method for both objects
            course.DisplayCourseDetails();

            //call DisplayTotalCourses method
            UpdateInstituteName();

        }

        //-------------DISPLAY Course DETAILS---------------
        //method to display Course details
        public void DisplayCourseDetails()
        {
            Console.WriteLine("\nCourse Name: " + courseName);

            Console.WriteLine("Course Duration: " + duration);

            Console.WriteLine("Course Fee: " + fee);

            Console.WriteLine("INSTITUTE NAME: " + instituteName);

        }

        //------------------DISPLAY TOTAL CourseS--------------
        //method to display total Courses
        public static void UpdateInstituteName()
        {
            //take new institute name input
            Console.Write("\nENTER NEW INSTITUTE NAME: ");

            string newName = Console.ReadLine();

            //update institute name
            instituteName = newName;

            Console.WriteLine("\nUPDATED SUCCESSFULLY");

            Console.WriteLine("NEW INSTITUTE NAME: " + instituteName);
        }
    }
}

