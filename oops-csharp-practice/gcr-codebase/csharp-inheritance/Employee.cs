using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class Employee
    internal class Employee
    {
        //protected variables
        protected string name;

        protected int id;

        protected double salary;

        //parameterized constructor 
        public Employee(string name, int id, double salary)
        {
            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        //method to display details of an employee
        public virtual void DisplayDetails()
        {
            Console.WriteLine("NAME: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("SALARY: " + salary);

        }

    }

    //derived class Manager
    class Manager : Employee
    {
        //private variable
        int teamSize;

        //parameterized constructor 
        public Manager(string name, int id, double salary, int teamSize) : base(name, id, salary)
        {
            this.teamSize = teamSize;
        }

        //override DisplayDetails method
        public override void DisplayDetails()
        {
            //call base class DisplayDetails method
            base.DisplayDetails();

            Console.WriteLine("TEAM SIZE: " + teamSize);
        }
    }

    //derived class Developer
    class Developer : Employee
    {
        //private variable
        string programmingLanguage;

        //parameterized constructor 
        public Developer(string name, int id, double salary, string programmingLanguage) : base(name, id, salary)
        {
            this.programmingLanguage = programmingLanguage;
        }

        //override DisplayDetails method
        public override void DisplayDetails()
        {
            //call base class DisplayDetails method
            base.DisplayDetails();

            Console.WriteLine("PROGRAMMING LANGUAGE: " + programmingLanguage);
        }
    }

    //derived class Intern
    class Intern : Employee
    {
        //private variable
        string internshipDuration;

        //parameterized constructor 
        public Intern(string name, int id, double salary, string internShipDuration) : base(name, id, salary)
        {
            this.internshipDuration = internShipDuration;
        }
        
        //override DisplayDetails method
        public override void DisplayDetails()
        {
            //call base class DisplayDetails method
            base.DisplayDetails();

            Console.WriteLine("DURATION: " + internshipDuration);
        }
    }

    //class containing Main method
    class Program
    {
        public static void Main(string[] args)
        {
            //call the TakeInputs method
            TakeInputs();
        }

        //method to take user inputs
        public static void TakeInputs()
        {
            //take manager name input
            Console.Write("ENTER MANAGER NAME: ");
            string managerName = Console.ReadLine();

            //take manager id input
            Console.Write("ENTER MANAGER ID: ");
            int managerId = Convert.ToInt32(Console.ReadLine());

            //take manager salary input
            Console.Write("ENTER MANAGER SALARY: ");
            double managerSalary = Convert.ToDouble(Console.ReadLine());

            //take team size input
            Console.Write("ENTER TEAM SIZE: ");
            int teamSize = Convert.ToInt32(Console.ReadLine());

            //create object of Manager class
            Employee manager = new Manager(managerName, managerId, managerSalary, teamSize);

            //take developer name input
            Console.Write("\nENTER DEVELOPER NAME: ");
            string developerName = Console.ReadLine();

            //take developer id input
            Console.Write("ENTER DEVELOPER ID: ");
            int developerId = Convert.ToInt32(Console.ReadLine());

            //take developer salary input
            Console.Write("ENTER DEVELOPER SALARY: ");
            double developerSalary = Convert.ToDouble(Console.ReadLine());

            //take programming language input
            Console.Write("ENTER PROGRAMMING LANGUAGE: ");
            string programmingLanguage = Console.ReadLine();

            //create object of Developer class
            Employee developer = new Developer(developerName, developerId, developerSalary, programmingLanguage);

            //take intern name input
            Console.Write("\nENTER INTERN NAME: ");
            string internName = Console.ReadLine();

            //take intern id input
            Console.Write("ENTER INTERN ID: ");
            int internId = Convert.ToInt32(Console.ReadLine());

            //take intern salary input
            Console.Write("ENTER INTERN SALARY: ");
            double internSalary = Convert.ToDouble(Console.ReadLine());

            //take internship duration input
            Console.Write("ENTER DURATION: ");
            string duration = Console.ReadLine();

            //create object of Intern class
            Employee intern = new Intern(internName, internId, internSalary, duration);

            //display manager details using DisplayDetails method
            Console.WriteLine("\nMANAGER DETAILS: ");
            manager.DisplayDetails();

            //display developer details using DisplayDetails method
            Console.WriteLine("\nDEVELOPER DETAILS: ");
            developer.DisplayDetails();

            //display intern details using DisplayDetails method
            Console.WriteLine("\nINTERN DETAILS: ");
            intern.DisplayDetails();

        }
    }
}
