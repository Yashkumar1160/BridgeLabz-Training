using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book
{
    //duplicate address book exception
    internal class DuplicateAddressBookException : Exception
    {
        public DuplicateAddressBookException(string message) : base(message)
        {
        }
    }

    //address book not found exception
    internal class AddressBookNotFoundException : Exception
    {
        public AddressBookNotFoundException(string message) : base(message)
        {
        }
    }

    //contact not found exception
    internal class ContactNotFoundException : Exception
    {
        public ContactNotFoundException(string message) : base(message)
        {
        }
    }

}
