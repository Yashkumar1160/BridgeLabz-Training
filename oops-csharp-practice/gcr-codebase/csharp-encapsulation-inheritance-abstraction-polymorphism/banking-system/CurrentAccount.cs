using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.banking_system
{
    internal class CurrentAccount:BankAccount
    {
        //constructor
        public CurrentAccount(int accNo, string name, double bal): base(accNo, name, bal) { }

        //override CalculateInterest method
        public override double CalculateInterest()
        {
            return balance * 0.02;
        }
    }
}
