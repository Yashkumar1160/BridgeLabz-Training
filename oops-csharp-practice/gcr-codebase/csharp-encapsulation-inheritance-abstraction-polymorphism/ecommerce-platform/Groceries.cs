using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ecommerce_platform
{
    internal class Groceries:Product
    {
        //constructor
        public Groceries(int id, string name, double price): base(id, name, price) { }

        //override CalculateDiscount method
        public override double CalculateDiscount()
        {
            return Price * 0.05;
        }
    }
}
