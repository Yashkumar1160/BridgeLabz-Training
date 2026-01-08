using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.smart_home_automation_system
{
    internal class ApplianceUtilityImpl:IControllable
    {
        //array to store appliances
        static Appliance[] appliances = new Appliance[100];

        //variable to store total appliance count
        static int totalAppliances = 0;


        //method to turn on and turn off an appliance 
        public static void ControlAppliance(int type,bool onOff)
        {
            //take model number
            Console.Write("ENTER MODEL NUMBER: ");
            int model = Convert.ToInt32(Console.ReadLine());

            //create object of ApplianceUtilityImpl class
            ApplianceUtilityImpl utility = new ApplianceUtilityImpl();

            //loop through appliances array
            for (int i = 0; i < totalAppliances; i++)
            {
                if (appliances[i].ModelNumber == model)
                {
                    //check correct appliance type
                    if ((type == 1 && appliances[i] is Fan) ||
                        (type == 2 && appliances[i] is Ac) ||
                        (type == 3 && appliances[i] is Light))
                    {
                        if (onOff)
                        {
                            utility.TurnOn(appliances[i]);
                        }
                        else
                        {
                            utility.TurnOff(appliances[i]);
                        }
                        return;
                    }
                    else
                    {
                        Console.WriteLine("\nAPPLIANCE TYPE DO NOT MATCH");
                        return;
                    }
                }
            }
            Console.WriteLine("\nAPPLIANCE NOT FOUND");
        }

        //method to add different appliances
        public static void AddAppliance(int type)
        {
            //take brand input 
            Console.Write("\nENTER BRAND: ");
            string brand = Console.ReadLine();

            //take model number input
            Console.Write("ENTER MODEL NUMBER: ");
            int model = Convert.ToInt32(Console.ReadLine());

            //if remote has remote
            Console.Write("HAS REMOTE (true/false): ");
            bool hasRemote = Convert.ToBoolean(Console.ReadLine());

            //take warranty input
            Console.Write("ENTER WARRANTY: ");
            int warranty = Convert.ToInt32(Console.ReadLine());

            //take price input
            Console.Write("ENTER PRICE: ");
            double price= Convert.ToDouble(Console.ReadLine());

            if (type == 1)
            {
                //create object of class Fan if type is 1
                Appliance appliance = new Fan(brand, model, hasRemote, warranty,price);
                appliances[totalAppliances] = appliance;

            }
            else if(type == 2)
            {
                //create object of class Ac if type is 2
                Appliance appliance = new Ac(brand, model, hasRemote, warranty,price);
                appliances[totalAppliances] = appliance;


            }
            else if( type == 3)
            {
                //create object of class Light if type is 3
                Appliance appliance = new Light(brand, model, hasRemote, warranty,price);
                appliances[totalAppliances] = appliance;

            }

            //update total appliance count
            totalAppliances++;

            Console.WriteLine("APPLIANCE ADDED");
        }

        //method to display all appliances
        public static void ViewAllAppliance()
        {
            if(totalAppliances == 0)
            {
                Console.WriteLine("NO APPLIANCE ADDED YET");
                return;
            }
            Console.WriteLine("\nAPPLIANCES DETAILS: ");  

            for (int i = 0; i < totalAppliances; i++)
            {
                Console.WriteLine(appliances[i]);

                Console.WriteLine("--------------------------------------------");
            }
        }

        //method to find an appliance with model number
        public static void FindAppliance()
        {
            //take model number
            Console.Write("\nENTER MODEL NUMBER: ");
            int model = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < totalAppliances; i++)
            {
                //check if both model numbers are same
                if (appliances[i].ModelNumber == model)
                {
                    Console.WriteLine("\nAPPLIANCE FOUND");

                    Console.WriteLine(appliances[i]);
                    
                    return;
                }
            }
            Console.WriteLine("\nAPPLIANCE NOT FOUND");
        }


        //implementation of TurnOn method
        public  void TurnOn(Appliance appliance)
        {
            //if appliance is of Type Fan
            if(appliance is Fan)
            {
                Console.WriteLine("FAN TURNED ON");
            }
            //if appliance is of Type Ac
            else if(appliance is Ac)
            {
                Console.WriteLine("AC TURNED ON");
            }
            //if appliance is of Type Light
            else if(appliance is Light)
            {
                Console.WriteLine("LIGHT TURNED ON");
            }
            else
            {
                Console.WriteLine("UNABLE TO FIND DEVICE");
            }
        }

        //implementation of TurnOff method
        public  void TurnOff(Appliance appliance)
        {
            //if appliance is of Type Fan
            if (appliance is Fan)
            {
                Console.WriteLine("FAN TURNED OFF");
            }
            //if appliance is of Type Ac
            else if (appliance is Ac)
            {
                Console.WriteLine("AC TURNED OFF");
            }
            //if appliance is of Type Light
            else if (appliance is Light)
            {
                Console.WriteLine("LIGHT TURNED OFF");
            }
            else
            {
                Console.WriteLine("UNABLE TO FIND DEVICE");
            }
        }

    }
}
