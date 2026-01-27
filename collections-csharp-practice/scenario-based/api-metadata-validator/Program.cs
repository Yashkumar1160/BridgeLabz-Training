using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.api_metadata_validator
{
    internal class Program
    {
        public static void Main()
        {
            //infinite loop until user exits
            while (true) 
            {
                //display options
                Console.WriteLine("\n--- HealthCheckPro Menu ---");
                Console.WriteLine("1. Scan API Metadata");
                Console.WriteLine("2. Exit");
                Console.Write("Enter your choice: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                if (choice == 1)
                {
                    //scan controller using reflection
                    HealthCheckPro.ScanAPIs(typeof(LabTestController));
                }
                else if (choice == 2)
                {
                    //exit the loop
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