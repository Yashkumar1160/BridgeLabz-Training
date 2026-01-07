using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.hospital_management_system
{
    internal class HospitalManager
    {
        //array to store patients
        private Patient[] patients = new Patient[50];

        //variable to store total patients count
        private int count = 0;

        //method to add patient
        public void AddPatient(Patient patient)
        {
            patients[count++] = patient;
        }

        //method to display all patients
        public void DisplayAllPatients()
        {
            if (count == 0)
            {
                Console.WriteLine("No patients added yet.");
                return;
            }

            for (int i = 0; i < count; i++)
            {
                patients[i].GetPatientDetails();
                Console.WriteLine("TOTAL BILL: " + patients[i].CalculateBill());
            }
        }

        //method to find patient
        public Patient FindPatient(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (patients[i].PatientId == id)
                    return patients[i];
            }
            return null;
        }
    }
}
