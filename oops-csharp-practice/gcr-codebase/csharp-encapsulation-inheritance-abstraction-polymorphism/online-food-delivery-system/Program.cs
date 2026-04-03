using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.online_food_delivery_system
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
            //create object of FoodManager class
            FoodManager manager = new FoodManager();

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\n--- ONLINE FOOD DELIVERY SYSTEM ---");
                Console.WriteLine("1. ADD VEG ITEM");
                Console.WriteLine("2. ADD NON VEG ITEM");
                Console.WriteLine("3. DISPLAY ALL ITEMS");
                Console.WriteLine("4. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        AddVegItem(manager);
                        break;

                    case 2:
                        AddNonVegItem(manager);
                        break;

                    case 3:
                        Console.WriteLine("ITEM DETAILS: ");
                        manager.DisplayAllItems();
                        break;

                    case 4:
                        Console.WriteLine("\nTHANKYOU");
                        return;

                    default:
                        Console.WriteLine("\nINVALID CHOICE");
                        break;
                }
            }
        }

        //method to add veg item
        static void AddVegItem(FoodManager manager)
        {
            //take item name
            Console.Write("ITEM NAME: ");
            string name = Console.ReadLine();

            //take price
            Console.Write("PRICE: ");
            double price = Convert.ToDouble(Console.ReadLine());

            //take quantity
            Console.Write("QUANTITY: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            //take discount
            Console.Write("DISCOUNT: ");
            double discount = Convert.ToDouble(Console.ReadLine());

            //create object of VegItemImpl class
            VegItemImpl veg = new VegItemImpl(name, price, quantity);

            //apply discount
            veg.ApplyDiscount(discount);

            //add item
            manager.AddItem(veg);

            Console.WriteLine("ITEM ADDED");
        }

        static void AddNonVegItem(FoodManager manager)
        {
            //take item name
            Console.Write("ITEM NAME: ");
            string name = Console.ReadLine();

            //take price
            Console.Write("PRICE: ");
            double price = Convert.ToDouble(Console.ReadLine());

            //take quantity
            Console.Write("QUANTITY: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            //take discount
            Console.Write("DISCOUNT: ");
            double discount = Convert.ToDouble(Console.ReadLine());

            //create object od NonVegItemImpl class
            NonVegItemImpl nonVeg = new NonVegItemImpl(name, price, quantity);

            //apply discount
            nonVeg.ApplyDiscount(discount);

            //add item
            manager.AddItem(nonVeg);
            Console.WriteLine("ITEM ADDED");
        }
    }
}
