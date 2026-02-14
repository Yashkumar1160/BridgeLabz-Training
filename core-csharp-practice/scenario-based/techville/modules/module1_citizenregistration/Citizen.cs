using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules.module1_citizenregistration
{
    public class Citizen
    {
        public string Name;
        public int Age;
        public double Income;

        public int ResidencyYears;

        public Citizen(string name,int age,double income,int residencyYears)
        {
            Name=name;
            Age=age;
            Income=income;
            ResidencyYears=residencyYears;
        }

        public override string ToString()
        {
            return "\nCitizen Name: "+Name+
            "\nAge: "+Age+
            "\nIncome: "+Income+
            "\nResidency Years: "+ResidencyYears;
        }

    }
}