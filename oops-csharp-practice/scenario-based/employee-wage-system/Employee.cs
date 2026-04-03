using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_system
{
    internal class Employee
    {
        //variable to store employee id
        protected string employeeId;
        
        //variable to store employee name
        protected string employeeName;
        
        //variable to store employee department
        protected string department;
        
        //variable to store company name
        protected string companyName;

        //variable to store wage per hours
        public int wagePerHours = 20;
        
        //variable to store full day hours
        public int fullDayHours = 8;
        
        //variable to store part time hours
        public int partTimeHours = 4;

        //variable to store total working days
        public int totalWorkingDays;
        
        //variable to store total working hours
        public int totalWorkingHours;
        
        //variable to store total wage of an employee
        public int totalWage;

        //method to set employee details
        public void SetEmployeeDetails(string id, string name, string dept, string company)
        {
            employeeId = id;
            employeeName = name;
            department = dept;
            companyName = company;
        }

        //method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("\nEMPLOYEE ID      : " + employeeId);
         
            Console.WriteLine("EMPLOYEE NAME    : " + employeeName);
            
            Console.WriteLine("DEPARTMENT       : " + department);
            
            Console.WriteLine("COMPANY NAME     : " + companyName);
        }

        //method to display wages details
        public void DisplayWageDetails()
        {
            Console.WriteLine("WORKING DAYS  : " + totalWorkingDays);
            
            Console.WriteLine("WORKING HOURS : " + totalWorkingHours);
            
            Console.WriteLine("TOTAL WAGE    : " + totalWage);
        }

    }
}
