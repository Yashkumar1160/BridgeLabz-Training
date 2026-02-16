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
            this.freeAmbulance = freeAmbulance;
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