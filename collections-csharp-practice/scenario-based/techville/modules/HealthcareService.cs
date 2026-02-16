using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules
{
    //M-6 City Services Framework
    public class HealthcareService : Service
    {
        private bool emergencySupport;

        //Constructor
        public HealthcareService(double cost, bool emergency) : base("Healthcare", cost)
        {
            emergencySupport = emergency;
        }

        public override void Register()
        {
            status = "Registered";
            Console.WriteLine($"{serviceName} service registered");
        }

        //override Cancel method
        public override void Cancel()
        {
            status = "Cancelled";
            Console.WriteLine($"{serviceName} service cancelled");
        }

        //override DisplayServiceDetails method
        public override void DisplayServiceDetails()
        {
            //M-7 Calling Parent Method
            base.DisplayServiceDetails();
            Console.WriteLine("Emergency Support: " + (emergencySupport ? "Available" : "Not Available"));
        }
    }
}