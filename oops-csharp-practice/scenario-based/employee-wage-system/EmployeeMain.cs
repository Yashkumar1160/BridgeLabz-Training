using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_system
{
    internal class EmployeeMain
    {
        public static void Main(string[] args)
        {
            Start();
        }

        //method to display menu
        public static void Start()
        {
            EmployeeMenu.ShowMenu();
        }
    }
}
