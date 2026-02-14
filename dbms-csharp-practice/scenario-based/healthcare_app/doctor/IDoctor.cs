using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.doctor
{
    public interface IDoctor
    {
        //UC-2.1->Add Doctor Profile
        void AddDoctor();

        //UC-2.2->Assign/Update Doctor Specialty
        void UpdateDoctorSpecialty();
        
        //UC-2.3->View Doctors by Specialty
        void ViewDoctorsBySpecialty();

       //UC-2.4->Deactivate Doctor Profile
        void DeactivateDoctor();
    }
}