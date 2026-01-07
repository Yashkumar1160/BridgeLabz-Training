using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.banking_system
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Start();
        }

        //method to start program
        public static void Start()
        {
            //create object of class AccountManager
            AccountManager manager = new AccountManager();

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\n1. ADD SAVINGS ACCOUNT");
                Console.WriteLine("2. ADD CURRENT ACCOUNT");
                Console.WriteLine("3. DEPOSIT");
                Console.WriteLine("4. WITHDRAW");
                Console.WriteLine("5. VIEW ALL ACCOUNTS");
                Console.WriteLine("6. APPLY FOR LOAN");
                Console.WriteLine("7. EXIT");
                Console.Write("ENTER CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        AddSavingsAccount(manager);
                        break;
                    case 2:
                        AddCurrentAccount(manager);
                        break;
                    case 3:
                        Deposit(manager);
                        break;
                    case 4:
                        Withdraw(manager);
                        break;
                    case 5:
                        manager.DisplayAccounts();
                        break;

                    case 6:
                        ApplyForLoan(manager);
                        break;

                    case 7:
                        return;
                    default:
                        Console.WriteLine("INVALID INPUT");
                        break;
                }
            }
        }

        //method to add savings account
        static void AddSavingsAccount(AccountManager manager)
        {
            //take account number
            Console.Write("ACCOUNT NUMBER: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            //take holder name
            Console.Write("HOLDER NAME: ");
            string name = Console.ReadLine();

            //take initial balance
            Console.Write("INITIAL BALANCE: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            //add account
            manager.AddAccount(new SavingsAccountImpl(accNo, name, balance));
            Console.WriteLine("SAVINGS ACCOUNT ADDED");
        }

        //method to add current account
        static void AddCurrentAccount(AccountManager manager)
        {
            //take account number
            Console.Write("ACCOUNT NUMBER: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            //take holder name
            Console.Write("HOLDER NAME: ");
            string name = Console.ReadLine();

            //take initial balance
            Console.Write("INITIAL BALANCE: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            //add account
            manager.AddAccount(new CurrentAccount(accNo, name, balance));
            Console.WriteLine("CURRENT ACCOUNT ADDED");
        }

        //method to deposit amount
        static void Deposit(AccountManager manager)
        {
            //take account number
            Console.Write("ACCOUNT NUMBER: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            //take amount to deposit
            Console.Write("AMOUNT TO DEPOSIT: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            //call Deposit method to deposit amount
            manager.Deposit(accNo, amount);
        }

        //method to withdrawal amount
        static void Withdraw(AccountManager manager)
        {
            //take account number
            Console.Write("ACCOUNT NUMBER: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            //take amount to withdrawal
            Console.Write("AMOUNT TO WITHDRAW: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            //call Withdraw method to withdrawal amount
            manager.Withdraw(accNo, amount);
        }

        //method to apply for loan
        static void ApplyForLoan(AccountManager manager)
        {
            //take account number
            Console.Write("ENTER ACCOUNT NUMBER: ");
            int accNo = Convert.ToInt32(Console.ReadLine());

            //call FindAccount method
            BankAccount acc = manager.FindAccount(accNo);

            //check if account is loannable
            if (acc is ILoanable loanable)
                loanable.ApplyForLoan();
            else
                Console.WriteLine("This account is not eligible for loans.");
        }
    }
}
