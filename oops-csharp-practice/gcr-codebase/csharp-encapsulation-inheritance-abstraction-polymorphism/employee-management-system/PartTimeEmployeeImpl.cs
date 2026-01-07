using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.employee_management_system
{
    internal class PartTimeEmployeeImpl:Employee
    {
        //variable to store hours worked
        private int hoursWorked;

        //variable to store department
        string department;

        //getter and setter
        public int HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        //constructor
        public PartTimeEmployeeImpl(int id, string name, double rate, int hours) : base(id, name, rate)
        {
            hoursWorked = hours; 
        }

        //override CalculateSalary method
        public override double CalculateSalary()
        {
            return baseSalary * hoursWorked;
        }

        //implementation of AssignDepartment method
        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        //implementation of GetDepartmentDetails method
        public string GetDepartmentDetails()
        {
            return department;
        }
    }
}
