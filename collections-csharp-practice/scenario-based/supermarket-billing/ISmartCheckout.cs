using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.supermarket_billing
{
    internal interface ISmartCheckout
    {
        void AddItem();

        void AddCustomer();

        void GenerateBill();

        double CalculateTotal(Customer customer);
    }
}
