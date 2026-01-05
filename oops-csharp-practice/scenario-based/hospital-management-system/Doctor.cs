using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_management_system
{
    internal class Doctor
    {
        //variable to store doctor name
        string name;

        //variable to store doctor's specialization
        string specialization;

        //parameterized constructor
        public Doctor(string name, string specialization)
        {
            this.name = name;
            this.specialization = specialization;
        }

        //method to display doctor details
        public void DisplayDocorDetails()
        {
            Console.WriteLine("\nDOCTOR DETAILS: ");

            Console.WriteLine("\nDOCTOR NAME: "+name);
            
            Console.WriteLine("DOCTOR SPECIALIZATION: "+specialization);
        }
    }
}
