using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.aadhar_numbers_sorting
{
    internal class RadixSortMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("------AADHAR CARD SORTING USING RADIX SORT-------");

            //create object of RadixSortUtilityImpl class
            RadixSortUtilityImpl utility=new RadixSortUtilityImpl();

            //loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n1. ADD SINGLE PERSON DETAILS");
                Console.WriteLine("2. ADD MULTIPLE PERSON DETAILS");
                Console.WriteLine("3. SORT BY AADHAR NUMBERS");
                Console.WriteLine("4. SEARCH AADHAR NUMEBR");
                Console.WriteLine("5. DISPLAY PERSON DETAILS");
                Console.WriteLine("6. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //add person details
                    case 1:
                        utility.AddPersonDetails();
                        break;

                    //add multiple persons details
                    case 2:
                        utility.AddMultiplePerson();
                        break;

                    //sort by aadhar numbers
                    case 3:
                        utility.SortByAadharNumbers();
                        break;

                    //search aadhar number
                    case 4:
                        utility.SearchAadharNumber();
                        break;

                    //display details
                    case 5:
                        utility.DisplayDetails();
                        break;

                    //exit
                    case 6:
                        Console.WriteLine("\nExit Successful");
                        return;

                    //invalid choice
                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }
    }
}
