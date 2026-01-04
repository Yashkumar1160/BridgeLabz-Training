using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_instance_vs_class_variable
{
    internal class Product
    {
        //attributes

        //instance variable
        string productName;

        double price;

        //class variable
        static int totalProducts;

        //create parameterized constructor
        Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }
        public static void Main(string[] args)
        {
            //take input for product name
            Console.Write("ENTER PRODUCT NAME: ");
            string productName = Console.ReadLine();

            //take input for price
            Console.Write("ENTER PRODUCT PRICE: ");
            double price = Convert.ToDouble(Console.ReadLine());

            //create object
            Product product = new Product(productName, price);

            //take input for product name
            Console.Write("ENTER PRODUCT NAME: ");
            string productName2 = Console.ReadLine();

            //take input for price
            Console.Write("ENTER PRODUCT PRICE: ");
            double price2 = Convert.ToDouble(Console.ReadLine());

            //create object
            Product product2 = new Product(productName2, price2);

            //call DisplayProductDetails method for both objects
            Console.WriteLine("PRODUCT 1:");
            product.DisplayProductDetails();
           
            Console.WriteLine("PRODUCT 2:");
            product2.DisplayProductDetails();

            //call DisplayTotalProducts method
            DisplayTotalProducts();
        }

        //-------------DISPLAY PRODUCT DETAILS---------------
        //method to display product details
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Name: " + productName);

            Console.WriteLine("Product Price: " + price);
        }

        //------------------DISPLAY TOTAL PRODUCTS--------------
        //method to display total products
        public static void DisplayTotalProducts()
        {
            Console.WriteLine("\nTotal Products: " + totalProducts);
        }
    }
}
