using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ecommerce_platform
{
    internal interface ITaxable
    {
        //method to calculate tax
        double CalculateTax();

        //method to get tax details
        string GetTaxDetails();
    }
}
