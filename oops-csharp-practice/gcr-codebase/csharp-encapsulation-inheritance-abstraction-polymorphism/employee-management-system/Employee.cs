using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.employee_management_system
{
    internal abstract class Employee
    {
        //protected variables
        protected int employeeId;

        protected string name;

        protected double baseSalary;

        //getter and setter for employeeId
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }

        //getter and setter for name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //getter and setter for baseSalary
        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }

        //constructor
        public Employee(int employeeId, string name, double baseSalary)
        {
            this.employeeId = employeeId;
            this.name = name;
            this.baseSalary = baseSalary;
        }

        //abstract method to calculate salary
        public abstract double CalculateSalary();

        //concrete method to display details of employee
        public void DisplayDetails()
        {
            Console.WriteLine("\nEMPLOYEE ID: "+EmployeeId);

            Console.WriteLine("EMPLOYEE NAME: " + Name);

            Console.WriteLine("SALARY: " + CalculateSalary());
        }
    }
}