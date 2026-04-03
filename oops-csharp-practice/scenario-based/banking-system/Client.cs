using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.banking_system
{
    internal class Client
    {
        //---------------CLIENT MENU-----------------
        //method to display client menu
        public void ClientMenu(Bank bank)
        {
            //infinite loop to display menu until user exits
            while (true)
            {
                Console.WriteLine("\n1. DEPOSIT AMOUNT");
                Console.WriteLine("\n2. WITHDRAWAL AMOUNT");
                Console.WriteLine("\n3. CHECK BALANCE");
                Console.WriteLine("\n4. LOGOUT");
                Console.WriteLine("\nENTER YOUR CHOICE");

                //take user choice
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    //if user enters 1
                    case 1:
                        DepositAmount(bank);
                        break;

                    //if user enters 2
                    case 2:
                        WithdrawalAmount(bank);
                        break;

                    //if user enters 3
                    case 3:
                        CheckBalance(bank);
                        break;

                    //if user enters 4
                    case 4:
                        Console.WriteLine("\nLOGOUT SUCCESSFUL");
                        return;

                    //if user enters invalid input
                    default:
                        Console.WriteLine("\nINVALID INPUT");
                        break;
                }
            }

        }

        //-------------DEPOSIT amount----------------
        //method to deposit amount
        public void DepositAmount(Bank bank)
        {
            //take account number
            Console.WriteLine("\nENTER ACCOUNT NUMBER:");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            //take amount
            Console.WriteLine("\nENTER AMOUNT");
            int amount = Convert.ToInt32(Console.ReadLine());

            //deposit amount
            if (bank.DepositAmount(accountNumber, amount))
            {
                Console.WriteLine("\nDEPOSIT SUCCESSFUL");
            }
            else
            {
                Console.WriteLine("\nACCOUNT DOES NOT EXIST");
            }



        }
        //-------------WITHDRAWAL amount--------------
        //method to withdrawal amount
        public void WithdrawalAmount(Bank bank)
        {
            //take account number
            Console.WriteLine("\nENTER ACCOUNT NUMBER:");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            //take amount
            Console.WriteLine("\nENTER amount");
            int amount = Convert.ToInt32(Console.ReadLine());

            //check if account exists, then withdraw amount
            int status = bank.WithdrawalAmount(accountNumber, amount);

            if (status == 1)
            {
                Console.WriteLine("\nWITHDRAWAL SUCCESSFUL");
            }
            else if (status == 0)
            {
                Console.WriteLine("\nINSUFFICIENT BALANCE");
            }
            else
            {
                Console.WriteLine("\nACCOUNT DOES NOT EXIST");
            }


        }
        //-------------CHECK BALANCE------------------
        //method to check balance
        public void CheckBalance(Bank bank)
        {
            //take account number
            Console.WriteLine("\nENTER ACCOUNT NUMBER:");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            //store balance
            double balance = bank.CheckBalance(accountNumber);

            //display balance
            Console.WriteLine("\nBALANCE: " + balance);
        }



    }
}
