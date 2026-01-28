using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.auto_audit_system
{
    internal class EventTrackerMenu
    {
        public static void DisplayMenu()
        {
            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n--- EventTracker Menu ---");
                Console.WriteLine("1. Generate Audit Logs");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    //scan controller and generate JSON logs
                    EventTracker.ScanAndLogEvents(typeof(UserActivityController));
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Exit Successful");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }
    }
}
