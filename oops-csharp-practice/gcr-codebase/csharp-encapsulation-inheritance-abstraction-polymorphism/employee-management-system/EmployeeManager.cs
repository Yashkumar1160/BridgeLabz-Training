using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.employee_management_system
{
    internal class EmployeeManager
    {
        //array to store employees
        Employee[]employees=new Employee[100];

        //variable to store total employee count
        int totalEmployees = 0;

        //method to add employee
        public void AddEmployee(Employee employee)
        {
            employees[totalEmployees++] = employee;
        }


        //method to view all employees
        public void ViewAllEmployees()
        {
            for(int i = 0; i < totalEmployees; i++)
            {
                employees[i].DisplayDetails();

                if (employees[i] is IDepartment dept)
                {
                    Console.WriteLine("DEPARTMENT: " + dept.GetDepartmentDetails());
                }
            }
        }
    }
}
