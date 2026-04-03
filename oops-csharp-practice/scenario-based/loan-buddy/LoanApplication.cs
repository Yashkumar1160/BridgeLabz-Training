using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.loan_buddy
{
    internal abstract class LoanApplication
    {
        //variable to store loan typs
        protected string loanType;

        //variable to store term months
        protected int termMonths;

        //variable to store interest rate
        protected double interestRate;

        //getter for loanType
        public string LoanType
        {
            get { return loanType; }
        }

        //getter for termMonths
        public int TermMonths
        {
            get { return termMonths; }
        }

        //getter for interestRate
        public double InterestRate
        {
            get { return interestRate; }
        }

        //constructor
        protected LoanApplication(string loanType, int termMonths, double interestRate)
        {
            this.loanType = loanType;
            this.termMonths = termMonths;
            this.interestRate = interestRate;
        }
    }
}
