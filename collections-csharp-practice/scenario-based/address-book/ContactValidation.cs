using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BridgeLabzTraining.collections_csharp_practice.scenario_based.address_book
{
    internal class ContactValidation
    {
        //method to validate email
        public static void ValidateEmail(string email)
        {
            if (!Regex.IsMatch(email,@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                throw new InvalidEmailException("Invalid Email");
            }
        }

        //method to validate phone number
        public static void ValidatePhone(string phone)
        {
            if (!Regex.IsMatch(phone, @"^[6-9][0-9]{9}$"))
            {
                throw new InvalidPhoneNumberException("Invalid Phone");
            }
        }

        //method to validate zip code
        public static void ValidateZip(string zip)
        {
            if (!Regex.IsMatch(zip, @"^[0-9]{6}$"))
            {
                throw new InvalidZipCodeException("Invalid Zip");
            }
        }

        //method to validate empty field
        public static void ValidateNotEmpty(string value, string field)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new EmptyFieldException($"{field} cannot be empty");
            }
        }

    }
}