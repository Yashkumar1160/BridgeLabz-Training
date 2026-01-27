using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace class_library
{
    public class PasswordValidator
    {
        //method to validate password
        public bool IsValid(string password)
        {
            //check for null or empty password
            if (string.IsNullOrEmpty(password))
                return false;

            //check minimum length
            if (password.Length < 8)
                return false;

            //check at least one uppercase letter
            if (!Regex.IsMatch(password, "[A-Z]"))
                return false;

            //check at least one digit
            if (!Regex.IsMatch(password, "[0-9]"))
                return false;

            //if password is valid
            return true;
        }
    }
}
