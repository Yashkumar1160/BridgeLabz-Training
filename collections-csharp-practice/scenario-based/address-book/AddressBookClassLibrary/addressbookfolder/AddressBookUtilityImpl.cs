using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.contact;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.addressbookfolder
{
    public class AddressBookUtilityImpl : IAddressBook 
    {
        //dictionary to store address book
        private Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();


        //store current selected address book
        private AddressBook selectedBook;


        //method to add address book
        public void AddAddressBook(AddressBook addressBook)
        {
            if (addressBooks.ContainsKey(addressBook.AddressBookName.ToLower()))
            {
                throw new DuplicateAddressBookException("Address Book already exists");
            }

            addressBooks.Add(addressBook.AddressBookName.ToLower(), addressBook);
            Console.WriteLine("\nADDRESS BOOK ADDED SUCCESSFULLY");
        }




        //method to select specific address book
        public AddressBook SelectAddressBook(string name)
        {
            if (!addressBooks.ContainsKey(name.ToLower()))
            {
                throw new AddressBookNotFoundException("Address Book not found");
            }

            selectedBook = addressBooks[name.ToLower()];
            Console.WriteLine($"ADDRESS BOOK SELECTED -> {name}");
            return selectedBook;
        }



        //method to search person by city or state
        public void SearchByCityOrState()
        {
            //check if address book exists
            if (addressBooks.Count == 0)
            {
                Console.WriteLine("\nNO ADDRESS BOOK EXISTS");
                return;
            }

            //take city
            Console.Write("\nENTER CITY: ");
            string city = Console.ReadLine();

            //take state
            Console.Write("ENTER STATE");
            string state = Console.ReadLine();

            //loop through dictionary
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
