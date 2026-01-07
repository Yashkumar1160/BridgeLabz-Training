using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.banking_system
{
    internal class SavingsAccountImpl : BankAccount, ILoanable 
    {
        //constructor
        public SavingsAccountImpl(int accNo, string name, double bal): base(accNo, name, bal) { }

        //override CalculateInterest method
        public override double CalculateInterest()
        {
            return balance * 0.04;
        }

        //implementation of ApplyForLoan method
        public void ApplyForLoan()
        {
            Console.WriteLine("Loan Applied (Savings Account)");
        }

        //implementation of CalculateLoanEligibility method
        public double CalculateLoanEligibility()
        {
            return balance * 5;
        }
    }
}
