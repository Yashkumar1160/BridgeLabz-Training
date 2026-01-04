using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_access_modifiers
{
    internal class Employee
    {
        //attributes
        public string employeeId;

        protected string department;

        private int salary;

        //method to modify salary 
        public void SetSalary(int newSalary)
        {
            //modify salary
            this.salary = newSalary;
        }

        //method to get salary
        public int GetSalary()
        {
            return salary;
        }

        //subclass
        class Manager : Employee
        {
            public static void Main(string[] args)
            {
                //call TakeInputs method
                TakeInputs();
            }

            //---------------TAKE INPUTS---------------
            //method to take inputs from user
            public static void TakeInputs()
            {
                //create object
                Manager manager = new Manager();

                //take employee id 
                Console.WriteLine("\nENTER EMPLOYEE ID: ");
                manager.employeeId = Console.ReadLine();

                //take department input
                Console.WriteLine("ENTER DEPARTMENT: ");
                manager.department = Console.ReadLine();

                //take salary input
                Console.WriteLine("ENTER SALARY: ");
                manager.SetSalary(Convert.ToInt32(Console.ReadLine()));

                manager.DisplayDetails();

            }

            //----------------DISPLAY DETAILS------------------
            //method to display all details 
            public void DisplayDetails()
            {
                Console.WriteLine("\nEMPLOYEE ID: " + employeeId);

                Console.WriteLine("EMPLOYEE DEPARTMENT: " + department);

                Console.WriteLine("EMPLOYEE SALARY: " + GetSalary());
            }
        }
    }
}
