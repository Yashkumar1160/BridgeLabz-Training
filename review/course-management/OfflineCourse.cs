using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review.course_management
{
    internal class OfflineCourse : Course 
    {
        public OfflineCourse(string studentName,string courseName,int rollNumber):base(studentName,courseName,rollNumber){ }

        public override double AttendenceCriteria()
        {
            return 75;
        }
    }
}
