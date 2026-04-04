using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dbms_csharp_practice.scenario_based.healthcare_app.specialty
{
    public interface ISpecialty
    {
        void AddSpecialty();
        void UpdateSpecialty();
        void ViewAllSpecialties();
        void DeleteSpecialty();

    }
}