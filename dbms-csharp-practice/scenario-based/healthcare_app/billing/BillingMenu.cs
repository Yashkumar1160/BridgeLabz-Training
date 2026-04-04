using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.billing
{
    public class BillingMenu
    {
        public static void DisplayMenu()
        {
            //create object 
            IBilling billing = new BillingUtilityImpl();

            //infinite loop until user exits
            while(true)
            {
                //display menu
                Console.WriteLine("\n----- BILLING & PAYMENTS -----");
                Console.WriteLine("1. Generate Bill");
                Console.WriteLine("2. Record Payment");
                Console.WriteLine("3. View Outstanding Bills");
                Console.WriteLine("4. Generate Revenue Report");
                Console.WriteLine("5. Exit");
                Console.Write("Enter Choice: ");

                //take user's choice
                int choice = int.Parse(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //Generate Bill
                    case 1:
                        billing.GenerateBill();
                        break;
                    // Record Payment
                    case 2:
                        billing.RecordPayment();
                        break;
                    //View Outstanding Bills
                    case 3:
                        billing.ViewOutstandingBills();
                        break;
                    //Generate Revenue Report
                    case 4:
                        billing.GenerateRevenueReport();
                        break;
                    //Exit
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}