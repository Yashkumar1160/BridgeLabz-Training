using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.employee_management_system
{
    internal class FullTimeEmployeeImpl : Employee, IDepartment 
    {
        //variable to store department
        string department;

        //constructor
        public FullTimeEmployeeImpl(int id,string name, double salary) : base(id, name, salary) { }

        //override CalculateSalary method
        public override double CalculateSalary()
        {
            return baseSalary;
        }

        //implementation of AssignDepartment method
        public void AssignDepartment(string department)
        {
            this.department=department;
        }

        //implementation of GetDepartmentDetails method
        public string GetDepartmentDetails()
        {
            return department;
        }

    }
}
