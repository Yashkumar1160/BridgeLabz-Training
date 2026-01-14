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
            Console.WriteLine("-----ADDRESS BOOK SYSTEM-----");

            //create object of AddressBookUtilityImpl class
            AddressBookUtilityImpl utility=new AddressBookUtilityImpl();

            //infinite loop until user exits
            while (true)
            {
                Console.WriteLine("\n1. ADD NEW CONTACT");
                Console.WriteLine("2. EDIT PERSON CONTACT");
                Console.WriteLine("3. DISPLAY CONTACTS");
                Console.WriteLine("4. EXIT PROGRAM");
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
                            Console.WriteLine("ADDRESS BOOK IS FULL");
                            return;
                        }

                        //take first name
                        Console.Write("ENTER FIRST NAME: ");
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


                    //edit person contact
                    case 2:
                        //if no contact exists
                        if (utility.TotalContacts == 0)
                        {
                            Console.WriteLine("\nNO CONTACT ADDED YET");
                            break;
                        }

                        //take first name
                        Console.Write("ENTER FIRST NAME: ");
                        string personFirstName=Console.ReadLine();

                        //take last name
                        Console.Write("ENTER LAST NAME: ");
                        string personLastName=Console.ReadLine();
                        
                        //call EditPersonalContact method
                        utility.EditPersonContact(personFirstName, personLastName);
                        break; 


                    //display contacts
                    case 3:
                        utility.DisplayContacts();
                        break;


                    //exit program
                    case 4:
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
