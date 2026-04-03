using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.contact;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.addressbookfolder
{
    public class AddressBookMenu
    {
        public static void Start()
        {
            Console.WriteLine("----- ADDRESS BOOK SYSTEM -----");

            //create object of AddressBookUtilityImpl class
            IAddressBook addressBookUtility = new AddressBookUtilityImpl();


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

                        try
                        {
                            AddressBook book = new AddressBook(name);
                            addressBookUtility.AddAddressBook(book);
                        }
                        catch (DuplicateAddressBookException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;


                    //select address book
                    case 2:
                        Console.Write("\nENTER ADDRESS BOOK NAME: ");
                        name = Console.ReadLine();

                        try
                        {
                            AddressBook selectedBook = addressBookUtility.SelectAddressBook(name);
                            ContactMenu.ShowContactMenu(selectedBook);
                        }
                        catch (AddressBookNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
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
    }
}
