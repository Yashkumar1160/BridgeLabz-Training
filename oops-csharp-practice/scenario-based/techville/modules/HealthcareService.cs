using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules
{
    public class HealthcareService:Service
    {
        private bool emergencySupport;

        //Constructor
        public HealthcareService(double cost, bool emergency): base("Healthcare", cost)
        {
            emergencySupport = emergency;
        }

        //override DisplayServiceDetails method
        public override void DisplayServiceDetails()
        {
            base.DisplayServiceDetails();
            Console.WriteLine("Emergency Support: " + (emergencySupport ? "Available" : "Not Available"));
        }
    }
}