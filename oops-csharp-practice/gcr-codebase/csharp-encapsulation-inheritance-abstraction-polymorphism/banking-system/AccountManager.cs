using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.banking_system
{
    internal class AccountManager
    {
        //array to store accounts
        BankAccount[] accounts = new BankAccount[50];

        //variable to store total accounts count
        int count = 0;

        //method to add account
        public void AddAccount(BankAccount account)
        {
            accounts[count] = account;
            count++;
        }

        //method to display all accounts
        public void DisplayAccounts()
        {
            for (int i = 0; i < count; i++)
            {
                accounts[i].DisplayDetails();
                Console.WriteLine("INTEREST: " + accounts[i].CalculateInterest());
            }
        }

        //method to deposit amount
        public void Deposit(int accNo, double amount)
        {
            BankAccount acc = FindAccount(accNo);
            if (acc != null)
            {
                acc.Deposit(amount);
                Console.WriteLine("Amount deposited successfully.");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        //method to withdrawal amount
        public void Withdraw(int accNo, double amount)
        {
            BankAccount acc = FindAccount(accNo);
            if (acc != null)
            {
                if (acc.Balance >= amount)
                {
                    acc.Withdraw(amount);
                    Console.WriteLine("Amount withdrawn successfully.");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        //method to find an account
        public BankAccount FindAccount(int accNo)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].AccountNumber == accNo)
                    return accounts[i];
            }
            return null;
        }

    }
}
