using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.library_management_system
{
    internal class MagazineImpl : LibraryItem, IReservable 
    {
        //constructor
        public MagazineImpl(int id, string title, string author): base(id, title, author) { }


        //override method to GetLoanDuration
        public override int GetLoanDuration()
        {
            return 7; // 7 days
        }

        //implementation of method to reserve item
        public void ReserveItem(string borrowerName)
        {
            if (!IsReserved())
            {
                SetReservation(borrowerName);
                Console.WriteLine("MAGAZINE RESERVED");
            }
            else
            {
                Console.WriteLine("MAGAZINE NOT AVAILABLE");
            }
        }

        //implementation of method to check item availability
        public bool CheckAvailability()
        {
            return !IsReserved();
        }
    }
}
