using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_management_system
{
    internal class Hospital
    {
        //variable to store hospital name
        static string hospitalName = "CITY HOSPITAL";

        //array to store patients 
        Patient[]patients=new Patient[100];

        //variable to total patients count
        int totalPatient = 0;

        //parameterized constructor
        public void AddPatient(Patient patient)
        {
            patients[totalPatient] = patient;
            totalPatient++;
        }

        //method to find patient 
        public Patient FindPatient(string patientId)
        {
            for (int i = 0; i < totalPatient; i++)
            {
                if (patients[i].GetPatientId() == patientId)
                {
                    return patients[i];
                }
            }
            return null;
        }

        //method to display all patients
        public void ViewAllPatients()
        {
            for(int i = 0;i <totalPatient; i++)
            {
                patients[i].DisplayPatientInfo();
            }
        }
    }
}
