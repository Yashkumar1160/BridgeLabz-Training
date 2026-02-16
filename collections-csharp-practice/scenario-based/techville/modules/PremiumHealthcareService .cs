using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules
{
    public class PremiumHealthcareService : HealthcareService
    {
        private bool freeAmbulance;

        //Constructor
        public PremiumHealthcareService(double cost, bool emergency, bool freeAmbulance) : base(cost, emergency)
        {
            serviceName = "Premium Healthcare";
            this.freeAmbulance = freeAmbulance;
        }

        //override Register method
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
            //M-7 Calling Parent Class Method
            base.DisplayServiceDetails();
            Console.WriteLine("Free Ambulance: " + (freeAmbulance ? "Available" : "Not Available"));
        }
    }
}