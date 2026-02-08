using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book
{
    //invalid email exception
    class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message) { }
    }

    //invalid phone number exception
    class InvalidPhoneNumberException : Exception
    {
        public InvalidPhoneNumberException(string message) : base(message) { }
    }

    //invalid zip code exception
    class InvalidZipCodeException : Exception
    {
        public InvalidZipCodeException(string message) : base(message) { }
    }

    //empty field exception
    class EmptyFieldException : Exception
    {
        public EmptyFieldException(string message) : base(message) { }
    }
}