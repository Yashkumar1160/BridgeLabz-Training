using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.banking_system
{

    internal abstract class BankAccount
    {
        //protected variables
        protected int accountNumber;

        protected string holderName;

        protected double balance;

        //getter for account number
        public int AccountNumber
        {
            get { return accountNumber; }
        }

        //getter for holder name
        public string HolderName
        {
            get { return holderName; }
        }

        //getter for balance
        public double Balance
        {
            get { return balance; }
        }

        //constructor
        public BankAccount(int accNo, string name, double bal)
        {
            accountNumber = accNo;
            holderName = name;
            balance = bal;
        }

        //method to deposit amount
        public void Deposit(double amount)
        {
            balance += amount;
        }

        //method to withdrawal amount
        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        //abstract method to calculate interest
        public abstract double CalculateInterest();

        //concrete method to display account details
        public void DisplayDetails()
        {
            Console.WriteLine("\nACCOUNT NO: " + AccountNumber);

            Console.WriteLine("NAME: " + HolderName);

            Console.WriteLine("BALANCE: " + Balance);
        }
    }
}
