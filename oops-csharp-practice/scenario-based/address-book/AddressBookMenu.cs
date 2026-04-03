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
                Console.WriteLine("1. CREATE ADDRESS BOOK");
                Console.WriteLine("2. SELECT ADDRESS BOOK");
                Console.WriteLine("3. SEARCH BY CITY OR STATE");
                Console.WriteLine("4. DISPLAY ADDRESS BOOKS");
                Console.WriteLine("5. EXIT PROGRAM");
                Console.Write("ENTER YOUR CHOICE: ");

                
                //take user's choice
                int choice = Convert.ToInt32(Console.ReadLine());

                
                //handle user's choice
                switch (choice)
                {
                
                    //add address book
                    case 1:
                        Console.Write("\nENTER ADDRESS BOOK NAME: ");
                        string name = Console.ReadLine();

                        AddressBook book = new AddressBook(name);
                        addressBookUtility.AddAddressBook(book);
                        break;


                    //select address book
                    case 2:
                        Console.Write("\nENTER ADDRESS BOOK NAME: ");
                        name = Console.ReadLine();

                        AddressBook selectedBook = addressBookUtility.SelectAddressBook(name);
                        if (selectedBook != null)
                        {
                            ShowContactMenu(selectedBook);
                        }
                        break;


                    //search by state or city
                    case 3:
                        addressBookUtility.SearchByCityOrState();
                        break;


                    //display address books
                    case 4:
                        addressBookUtility.DisplayAddressBooks();
                        break;


                    //exit
                    case 5:
                        Console.WriteLine("\nEXIT SUCCESSFUL");
                        return;


                    default:
                        Console.WriteLine("\nINVALID CHOICE");
                        break;
                }
            }
        }



        //method to display contact menu
        public static void ShowContactMenu(AddressBook selectedBook)
        {

            //create object of AddressBookUtilityImpl class
            ContactsUtilityImpl utility=selectedBook.Utility;

        
            //infinite loop until user exits
            while (true)
            {
            
                Console.WriteLine("\nCONTACTS MENU");
                Console.WriteLine("1. ADD NEW CONTACT");
                Console.WriteLine("2. ADD MULTIPLE CONTACTS");
                Console.WriteLine("3. EDIT PERSON CONTACT");
                Console.WriteLine("4. DISPLAY CONTACTS");
                Console.WriteLine("5. DISPLAY BY CITY");
                Console.WriteLine("6. DISPLAY BY STATE");
                Console.WriteLine("7. DISPLAY COUNT BY CITY");
                Console.WriteLine("8. DISPLAY COUNT BY STATE");
                Console.WriteLine("9. DELETE PERSON CONTACT");
                Console.WriteLine("10. SORT CONTACTS BY PERSON NAME");
                Console.WriteLine("11. SORT CONTACTS BY CITY");
                Console.WriteLine("12. SORT CONTACTS BY STATE");
                Console.WriteLine("13. SORT CONTACTS BY ZIP CODES");
                Console.WriteLine("0. RETURN TO ADDRESS BOOK MENU");
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

                        //check duplicate contact
                        if (utility.CheckContact(firstName, lastName))
                        {
                            Console.WriteLine("\nCONTACT ALREADY EXISTS FOR THIS PERSON");
                            break;
                        }

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


                    //display contacts by city
                    case 5:
                        utility.DisplayContactsWithCity();
                        break;


                    //display contacts by state
                    case 6:
                        utility.DisplayContactsWithState();
                        break;


                    //display contact count by city
                    case 7:
                        utility.DisplayCityCount();
                        break;


                    //display contact count by state
                    case 8:
                        utility.DisplayStateCount();
                        break;


                    //delete person contact
                    case 9:
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


                    //sort contacts by person name
                    case 10:
                        utility.SortByPersonName();
                        Console.WriteLine("\nCONTACTS SORTED");
                        break;


                    //sort contacts by city
                    case 11:
                        utility.SortByCity();
                        Console.WriteLine("\nCONTACTS SORTED");
                        break;


                    //sort contacts by state
                    case 12:
                        utility.SortByState();
                        Console.WriteLine("\nCONTACTS SORTED");
                        break;


                    //sort contacts by zip
                    case 13:
                        utility.SortByZip();
                        Console.WriteLine("\nCONTACTS SORTED");
                        break;


                    //exit program
                    case 0:
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
