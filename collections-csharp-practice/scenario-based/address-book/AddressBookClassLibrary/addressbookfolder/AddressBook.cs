using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.contact;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.addressbookfolder
{
    public class AddressBook
    {
        //variable to store address book name
        public string AddressBookName { get;  set; }

        //variable to store contacts utility 
        public ContactsUtilityImpl Utility { get;  set; }

        //constructor
        public AddressBook(string addressBookName)
        {
            AddressBookName = addressBookName;
            Utility = new ContactsUtilityImpl();
        }
    }
}
