using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.emergency_patient_navigation
{
    internal interface IAmbulance
    {
        //method to add a unit
        public void AddUnit();

        //method to remove units
        public void RemoveUnit();

        //method to update unit status
        public void UpdateUnitStatus();

        //method to redirect patient to another unit
        public void RedirectPatient();

        //method to display all units 
        public void DisplayUnits();
    }
}
