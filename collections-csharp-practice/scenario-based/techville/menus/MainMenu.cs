using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.menus
{
    public class MainMenu
    {
        //Main Menu
        public static void DisplayMenu()
        {
            //create object of Module Menu class
            ModuleMenu module = new ModuleMenu();

            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n====== TechVille Main Menu ======");
                Console.WriteLine("1. Citizen Registration");
                Console.WriteLine("2. Display All Citizens");
                Console.WriteLine("3. Check Eligibility of All Citizens");
                //M-3 Smart Citizen Database Options
                Console.WriteLine("4. Display Zone & Sector Data");
                Console.WriteLine("5. Sort Citizen IDs");
                Console.WriteLine("6. Search Citizen by ID");
                Console.WriteLine("7. Copy Citizen IDs");
                //M-4 Citizen Profile Management
                Console.WriteLine("8. Update Citizen Profile");
                Console.WriteLine("9. Search Citizen by Name");
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

                    //M-3 Options
                    //Display Zone & Sectors Data
                    case 4:
                        module.DisplayZoneData();
                        break;

                    //Sort by Ids
                    case 5:
                        module.SortIds();
                        break;

                    //Search By Id
                    case 6:
                        //take citizen id 
                        Console.Write("Enter Citizen ID: ");
                        int id = int.Parse(Console.ReadLine());
                        module.SearchById(id);
                        break;

                    //Copy Id
                    case 7:
                        module.Copy();
                        break;

                    //Update Citizen Profile
                    case 8:
                        Console.Write("Enter Citizen ID: ");
                        int updateId = int.Parse(Console.ReadLine());
                        module.UpdateProfile(updateId);
                        break;

                    //Search Citizen By Name
                    case 9:
                        Console.Write("Enter Name to Search: ");
                        string searchName = Console.ReadLine();
                        module.SearchByName(searchName);
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
