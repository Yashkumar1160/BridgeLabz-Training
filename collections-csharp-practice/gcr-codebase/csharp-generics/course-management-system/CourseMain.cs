using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.course_management_system
{
    internal class CourseMain
    {
        public static void Main()
        {
            //create exam course manager
            Course<ExamCourse> examCourses = new Course<ExamCourse>();

            //create assignment course manager
            Course<AssignmentCourse> assignmentCourses = new Course<AssignmentCourse>();

            //add exam courses
            examCourses.AddCourse(new ExamCourse("Data Structures", 120000));
            examCourses.AddCourse(new ExamCourse("Operating Systems", 130000));

            //add assignment courses
            assignmentCourses.AddCourse(new AssignmentCourse("Software Engineering", 140000));
            assignmentCourses.AddCourse(new AssignmentCourse("Web Development", 150000));

            //display courses
            Console.WriteLine("EXAM COURSES:");
            examCourses.DisplayCourses();

            Console.WriteLine("\nASSIGNMENT COURSES:");
            assignmentCourses.DisplayCourses();
        }
    }
}
