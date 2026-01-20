using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.course_management_system
{
    internal class AssignmentCourse : CourseType 
    {
        //constructor
        public AssignmentCourse(string courseName, double courseFee) : base(courseName, courseFee) { }


        //override DisplayDetails method
        public override void DisplayDetails()
        {
            Console.WriteLine("Course Name: " + CourseName);

            Console.WriteLine("Course Fee: " + CourseFee);
        }
    }
}
