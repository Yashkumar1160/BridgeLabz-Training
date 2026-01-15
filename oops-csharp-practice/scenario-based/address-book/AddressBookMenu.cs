using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book
{
    internal class AddressBookMenu
    {
        public static void Start()
        {
            Console.WriteLine("----- ADDRESS BOOK SYSTEM -----");

            //create object of AddressBookUtilityImpl class
            AddressBookUtilityImpl addressBookUtility = new AddressBookUtilityImpl();

            //infinite loop until user exits
            while (true)
            {
                //display choices
                Console.WriteLine("\nADDRESS BOOK MENU: ");
                Console.WriteLine("\n1. CREATE ADDRESS BOOK");
                Console.WriteLine("2. SELECT ADDRESS BOOK");
                Console.WriteLine("3. DISPLAY ADDRESS BOOKS");
                Console.WriteLine("4. EXIT PROGRAM");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch (choice)
                {
                    //add address book
                    case 1:
                        Console.Write("ENTER ADDRESS BOOK NAME: ");
                        string name = Console.ReadLine();

                        AddressBook book = new AddressBook(name);
                        addressBookUtility.AddAddressBook(book);
                        break;

                    //select address book
                    case 2:
                        Console.Write("ENTER ADDRESS BOOK NAME: ");
                        name = Console.ReadLine();

                        AddressBook selectedBook = addressBookUtility.SelectAddressBook(name);
                        if (selectedBook != null)
                        {
                            ShowContactMenu(selectedBook);
                        }
                        break;

                    //display address books
                    case 3:
                        addressBookUtility.DisplayAddressBooks();
                        break;

                    case 4:
                        Console.WriteLine("EXIT SUCCESSFUL");
                        return;

                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                }
            }
        }

        public static void ShowContactMenu(AddressBook selectedBook)
        {

            //create object of AddressBookUtilityImpl class
            ContactsUtilityImpl utility=selectedBook.Utility;

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\nCONTACTS MENU");
                Console.WriteLine("\n1. ADD NEW CONTACT");
                Console.WriteLine("2. ADD MULTIPLE CONTACTS");
                Console.WriteLine("3. EDIT PERSON CONTACT");
                Console.WriteLine("4. DISPLAY CONTACTS");
                Console.WriteLine("5. DELETE PERSON CONTACT");
                Console.WriteLine("6. RETURN TO ADDRESS BOOK MENU");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch(choice)
                {
                    //add new contact
                    case 1:
                        //if address book is full
                        if (utility.TotalContacts == 99)
                        {
                            Console.WriteLine("\nADDRESS BOOK IS FULL");
                            return;
                        }

                        //take first name
                        Console.Write("\nENTER FIRST NAME: ");
                        string firstName=Console.ReadLine();

                        //take last name
                        Console.Write("ENTER LAST NAME: ");
                        string lastName =Console.ReadLine();

                        //take email
                        Console.Write("ENTER EMAIL: ");
                        string email =Console.ReadLine();
                        
                        //take city
                        Console.Write("ENTER CITY: ");
                        string city =Console.ReadLine();
                        
                        //take state
                        Console.Write("ENTER STATE: ");
                        string state =Console.ReadLine();
                        
                        //take zip code
                        Console.Write("ENTER ZIP CODE: ");
                        string zip =Console.ReadLine();
                        
                        //take phone number
                        Console.Write("ENTER PHONE NUMBER: ");
                        string phoneNumber =Console.ReadLine();
                        
                        //take address
                        Console.Write("ENTER ADDRESS: ");
                        string address =Console.ReadLine();

                        //create object of Contact class
                        Contact contact = new Contact(firstName, lastName, address, city, state, zip, email, phoneNumber);

                        //add new contact
                        utility.AddNewContact(contact);

                        Console.WriteLine("\nCONTACT ADDED SUCCESSFULLY");
                        break;


                    //add multiple contacts
                    case 2:
                        //if address book is full
                        if (utility.TotalContacts == 99)
                        {
                            Console.WriteLine("ADDRESS BOOK IS FULL");
                            return;
                        }

                        //take number of persons
                        Console.WriteLine("ENTER NUMBER OF PERSONS: ");
                        int n=Convert.ToInt32(Console.ReadLine());

                        //call AddMultipleContacts method
                        utility.AddMultipleContacts(n);
                        Console.WriteLine("\nCONTACTS ADDED SUCCESSFULLY");
                        break;


                    //edit person contact
                    case 3:
                        //if no contact exists
                        if (utility.TotalContacts == 0)
                        {
                            Console.WriteLine("\nNO CONTACT EXISTS");
                            break;
                        }

                        //take first name
                        Console.Write("\nENTER FIRST NAME: ");
                        string personFirstName=Console.ReadLine();

                        //take last name
                        Console.Write("ENTER LAST NAME: ");
                        string personLastName=Console.ReadLine();
                        
                        //call EditPersonalContact method
                        utility.EditPersonContact(personFirstName, personLastName);
                        break; 


                    //display contacts
                    case 4:
                        utility.DisplayContacts();
                        break;

                    //delete person contact
                    case 5:
                        if (utility.TotalContacts == 0)
                        {
                            Console.WriteLine("\nNO CONTACT EXISTS");
                            break;
                        }

                        //take person first name
                        Console.Write("ENTER FIRST NAME: ");
                        personFirstName =Console.ReadLine();

                        //take person last name
                        Console.Write("ENTER LAST NAME: ");
                        personLastName =Console.ReadLine();

                        //call DeletePersonContact method
                        utility.DeletePersonContact(personFirstName, personLastName);
                        break;

                    //exit program
                    case 6:
                        Console.WriteLine("\nEXIT SUCCESSFUL");
                        return;


                    //invalid choice
                    default:
                        Console.WriteLine("\nINVALID CHOICE");
                        break;
                        
                }
            }
        }
    }
}
