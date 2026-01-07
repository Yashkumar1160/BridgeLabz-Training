using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.library_management_system
{
    internal interface IReservable
    {
        //method to reserce item
        void ReserveItem(string borrowerName);

        //method to check item availability
        bool CheckAvailability();
    }
}
