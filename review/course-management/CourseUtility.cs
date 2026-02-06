using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review.course_management
{
    internal class CourseUtility : ICourse 
    {

        private Course[]courseDetails = new Course[100];

        int totalStudents = 0;


        public void DisplayTotalStudents()
        {
            Console.WriteLine("TOTAL STUDENTS ENROLLED IN COURSES: " + totalStudents);
        }


        public void AddStudentCourse(Course course)
        {
            if (totalStudents >= courseDetails.Length)
            {
                Console.WriteLine("SEATS ARE FULL");
                return;
            }

            courseDetails[totalStudents] = course;
            totalStudents++;
            Console.WriteLine("\nSTUDENT ADDED SUCCESSFULLY");
        }


        //fee based on different classes
        public void FeeCalculation(Course course)
        {
            if(course is OnlineCourse)
            {
                Console.WriteLine("ONLINE COURSE FEE: " + 50000);
            }
            
            else if(course is OfflineCourse)
            {
                Console.WriteLine("OFFLINE COURSE FEE: " + 70000);
            }
            else if(course is HybridCourse)
            {
                Console.WriteLine("HYBRID COURSE FEE: " + 90000);
            } 
            
        }


        public void DisplayCourseDetails()
        {
            Console.WriteLine("COURSE DETAILS: ");

            for (int i = 0; i < totalStudents; i++)
            {

                Console.WriteLine(courseDetails[i]);

                Console.WriteLine("ATTENDENCE CRITERIA: "+courseDetails[i].AttendenceCriteria());
                
                FeeCalculation(courseDetails[i]);
            }
        }

    }
}
