using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.loan_buddy
{
    internal class AutoLoan : LoanApplication 
    {
        //constructor
        public AutoLoan(string loanType, int termMonths, double interestRate) : base(loanType, termMonths, interestRate) { }

    }
}
