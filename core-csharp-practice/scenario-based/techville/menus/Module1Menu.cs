using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.services;
namespace techville.menus
{
    public class Module1Menu
    {
        CitizenServices citizenService = new CitizenServices();

        //display menu
        public void Show()
        {   
            //infinite loop until user exits
            while (true)
            {
                //diaplay menu
                Console.WriteLine("\n===== Citizen Registration =====");
                Console.WriteLine("1. Register Citizen");
                Console.WriteLine("2. Back to Main Menu");
                Console.Write("Select Option: ");

                //take user's choice
                int choice = int.Parse(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //register citizen
                    case 1:
                        citizenService.RegisterCitizen();
                        break;

                    //back to main menu
                    case 2:
                        return; 

                    //invalid choice
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
    }
}