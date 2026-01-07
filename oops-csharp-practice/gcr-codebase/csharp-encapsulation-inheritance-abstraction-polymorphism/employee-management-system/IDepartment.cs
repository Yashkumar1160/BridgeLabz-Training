using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.employee_management_system
{
    internal interface IDepartment
    {
        //method to assign department
        void AssignDepartment(string departmentName);

        //method to get department details
        string GetDepartmentDetails();
    }
}
