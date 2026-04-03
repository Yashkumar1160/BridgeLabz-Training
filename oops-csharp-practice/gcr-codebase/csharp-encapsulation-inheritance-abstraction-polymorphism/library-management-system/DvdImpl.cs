using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.library_management_system
{
    internal class DvdImpl:LibraryItem, IReservable
    {
        //constructor
        public DvdImpl(int id, string title, string author): base(id, title, author) { }

        //override GetLoadDuration method
        public override int GetLoanDuration()
        {
            return 3; 
        }

        //implementation of method to reserve item
        public void ReserveItem(string borrowerName)
        {
            if (!IsReserved())
            {
                SetReservation(borrowerName);
                Console.WriteLine("DVD RESERVED");
            }
            else
            {
                Console.WriteLine("DVD NOT AVAILABLE");
            }
        }

        //implementation of method to check availability
        public bool CheckAvailability()
        {
            return !IsReserved();
        }
    }
}
