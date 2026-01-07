using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.hospital_management_system
{
    internal interface IMedicalRecord
    {
        //method to add patient record
        void AddRecord(string record);

        //method to view patient record
        void ViewRecords();
    }
}
