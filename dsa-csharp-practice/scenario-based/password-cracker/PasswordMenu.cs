using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.password_cracker
{
    internal class PasswordMenu
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("-------PASSWORD CRACKER----------");

            //create object of PasswordUtilityImpl class
            PasswordUtilityImpl utility = new PasswordUtilityImpl();

            //infinite loop until user exits
            while(true)
            {
                Console.WriteLine("\n1. SET PASSWORD");
                Console.WriteLine("2. START CRACKING");
                Console.WriteLine("3. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch(choice)
                {
                    //set password
                    case 1:
                        utility.SetPassword();
                        break;

                    //start password cracking
                    case 2:
                        utility.StartPasswordCracking();
                        break;

                    //exit
                    case 3:
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
