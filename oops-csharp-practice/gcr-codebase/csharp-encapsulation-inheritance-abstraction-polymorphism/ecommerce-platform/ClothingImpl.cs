using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ecommerce_platform
{
    internal class ClothingImpl : Product, ITaxable 
    {
        //constructor
        public ClothingImpl(int id, string name, double price): base(id, name, price) { }

        //override CalculateDiscount method
        public override double CalculateDiscount()
        {
            return Price * 0.20;
        }

        //implementation of CalculateTax method
        public double CalculateTax()
        {
            return Price * 0.05;
        }

        //implementation of GetTaxDetails method
        public string GetTaxDetails()
        {
            return "5% GST Applied";
        }
    }
}
