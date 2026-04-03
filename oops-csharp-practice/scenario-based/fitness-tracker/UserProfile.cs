using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.fitness_tracker
{
    internal class UserProfile
    {
        //variable to store user name
        private string name;

        //variable to store user age
        private int age;

        //variable to store user gender
        private string gender;

        //variable to store user height
        private double height;

        //variable to store user weight
        private double weight;

        //getter and setter for name
        public string Name
        {
            get { return name; } 
            set { name = value; }
        }

        //getter and setter for age
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //getter and setter for gender
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        //getter and setter for height
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        //getter and setter for weight
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        //constructor
        public UserProfile(string name,int age,string gender,double height,double weight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Height = height;
            Weight = weight;
        }

        //override ToString method 
        public override string ToString()
        {
            Console.WriteLine("\nUSER DETAILS: ");
            return "\nNAME: " + Name +
                "\nAGE: " + Age +
                "\nGENDER: " + Gender +
                "\nHEIGHT: " + Height +
                "\nWEIGHT: " + Weight;
        }
    }
}
