using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book
{
    internal class ContactsUtilityImpl : IContact
    {
        //array to store contacts
        public List<Contact> contacts = new List<Contact>();


        //dictionary to store contacts according to cities
        Dictionary<string, LinkedList<Contact>> cityContacts = new Dictionary<string, LinkedList<Contact>>();


        //dictionary to store count of person by city
        Dictionary<string, int> cityCount = new Dictionary<string, int>();


        //dictionary to store contacts according to states
        Dictionary<string, LinkedList<Contact>> stateContacts = new Dictionary<string, LinkedList<Contact>>();


        //dictionary to store count of person by state
        Dictionary<string, int> stateCount = new Dictionary<string, int>();


        //getter for total contact
        public int TotalContacts
        {
            get { return contacts.Count; }
        }



        //method to check duplicate contacts
        public bool CheckContact(string firstName, string lastName)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                //if name is already present
                if (firstName.ToLower() == contacts[i].FirstName.ToLower() && lastName.ToLower() == contacts[i].LastName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }



        //implementation of AddNewContact method to add new contact
        public void AddNewContact(Contact contact)
        {
            if (CheckContact(contact.FirstName, contact.LastName))
            {
                throw new DuplicateAddressBookException("Contact already exists");
            }

            string city = contact.City;
            string state = contact.State;

            //add contact according to city
            if (!cityContacts.ContainsKey(city))
            {
                cityContacts[city] = new LinkedList<Contact>();
            }
            cityContacts[city].AddLast(contact);

            //increase count of person by city
            if (!cityCount.ContainsKey(city))
            {
                cityCount[city] = 0;
            }
            cityCount[city]++;


            //add contact according to state
            if (!stateContacts.ContainsKey(state))
            {
                stateContacts[state] = new LinkedList<Contact>();
            }
            stateContacts[state].AddLast(contact);

            //increase count of person by state
            if (!stateCount.ContainsKey(state))
            {
                stateCount[state] = 0;
            }
            stateCount[state]++;

            //add contact
            contacts.Add(contact);
            Console.WriteLine("\nCONTACT ADDED SUCCESSFULLY");
        }




        //implementation of EditPersonContact method to edit person contact
        public void EditPersonContact(string firstName, string lastName)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName.ToLower() == firstName.ToLower() &&
                    contacts[i].LastName.ToLower() == lastName.ToLower())
                {
                    DisplayChangingOptions(contacts[i]);
                    return;
                }
            }
            throw new ContactNotFoundException("Person not found in address book");
        }



        //helper method for displaying changing choices
        public void DisplayChangingOptions(Contact contact)
        {
            //loop until user saves changes
            while (true)
            {
                //display menu
                Console.WriteLine("\n1. CHANGE FIRST NAME");
                Console.WriteLine("2. CHANGE LAST NAME");
                Console.WriteLine("3. CHANGE EMAIL");
                Console.WriteLine("4. CHANGE ADDRESS");
                Console.WriteLine("5. CHANGE CITY");
                Console.WriteLine("6. CHANGE STATE");
                Console.WriteLine("7. CHANGE PHONE NUMBER");
                Console.WriteLine("8. SAVE CHANGES");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //change first name
                    case 1:
                        Console.Write("\nENTER NEW FIRST NAME:");
                        contact.FirstName = Console.ReadLine();
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //change last name
                    case 2:
                        Console.Write("\nENTER NEW LAST NAME:");
                        contact.LastName = Console.ReadLine();
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //change email
                    case 3:
                        Console.Write("\nENTER NEW EMAIL:");
                        contact.Email = Console.ReadLine();
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //change address
                    case 4:
                        Console.Write("\nENTER NEW ADDRESS:");
                        contact.Address = Console.ReadLine();
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //change city
                    case 5:
                        Console.Write("\nENTER NEW CITY:");
                        contact.City = Console.ReadLine();
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //change state
                    case 6:
                        Console.Write("\nENTER NEW STATE:");
                        contact.State = Console.ReadLine();
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //change phone number
                    case 7:
                        Console.Write("\nENTER NEW PHONE NUMBER:");
                        contact.PhoneNumber = Console.ReadLine();
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //save changes
                    case 8:
                        Console.WriteLine("\nCHANGES SAVED SUCCESSFULLY");
                        return;

                    default:
                        Console.WriteLine("\nINVALID CHOICE");
                        break;
                }

            }
        }



        //method to delete person contact by name
        public void DeletePersonContact(string firstName, string lastName)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].FirstName.ToLower() == firstName.ToLower() &&
                    contacts[i].LastName.ToLower() == lastName.ToLower())
                {
                    contacts.RemoveAt(i);
                    Console.WriteLine("\nCONTACT DELETED SUCCESSFULLY");
                    return;
                }
            }
            throw new ContactNotFoundException("Contact not found to delete");
        }



        //method to add multiple contacts
        public void AddMultipleContacts(int numberOfContacts)
        {

            for (int i = 0; i < numberOfContacts; i++)
            {
                Console.WriteLine($"ENTER DETAILS OF PERSON {i + 1}: ");

                //take first name
                Console.Write("\nENTER FIRST NAME: ");
                string firstName = Console.ReadLine();

                //take last name
                Console.Write("ENTER LAST NAME: ");
                string lastName = Console.ReadLine();

                //take email
                Console.Write("ENTER EMAIL: ");
                string email = Console.ReadLine();

                //take city
                Console.Write("ENTER CITY: ");
                string city = Console.ReadLine();

                //take state
                Console.Write("ENTER STATE: ");
                string state = Console.ReadLine();

                //take zip code
                Console.Write("ENTER ZIP CODE: ");
                string zip = Console.ReadLine();

                //take phone number
                Console.Write("ENTER PHONE NUMBER: ");
                string phoneNumber = Console.ReadLine();

                //take address
                Console.Write("ENTER ADDRESS: ");
                string address = Console.ReadLine();

                //create object
                Contact contact = new Contact(firstName, lastName, address, city, state, zip, email, phoneNumber);

                //add contact
                AddNewContact(contact);

            }
        }



        //method to find person by city or state
        public void SearchByCityOrState(string city, string state)
        {
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts[i].City.ToLower() == city.ToLower() || contacts[i].State.ToLower() == state.ToLower())
                {
                    Console.WriteLine($"{contacts[i].FirstName} {contacts[i].LastName}");
                }
            }
        }



        //method to display contacts according to city
        public void DisplayContactsWithCity()
        {
            foreach (string city in cityContacts.Keys)
            {
                Console.WriteLine($"\nCONTACTS FROM '{city}' :");
                Console.WriteLine("\n-------------------------------");

                LinkedList<Contact> contactList = cityContacts[city];

                foreach (Contact c in contactList)
                {
                    Console.WriteLine(c);
                }
            }
        }




        //method to display contacts according to state
        public void DisplayContactsWithState()
        {
            foreach (string state in stateContacts.Keys)
            {
                Console.WriteLine($"\nCONTACTS FROM '{state}' :");
                Console.WriteLine("\n------------------------------------");

                LinkedList<Contact> contactList = stateContacts[state];

                foreach (Contact c in contactList)
                {
                    Console.WriteLine(c);
                }
            }
        }


        //method to display number of contacts according to city 
        public void DisplayCityCount()
        {
            Console.WriteLine("\nNUMBER OF CONTACTS BY CITY: ");
            foreach (string city in cityCount.Keys)
            {
                Console.WriteLine(city + " : " + cityCount[city]);
            }
        }



        //method to display number of contacts according to state
        public void DisplayStateCount()
        {
            Console.WriteLine("\nNUMBER OF CONTACTS BY STATE: ");
            foreach (string state in stateCount.Keys)
            {
                Console.WriteLine(state + " : " + stateCount[state]);
            }
        }



        //method to sort contacts by person name using bubble sort
        public void SortByPersonName()
        {
            for (int i = 0; i < contacts.Count - 1; i++)
            {
                for (int j = 0; j < contacts.Count - i - 1; j++)
                {
                    if (string.Compare(contacts[j].FirstName, contacts[j + 1].FirstName, true) > 0)
                    {
                        Contact temp = contacts[j];
                        contacts[j] = contacts[j + 1];
                        contacts[j + 1] = temp;
                    }
                }
            }
        }



        //method to sort contacts by state using bubble sort
        public void SortByState()
        {
            for (int i = 0; i < contacts.Count - 1; i++)
            {
                for (int j = 0; j < contacts.Count - i - 1; j++)
                {
                    if (string.Compare(contacts[j].State, contacts[j + 1].State, true) > 0)
                    {
                        Contact temp = contacts[j];
                        contacts[j] = contacts[j + 1];
                        contacts[j + 1] = temp;
                    }
                }
            }
        }



        //method to sort contacts by city using bubble sort
        public void SortByCity()
        {
            for (int i = 0; i < contacts.Count - 1; i++)
            {
                for (int j = 0; j < contacts.Count - i - 1; j++)
                {
                    if (string.Compare(contacts[j].City, contacts[j + 1].City, true) > 0)
                    {
                        Contact temp = contacts[j];
                        contacts[j] = contacts[j + 1];
                        contacts[j + 1] = temp;
                    }
                }
            }
        }



        //method to sort contacts by zip codes using bubble sort
        public void SortByZip()
        {
            for (int i = 0; i < contacts.Count - 1; i++)
            {
                for (int j = 0; j < contacts.Count - i - 1; j++)
                {
                    if (string.Compare(contacts[j].Zip, contacts[j + 1].Zip, true) > 0)
                    {
                        Contact temp = contacts[j];
                        contacts[j] = contacts[j + 1];
                        contacts[j + 1] = temp;
                    }
                }
            }
        }

        


        //method to display all contacts
        public void DisplayContacts()
        {
            //if no contact exists
            if (contacts.Count == 0)
            {
                Console.WriteLine("\nNO CONTACT EXISTS");
                return;
            }

            Console.WriteLine("ALL CONTACTS: ");

            //loop through contacts array
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine(contacts[i]);
                Console.WriteLine("\n-------------------------------------------");
            }
        }

    }
}
