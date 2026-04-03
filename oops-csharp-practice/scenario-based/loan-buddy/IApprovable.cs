using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.loan_buddy
{
    internal interface IApprovable
    {
        //method to approve loan
        bool ApproveLoan(Applicant applicant);

        //method to calculate emi
        double CalculateEMI(double principal, double rate, int months);
    }
}
