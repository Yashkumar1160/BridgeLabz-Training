using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book
{
    internal class AddressBookUtilityImpl : IAddressBook 
    {
        //array to store contacts
        private Contact[]addressBook=new Contact[100];

        //variable to store total contacts count
        private int totalContacts = 0;

        //getter for total contact
        public int TotalContacts
        {
            get { return totalContacts; } 
        }

        //implementation of AddNewContact method to add new contact
        public void AddNewContact(Contact contact)
        { 
            addressBook[totalContacts] = contact;
            totalContacts++;
        }


        //implementation of EditPersonContact method to edit person contact
        public void EditPersonContact(string firstName,string lastName)
        {
            //loop through addressBook array
            for(int i=0;i<totalContacts;i++)
            {
                //if first name and last name matches
                if (addressBook[i].FirstName.ToLower() == firstName.ToLower() && addressBook[i].LastName.ToLower()==lastName.ToLower())
                {
                    DisplayChangingOptions(addressBook[i]);
                    return;
                }
            }
            Console.WriteLine("\nPERSON NOT FOUND");
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
                switch(choice)
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
            //loop through addressBook array
            for(int i = 0; i < totalContacts; i++)
            {
                //if first name and last name matches
                if (addressBook[i].FirstName.ToLower() == firstName.ToLower() && addressBook[i].LastName.ToLower() == lastName.ToLower())
                {
                   
                    //shift elements
                    for (int j = i; j < totalContacts - 1; j++)
                    {
                        addressBook[j] = addressBook[j + 1];
                    }

                    //make address book null
                    addressBook[totalContacts-1] = null;
                    Console.WriteLine("\nCONTACT DELETED SUCCESSFULLY");
                    totalContacts--;
                    return;
                }
            }

            Console.WriteLine("\nPERSON CONTACT NOT FOUND");
        }

        //method to display all contacts
        public void DisplayContacts()
        {
            //if no contact exists
            if(totalContacts == 0)
            {
                Console.WriteLine("\nNO CONTACT EXISTS");
                return;
            }

            //loop through addressBook array
            for(int i=0; i<totalContacts; i++)
            {
                Console.WriteLine(addressBook[i]);
            }
        }

    }
}
