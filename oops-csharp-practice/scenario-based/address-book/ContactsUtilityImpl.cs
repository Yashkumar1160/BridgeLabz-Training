using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book
{
    internal class ContactsUtilityImpl : IContact 
    {
        //array to store contacts
        private Contact[]contacts=new Contact[100];

        //variable to store total contacts count
        private int totalContacts = 0;

        //getter for total contact
        public int TotalContacts
        {
            get { return totalContacts; } 
        }

        //method to check duplicate contacts
        public bool CheckContact(string firstName,string lastName)
        {
            for(int i = 0; i < totalContacts; i++)
            {
                //if name is already present
                if(firstName.ToLower() == contacts[i].FirstName.ToLower() && lastName.ToLower() == contacts[i].LastName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        //implementation of AddNewContact method to add new contact
        public void AddNewContact(Contact contact)
        {
            contacts[totalContacts] = contact;
            totalContacts++;
            Console.WriteLine("\nCONTACT ADDED SUCCESSFULLY");
        }


        //implementation of EditPersonContact method to edit person contact
        public void EditPersonContact(string firstName,string lastName)
        {
            //loop through contacts array
            for(int i=0;i<totalContacts;i++)
            {
                //if first name and last name matches
                if (contacts[i].FirstName.ToLower() == firstName.ToLower() && contacts[i].LastName.ToLower()==lastName.ToLower())
                {
                    DisplayChangingOptions(contacts[i]);
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
            //loop through contacts array
            for(int i = 0; i < totalContacts; i++)
            {
                //if first name and last name matches
                if (contacts[i].FirstName.ToLower() == firstName.ToLower() && contacts[i].LastName.ToLower() == lastName.ToLower())
                {
                   
                    //shift elements
                    for (int j = i; j < totalContacts - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }

                    //make address book null
                    contacts[totalContacts-1] = null;
                    Console.WriteLine("\nCONTACT DELETED SUCCESSFULLY");
                    totalContacts--;
                    return;
                }
            }

            Console.WriteLine("\nPERSON CONTACT NOT FOUND");
        }


        //method to add multiple contacts
        public void AddMultipleContacts(int numberOfContacts)
        {
            Contact[]newContacts= new Contact[numberOfContacts];

            for(int i = 0; i < numberOfContacts; i++)
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
                contacts[totalContacts]= contact;
                totalContacts++;

            }
        }

        //method to find person by city or state
        public void SearchByCityOrState(string city,string state)
        {
            for(int i = 0;i < totalContacts;i++)
            {
                if (contacts[i].City.ToLower() == city.ToLower() || contacts[i].State.ToLower()==state.ToLower())
                {
                    Console.WriteLine($"{contacts[i].FirstName} {contacts[i].LastName}");
                }
            }
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

            //loop through contacts array
            for(int i=0; i<totalContacts; i++)
            {
                Console.WriteLine(contacts[i]);
                Console.WriteLine("\n-------------------------------------------");
            }
        }

    }
}
