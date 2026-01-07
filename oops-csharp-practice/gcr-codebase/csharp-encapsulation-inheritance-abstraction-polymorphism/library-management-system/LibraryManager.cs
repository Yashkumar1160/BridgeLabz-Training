using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.gcr_codebase.csharp_encapsulation_inheritance_abstraction_polymorphism.library_management_system
{
    internal class LibraryManager
    {
        //array to store items
        LibraryItem[] items = new LibraryItem[50];

        //variable to store total items count
        int count = 0;

        //method to add item
        public void AddItem(LibraryItem item)
        {
            items[count] = item;
            count++;
        }

        //method to display all items
        public void DisplayAllItems()
        {
            for (int i = 0; i < count; i++)
            {
                items[i].GetItemDetails();
                Console.WriteLine("LOAN DURATION: " + items[i].GetLoanDuration() + " DAYS");
            }
        }

        //method to handle reservation
        public bool ReserveItem(int itemId, string borrowerName)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i].ItemId == itemId && items[i] is IReservable reservable)
                {
                    reservable.ReserveItem(borrowerName);
                    return true;
                }
            }
            return false;
        }

    }
}
