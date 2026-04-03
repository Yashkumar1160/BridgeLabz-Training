using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.csharp_generics.dynamic_online_marketplace
{
    internal class Product<T> where T : ProductCategory 
    {
        public string ProductName;
        public double Price;


        //constructor
        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }

        //method to display product info
        public void Display()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("----------------------");
        }
    }
}
