using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.fitness_rankings
{
    internal class Person
    {
        //attributes
        private string personName;
        private int steps;
        private int age;

        //getter and setter
        public string PersonName { get; set; }
        public int Steps { get; set; }

        public int Age { get; set; }

        //constructor
        public Person(string personName, int steps, int age)
        {
            PersonName = personName;
            Steps = steps;
            Age = age;
        }

        //override ToString method
        public override string ToString()
        {
            return "\nPerson Name: " + PersonName +
                "\nSteps: " + Steps+
                "\nAge: "+Age;
        }
    }
}
