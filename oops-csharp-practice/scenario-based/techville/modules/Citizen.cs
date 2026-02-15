using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules
{
    public class Citizen
    {
        //Private fields
        private string name;
        private int age;
        private double income;
        private int residencyYears;
        private string email;
        private string address;
        private string servicePackage;
        public Citizen(string name, int age, double income, int residencyYears, string servicePackage)
        {
            Name = name;
            Age = age;
            Income = income;
            ResidencyYears = residencyYears;
            ServicePackage = servicePackage;
            Email = "";
            Address = "";
        }

        // Public Properties (Getters & Setters)
        public string Name{ get; set; }

        public int Age{ get; set; }

        public double Income{ get; set; }

        public int ResidencyYears{ get; set; }

        public string Email{ get; set; }

        public string Address{ get; set; }

        public string ServicePackage{ get; set; }

        //method to display basic info
        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        //override ToString method
        public override string ToString()
        {
            return "\nCitizen Name: " + Name +
            "\nAge: " + Age +
            "\nIncome: " + Income +
            "\nResidency Years: " + ResidencyYears +
            "\nEmail: " + Email +
            "\nAddress: " + Address +
            "\nService Package: " + ServicePackage;
        }

    }
}