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

        //method to add multiple  contacts
        void AddMultipleContacts(int numberOfContacts);

        //method to check for duplicate contact
        bool CheckContact(string firstName,string lastName);

        //method to find person by state or city
        void SearchByCityOrState(string firstName,string lastName);

        //method to display contacts by city
        void DisplayContactsWithCity();

        //method to display contacts by state
        void DisplayContactsWithState();

        //method to display contacts count by city
        void DisplayCityCount();

        //method to display contacts count by state 
        void DisplayStateCount();

        //method to sort contacts by person name
        void SortByPersonName();

        //method to sort contacts by city
        void SortByCity();
        //method to sort contacts by city
        void SortByState();

        //method to sort contacts by city
        void SortByZip();
    }
}
