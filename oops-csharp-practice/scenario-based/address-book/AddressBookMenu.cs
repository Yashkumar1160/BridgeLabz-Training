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
                Console.WriteLine("2. DISPLAY CONTACTS");
                Console.WriteLine("3. EXIT PROGRAM");
                Console.Write("ENTER YOUR CHOICE: ");

                //take user's choice
                int choice=Convert.ToInt32(Console.ReadLine());

                //handle user's choice
                switch(choice)
                {
                    //add new contact
                    case 1:
                        Console.Write("ENTER FIRST NAME: ");
                        string firstName=Console.ReadLine();

                        Console.Write("ENTER LAST NAME: ");
                        string lastName =Console.ReadLine();

                        Console.Write("ENTER EMAIL: ");
                        string email =Console.ReadLine();
                        
                        Console.Write("ENTER CITY: ");
                        string city =Console.ReadLine();
                        
                        Console.Write("ENTER STATE: ");
                        string state =Console.ReadLine();
                        
                        Console.Write("ENTER ZIP CODE: ");
                        string zip =Console.ReadLine();
                        
                        Console.Write("ENTER PHONE NUMBER: ");
                        string phoneNumber =Console.ReadLine();
                        
                        Console.Write("ENTER ADDRESS: ");
                        string address =Console.ReadLine();

                        Contact contact = new Contact(firstName, lastName, address, city, state, zip, email, phoneNumber);

                        utility.AddNewContact(contact);

                        Console.WriteLine("CONTACT ADDED SUCCESSFULLY");

                        break;


                    //display contacts
                    case 2:
                        utility.DisplayContacts();
                        break;

                    //exit program
                    case 3:
                        Console.WriteLine("EXIT SUCCESSFUL");
                        return;

                    //invalid choice
                    default:
                        Console.WriteLine("INVALID CHOICE");
                        break;
                        
                }
            }
        }
    }
}
