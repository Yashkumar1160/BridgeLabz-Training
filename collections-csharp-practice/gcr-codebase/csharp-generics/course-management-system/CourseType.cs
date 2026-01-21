using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.course_management_system
{
    internal abstract class CourseType
    {
        //attributes
        string courseName;
        double courseFee;

        //getters and setters
        public string CourseName { get; set; }
        public double CourseFee { get; set; }

        //constructor
        public CourseType(string courseName, double courseFee)
        {
            CourseName = courseName;
            CourseFee = courseFee;
        }

        //abstract method to display details
        public abstract void DisplayDetails();
    }
}
