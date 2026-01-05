using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_management_system
{
    internal class Bill
    {
        //method to generate bill
        public static void GenerateBill(IPayable p)
        {
            Console.WriteLine("TOTAL BILL: " + p.CalculateBill());
        }
    }
}
