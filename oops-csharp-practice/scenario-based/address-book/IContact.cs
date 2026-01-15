using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book
{
    internal interface IContact
    {
        //method to add new contact
        void AddNewContact(Contact contact);

        //method to edit person contact
        void EditPersonContact(string firstName,string lastName);

        //method to delete person contact
        void DeletePersonContact(string firstName,string lastName);

        //method to add mmultiple  contacts
        void AddMultipleContacts(int numberOfContacts);

        //method to check for duplicate contact
        bool CheckContact(string firstName,string lastName);

        //method to find person by state or city
        void SearchByCityOrState(string firstName,string lastName);
    }
}
