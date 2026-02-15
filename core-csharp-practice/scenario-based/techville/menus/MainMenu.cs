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
            ModuleMenu module = new ModuleMenu();

            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n====== TechVille Main Menu ======");
                Console.WriteLine("1. Citizen Registration");
                Console.WriteLine("2. Display All Citizens");
                Console.WriteLine("3. Check Eligibility of All Citizens");
                Console.WriteLine("0. Exit");
                Console.Write("Enter Option: ");

                //take user's choice
                int choice = int.Parse(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //citizen register
                    case 1:
                        module.Show();
                        break;

                    //display all citizens
                    case 2:
                        module.DisplayAll();
                        break;

                    //check eligibility
                    case 3:
                        module.CheckEligibility();
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
