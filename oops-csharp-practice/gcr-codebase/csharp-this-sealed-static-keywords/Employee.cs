using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_this_sealed_static_keywords
{
    internal class Employee
    {
        //static variables
        public static string companyName = "MARVEL";

        private static int totalEmployees;

        //instance variables

        public readonly string id;

        private string name;

        private string designation;

        //create parameterized constructor
        public Employee(string id, string name, string designation)
        {
            this.id = id;
            this.name = name;
            this.designation = designation;
            totalEmployees++;
        }
        public static void Main(string[] args)
        {
            //call TakeInputs method
            TakeInputs();
        }

        //------------TAKE INPUTS-----------------
        //method to take user inputs
        public static void TakeInputs()
        {
            //display company name
            Console.WriteLine(companyName);

            //take id input
            Console.Write("ENTER ID:");
            string id = Console.ReadLine();

            //take name input
            Console.Write("ENTER NAME: ");
            string name = Console.ReadLine();

            //take designation input
            Console.Write("ENTER DESIGNATION: ");
            string designation = Console.ReadLine();

            //create object
            Employee employee = new Employee(id, name, designation);


            //check if object is of class type
            if (employee is Employee)
            {
                employee.DisplayDetails();
                DisplayTotalEmployees();

            }
        }

        //--------------DISPLAY DETAILS----------------
        //method to display all details
        public void DisplayDetails()
        {
            Console.WriteLine("\nEMPLOYEE DETAILS: ");

            Console.WriteLine("EMPLOYEE NAME: " + name);

            Console.WriteLine("EMPLOYEE ID: " + id);

            Console.WriteLine("EMPLOYEE DESIGNATION: " + designation);
        }

        //----------DISPLAY TOTAL EMPLOYEES---------------
        //method to display total employees
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("\nTOTAL EMPLOYEES: " + totalEmployees);
        }

    }
}
