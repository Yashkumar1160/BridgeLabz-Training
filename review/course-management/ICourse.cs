using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review.course_management
{
    internal interface ICourse
    {
        void DisplayCourseDetails();

        void AddStudentCourse(Course course);

        void FeeCalculation(Course course);

        void DisplayTotalStudents();
    }
}
