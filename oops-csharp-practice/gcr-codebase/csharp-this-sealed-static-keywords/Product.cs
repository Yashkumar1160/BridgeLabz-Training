using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_this_sealed_static_keywords
{
    internal class Product
    {
        //static variable to store discount
        public static double discount = 15;

        //instance variables
        public readonly string productId;

        private string productName;

        private double price;

        private int quantity;

        //create parameterized constructor
        public Product(string productId, string productName, double price, int quantity)
        {
            this.productId = productId;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }
        public static void Main(string[] args)
        {
            //call TakeInputs method
            TakeInputs();
        }

        //------------TAKE INPUTS-----------------
        //method to take user inputs
        public static void TakeInputs()
        {
            //take productId input
            Console.Write("ENTER PRODUCTID:");
            string productId = Console.ReadLine();

            //take product name input
            Console.Write("ENTER PRODUCT NAME: ");
            string productName = Console.ReadLine();

            //take price input
            Console.Write("ENTER PRICE: ");
            double price = Convert.ToDouble(Console.ReadLine());

            //take quantity input
            Console.Write("ENTER QUANTITY: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            //create object
            Product product = new Product(productId, productName, price, quantity);


            //check if object is of class type
            if (product is Product)
            {
                //call DisplayDetails method
                product.DisplayDetails();

                //call UpdateDiscount method
                UpdateDiscount();

            }
        }

        //--------------DISPLAY DETAILS----------------
        //method to display all product details
        public void DisplayDetails()
        {
            Console.WriteLine("\nPRODUCT DETAILS: ");

            Console.WriteLine("PRODUCT NAME: " + productName);

            Console.WriteLine("PRODUCT  ID: " + productId);

            Console.WriteLine("PRODUCT PRICE: " + price);

            Console.WriteLine("PRODUCT QUANTITY: " + quantity);

        }

        //----------UPDATE DISCOUNT---------------
        //method to update discount
        public static void UpdateDiscount()
        {
            //discount before updation
            Console.WriteLine("\nOLD DISCOUNT: " + discount);

            //take new discount input
            Console.WriteLine("ENTER NEW DISCOUNT VALUE: ");

            double newDiscount = Convert.ToDouble(Console.ReadLine());

            //update discount
            discount = newDiscount;

            Console.WriteLine("DISCOUNT UPDATED");

            //discount after updation
            Console.WriteLine("NEW DISCOUNT: " + discount);
        }

    }
}
