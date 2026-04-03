using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.online_food_delivery_system
{
    internal class NonVegItemImpl : FoodItem, IDiscountable 
    {
        //variable to store discount
        private double discount = 0;

        //variable to store extra charge
        private double extraCharge = 20;

        //constructor
        public NonVegItemImpl(string name, double price, int quantity) : base(name, price, quantity) { }

        //override CalculateTotalPrice method
        public override double CalculateTotalPrice()
        {
            double total = (Price + extraCharge) * Quantity;
            total -= total * (discount / 100);
            return total;
        }

        //implementation of method to apply discount 
        public void ApplyDiscount(double discountPercentage)
        {
            discount = discountPercentage;
        }

        //implementation of method to get discount details
        public string GetDiscountDetails()
        {
            return "DISCOUNT APPLIED: " + discount + "%";
        }

    }
}
