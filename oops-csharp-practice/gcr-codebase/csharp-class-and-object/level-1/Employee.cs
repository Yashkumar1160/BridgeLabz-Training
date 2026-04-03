using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_class_and_object.level_1
{
    internal class Employee
    {
        //attributes to store data
        //name of employee
        private string name;

        //employee id
        private string id;

        //employee salary
        private int salary;

        public static void Main(string[] args)
        {
            //create object
            Employee emp = new Employee();

            //take employee name
            Console.Write("Enter Employee Name: ");

            emp.name = Console.ReadLine();

            //take employee id
            Console.Write("Enter Employee Id: ");

            emp.id = Console.ReadLine();

            //take employee salary
            Console.Write("Enter Employee Salary: ");

            emp.salary = Convert.ToInt32(Console.ReadLine());

            //call DisplayDetails method
            emp.DisplayDetails();
        }

        //----------------DISPLAY DETAILS-----------------
        //method to display the details of employee
        public void DisplayDetails()
        {
            //display details of employee
            Console.WriteLine("EMPLOYEE DETAILS ARE: ");

            Console.WriteLine("Name: " + name);

            Console.WriteLine("Id: " + id);

            Console.WriteLine("Salary: " + salary);
        }
    }
}
