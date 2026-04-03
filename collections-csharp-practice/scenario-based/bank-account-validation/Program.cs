using System;

namespace BankAccountApp
{
    internal class Program
    {
        //property to store account balance
        public decimal Balance { get; set; }

        //constructor to set initial balance
        public Program(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        //method to deposit amount
        public void Deposit(decimal amount)
        {
            //check for negative deposit
            if (amount < 0)
            {
                throw new Exception("Deposit amount cannot be negative");
            }

            //add amount to balance
            Balance += amount;
        }

        //method to withdraw amount
        public void Withdraw(decimal amount)
        {
            //check for insufficient funds
            if (amount > Balance)
            {
                throw new Exception("Insufficient funds.");
            }

            //deduct amount from balance
            Balance -= amount;
        }
    }
}
