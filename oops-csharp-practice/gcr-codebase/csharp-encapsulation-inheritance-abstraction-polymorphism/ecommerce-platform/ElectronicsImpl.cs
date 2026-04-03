using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ecommerce_platform
{
    internal class ElectronicsImpl : Product, ITaxable 
    {
        //constructor
        public ElectronicsImpl(int id, string name, double price): base(id, name, price) { }

        //override CalculateDiscount method
        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }

        //implementation of CalculateTax method
        public double CalculateTax()
        {
            return Price * 0.18;
        }

        //implementation of CalculateTax method
        public string GetTaxDetails()
        {
            return "18% GST Applied";
        }
    }
}
