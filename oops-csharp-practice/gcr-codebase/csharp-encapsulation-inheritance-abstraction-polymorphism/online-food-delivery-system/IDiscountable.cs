using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.online_food_delivery_system
{
    internal interface IDiscountable
    {
        //method to apply discount on item
        void ApplyDiscount(double discountPercentage);

        //method to get discount details
        string GetDiscountDetails();
    }
}
