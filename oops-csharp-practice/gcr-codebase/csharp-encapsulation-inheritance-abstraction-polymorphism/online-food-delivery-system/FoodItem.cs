using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.online_food_delivery_system
{
    internal abstract class FoodItem
    {
        //variable to store item name
        protected string itemName;

        //variable to store price
        protected double price;
        
        //variable to store quantity
        protected int quantity;

        //getter and setter for itemName
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        //getter and setter for price
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        //getter and setter for quantity
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        //parameterized constructor
        public FoodItem(string name, double price, int quantity)
        {
            this.itemName = name;
            this.price = price;
            this.quantity = quantity;
        }

        //abstract method to calculate total price
        public abstract double CalculateTotalPrice();

        //concrete method to display item details
        public void GetItemDetails()
        {
            Console.WriteLine("\nITEM NAME: " + ItemName);
            
            Console.WriteLine("PRICE: " + Price);
            
            Console.WriteLine("QUANTITY: " + Quantity);
        }
    }
}
