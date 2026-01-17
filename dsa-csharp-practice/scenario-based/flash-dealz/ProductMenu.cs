using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.flash_dealz
{
    internal class ProductMenu
    {
        //method to display menu
        public static void DisplayMenu()
        {
            Console.WriteLine("--------PRODUCT SORTING BY DISCOUNT---------");

            //create object 
            ProductsUtilityImpl utility = new ProductsUtilityImpl();

            //generate random data of products
            utility.GenerateRandomData();

            //infinite loop until user exits
            while(true)
            {
                //display menu
                Console.WriteLine("\n1. DISPLAY NUMBER OF PRODUCTS");
                Console.WriteLine("2. SORT PRODUCTS BY DISCOUNT");
                Console.WriteLine("3. DISPLAY ALL PRODUCTS");
                Console.WriteLine("4. EXIT PROGRAM");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch(choice)
                {
                    //display number of products
                    case 1:
                        utility.DisplayProductsCount();
                        break;


                    //sort products based on discount
                    case 2:
                        utility.SortProducts();
                        break;


                    //display all products
                    case 3:
                        utility.DisplayAllProducts();
                        break;


                    //exit program
                    case 4:
                        Console.WriteLine("\nEXIT SUCCESSFUL");
                        return;


                    //invalid choice
                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;


                }
            }
        }
    }
}
