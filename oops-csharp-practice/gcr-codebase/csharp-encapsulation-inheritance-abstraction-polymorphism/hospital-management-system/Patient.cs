using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.hospital_management_system
{
    internal abstract class Patient
    {
        //protected variables
        protected int patientId;
        
        protected string name;
        
        protected int age;

        //private variables
        private string diagnosis;
        private string medicalHistory;

        //getter and setter for patientId
        public int PatientId
        {
            get { return patientId; }
            set { patientId = value; }
        }

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

        //getter and setter for diagnosis
        public void SetDiagnosis(string diag)
        {
            diagnosis = diag;
        }
        public string GetDiagnosis()
        {
            return diagnosis;
        }

        public void SetMedicalHistory(string history)
        {
            medicalHistory = history;
        }
        public string GetMedicalHistory()
        {
            return medicalHistory;
        }

        //constructor
        public Patient(int id, string name, int age)
        {
            this.patientId = id;
            this.name = name;
            this.age = age;
        }

        // Abstract method to calculate bill
        public abstract double CalculateBill();

        // Concrete method to display patient details
        public void GetPatientDetails()
        {
            Console.WriteLine($"\nPATIENT ID: {PatientId}");
            Console.WriteLine($"NAME: {Name}");
            Console.WriteLine($"AGE: {Age}");
            Console.WriteLine($"DIAGNOSIS: {GetDiagnosis()}");
            Console.WriteLine($"MEDICAL HISTORY: {GetMedicalHistory()}");
        }
    }
}
