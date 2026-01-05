using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.car_rental_application
{
    internal class UtilityClass
    {
        //method to check days 
        public static bool CheckDays(int days)
        {
            return days > 0 && days <= 45;
        }
    }
}
