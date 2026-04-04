using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.billing
{
    public interface IBilling
    {
        //UC-5.1 Generate Bill
        void GenerateBill();

        //UC-5.2 Record Payment
        void RecordPayment();

        //UC-5.3 View Outstanding Bills
        void ViewOutstandingBills();

        //UC-5.4 Revenue Report
        void GenerateRevenueReport();
    }
}