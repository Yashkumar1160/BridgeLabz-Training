using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.employee_management_system
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Start();
        }

        //method to start program
        public static void Start()
        {
            //create object of EmployeeManager class
            EmployeeManager manager = new EmployeeManager();

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\n1. ADD FULL TIME EMPLOYEE");
                Console.WriteLine("2. ADD PART TIME EMPLOYEE");
                Console.WriteLine("3. VIEW EMPLOYEE");
                Console.WriteLine("4. EXIT");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        //take emp id
                        Console.Write("\nENTER EMPLOYEE ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        //take emp name
                        Console.Write("ENTER EMPLOYEE NAME: ");
                        string name = Console.ReadLine();

                        //take emp salary
                        Console.Write("ENTER SALARY: ");
                        double salary = Convert.ToDouble(Console.ReadLine());

                        //take emp department
                        Console.Write("ENTER DEPARTMENT: ");
                        string department = Console.ReadLine();

                        //create object of class FullTimeEmployeeImpl 
                        FullTimeEmployeeImpl fullTimeEmployee = new FullTimeEmployeeImpl(id, name, salary);

                        //assign department
                        fullTimeEmployee.AssignDepartment(department);

                        //add employee
                        manager.AddEmployee(fullTimeEmployee);

                        Console.WriteLine("EMPLOYEE ADDED");

                        break;

                    case 2:
                        //take emp id
                        Console.Write("\nENTER EMPLOYEE ID: ");
                        int partTimeId = Convert.ToInt32(Console.ReadLine());

                        //take emp name
                        Console.Write("ENTER EMPLOYEE NAME: ");
                        string partTimeName = Console.ReadLine();

                        //take emp salary
                        Console.Write("ENTER HOURLY SALARY: ");
                        double partTimeSalary = Convert.ToDouble(Console.ReadLine());

                        //take hours
                        Console.Write("ENTER HOURS: ");
                        int hours = Convert.ToInt32(Console.ReadLine());

                        //take emp department
                        Console.Write("ENTER DEPARTMENT: ");
                        string partTimeDepartment = Console.ReadLine();

                        //create object of class PartTimeEmployeeImpl 
                        PartTimeEmployeeImpl partTimeEmployee = new PartTimeEmployeeImpl(partTimeId, partTimeName, partTimeSalary, hours);

                        //assign department
                        partTimeEmployee.AssignDepartment(partTimeDepartment);

                        //add employee
                        manager.AddEmployee(partTimeEmployee);

                        Console.WriteLine("EMPLOYEE ADDED");

                        break;

                    case 3:
                        Console.WriteLine("\nEMPLOYEE DETAILS:");
                        manager.ViewAllEmployees();
                        break;

                    case 4:
                        Console.WriteLine("\nTHANKYOU");
                        return;

                    default:
                        Console.WriteLine("\nINVALID INPUT");
                        break;

                }
            }
        }
    }
}
