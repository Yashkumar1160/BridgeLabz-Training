using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.supermarket_billing
{
    internal class SmartCheckoutMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("------SUPER MARKET BILLING QUEUE------");

            //create object of SmartCheckoutUtilityImpl class
            SmartCheckoutUtilityImpl utility = new SmartCheckoutUtilityImpl();

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\n1. ADD CUSTOMER TO QUEUE");
                Console.WriteLine("2. ADD ITEM");
                Console.WriteLine("3. GENERATE BILLS");
                Console.WriteLine("4. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //add customer to queue
                    case 1:
                        utility.AddCustomer();
                        break;

                    //add item 
                    case 2:
                        utility.AddItem();
                        break;

                    //generate bills
                    case 3:
                        utility.GenerateBill();
                        break;

                    //exit
                    case 4:
                        Console.WriteLine("\nExit Successful");
                        return;

                    //invalid choice
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;


                }


            }
        }
    }
}
