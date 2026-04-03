using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using techville.services;
namespace techville.menus
{
    public class ModuleMenu
    {

        //display menu
        public void Show(CitizenServices citizenService)
        {
            //infinite loop until user exits
            while (true)
            {
                //diaplay menu
                Console.WriteLine("\n===== Citizen Registration =====");
                Console.WriteLine("1. Register Citizen");
                //M-10 Citizen Network System
                Console.WriteLine("2. Show Queue");
                Console.WriteLine("3. Show Profiles Forward");
                Console.WriteLine("4. Show Profiles Backward");
                Console.WriteLine("5. Show Round Robin");
                Console.WriteLine("0. Back to Main Menu");
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

                    //show queue
                    case 2:
                        citizenService.ShowQueue();
                        break;
                    //show profiles forward
                    case 3:
                        citizenService.ShowProfilesForward();
                        break;
                    //show profiles backward
                    case 4:
                        citizenService.ShowProfilesBackward();
                        break;
                    //show round robin
                    case 5:
                        citizenService.ShowRoundRobin();
                        break;
                    //return to main menu
                    case 0:
                        return;

                    //invalid choice
                    default:
                        Console.WriteLine("Invalid Choice. Try again.");
                        break;
                }
            }
        }

        //method to display citizens data
        public void DisplayAll(CitizenServices citizenService)
        {
            citizenService.DisplayAllCitizens();
        }


        //method to check eligibility
        public void CheckEligibility(CitizenServices citizenService)
        {
            citizenService.CheckAllEligibility();
        }

        //M-3 method to display zone data
        public void DisplayZoneData(CitizenServices citizenService)
        {
            citizenService.DisplayZoneSectorData();
        }

        //M-3 method to sort citizen IDs
        public void SortIds(CitizenServices citizenService)
        {
            citizenService.SortCitizenIds();
        }

        //M-3 method to search citizen by ID
        public void SearchById(int id,CitizenServices citizenService)
        {
            citizenService.SearchCitizenById(id);
        }

        //M-3 method to copy Citizen IDs
        public void Copy(CitizenServices citizenService)
        {
            citizenService.CopyCitizenIds();
        }

        //M-4 method to update profile
        public void UpdateProfile(int id,CitizenServices citizenService)
        {
            citizenService.UpdateCitizenProfile(id);
        }

        //M-4 method to search citizen by name
        public void SearchByName(string name,CitizenServices citizenService)
        {
            citizenService.SearchCitizenByName(name);
        }


    }
}