using BridgeLabzTraining.oops_csharp_practice.scenario_based.car_rental_application;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.supermarket_billing
{
    internal class SmartCheckoutUtilityImpl : ISmartCheckout 
    {
        //queue to store customers
        Queue<Customer> customerQueue = new Queue<Customer>();

        //dictionary to store item details
        Dictionary<string, Item> items = new Dictionary<string, Item>();

        //method to add item
        public void AddItem()
        {
            //take item name
            Console.Write("\nENTER ITEM NAME: ");
            string itemName = Console.ReadLine();

            //if item already exists
            if (items.ContainsKey(itemName))
            {
                Console.WriteLine("\nItem Already Exists");
                return;
            }

            //take item price
            Console.Write("ENTER ITEM PRICE: ");
            double price = Convert.ToDouble(Console.ReadLine());

            //take quantity
            Console.Write("ENTER QUANTITY: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            //create object 
            Item item = new Item(itemName, price, quantity);

            //add item
            items[itemName] = item;

            Console.WriteLine("\nItem Added Successfully");

        }


        //method to add customer to queue
        public void AddCustomer()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("\nAdd Items First");
                return;
            }

            //take customer name
            Console.Write("\nENTER CUSTOMER NAME: ");
            string name = Console.ReadLine();

            //create object of Customer class
            Customer customer = new Customer(name);

            //take number of items
            Console.Write("\nENTER NUMBER OF ITEMS: ");
            int numberOfItems = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < numberOfItems; i++)
            {
                //take item
                Console.Write("\nENTER ITEM: ");
                string item = Console.ReadLine();

                //add item to list
                customer.Items.Add(item);
            }

            //add customer to queue
            customerQueue.Enqueue(customer);

            Console.WriteLine("\nCustomer Added To Queue");
        }


        //method to generate bills for customers in queue
        public void GenerateBill()
        {
            //if no customer is added
            if (customerQueue.Count == 0)
            {
                Console.WriteLine("\nNo Customer Added Yet");
                return;
            }

            //loop through customer queue
            foreach(Customer customer in customerQueue)
            {
                Console.WriteLine("\nCustomer Name: " + customer.CustomerName);
                double totalBill = CalculateTotal(customer);
                Console.WriteLine("Total Bill: " + totalBill);
            }
        }

        //method to calculate total of items
        public double CalculateTotal(Customer customer)
        {
            //variable to store total bill
            double total = 0;

            foreach (string itemName in customer.Items)
            {
                //check if item exists and stock available
                if (items.ContainsKey(itemName) && items[itemName].Quantity > 0)
                {
                    Item storeItem = items[itemName];

                    Console.WriteLine("Item Name: " + storeItem.ItemName);
                    Console.WriteLine("Price: " + storeItem.Price);

                    total += storeItem.Price;

                    //update quantity
                    storeItem.Quantity--; 
                }
                else
                {
                    Console.WriteLine(itemName + " is out of stock");
                }
            }

            return total;
        }
    }
}
