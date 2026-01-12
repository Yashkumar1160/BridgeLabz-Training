using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.loan_buddy
{
    internal class Applicant
    {
        //variable to store name
        private string name;

        //variable to store credit score
        private int creditScore;

        //variable to store income
        private double income;

        //variable to store loan amount
        private double loanAmount;

        //getter and setter for name
        public string Name {
            get {return name; }
            set { name = value;} 
        }

        //getter and setter for credit score
        public int CreditScore
        {
            get { return creditScore; }
            private set { creditScore = value; } 
        }

        //getter and setter for income
        public double Income {
            get { return income; }
            set {  income = value; } 
        }

        //getter and setter for loan amoount
        public double LoanAmount {
            get { return loanAmount; }
            set {  loanAmount = value; } 
        }

        //constructor
        public Applicant(string name, int creditScore, double income, double loanAmount)
        {
            Name = name;
            CreditScore = creditScore;
            Income = income;
            LoanAmount = loanAmount;
        }

        //override ToString method
        public override string ToString()
        {
            return "\nAPPLICANT DETAILS:" +

                   "\nNAME: " + Name +
                
                   "\nCREDIT SCORE: " + creditScore +
                   
                   "\nINCOME: " + Income +
                   
                   "\nLOAN AMOUNT: " + LoanAmount;
        }
    }
}
