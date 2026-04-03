using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_constructors.level_1
{
    internal class Person
    {
        //attributes to store data

        string name;

        int age;

        //create parameterized constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //create copy constructor
        public Person(Person person)
        {
            this.name = person.name;
            this.age = person.age;
        }

        public static void Main(string[] args)
        {
            //take name input
            Console.Write("ENTER NAME: ");
            string name = Console.ReadLine();

            //take age input
            Console.Write("ENTER AGE: ");
            int age = Convert.ToInt32(Console.ReadLine());

            //create object using parameterized constructor
            Person Person1 = new Person(name, age);

            //create objecy using copy constructor
            Person Person2 = new Person(Person1);

            //call DisplayDetails Method
            Console.WriteLine("\nUSING PARAMETERIZED CONSTRUCTOR:");
            Person1.DisplayDetails();

            Console.WriteLine("\nUSING COPY CONSTRUCTOR:");
            Person2.DisplayDetails();

        }

        //---------------DISPLAY DETAILS-----------------
        //method to DISPLAY DETAILS of Person
        public void DisplayDetails()
        {
            //display details of person
            Console.WriteLine("Person Name: " + name);

            Console.WriteLine("Person Age: " + age);

        }

    }
}
