using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.addressbookfolder;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.contact
{
    public class ContactsUtilityImpl : IContact
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
        public int TotalContacts()
        {
            return contacts.Count;
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
            //infinite loop to display menu
            while (true)
            {
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
                    //CHANGE FIRST NAME
                    case 1:
                        string newFirstName;
                        while (true)
                        {
                            try
                            {
                                Console.Write("ENTER NEW FIRST NAME: ");
                                newFirstName = Console.ReadLine();
                                ContactValidation.ValidateNotEmpty(newFirstName, "First Name");
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message + ". Please try again.");
                            }
                        }
                        contact.FirstName = newFirstName;
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //CHANGE LAST NAME
                    case 2:
                        string newLastName;
                        while (true)
                        {
                            try
                            {
                                Console.Write("ENTER NEW LAST NAME: ");
                                newLastName = Console.ReadLine();
                                ContactValidation.ValidateNotEmpty(newLastName, "Last Name");
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message + ". Please try again.");
                            }
                        }
                        contact.LastName = newLastName;
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //CHANGE EMAIL
                    case 3:
                        string newEmail;
                        while (true)
                        {
                            try
                            {
                                Console.Write("ENTER NEW EMAIL: ");
                                newEmail = Console.ReadLine();
                                ContactValidation.ValidateNotEmpty(newEmail, "Email");
                                ContactValidation.ValidateEmail(newEmail);
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message + ". Please try again.");
                            }
                        }
                        contact.Email = newEmail;
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //CHANGE ADDRESS
                    case 4:
                        string newAddress;
                        while (true)
                        {
                            try
                            {
                                Console.Write("ENTER NEW ADDRESS: ");
                                newAddress = Console.ReadLine();
                                ContactValidation.ValidateNotEmpty(newAddress, "Address");
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message + ". Please try again.");
                            }
                        }
                        contact.Address = newAddress;
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //CHANGE CITY
                    case 5:
                        string newCity;
                        while (true)
                        {
                            try
                            {
                                Console.Write("ENTER NEW CITY: ");
                                newCity = Console.ReadLine();
                                ContactValidation.ValidateNotEmpty(newCity, "City");
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message + ". Please try again.");
                            }
                        }
                        contact.City = newCity;
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //CHANGE STATE
                    case 6:
                        string newState;
                        while (true)
                        {
                            try
                            {
                                Console.Write("ENTER NEW STATE: ");
                                newState = Console.ReadLine();
                                ContactValidation.ValidateNotEmpty(newState, "State");
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message + ". Please try again.");
                            }
                        }
                        contact.State = newState;
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //CHANGE PHONE NUMBER
                    case 7:
                        string newPhone;
                        while (true)
                        {
                            try
                            {
                                Console.Write("ENTER NEW PHONE NUMBER: ");
                                newPhone = Console.ReadLine();
                                ContactValidation.ValidateNotEmpty(newPhone, "Phone Number");
                                ContactValidation.ValidatePhone(newPhone);
                                break;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message + ". Please try again.");
                            }
                        }
                        contact.PhoneNumber = newPhone;
                        Console.WriteLine("CHANGES DONE");
                        break;

                    //SAVE CHANGES
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

                //take FIRST NAME
                string firstName;
                while (true)
                {
                    try
                    {
                        Console.Write("ENTER FIRST NAME: ");
                        firstName = Console.ReadLine();
                        ContactValidation.ValidateNotEmpty(firstName, "First Name");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + ". Please try again.");
                    }
                }

                //take LAST NAME
                string lastName;
                while (true)
                {
                    try
                    {
                        Console.Write("ENTER LAST NAME: ");
                        lastName = Console.ReadLine();
                        ContactValidation.ValidateNotEmpty(lastName, "Last Name");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + ". Please try again.");
                    }
                }

                //take EMAIL
                string email;
                while (true)
                {
                    try
                    {
                        Console.Write("ENTER EMAIL: ");
                        email = Console.ReadLine();
                        ContactValidation.ValidateNotEmpty(email, "Email");
                        ContactValidation.ValidateEmail(email);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + ". Please try again.");
                    }
                }

                //take CITY
                string city;
                while (true)
                {
                    try
                    {
                        Console.Write("ENTER CITY: ");
                        city = Console.ReadLine();
                        ContactValidation.ValidateNotEmpty(city, "City");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + ". Please try again.");
                    }
                }

                //take STATE
                string state;
                while (true)
                {
                    try
                    {
                        Console.Write("ENTER STATE: ");
                        state = Console.ReadLine();
                        ContactValidation.ValidateNotEmpty(state, "State");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + ". Please try again.");
                    }
                }

                //take ZIP
                string zip;
                while (true)
                {
                    try
                    {
                        Console.Write("ENTER ZIP CODE: ");
                        zip = Console.ReadLine();
                        ContactValidation.ValidateNotEmpty(zip, "Zip Code");
                        ContactValidation.ValidateZip(zip);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + ". Please try again.");
                    }
                }

                //take PHONE NUMBER
                string phoneNumber;
                while (true)
                {
                    try
                    {
                        Console.Write("ENTER PHONE NUMBER: ");
                        phoneNumber = Console.ReadLine();
                        ContactValidation.ValidateNotEmpty(phoneNumber, "Phone Number");
                        ContactValidation.ValidatePhone(phoneNumber);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + ". Please try again.");
                    }
                }

                //take ADDRESS
                string address;
                while (true)
                {
                    try
                    {
                        Console.Write("ENTER ADDRESS: ");
                        address = Console.ReadLine();
                        ContactValidation.ValidateNotEmpty(address, "Address");
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + ". Please try again.");
                    }
                }

                //create contact
                Contact contact = new Contact(firstName, lastName, address, city, state, zip, email, phoneNumber);
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


        //method to display contact
        public void DisplayContact(Contact contact)
        {
            //store type
            Type type = typeof(Contact);

            //array to store properties
            PropertyInfo[] properties = type.GetProperties();

            //loop through each property
            foreach (PropertyInfo property in properties)
            {
                //Check if DisplayFieldAttribute is applied
                DisplayFieldAttribute attribute = property.GetCustomAttribute<DisplayFieldAttribute>();
                if (attribute != null)
                {
                    string displayName = attribute.DisplayName;
                    object value = property.GetValue(contact);
                    Console.WriteLine($"{displayName}: {value}");
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
                DisplayContact(contacts[i]);
                Console.WriteLine("\n-------------------------------------------");
            }
        }

    }
}
