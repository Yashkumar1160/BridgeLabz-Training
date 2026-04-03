using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book
{
    internal class AddressBookUtilityImpl : IAddressBook 
    {
        //dictionary to store address book
        private Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();

        //store current selected address book
        private AddressBook selectedBook;

        //method to add address book
        public void AddAddressBook(AddressBook addressBook)
        {
            //if address book does not exist
            if (addressBooks.ContainsKey(addressBook.AddressBookName))
            {
                Console.WriteLine("ADDRESS BOOK IS ALREADY PRESENT");
                return;
            }

            //add address book to dictionary
            addressBooks.Add(addressBook.AddressBookName.ToLower(), addressBook);

            Console.WriteLine("\nADDRESS BOOK ADDED SUCCESSFULLY");
        }


        //method to select specific address book
        public AddressBook SelectAddressBook(string name)
        {
            //if address book does not exist
            if (!addressBooks.ContainsKey(name.ToLower()))
            {
                Console.WriteLine("ADDRESS BOOK NOT FOUND");
                return null;
            }

            //current address book
            selectedBook = addressBooks[name.ToLower()];
            Console.WriteLine($"ADDRESS BOOK SELECTED -> {name}");
            return selectedBook;
        }


        //method to search person by city or state
        public void SearchByCityOrState()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("\nNO ADDRESS BOOK EXISTS");
                return;
            }

            Console.Write("\nENTER CITY: ");
            string city = Console.ReadLine();

            Console.Write("ENTER STATE");
            string state = Console.ReadLine();

            foreach (string addressBookName in addressBooks.Keys)
            {
                Console.WriteLine($"\nPERSON IN {addressBookName}:");

                AddressBook addressBook = addressBooks[addressBookName];

                ContactsUtilityImpl utility=addressBook.Utility;

                utility.SearchByCityOrState(city, state);
            }
        }

        //method to display address books
        public void DisplayAddressBooks()
        {
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("NO ADDRESS BOOK ADDED");
                return;
            }

            foreach(string name in addressBooks.Keys)
            {
                Console.WriteLine(name);
            }
        }
    }
}
