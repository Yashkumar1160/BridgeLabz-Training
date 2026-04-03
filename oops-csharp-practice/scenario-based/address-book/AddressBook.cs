using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book
{
    internal class AddressBook
    {
        //variavle to store address book name
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
