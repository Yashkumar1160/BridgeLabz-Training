using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.visit_management
{
    public interface IVisit
    {
        void RecordPatientVisit();
        void ViewPatientMedicalHistory();
        void AddPrescription();
    }
}