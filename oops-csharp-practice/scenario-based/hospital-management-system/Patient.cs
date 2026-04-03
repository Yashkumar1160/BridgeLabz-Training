using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.hospital_management_system
{
    abstract class Patient
    {
        //variable to store patient id 
        string patientId;

        //variable to store patient name
        string name;

        //variable to store patient age
        int age;

        //variable to check if patient is admitted or not
        bool isAdmitted;

        //parameterized constructor
        public Patient(string patientId, string name, int age)
        {
            this.patientId = patientId;
            this.name = name;
            this.age = age;
            isAdmitted = true;
        }

        //method to get patient id 
        public string GetPatientId()
        {
            return patientId;
        }

        //method to check if patient is admitted or not
        public bool IsAdmitted()
        {
            return isAdmitted; 
        }

        //method to discharge a patient
        public void Discharge(string patientId)
        {
            isAdmitted = false;
        }


        //abstract method to display patient info
        public abstract void DisplayPatientInfo();
    }
}
