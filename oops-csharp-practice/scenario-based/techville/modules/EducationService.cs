using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules
{
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
            base.DisplayServiceDetails();
            Console.WriteLine("Courses Offered: " + numberOfCourses);
        }
    }
}