using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_this_sealed_static_keywords
{
    internal class BankAccount
    {
        //attributes
        static string bankName = "STATE BANK OF INDIA";

        static int totalAccounts;

        readonly int accountNumber;

        string accountHolderName;

        //method to get total accounts
        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }

        //create parameterized constructor
        public BankAccount(int accountNumber, string accountHolderName)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;
            totalAccounts++;
        }
        public static void Main(string[] args)
        {
            //call TakeInputs method
            TakeInputs();
        }

        //------------TAKE INPUTS-----------------
        //method to take user inputs
        public static void TakeInputs()
        {
            //display bank name
            Console.WriteLine(bankName);

            //take account Number input
            Console.Write("ENTER ACCOUNT NUMBER: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());

            //take holder name input
            Console.Write("ENTER HOLDER NAME: ");
            string holderName = Console.ReadLine();

            //create object
            BankAccount bankAccount = new BankAccount(accountNumber, holderName);

            //check if object is of class type
            if (bankAccount is BankAccount)
            {
                bankAccount.DisplayDetails();

                Console.WriteLine("Total Accounts: " + GetTotalAccounts());
            }
        }

        //--------------DISPLAY DETAILS----------------
        //method to display all details
        public void DisplayDetails()
        {
            Console.WriteLine("\nBANKING DETAILS: ");

            Console.WriteLine("ACCOUNT NUMBER: " + accountNumber);

            Console.WriteLine("HOLDER NAME: " + accountHolderName);
        }

    }
}
