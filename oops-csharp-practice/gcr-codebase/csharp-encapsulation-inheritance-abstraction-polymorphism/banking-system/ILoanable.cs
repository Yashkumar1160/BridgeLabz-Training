using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.banking_system
{
    internal interface ILoanable
    {
        //method to apply for a loan
        void ApplyForLoan();

        //method to calculate loan eligibility
        double CalculateLoanEligibility();
    }
}
