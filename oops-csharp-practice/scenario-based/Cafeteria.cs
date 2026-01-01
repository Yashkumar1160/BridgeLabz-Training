using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based
{
    internal class Cafeteria
    {
        const int orderLimit= 10;


        //static array to store menu items with prices
        static string[,] menu =
            {
                { "KADHAI PANEER","220" },
                { "BUTTER PANEER","240" },
                { "CHILLI PANEER","210" },
                { "CHEESE BURGER","120" },
                { "DOSA","90"  },
                { "COFFEE","60"  },
                { "EGG CURRY","180" },
                { "CHICKEN CURRY","260" },
                { "MATAR MUSHROOM","200" },
                { "PLAIN RICE","80"  }
            };

        //array to store customer ordered items
        string[] orderedItems = new string[orderLimit];

        //total item count
        int totalItems = 0;

        //array to store individual item count
        int[] itemCount = new int[orderLimit];

        public static void Main(string[] args)
        {
            //object of class Cafeteria
            Cafeteria cafeteria = new Cafeteria();

            //call UserChoice method
            cafeteria.UserChoice();
        }

        //---------------------DISPLAY MENU--------------------
        //method to display menu 
        public void DisplayMenu()
        {
            Console.WriteLine("\nCAFETERIA MENU");

            //loop through menu array to display items
            for (int i = 0; i < menu.GetLength(0); i++)
            {
                Console.WriteLine($"\n {i + 1}. {menu[i,0]} --> {menu[i,1]}");
            }

            Console.WriteLine(" \n ENTER 0 TO PLACE ORDER");

            //infinite loop until user enters 0
            while (true)
            {
                Console.Write("\n ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32( Console.ReadLine() );

                //check if choice is valid 
                if(choice >= 1&& choice <=orderedItems.Length)
                {
                    //check if new item can be added or not 
                    if (orderedItems.Length > totalItems)
                    {
                        //add item
                        orderedItems[totalItems++] =GetItemByIndex(choice);
                        itemCount[choice - 1]++;

                        Console.WriteLine($"\n {menu[choice - 1,0]} ADDED.");

                    }
                    //if orderedItems array is full 
                    else
                    {
                        Console.WriteLine("\n ORDER LIMIT REACHED");
                        return;
                    }
                }
                //if user enters 0
                else if(choice == 0)
                {
                    //call CheckOrder method
                    if (CheckOrder())
                    {
                        Console.WriteLine("\n ADD ITEMS FIRST");   
                    }
                    else
                    {
                        Console.WriteLine("\n ORDER PLACED SUCCESSFULLY");
                        return;
                    }
                }
                //if user enters invalid choice
                else
                {
                    Console.WriteLine("\n INVALID CHOICE");
                    continue;
                }
            }
        }

        //---------------USER CHOICE-------------------------
        //method to take user's choice
        public void UserChoice()
        {
            Console.WriteLine("WELCOME TO CAFETERIA");

            //loop until user enters 4
            while (true)
            {
                //display choices
                Console.WriteLine("\n 1. DISPLAY MENU");
                Console.WriteLine("\n 2. ORDERED ITEMS");
                Console.WriteLine("\n 3. GENERATE BILL");
                Console.WriteLine("\n 4. EXIT");
                Console.Write("\n ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32( Console.ReadLine() ) ;

                //handle user's choice
                switch(choice)
                {
                    case 1:
                        DisplayMenu();
                        break;

                    case 2:
                        if (totalItems != 0)
                        {
                            OrderedItems();
                        }
                        else
                        {
                            Console.WriteLine("\n   NO ORDERS YET");
                        }
                        break;

                    case 3:
                        double total=GenerateBill();
                        if (total != 0)
                        {
                            Console.WriteLine($"\n  TOTAL BILL AMOUNT: {total} INR");
                        }
                        else
                        {
                            Console.WriteLine("\n   NO ORDERS YET");
                        }
                            break;

                    case 4:
                        Console.WriteLine("\n   THANKYOU FOR VISITING");
                        return;

                    default:
                        Console.WriteLine("\n   INVALID CHOICE");
                        break;
                }
            }
        }

        //---------------ORDERED ITEMS------------------
        //method to display all ordered items
        public void OrderedItems()
        {
            Console.WriteLine("\nALL ORDERED ITEMS ARE:");

            //loop through menu and itemCounr arrays 
            for (int i = 0; i < menu.GetLength(0); i++)
            {
                //if item count is greater than 0
                if (itemCount[i] > 0)
                {
                    Console.WriteLine($"\n  {menu[i, 0]} - {itemCount[i]}");
                }
            }

            Console.WriteLine("\n  Total Items: " + totalItems);
        }

        //-------------GET ITEM BY INDEX---------------
        //method to get item by index
        public string GetItemByIndex(int index)
        {
            //return item at [index-1,0]
            return menu[index-1,0];
        }

        //---------------GENERATE BILL-----------------
        //method to generate total bill
        public double GenerateBill()
        {
            //initialize total variable with 0
            double total=0;

            //loop through orderedItems and menu arrays
            for(int i = 0; i < totalItems; i++)
            {
                for (int j = 0; j < menu.GetLength(0); j++)
                {
                    //find the price of item
                    if (orderedItems[i] == menu[j,0])
                    {
                        //add price to total
                        total+= Convert.ToDouble(menu[j,1]);
                        break;
                    }
                }
            }

            return total;
        }

        //---------------CHECK ORDER---------------------
        //method to check if customer ordered an item or not
        public bool CheckOrder()
        {
            //if the length of order array is 0 then return false
            return totalItems==0;
        }
    }
}
