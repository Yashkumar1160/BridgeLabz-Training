using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.custom_furniture_manufacturing
{
    internal interface ICalculate
    {
        //method to find revenue with waste
        int FindMaxRevenueWithWaste(int length,int waste);

        //method to find revenue without waste
        int FindMaxRevenue(int rodLength);

        //method to find meximum revenue with minimum waste
        int FindMaxRevenueWithMinWaste(int length);

    }
}
