using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_library
{
    namespace class_library
    {
        public class BankAccount
        {
            //variable to store balance
            private double balance;

            //constructor
            public BankAccount(double initialBalance = 0)
            {
                balance = initialBalance;
            }

            //method to deposit money
            public void Deposit(double amount)
            {
                if (amount < 0)
                {
                    throw new ArgumentException("Deposit amount must be positive"); 
                }
                balance += amount;
            }

            //method to withdraw money
            public void Withdraw(double amount)
            {
                if (amount < 0)
                {
                    throw new ArgumentException("Withdraw amount must be positive");
                }

                //check for insufficient funds
                if (amount > balance)
                {
                    throw new InvalidOperationException("Insufficient funds");
                }

                balance -= amount;
            }

            //method to get current balance
            public double GetBalance()
            {
                return balance;
            }
        }
    }

}
