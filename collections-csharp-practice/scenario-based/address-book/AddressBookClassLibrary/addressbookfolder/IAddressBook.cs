using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.contact;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.addressbookfolder
{
    public interface IAddressBook
    {
        //method to add address book
        void AddAddressBook(AddressBook addressBook);

        //method to select specific address book
        AddressBook SelectAddressBook(string name);

        //method to search person contact by city or state
        void SearchByCityOrState();

        //method to display address book
        void DisplayAddressBooks();
    }
}
