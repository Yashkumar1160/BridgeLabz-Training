using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.patient
{
    public interface IPatient
    {
        //UC-1.1->Register New Patient
        void RegisterPatient();

        //UC-1.2->Update Patient Information
        void UpdatePatient();

        //UC-1.3->Search Patient Records
        void SearchPatient();
        
        //UC-1.4->View Patient History
        void ViewPatientHistory();
    }
}