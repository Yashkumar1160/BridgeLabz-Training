using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book
{
    internal interface IAddressBook
    {
        //method to add new contact
        void AddNewContact(Contact contact);

        //method to edit person contact
        void EditPersonContact(string firstName,string lastName);

        //method to delete person contact
        void DeletePersonContact(string firstName,string lastName);
    }
}
