using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.exam_review_system
{
    internal class Student
    {
        //attributes
        int rollNumber;
        string studentName;
        int age;

        //getter and setter
        public string StudentName { get; set; }
        public int Age { get; set; }

        public int RollNumber {  get; set; }

        //constructor
        public Student(int  rollNumber, string studentName, int age)
        {
            StudentName= studentName;
            Age= age;
            RollNumber= rollNumber;
        }


        //override ToString method
        public override string ToString()
        {
            return "Student Name: " + StudentName +
                "\nAge: " + Age + 
                "\nRoll Number: " + RollNumber;
        }
    }
}
