using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_access_modifiers
{
    internal class BankAccount
    {
        //attributes
        public int accountNumber;

        protected string accountHolder;

        private double balance;

        //method to deposit amount
        public void Deposit(double amount)
        {
            //update balance
            balance += amount;
        }

        //method to get balance
        public double GetBalance()
        {
            return balance;
        }

        //subclass
        class SavingsAccount : BankAccount
        {
            public static void Main(string[] args)
            {
                //call TakeInputs method
                TakeInputs();
            }

            //---------------TAKE INPUTS---------------
            //method to take inputs from user
            public static void TakeInputs()
            {
                //create object
                SavingsAccount savings = new SavingsAccount();

                //take account number
                Console.WriteLine("ENTER ACCOUNT NUMBER: ");
                savings.accountNumber = Convert.ToInt32(Console.ReadLine());

                //take account holder name
                Console.WriteLine("ENTER ACCOUNT HOLDER NAME: ");
                savings.accountHolder = Console.ReadLine();

                //take amount to deposit
                Console.WriteLine("ENTER AMOUNT TO DEPOSIT: ");
                savings.Deposit(Convert.ToDouble(Console.ReadLine()));

                savings.DisplayDetails();

            }

            //----------------DISPLAY DETAILS------------------
            //method to display all details 
            public void DisplayDetails()
            {
                Console.WriteLine("ACCOUNT NUMBER: "+accountNumber);

                Console.WriteLine("ACCOUNT HOLDER NAME: "+accountHolder);

                Console.WriteLine("ACCOUNT BALANCE: " + GetBalance());
            }
        }
    }
}
