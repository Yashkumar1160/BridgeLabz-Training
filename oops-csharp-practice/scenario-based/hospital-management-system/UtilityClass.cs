using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_management_system
{
    //utility class 
    internal class UtilityClass
    {
        //method to check age input
        public static bool CheckAge(int age)
        {
            return age > 0 && age<110;
        }
    }
}
