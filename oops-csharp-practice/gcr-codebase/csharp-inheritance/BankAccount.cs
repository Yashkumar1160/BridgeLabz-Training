using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class BankAccount
    internal class BankAccount
    {
        //protected variables
        protected string accountNumber;

        protected double balance;

        //parameterized constructor
        public BankAccount(string accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        //method to display account type
        public virtual void DisplayAccountType()
        {
            Console.WriteLine("ACCOUNT TYPE");
        }
    }

    //derived class SavingsAccount
    class SavingsAccount : BankAccount
    {
        //private variable
        double interestRate;

        //parameterized constructor
        public SavingsAccount(string accountNumber, double balance, double interestRate) : base(accountNumber, balance)
        {
            this.interestRate = interestRate;
        }

        //override DisplayAccountType method
        public override void DisplayAccountType()
        {
            Console.WriteLine("\nSAVINGS ACCOUNT DETAILS: ");

            Console.WriteLine("ACCOUNT TYPE: SAVINGS ACCOUNT");

            Console.WriteLine("BALANCE: " + balance);

            Console.WriteLine("INTEREST RATE: " + interestRate);
        }
    }

    //derived class CheckingAccount
    class CheckingAccount : BankAccount
    {
        //private variable
        double withdrawalLimit;

        //parameterized constructor
        public CheckingAccount(string accountNumber, double balance, double withdrawalLimit) : base(accountNumber, balance)
        {
            this.withdrawalLimit = withdrawalLimit;
        }

        //override DisplayAccountType method
        public override void DisplayAccountType()
        {
            Console.WriteLine("\nCHECKING ACCOUNT DETAILS: ");

            Console.WriteLine("ACCOUNT TYPE: CHECKING ACCOUNT");

            Console.WriteLine("BALANCE: " + balance);

            Console.WriteLine("WITHDRAWAL LIMIT: " + withdrawalLimit);
        }
    }

    //derived class FixedDepositAccount
    class FixedDepositAccount : BankAccount
    {
        //private variable
        int tenure;

        //parameterized constructor
        public FixedDepositAccount(string accountNumber, double balance, int tenure) : base(accountNumber, balance)
        {
            this.tenure = tenure;
        }

        //override DisplayAccountType method
        public override void DisplayAccountType()
        {
            Console.WriteLine("\nFIXED DEPOSIT ACCOUNT DETAILS: ");

            Console.WriteLine("ACCOUNT TYPE: FIXED DEPOSIT ACCOUNT");

            Console.WriteLine("BALANCE: " + balance);

            Console.WriteLine("TENURE: " + tenure);
        }
    }

    //class containing Main method
    class Program
    {
        public static void Main(string[] args)
        {
            //call the TakeInputs method
            TakeInputs();
        }

        //method to take user inputs 
        public static void TakeInputs()
        {
            //take input for savings account number
            Console.Write("ENTER ACCOUNT NUMBER: ");
            string accountNumber = Console.ReadLine();

            //take input for savings account balance
            Console.Write("ENTER BALANCE: ");
            double accountBalance = Convert.ToDouble(Console.ReadLine());

            //take input for interest rate
            Console.Write("ENTER INTEREST RATE: ");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            //create object of SavingsAccount class
            BankAccount savingsAccount = new SavingsAccount(accountNumber, accountBalance, interestRate);

            //take input for checking account number
            Console.Write("\nENTER CHECKING ACCOUNT NUMBER: ");
            string accountNumber2 = Console.ReadLine();

            //take balance for checking account
            Console.Write("ENTER CHECKING ACCOUNT BALANCE: ");
            double accountBalance2 = Convert.ToDouble(Console.ReadLine());

            //take input for withdrawal limit
            Console.Write("ENTER WITHDRAWAL LIMIT: ");
            double withdrawalLimit = Convert.ToDouble(Console.ReadLine());

            //create object of CheckingAccount class
            BankAccount checkingAccount = new CheckingAccount(accountNumber2, accountBalance2, withdrawalLimit);

            //take input for fixed deposit account number
            Console.Write("\nENTER FIXED DEPOSIT ACCOUNT NUMBER: ");
            string accountNumber3 = Console.ReadLine();

            //take input for fixed account balance
            Console.Write("ENTER FIXED DEPOSIT ACCOUNT BALANCE: ");
            double accountBalance3 = Convert.ToDouble(Console.ReadLine());

            //take input for tenure
            Console.Write("ENTER  TENURE: ");
            int tenure = Convert.ToInt32(Console.ReadLine());

            //create object of FixedDepositAccount class
            BankAccount fixedDepositAccount = new FixedDepositAccount(accountNumber3, accountBalance3, tenure);

            //call DisplayAccountType method using each object

            savingsAccount.DisplayAccountType();

            checkingAccount.DisplayAccountType();

            fixedDepositAccount.DisplayAccountType();

        }
    }
}
