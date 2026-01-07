using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.employee_wage_system
{
    internal class EmployeeMenu
    {
        //array to store employees
        static Employee[] employees = new Employee[100];

        //variable to store total count of employees        
        static int totalEmployees = 0;

        //method to display menu
        public static void ShowMenu()
        {
            //infinite loop until user exits
            while (true)
            {
                //display menu
                Console.WriteLine("--------WELCOME TO EMPLOYEE WAGE COMPUTATION PROGRAM--------");
                Console.WriteLine("\n1. ADD EMPLOYEE");
                Console.WriteLine("2. COMPUTE EMPLOYEE WAGE");
                Console.WriteLine("3. DISPLAY EMPLOYEE DETAILS");
                Console.WriteLine("4. EXIT");
                Console.Write("ENTER CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;

                    case 2:
                        CalculateWage();
                        break;

                    case 3:
                        DisplayEmployees();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            }
        }

        //method to add an employee
        private static void AddEmployee()
        {
            //create instance of concrete employee class
            Employee emp = new EmployeeImpl();

            //take employee id input
            Console.Write("ENTER EMPLOYEE ID: ");
            string id = Console.ReadLine();

            //take employee name input
            Console.Write("ENTER EMPLOYEE NAME: ");
            string name = Console.ReadLine();

            //take employee department input
            Console.Write("ENTER DEPARTMENT: ");
            string dept = Console.ReadLine();

            //take employee company name input
            Console.Write("ENTER COMPANY NAME: ");
            string company = Console.ReadLine();

            //set employee details
            emp.SetEmployeeDetails(id, name, dept, company);

            //store employee in array
            employees[totalEmployees] = emp;
            totalEmployees++;

            Console.WriteLine("EMPLOYEE ADDED");
        }

        //method to calculate wage
        private static void CalculateWage()
        {
            //create object of EmployeeUtilityImpl
            EmployeeUtilityImpl utilityImpl=new EmployeeUtilityImpl();

            //loop to claculate wage for each employee
            for (int i = 0; i < totalEmployees; i++)
            {
                utilityImpl.CalculateWage(employees[i]);
            }

            Console.WriteLine("WAGE CALCULATED");
        }

        //method to display all employees 
        private static void DisplayEmployees()
        {
            for (int i = 0; i < totalEmployees; i++)
            {
                employees[i].DisplayEmployeeDetails();

                employees[i].DisplayWageDetails();
            }
        }
    }
}
