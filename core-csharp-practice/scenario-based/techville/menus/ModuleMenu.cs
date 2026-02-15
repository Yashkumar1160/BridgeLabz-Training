using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.services;
namespace techville.menus
{
    public class ModuleMenu
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

                    case 2:
                        return;

                    //invalid choice
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }

        //method to display citizens data
        public void DisplayAll()
        {
            citizenService.DisplayAllCitizens();
        }


        //method to check eligibility
        public void CheckEligibility()
        {
            citizenService.CheckAllEligibility();
        }

        //M-3 method to display zone data
        public void DisplayZoneData()
        {
            citizenService.DisplayZoneSectorData();
        }

        //M-3 method to sort citizen IDs
        public void SortIds()
        {
            citizenService.SortCitizenIds();
        }

        //M-3 method to search citizen by ID
        public void SearchById(int id)
        {
            citizenService.SearchCitizenById(id);
        }

        //M-3 method to copy Citizen IDs
        public void Copy()
        {
            citizenService.CopyCitizenIds();
        }

        //M-4 method to update profile
        public void UpdateProfile(int id)
        {
            citizenService.UpdateCitizenProfile(id);
        }

        //M-4 method to search citizen by name
        public void SearchByName(string name)
        {
            citizenService.SearchCitizenByName(name);
        }


    }
}