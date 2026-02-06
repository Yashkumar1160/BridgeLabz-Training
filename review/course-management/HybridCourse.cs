using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review.course_management
{
    internal class HybridCourse : Course 
    {
        public HybridCourse(string studentName, string courseName, int rollNumber) : base(studentName, courseName, rollNumber) { }

        //override 
        public override double AttendenceCriteria()
        {
            return 90;
        }

    }
}
