using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace techville.modules
{
    public class Citizen
    {
        //properties
        public string Name;
        public int Age;
        public double Income;

        public int ResidencyYears;

        //M-2 Service Eligibility Checker
        public string ServicePackage;
        public Citizen(string name,int age,double income,int residencyYears,string servicePackage)
        {
            Name=name;
            Age=age;
            Income=income;
            ResidencyYears=residencyYears;
            ServicePackage=servicePackage;
        }

        //override ToString method
        public override string ToString()
        {
            return "\nCitizen Name: "+Name+
            "\nAge: "+Age+
            "\nIncome: "+Income+
            "\nResidency Years: "+ResidencyYears+
            "\nService Package: "+ServicePackage;
;
        }

    }
}