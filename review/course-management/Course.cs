using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review.course_management
{
    internal abstract class Course
    {
        private int rollNumber;
        
        private string studentName;

        private string courseName;

        public int RollNumber { get; set; }

        public string StudentName { get; set; }

        public string CourseName { get; set; }


        //constructor
        public Course(string studentName, string courseName, int rollNumber)
        {
            RollNumber = rollNumber;
            StudentName = studentName;
            CourseName = courseName;
        }

        //abstract method for attendence based on class
        public abstract double AttendenceCriteria();

        //override ToString method to display student details
        public override string ToString()
        {
            return "\nStudent Name: " + StudentName +
                    "\nCourse Name: " + CourseName +
                    "\nRoll Number: " + RollNumber;
        }
    }
}
