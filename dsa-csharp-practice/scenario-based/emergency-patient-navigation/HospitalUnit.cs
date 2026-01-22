using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.dsa_csharp_practice.scenario_based.emergency_patient_navigation
{
    internal class HospitalUnit
    {
        //attributes
        public string unitName;
        public bool isAvailable;
        public HospitalUnit Next;

        //constructor
        public HospitalUnit(string unitName,bool isAvailable)
        {
            this.unitName = unitName;
            this.isAvailable = isAvailable;
            this.Next = null;
        }

        //override ToString method
        public override string ToString()
        {
            return "\nUnit Name: " + unitName +
                "\nIs Available: " + isAvailable;
        }
    }
}
