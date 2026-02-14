using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.menus
{
    public class MainMenu
    {
        //Main menu
        public static void DisplayMenu()
        {
            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n====== TechVille Main Menu ======");
                Console.WriteLine("1. Citizen Registration");
                Console.WriteLine("0. Exit");
                Console.Write("Enter Option: ");

                //take user's choice
                int choice = int.Parse(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {   
                    //citizen register
                    case 1:
                        Module1Menu module1 = new Module1Menu();
                        module1.Show();
                        break;
                    
                    //exit
                    case 0:
                        Console.WriteLine("Exit Successful");
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
