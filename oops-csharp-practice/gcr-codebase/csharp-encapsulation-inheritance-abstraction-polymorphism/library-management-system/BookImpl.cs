using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.library_management_system
{
    internal class BookImpl : LibraryItem, IReservable 
    {
        //constructor
        public BookImpl(int id, string title, string author): base(id, title, author) { }

        //override GetLoadDuration method
        public override int GetLoanDuration()
        {
            return 14; 
        }

        //implementation of method to reserve item
        public void ReserveItem(string borrowerName)
        {
            //check if item is reserved
            if (!IsReserved())
            {
                SetReservation(borrowerName);

                Console.WriteLine("BOOK RESERVED SUCCESSFULLY");
            }
            else
            {
                Console.WriteLine("BOOK ALREADY RESERVED");
            }
        }

        //implementation of method to check availability
        public bool CheckAvailability()
        {
            return !IsReserved();
        }
    }
}
