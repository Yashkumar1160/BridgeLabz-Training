using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.addressbookfolder;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book.AddressBookClassLibrary.contact
{
    public class Contact
    {
        //properties
        [DisplayField("First Name")]
        public string FirstName { get; set; }

        [DisplayField("Last Name")]
        public string LastName { get; set; }

        [DisplayField("Email")]
        public string Email { get; set; }

        [DisplayField("Phone Number")]
        public string PhoneNumber { get; set; }

        [DisplayField("City")]
        public string City { get; set; }

        [DisplayField("State")]
        public string State { get; set; }

        [DisplayField("Zip Code")]
        public string Zip { get; set; }

        [DisplayField("Address")]
        public string Address { get; set; }

        //constructor
        public Contact(string firstName, string lastName, string address, string city, string state, string zip, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        //override ToString method
        public override string ToString()
        {
            return "\nFIRST NAME: " + FirstName +
                "\nLAST NAME: " + LastName +
                "\nEMAIL: " + Email +
                "\nCITY " + City +
                "\nSTATE: " + State +
                "\nZIP: " + Zip +
                "\nPHONE NUMBER: " + PhoneNumber +
                "\nADDRESS: " + Address;
        }
    }
}
