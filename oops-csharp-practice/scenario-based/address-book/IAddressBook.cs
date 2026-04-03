using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book
{
    internal interface IAddressBook
    {
        //method to add address book
        void AddAddressBook(AddressBook addressBook);

        //method to select specific address book
        AddressBook SelectAddressBook(string name);

        //method to search person contact by city or state
        void SearchByCityOrState();
    }
}
