using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules
{
    //M-6 City Services Framework
    public class EducationService:Service
    {
        private int numberOfCourses;

        //Constructor
        public EducationService(double cost, int courses):base("Education", cost)
        {
            numberOfCourses = courses;
        }

        //override DisplayServiceDetails method
        public override void DisplayServiceDetails()
        {
            //M-7 Calling Parent Method
            base.DisplayServiceDetails();
            Console.WriteLine("Courses Offered: " + numberOfCourses);
        }
    }
}