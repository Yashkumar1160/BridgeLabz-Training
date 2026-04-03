using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzTraining.oops_csharp_practice.scenario_based.address_book
{
    internal class Contact
    {
        //private variables to store person data
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string email;
        private string phoneNumber;


        //getters and setters for each field
        public string FirstName
        {
            get; set;
        }

       public string LastName
        {
            get; set;
        }

        public string Address
        {
            get; set;
        }

        public string City
        {
            get; set;
        }

        public string State
        {
            get; set;
        }

        public string Zip
        {
            get; set;
        }

        public string Email
        {
            get; set;
        }

        public string PhoneNumber
        {
            get; set;
        }


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
            return "\nFIRST NAME: "+FirstName+
                "\nLAST NAME: "+LastName+
                "\nEMAIL: " + Email +
                "\nCITY " + City +
                "\nSTATE: " + State +
                "\nZIP: " + Zip +
                "\nPHONE NUMBER: " + PhoneNumber+
                "\nADDRESS: " + Address ;
        }
    }
}
