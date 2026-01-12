using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.loan_buddy
{
    internal class LoanMenu
    {
        //method to start program
        public static void Start()
        {
            Console.WriteLine("---- LOAN BUDDY ----");

            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("\n1. PERSONAL LOAN");
                Console.WriteLine("2. HOME LOAN");
                Console.WriteLine("3. AUTO LOAN");
                Console.WriteLine("4. EXIT");
                Console.Write("ENTER CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        //take term months
                        Console.Write("ENTER TERM MONTHS : ");
                        int termMonths = Convert.ToInt32(Console.ReadLine());

                        //take interest rate input
                        Console.Write("ENTER INTEREST RATE: ");
                        double personalInterestRate=Convert.ToDouble(Console.ReadLine());

                        //create object of PersonalLoan class
                        PersonalLoan personalLoan= new PersonalLoan("PERSONAL LOAN",termMonths,personalInterestRate);
                        LoanUtilityImpl.ProcessLoan(personalLoan);
                        break;

                    case 2:
                        //take term months
                        Console.Write("ENTER TERM MONTHS : ");
                        int termMonths2 = Convert.ToInt32(Console.ReadLine());

                        //take interest rate input
                        Console.Write("ENTER INTEREST RATE: ");
                        double homeInterestRate = Convert.ToDouble(Console.ReadLine());

                        //create object of HomeLoan class
                        HomeLoan homeLoan = new HomeLoan("HOME LOAN", termMonths2, homeInterestRate);
                        LoanUtilityImpl.ProcessLoan(homeLoan);
                        break;

                    case 3:
                        //take term months
                        Console.Write("ENTER TERM MONTHS : ");
                        int termMonths3 = Convert.ToInt32(Console.ReadLine());

                        //take interest rate input
                        Console.Write("ENTER INTEREST RATE: ");
                        double autoInterestRate = Convert.ToDouble(Console.ReadLine());

                        //create object of AutoLoan class
                        AutoLoan autoLoan = new AutoLoan("AUTO LOAN", termMonths3, autoInterestRate);
                        LoanUtilityImpl.ProcessLoan(autoLoan);
                        break;

                    case 4:
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
