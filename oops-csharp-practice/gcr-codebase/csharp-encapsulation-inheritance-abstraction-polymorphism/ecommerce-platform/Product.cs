using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ecommerce_platform
{
    internal abstract class Product
    {
        //protected variables
        protected int productId;

        protected string name;

        protected double price;

        //getter and setter for productId
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        //getter and setter for name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //getter and setter for price
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        // Constructor
        public Product(int id, string name, double price)
        {
            productId = id;
            this.name = name;
            this.price = price;
        }

        // Abstract method
        public abstract double CalculateDiscount();

        // Concrete method
        public void DisplayDetails()
        {
            Console.WriteLine("\nPRODUCT ID: " + ProductId);
         
            Console.WriteLine("PRODUCT NAME: " + Name);
            
            Console.WriteLine("PRODUCT PRICE: " + Price);
        }
    }
}
