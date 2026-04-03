using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.vehicle_rental_system
{
    internal class TruckImpl : Vehicle, IInsurable 
    {
        public TruckImpl(string number, double rate)
            : base(number, "Truck", rate) { }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 1000;
        }

        public string GetInsuranceDetails()
        {
            return "Truck Insurance: ₹1000";
        }
    }
}
