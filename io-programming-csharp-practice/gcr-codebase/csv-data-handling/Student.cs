using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BridgeLabzTraining.io_programming_csharp_practice.gcr_codebase.csv_data_handling
{
    internal class Student
    {
        //student properties
        int id;
        string name;
        int age;
        int marks;

        //getter and setter
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

        ////constructor
        //public Student(int id, String name, int age, int marks)
        //{
        //    Id = id;
        //    Name = name;
        //    Age = age;
        //    Marks = marks;
        //}

        //override ToString method
        public override string ToString()
        {
            return "ID: " + Id +
                "\n Name: " + Name +
                "\n Age: " + Age +
                "\n Marks: " + Marks;
        }
    }
}
