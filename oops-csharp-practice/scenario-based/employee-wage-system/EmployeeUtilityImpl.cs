using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_system
{
    internal class EmployeeUtilityImpl : IEmployee 
    {
        //total working days for a month
        public static int workingDays = 20;

        //total working hours 
        public static int workingHours = 100;

        public void CalculateWage(Employee employee)
        {
            //create object of Random class
            Random random = new Random();
                
            employee.totalWorkingDays = 0;

            employee.totalWorkingHours = 0;
            
            employee.totalWage = 0;

            while (employee.totalWorkingDays < workingDays && employee.totalWorkingHours < workingHours)
            {
                //update total working days
                employee.totalWorkingDays++;

                //use random to find a employee type 
                int empType = random.Next(0, 3);

                //initialize hours variable with 0
                int hours = 0;

                //fullday employee
                if (empType == 1)
                {
                    hours = employee.fullDayHours;
                }
                //parttime employee
                else if (empType == 2)
                {
                    hours = employee.partTimeHours;
                }

                //update total working hours
                employee.totalWorkingHours += hours;
                
                //update total wages
                employee.totalWage += hours * employee.wagePerHours;
            }
        }

    }
}
