using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.banking_system
{

    internal class BankManager
    {
        //manager login details
        private static string adminUsername = "admin1234";

        private static string adminPassword = "password";
        public bool CheckCredentials()
        {
            //take username
            Console.WriteLine("ENTER USERNAME:");
            string userName = Console.ReadLine();

            //take password
            Console.WriteLine("ENTER PASSWORD:");
            string password = Console.ReadLine();

            //check credentials
            if (userName == adminUsername && password == adminPassword)
            {
                return true;
            }

            return false;
        }
        public void ManagerMenu(Bank bank)
        {
            if (CheckCredentials())
            {
                //infinite loop to display menu until user exit
                while (true)
                {

                    Console.WriteLine("\n1. OPEN ACCOUNT");
                    Console.WriteLine("\n2. CLOSE ACCOUNT");
                    Console.WriteLine("\n3. VIEW ALL ACCOUNTS");
                    Console.WriteLine("\n4. LOGOUT");
                    Console.WriteLine("\nENTER YOUR CHOICE:");

                    //take  user choice
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        //if user enters 1
                        case 1:
                            OpenAccount(bank);
                            break;

                        //if user enters 2
                        case 2:
                            CloseAccount(bank);
                            break;

                        //if user enters 3
                        case 3:
                            ViewAllAccounts(bank);
                            break;

                        //if user enters 4
                        case 4:
                            Console.WriteLine("LOGOUT SUCCESS");
                            return;

                        //if user enters invalid input
                        default:
                            Console.WriteLine("INVALID INPUT");
                            break;
                    }
                }
            }
            //if credentials are wrong
            else
            {
                Console.WriteLine("WRONG CREDENTIALS");
            }
        }
        //------------------OPEN ACCOUNT------------------
        //method to open an account
        public void OpenAccount(Bank bank)
        {
            //take client name
            Console.WriteLine("ENTER NAME:");
            string name = Console.ReadLine();

            //take client email
            Console.WriteLine("ENTER EMAIL:");
            string email = Console.ReadLine();

            //take client phone number
            Console.WriteLine("ENTER PHONE NUMBER:");
            long phoneNumber = Convert.ToInt64(Console.ReadLine());

            //take client address
            Console.WriteLine("ENTER ADDRESS:");
            string address = Console.ReadLine();

            //take account number
            Console.WriteLine("ENTER ACCOUNT NUMBER");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            //call OpenAccount method in Bank class
            bank.OpenAccount(name, email, phoneNumber, address, accountNumber);

        }
        //------------------CLOSE ACCOUNT-----------------
        public void CloseAccount(Bank bank)
        {
            //take account number
            Console.WriteLine("ENTER ACCOUNT NUMBER");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            //call CloseAccount method in Bank class
            bank.CloseAccount(accountNumber);
        }

        //----------------VIEW ALL ACCOUNT----------------
        public void ViewAllAccounts(Bank bank)
        {
            //call ViewAllAccounts method in Bank class
            bank.ViewAllAccounts();
        }
    }
}
