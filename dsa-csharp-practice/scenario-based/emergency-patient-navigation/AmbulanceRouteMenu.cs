using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.emergency_patient_navigation
{
    internal class AmbulanceRouteMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("-----EMERGENCY PATIENT NAVIGATION-----");

            //create object
            AmbulanceRouteUtilityImpl utility = new AmbulanceRouteUtilityImpl();

            //infinite loop until user exits
            while (true)
            {
                //display options
                Console.WriteLine("\n1. ADD UNIT");
                Console.WriteLine("2. UPDATE UNIT STATUS");
                Console.WriteLine("3. REMOVE UNIT");
                Console.WriteLine("4. DISPLAY UNITS");
                Console.WriteLine("5. REDIRECT PATIENT");
                Console.WriteLine("6. EXIT");
                Console.Write("ENTER CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //add unit
                    case 1:
                        utility.AddUnit();
                        break;

                    //update unit status
                    case 2:
                        utility.UpdateUnitStatus();
                        break;

                    //remove unit
                    case 3:
                        utility.RemoveUnit();
                        break;

                    //display units
                    case 4:
                        utility.DisplayUnits();
                        break;

                    //redirect patient
                    case 5:
                        utility.RedirectPatient();
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
