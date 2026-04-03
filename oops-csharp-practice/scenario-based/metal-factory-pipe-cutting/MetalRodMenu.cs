using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.metal_factory_pipe_cutting
{
    internal class MetalRodMenu
    {
        //method to start program
        public static void Start()
        {
            Console.WriteLine("METAL ROD REVENUE CALCULATOR");

            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n1. ADD PRICE CHART");
                Console.WriteLine("2. FIND BEST REVENUE (SCENARIO A)");
                Console.WriteLine("3. ADD CUSTOM PRICE (SCENARIO B)");
                Console.WriteLine("4. NOT OPTIMIZED STRATEGY (SCENARIO C)");
                Console.WriteLine("5. EXIT PROGRAM");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());
                
                //handle user's choice
                switch(choice)
                {
                    case 1:
                        Utility.AddPrices();
                        break;

                    case 2:
                        Utility.FindBestRevenue();
                        break;

                    case 3:
                        Utility.CustomLengthPrice();
                        break;

                    case 4:
                        Utility.NotOptimized();
                        break;

                    case 5:
                        Console.WriteLine("EXIT SUCCESSFUL");
                        return;

                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }

            }
        }
    }
}
