using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.ecommerce_platform
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Start();
        }

        //method to start program
        public static void Start()
        {
            //create object of class ProductManager
            ProductManager manager = new ProductManager();

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\n1. ADD ELECTRONICS");
                Console.WriteLine("2. ADD CLOTHING");
                Console.WriteLine("3. ADD GROCERIES");
                Console.WriteLine("4. VIEW ALL PRODUCTS");
                Console.WriteLine("5. EXIT");
                Console.Write("ENTER CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        AddElectronics(manager);
                        break;

                    case 2:
                        AddClothing(manager);
                        break;

                    case 3:
                        AddGroceries(manager);
                        break;

                    case 4:
                        manager.DisplayAllProducts();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }
            }
        }

        //method to add electronics product
        static void AddElectronics(ProductManager manager)
        {
            //take product id
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //take product name
            Console.Write("NAME: ");
            string name = Console.ReadLine();

            //take product price
            Console.Write("PRICE: ");
            double price = Convert.ToDouble(Console.ReadLine());

            //add product
            manager.AddProduct(new ElectronicsImpl(id, name, price));
            Console.WriteLine("ELECTRONICS PRODUCT ADDED");
        }

        //method to add clothing product
        static void AddClothing(ProductManager manager)
        {
            //take product id
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //take product name
            Console.Write("NAME: ");
            string name = Console.ReadLine();

            //take product price
            Console.Write("PRICE: ");
            double price = Convert.ToDouble(Console.ReadLine());

            //add product
            manager.AddProduct(new ClothingImpl(id, name, price));
            Console.WriteLine("CLOTHING PRODUCT ADDED");
        }

        //method to add grocery product
        static void AddGroceries(ProductManager manager)
        {
            //take product id
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            //take product name
            Console.Write("NAME: ");
            string name = Console.ReadLine();

            //take product price
            Console.Write("PRICE: ");
            double price = Convert.ToDouble(Console.ReadLine());

            //add product
            manager.AddProduct(new Groceries(id, name, price));
            Console.WriteLine("GROCERY PRODUCT ADDED");
        }
    }
}
