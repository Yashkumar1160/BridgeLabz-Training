using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.browser_buddy
{
    internal class BrowserMenu
    {
        public static void Start()
        {
            //create object for BrowserManager
            BrowserManager browser = new BrowserManager();


            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n--- BROWSER BUDDY MENU ---");
                Console.WriteLine("1. VISIT NEW TAB");
                Console.WriteLine("2. GO BACK");
                Console.WriteLine("3. MOVE FORWARD");
                Console.WriteLine("4. RESTORE TAB");
                Console.WriteLine("5. SHOW CURRENT TAB");
                Console.WriteLine("6. CLOSE TAB");
                Console.WriteLine("7. EXIT PROGRAM");
                Console.Write("Enter choice: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());


                //handle user's choice
                switch (choice)
                {
                    //visit new tab
                    case 1:
                        browser.Visit();
                        break;

                    //go back
                    case 2:
                        browser.Back();
                        break;

                    //move forward
                    case 3:
                        browser.Forward();
                        break;

                    //restore tab
                    case 4:
                        browser.RestoreTab();
                        break;

                    //show current tab
                    case 5:
                        browser.ShowCurrentPage();
                        break;

                    //close tab
                    case 6:
                        browser.CloseTab();
                        break;

                    //exit
                    case 7:
                        Console.WriteLine("EXIT SUCCESSFUL");
                        return;

                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            }
        }
    }
}
