using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.contact;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.addressbookfolder;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.contact
{
    public class ContactMenu
    {
        //method to display contact menu
        public static void ShowContactMenu(AddressBook selectedBook)
        {

            //create object of AddressBookUtilityImpl class
            IContact utility = selectedBook.Utility;


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
                int choice = Convert.ToInt32(Console.ReadLine());


                //handle user's choice
                switch (choice)
                {

                    //add new contact
                    case 1:
                        //if address book is full
                        if (utility.TotalContacts() == 99)
                        {
                            Console.WriteLine("\nADDRESS BOOK IS FULL");
                            return;
                        }

                        //take first name
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

                        //take last name
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

                        //take email
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

                        //take city
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

                        //take state
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

                        //take zip code
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

                        //take phone number
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

                        //take address
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


                        //create object of Contact class
                        Contact contact = new Contact(firstName, lastName, address, city, state, zip, email, phoneNumber);

                        try
                        {
                            utility.AddNewContact(contact);
                        }
                        catch (DuplicateAddressBookException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;


                    //add multiple contacts
                    case 2:
                        //if address book is full
                        if (utility.TotalContacts() == 99)
                        {
                            Console.WriteLine("ADDRESS BOOK IS FULL");
                            return;
                        }

                        //take number of persons
                        Console.WriteLine("ENTER NUMBER OF PERSONS: ");
                        int n = Convert.ToInt32(Console.ReadLine());

                        //call AddMultipleContacts method
                        utility.AddMultipleContacts(n);
                        Console.WriteLine("\nCONTACTS ADDED SUCCESSFULLY");
                        break;



                    //edit person contact
                    case 3:
                        //if no contact exists
                        if (utility.TotalContacts() == 0)
                        {
                            Console.WriteLine("\nNO CONTACT EXISTS");
                            break;
                        }

                        //take first name
                        Console.Write("\nENTER FIRST NAME: ");
                        string personFirstName = Console.ReadLine();

                        //take last name
                        Console.Write("ENTER LAST NAME: ");
                        string personLastName = Console.ReadLine();

                        try
                        {
                            utility.EditPersonContact(personFirstName, personLastName);
                        }
                        catch (ContactNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
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
                        if (utility.TotalContacts() == 0)
                        {
                            Console.WriteLine("\nNO CONTACT EXISTS");
                            break;
                        }

                        //take person first name
                        Console.Write("ENTER FIRST NAME: ");
                        personFirstName = Console.ReadLine();

                        //take person last name
                        Console.Write("ENTER LAST NAME: ");
                        personLastName = Console.ReadLine();

                        //call DeletePersonContact method
                        try
                        {
                            utility.DeletePersonContact(personFirstName, personLastName);
                        }
                        catch (ContactNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
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