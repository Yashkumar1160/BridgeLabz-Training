using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    internal class ApplianceMenu
    {
        //method to start program
        public static void Start()
        {
            bool turnOn = true;
            bool turnOff = false;

            Console.WriteLine("------SMART HOME AUTOMATION SYSTEM------");

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\n1. ADD APPLIANCE");
                Console.WriteLine("2. TURN ON FAN");
                Console.WriteLine("3. TURN ON AC");
                Console.WriteLine("4. TURN ON LIGHT");
                Console.WriteLine("5. TURN OFF FAN");
                Console.WriteLine("6. TURN OFF AC");
                Console.WriteLine("7. TURN OFF LIGHT");
                Console.WriteLine("8. VIEW ALL APPLIANCES");
                Console.WriteLine("9. FIND APPLIANCE");
                Console.WriteLine("10. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch(choice)
                {
                    case 1:
                        AddAppliance();
                        break;

                    case 2:
                        //call ControlAppliance method from ApplianceUtilityImpl class
                        ApplianceUtilityImpl.ControlAppliance(1,turnOn);
                        break;

                    case 3:
                        //call ControlAppliance method from ApplianceUtilityImpl class
                        ApplianceUtilityImpl.ControlAppliance(2,turnOn);
                        break;

                    case 4:
                        //call ControlAppliance method from ApplianceUtilityImpl class
                        ApplianceUtilityImpl.ControlAppliance(3,turnOn);
                        break;

                    case 5:
                        //call ControlAppliance method from ApplianceUtilityImpl class
                        ApplianceUtilityImpl.ControlAppliance(1,turnOff);
                        break;

                    case 6:
                        //call ControlAppliance method from ApplianceUtilityImpl class
                        ApplianceUtilityImpl.ControlAppliance(2,turnOff);
                        break;

                    case 7:
                        //call ControlAppliance method from ApplianceUtilityImpl class
                        ApplianceUtilityImpl.ControlAppliance(3,turnOff);
                        break;

                    case 8:
                        //call ControlAppliance method from ApplianceUtilityImpl class
                        ApplianceUtilityImpl.ViewAllAppliance();
                        break;

                    case 9:
                        //call FindAppliance method from ApplianceUtilityImpl class
                        ApplianceUtilityImpl.FindAppliance();
                        break;

                    case 10:
                        Console.WriteLine("\nEXIT SUCCESSFUL THANKYOU");
                        return;

                    default:
                        Console.WriteLine("\nINVALID CHOICE");
                        break;
                }
                
            }
        }  

        //method to display appliances menu
        public static void AddAppliance()
        {
            while(true)
            {
                Console.WriteLine("\n1. ADD FAN");
                Console.WriteLine("2. ADD AC");
                Console.WriteLine("3. ADD LIGHT");
                Console.WriteLine("4. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice= Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        //call AddAppliance method from ApplianceUtilityImpl class
                        ApplianceUtilityImpl.AddAppliance(1);
                        break;

                    case 2:
                        //call AddAppliance method from ApplianceUtilityImpl class
                        ApplianceUtilityImpl.AddAppliance(2);
                        break;

                    case 3:
                        //call AddAppliance method from ApplianceUtilityImpl class
                        ApplianceUtilityImpl.AddAppliance(3);
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("\nINVALID CHOICE");
                        break;
                }
            }
          

        }
    }
}
