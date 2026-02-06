using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review.course_management
{
    internal class OnlineCourse:Course
    {
        public OnlineCourse(string studentName, string courseName, int rollNumber) : base(studentName, courseName, rollNumber) { }

        public override double AttendenceCriteria()
        {
            return 95;
        }

    }
}
