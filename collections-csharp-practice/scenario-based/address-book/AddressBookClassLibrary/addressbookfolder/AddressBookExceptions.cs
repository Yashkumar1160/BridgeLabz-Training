using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.contact;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.addressbookfolder
{
    //duplicate address book exception
    public class DuplicateAddressBookException : Exception
    {
        public DuplicateAddressBookException(string message) : base(message)
        {
        }
    }

    //address book not found exception
    public class AddressBookNotFoundException : Exception
    {
        public AddressBookNotFoundException(string message) : base(message)
        {
        }
    }

    //contact not found exception
    public class ContactNotFoundException : Exception
    {
        public ContactNotFoundException(string message) : base(message)
        {
        }
    }

}
