using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book
{
    internal class AddressBookUtilityImpl : IAddressBook 
    {
        //array to store contacts
        private Contact[]addressBook=new Contact[100];

        //variable to store total contacts count
        int totalContacts = 0;

        //implementation of AddNewContact method to add new contact
        public void AddNewContact(Contact contact)
        {
            addressBook[totalContacts] = contact;
            totalContacts++;
        }

        //method to display all contacts
        public void DisplayContacts()
        {
            if(totalContacts == 0)
            {
                Console.Write("NO CONTACT ADDED YET");
                return;
            }

            for(int i=0; i<totalContacts; i++)
            {
                Console.WriteLine(addressBook[i]);
            }
        }
    }
}
