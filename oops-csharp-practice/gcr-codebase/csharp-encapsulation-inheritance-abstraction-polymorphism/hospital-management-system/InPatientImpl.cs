using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.hospital_management_system
{
    internal class InPatientImpl : Patient, IMedicalRecord 
    {
        //variable to store days 
        private int daysAdmitted;

        //array to store records
        private string[] records = new string[50];

        //variable to store record count
        private int recordCount = 0;

        //constructor
        public InPatientImpl(int id, string name, int age, int days) : base(id, name, age)
        {
            daysAdmitted = days;
        }

        //override CalculateBill method
        public override double CalculateBill()
        {
            double roomCharge = 500; // per day
            double total = roomCharge * daysAdmitted;
            return total;
        }

        //implementation of AddRecord method
        public void AddRecord(string record)
        {
            records[recordCount++] = record;
            Console.WriteLine("Record added successfully!");
        }

        //implementation of ViewRecords method
        public void ViewRecords()
        {
            if (recordCount == 0)
            {
                Console.WriteLine("No records available.");
                return;
            }

            Console.WriteLine("Medical Records:");
            for (int i = 0; i < recordCount; i++)
            {
                Console.WriteLine($"- {records[i]}");
            }
        }
    }
}
