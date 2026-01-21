using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.ranksheet_generator
{
    internal class EduResultMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("-------RANK SHEET GENERATOR------");

            //create object of EduResultUtilityImpl class
            EduResultUtilityImpl utility = new EduResultUtilityImpl();

            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n1. ADD STATE");
                Console.WriteLine("2. ADD DISTRICT");
                Console.WriteLine("3. ADD STUDENT");
                Console.WriteLine("4. DISPLAY STUDENTS BY RANK");
                Console.WriteLine("5. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //add state
                    case 1:
                        utility.AddState();
                        break;

                    //add district
                    case 2:
                        utility.AddDistrict();
                        break;

                    //add student
                    case 3:
                        utility.AddStudent();
                        break;

                    //display results
                    case 4:
                        utility.DisplayResult();
                        break;

                    //exit
                    case 5:
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
