using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.course_management_system
{
    internal class Course<T> where T : CourseType 
    {
        //array to store courses
        T[]courses=new T[100];

        //variable to store total courses count
        int totalCourses = 0;

        //method to add course
        public void AddCourse(T course)
        {
            courses[totalCourses++] = course;
        }

        //method to display all courses
        public void DisplayCourses()
        {
            for(int i=0;i<totalCourses;i++)
            {
                courses[i].DisplayDetails();
            }
        }

    }
}
