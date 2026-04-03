using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.aadhar_numbers_sorting
{
    internal class Person
    {
        //attributes
        string name;
        long aadharNumber;
        int age;
        string gender;


        //getters and setters
        public String PersonName { get; set; }
        public String Gender { get; set; }
        public int Age { get; set; }
        public long AadharNumber { get; set; }

        //constructor
        public Person(string name, int age,string gender, long aadharNumber)
        {
            PersonName=name;
            Age=age;
            Gender=gender;
            AadharNumber=aadharNumber;
        }


        //override ToString method
        public override string ToString()
        {
            return "\nPerson Name: " + PersonName +
                "\nAge: " + Age +
                "\nGender: " + Gender +
                "\nAadhar Number: " + AadharNumber;
        }

    }
}
