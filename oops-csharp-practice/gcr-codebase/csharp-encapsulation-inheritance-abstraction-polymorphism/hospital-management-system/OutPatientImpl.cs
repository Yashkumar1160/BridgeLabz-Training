using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.hospital_management_system
{
    internal class OutPatientImpl : Patient, IMedicalRecord 
    {
        //array to store records
        private string[] records = new string[50];

        //variable to store total records count
        private int recordCount = 0;

        //constructor
        public OutPatientImpl(int id, string name, int age) : base(id, name, age) { }

        //override CalculateBill method
        public override double CalculateBill()
        {
            double consultationFee = 300;
            return consultationFee;
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
