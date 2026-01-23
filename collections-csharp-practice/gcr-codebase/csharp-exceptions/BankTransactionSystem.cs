using BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.banking_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_exceptions
{
    //custom exception class for insufficient funds
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }

    internal class BankTransactionSystem
    {
        //variable to store account balance
        private double balance;

        //constructor 
        public BankTransactionSystem(double initialBalance)
        {
            balance = initialBalance;
        }

        //method to withdraw amount
        public void Withdraw(double amount)
        {
            //check for negative amount
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount!");
            }

            //check for insufficient balance
            if (amount > balance)
            {
                throw new InsufficientFundsException("Insufficient balance!");
            }

            //update balance
            balance -= amount;
            Console.WriteLine("Withdrawal successful, new balance: " + balance);
        }

        public static void Main(string[] args)
        {
            //create object of BankTransactionSystem class
            BankTransactionSystem account = new BankTransactionSystem(1000);

            //try block
            try
            {
                //take input for withdrawal amount
                Console.Write("Enter amount to withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                //call Withdraw method
                account.Withdraw(amount);
            }
            //catch custom InsufficientFundsException
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine("InsufficientFundsException occurred: " + ex.Message);
            }
            //catch ArgumentException for negative amount
            catch (ArgumentException ex)
            {
                Console.WriteLine("ArgumentException occurred: " + ex.Message);
            }
            //catch FormatException
            catch (FormatException)
            {
                Console.WriteLine("FormatException occurred: Please enter a valid numeric amount");
            }
        }
    }
}
