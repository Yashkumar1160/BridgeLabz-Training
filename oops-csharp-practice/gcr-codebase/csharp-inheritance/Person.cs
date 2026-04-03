using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_inheritance
{
    //base class Person
    internal class Person
    {
        //protected variables
        protected string name;

        protected int age;

        //parameterized constructor
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //method to display person role
        public virtual void DisplayRole()
        {
            Console.WriteLine("ROLE: PERSON");
        }
    }

    //derived class Teacher
    class Teacher : Person
    {
        //private variable
        string subject;

        //parameterized constructor
        public Teacher(string name, int age, string subject) : base(name, age)
        {
            this.subject = subject;
        }

        //override DisplayRole method
        public override void DisplayRole()
        {
            Console.WriteLine("\nTEACHER NAME: " + name);

            Console.WriteLine("TEACHER AGE: " + age);

            Console.WriteLine("ROLE: TEACHER");

            Console.WriteLine("SUBJECT: " + subject);
        }
    }

    //derived class Student
    class Student : Person
    {
        //private variable grade
        string grade;

        //parameterized constructor
        public Student(string name, int age, string grade) : base(name, age)
        {
            this.grade = grade;
        }

        //override DisplayRole method
        public override void DisplayRole()
        {
            Console.WriteLine("\nSTUDENT NAME: " + name);

            Console.WriteLine("STUDENT AGE: " + age);

            Console.WriteLine("ROLE: STUDENT");

            Console.WriteLine("GRADE: " + grade);
        }
    }

    //derived class Staff
    class Staff : Person
    {
        //private variable
        string department;

        //parameterized constructor
        public Staff(string name, int age, string department) : base(name, age)
        {
            this.department = department;
        }

        //override DisplayRole method
        public override void DisplayRole()
        {
            Console.WriteLine("\nSTAFF NAME: " + name);

            Console.WriteLine("STAFF AGE: " + age);

            Console.WriteLine("ROLE: STAFF");

            Console.WriteLine("DEPARTMENT: " + department);
        }
    }

    //class containing Main method
    class Program
    {
        public static void Main(string[] args)
        {
            //call TakeInputs method
            TakeInputs();
        }

        //method to take user inputs
        public static void TakeInputs()
        {
            //take teacher name input
            Console.Write("ENTER TEACHER NAME: ");
            string teacherName = Console.ReadLine();

            //take teacher age input
            Console.Write("ENTER TEACHER AGE: ");
            int teacherAge = Convert.ToInt32(Console.ReadLine());

            //take subject input
            Console.Write("ENTER SUBJECT: ");
            string subject = Console.ReadLine();

            //create object of Teacher class
            Person teacher = new Teacher(teacherName, teacherAge, subject);

            //take student name input
            Console.Write("\nENTER STUDENT NAME: ");
            string studentName = Console.ReadLine();

            //take student age input
            Console.Write("ENTER STUDENT AGE: ");
            int studentAge = Convert.ToInt32(Console.ReadLine());

            //take student grade input
            Console.Write("ENTER GRADE: ");
            string grade = Console.ReadLine();

            //create object of class Student
            Person student = new Student(studentName, studentAge, grade);

            //take staff name input
            Console.Write("\nENTER STAFF NAME: ");
            string staffName = Console.ReadLine();

            //take staff age input
            Console.Write("ENTER STAFF AGE: ");
            int staffAge = Convert.ToInt32(Console.ReadLine());

            //take staff department input
            Console.Write("ENTER DEPARTMENT: ");
            string department = Console.ReadLine();

            //create object of class Staff
            Person staff = new Staff(staffName, staffAge, department);

            //call DisplayRole method using different objects
            teacher.DisplayRole();

            student.DisplayRole();

            staff.DisplayRole();
        }
    }
}
