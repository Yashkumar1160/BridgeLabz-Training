using BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.custom_furniture_manufacturing
{
    internal class FurnitureMenu
    {
        //method to start program
        public static void Start()
        {
            Console.WriteLine("------CUSTOM FURNITURE MANUFACTURING--------");

            //create object of FurnitureUtility class
            FurnitureUtility furnitureUtility = new FurnitureUtility();

            //take rod length
            Console.Write("ENTER ROD LENGTH: ");
            int rodLength = Convert.ToInt32(Console.ReadLine());

            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n1. ADD PRICES ARRAY");
                Console.WriteLine("2. FIND MAXIMUM REVENUE");
                Console.WriteLine("3. FIND MAXIMUM REVENUE WITH WASTE CONSTRAINT");
                Console.WriteLine("4. FIND MAXIMUM REVENUE WITH MINIMUM WASTE");
                Console.WriteLine("5. EXIT PROGRAM");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        furnitureUtility.AddPriceChart(rodLength);
                        break;

                    case 2:
                        int maximum=furnitureUtility.FindMaxRevenue(rodLength);
                        Console.WriteLine("MAXIMUM REVENUE: "+maximum);
                        break;

                    case 3:
                        Console.Write("ENTER WASTE CONSTRAINT: ");
                        int maxWithWaste=furnitureUtility.FindMaxRevenueWithWaste(rodLength,Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("MAX REVENUE WITH WASTE CONSTRAINT: "+maxWithWaste);
                        break;

                    case 4:
                        furnitureUtility.FindMaxRevenueWithMinWaste(rodLength);
                        break;

                    case 5:
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
