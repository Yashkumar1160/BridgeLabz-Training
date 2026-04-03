using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.loan_buddy
{
    internal class LoanUtilityImpl : IApprovable 
    {
        //array to store applicants
        private static Applicant[] applicants = new Applicant[100];

        //variable to store total applicants count
        private static int totalApplicants = 0;

        //create object for LoanUtilityImpl class
        static LoanUtilityImpl utility = new LoanUtilityImpl();


        //method to process loan
        public static void ProcessLoan(LoanApplication loanApplication)
        {
            //add applicant
            Applicant applicant = AddApplicant();

            //call ApproveLoan method
            bool approved = utility.ApproveLoan(applicant);

            //check if loan approved
            if (!approved)
            {
                Console.WriteLine("LOAN REJECTED");
                return;
            }

            //call CalculateEMI method
            double emi = utility.CalculateEMI(applicant.LoanAmount,loanApplication.InterestRate,loanApplication.TermMonths);


            //display loan details
            DisplayLoanDetails(applicant, loanApplication, emi);
        }


        //method to approve or reject loan
        public bool ApproveLoan(Applicant applicant)
        {
            //required income and credit score
            int income = 25000;
            int creditScore = 650;

            //check for income and credit score
            return applicant.Income >= income && applicant.CreditScore >= creditScore;
        }


        //method to calculate emi for loan
        public double CalculateEMI(double P, double R, int N)
        {
            //calculate monthly rate
            double monthlyRate = R / 12;

            //calculate emi
            double emi= (P * monthlyRate * Math.Pow(1 + monthlyRate, N)) / (Math.Pow(1 + monthlyRate, N) - 1);

            return emi;
        }


        //method to add applicant
        private static Applicant AddApplicant()
        {
            //take name input
            Console.Write("ENTER NAME: ");
            string name = Console.ReadLine();

            //take credit score input
            Console.Write("ENTER CREDIT SCORE: ");
            int creditScore = Convert.ToInt32(Console.ReadLine());

            //take income input
            Console.Write("ENTER INCOME: ");
            double income = Convert.ToDouble(Console.ReadLine());

            //take loan amount input
            Console.Write("ENTER LOAN AMOUNT: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            //create object and add applicant to array
            Applicant applicant = new Applicant(name, creditScore, income, amount);
            applicants[totalApplicants] = applicant;

            //update total applicant count
            totalApplicants++;

            return applicant;
        }


        //method to display loan details
        private static void DisplayLoanDetails(Applicant applicant, LoanApplication loanApplication, double emi)
        {
            Console.WriteLine(applicant);

            Console.WriteLine("LOAN TYPE: " + loanApplication.LoanType);
            
            Console.WriteLine("TERM MONTHS: " + loanApplication.TermMonths);
            
            Console.WriteLine("INTEREST RATE: " + loanApplication.InterestRate);
            
            Console.WriteLine("MONTHLY EMI: " + Math.Round(emi, 2));
            
            Console.WriteLine("LOAN APPROVED");
        }
    }
}
